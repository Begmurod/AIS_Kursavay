using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Xpo;
using Kursach.DB.Kursach;
using System.Text.RegularExpressions;

namespace Kursach.UI.WinForm
{
    public partial class MaterialForm : DevExpress.XtraEditors.XtraForm
    {
        public bool edit;//при true режим формы переходит в редактирование (это надо еще сделать...)
        public bool view;
        public Guid currentMaterialGuid;

        private device_Material currentMaterial;

        bool formValid = true;//После реализации метода validForm поменять на false
        private UnitOfWork uow = new UnitOfWork();
        public MaterialForm()
        {
            InitializeComponent();
        }
        public MaterialForm(UnitOfWork u)
        {
            InitializeComponent();
            uow = u;
        }

        private void MaterialForm_Load(object sender, EventArgs e)
        {
            initForm();
        }
        void initForm()
        {
            if (edit)
            {
                currentMaterial = uow.GetObjectByKey<device_Material>(currentMaterialGuid);
            }
            else
            {
                currentMaterial = new device_Material(uow);
            }

            #region Настройка внешнего вида
            if (edit)
            {
                Text = string.Format("Редактирование единицы {0} ", currentMaterial.Name);
                addButton.Text = "Сохранить";
            }

            if (view)
            {
                Text = string.Format("Просмотр единицы {0} ", currentMaterial.Name);
                nameTextEdit.ReadOnly = true;
                volumeTextEdit1.ReadOnly = true;
                unitOfMeasurementTextEdit.ReadOnly = true;
                layoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
            if (edit)
            {
                nameTextEdit.Text = currentMaterial.Name;
                volumeTextEdit1.EditValue = currentMaterial.Volume;
                unitOfMeasurementTextEdit.Text = currentMaterial.UnitOfMeasurement;
            }
        }
        #endregion

        private void addButton_Click(object sender, EventArgs e)
        {
            validForm();
            SaveMachine();
            uow.CommitChanges();//Сохранение объекта в БД       
            Close();
        }
        void SaveMachine()
        {
            if (formValid)
            {
                currentMaterial.Name = nameTextEdit.Text;
                currentMaterial.Volume = Convert.ToDecimal( volumeTextEdit1.Text);
                currentMaterial.UnitOfMeasurement = unitOfMeasurementTextEdit.Text;
                
                if (edit)
                {
                    currentMaterial.DateOfChange = DateTime.Now;
                    currentMaterial.Save();
                }
                uow.CommitChanges();//Сохранение объекта в БД  
                Close();
            }

        }
        private void validForm()
        {
            //TODO  Сделать валидацию формы!!!
            formValid = false;

            List<string> notExistData = new List<string>();

            formValid = dxValidationProvider.Validate();
            foreach (Control c in dxValidationProvider.GetInvalidControls())
            {
                notExistData.Add(dxValidationProvider.GetValidationRule(c).ErrorText);
            }
            if (!formValid && notExistData.Count != 0)
            {
                int i = 1;
                string str = string.Empty;
                foreach (string s in notExistData)
                {
                    if (i == 1)
                        str = string.Format("\n{0}. {1}", i, s);
                    else
                        str = string.Format("{0}\n{1}. {2}", str, i, s);
                    i++;
                }
                str = string.Format("Для сохранения записи не хватает данных: {0}", str);
                XtraMessageBox.Show(str, "Ввод недостающих данных", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        
        private void cancelButton_Click(object sender, EventArgs e)
        {
            uow.Dispose();
            Close();
        }

        private void volumeTextEdit1_KeyPress(object sender, KeyPressEventArgs e)
        {
        char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44) // цифры, клавиша BackSpace и запятая
            {
                e.Handled = true;
            }
        }

        private void nameTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            if ((char)e.KeyChar == (Char)Keys.CapsLock) return;
            if ((char)e.KeyChar == (Char)Keys.Back) return;
            if (char.IsLetter(e.KeyChar)) return;
            e.Handled = true;
            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success)
            {
                e.Handled = true;
            }
        }

        private void unitOfMeasurementTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            if ((char)e.KeyChar == (Char)Keys.CapsLock) return;
            if ((char)e.KeyChar == (Char)Keys.Back) return;
            if (char.IsLetter(e.KeyChar)) return;
            e.Handled = true;
            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success)
            {
                e.Handled = true;
            }
        }
    }
}

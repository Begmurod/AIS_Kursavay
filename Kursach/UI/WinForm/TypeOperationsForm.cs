using DevExpress.Xpo;
using DevExpress.XtraEditors;
using Kursach.DB.Kursach;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach.UI.WinForm
{
    public partial class TypeOperationsForm : Form
    {
        public bool edit;//при true режим формы переходит в редактирование (это надо еще сделать...)
        public bool view;
        public Guid currentTypeOperationsGuid;
        private device_TypeOperations currentTypeOperations;

        bool formValid = true;//После реализации метода validForm поменять на false
        private UnitOfWork uow = new UnitOfWork();
        public TypeOperationsForm()
        {
            InitializeComponent();
        }
        public TypeOperationsForm(UnitOfWork u)
        {
            InitializeComponent();
            uow = u;
        }
        void initForm()
        {
            if (edit)
            {
                currentTypeOperations = uow.GetObjectByKey<device_TypeOperations>(currentTypeOperationsGuid);
            }
            else
            {
                currentTypeOperations = new device_TypeOperations(uow);
            }

            #region Настройка внешнего вида
            if (edit)
            {
                Text = string.Format("Редактирование тип операции {0}", currentTypeOperations.NameOperationsType);
                addButton.Text = "Сохранить";
            }

            if (view)
            {
                Text = string.Format("Просмотр тип операции{0}", currentTypeOperations.NameOperationsType);
                nameOperationsTypeTextEdit.ReadOnly = true;
                layoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
            #endregion


            if (edit)
            {
                nameOperationsTypeTextEdit.Text = currentTypeOperations.NameOperationsType;
            }
        }

        private void TypeOperationsForm_Load(object sender, EventArgs e)
        {
            initForm();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            validForm();
            SaveVendor();
            uow.CommitChanges();//Сохранение объекта в БД       
            Close();
        }
        void SaveVendor()
        {
            if (formValid)
            {
                currentTypeOperations.NameOperationsType = nameOperationsTypeTextEdit.Text;

                if (edit)
                {
                    currentTypeOperations.DateOfChange = DateTime.Now;
                    currentTypeOperations.Save();
                }
            }

        }
        private void validForm()
        {
            //TODO  Сделать валидацию формы!!! formValid = false;
            formValid = false;
            List<string> notExistData = new List<string>();

            formValid = dxValidationProvider1.Validate();
            foreach (Control c in dxValidationProvider1.GetInvalidControls())
            {
                notExistData.Add(dxValidationProvider1.GetValidationRule(c).ErrorText);
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

        private void nameOperationsTypeTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            if ((char)e.KeyChar == (Char)Keys.Space) return;
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

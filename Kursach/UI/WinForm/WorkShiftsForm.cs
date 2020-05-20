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
    public partial class WorkShiftsForm : Form
    {
        public bool edit;//при true режим формы переходит в редактирование (это надо еще сделать...)
        public bool view;
        public Guid currentWorkShiftsGuid;
        private device_WorkShifts currentWorkShifts;

        bool formValid = true;//После реализации метода validForm поменять на false
        private UnitOfWork uow = new UnitOfWork();
        public WorkShiftsForm()
        {
            InitializeComponent();
        }
        public WorkShiftsForm(UnitOfWork u)
        {
            InitializeComponent();
            uow = u;
        }
        void initForm()
        {
            if (edit)
            {
                currentWorkShifts = uow.GetObjectByKey<device_WorkShifts>(currentWorkShiftsGuid);
            }
            else
            {
                currentWorkShifts = new device_WorkShifts(uow);
            }

            #region Настройка внешнего вида
            if (edit)
            {
                Text = string.Format("Редактирование тип {0}", currentWorkShifts.TypeOfShift);
                addButton.Text = "Сохранить";
            }

            if (view)
            {
                Text = string.Format("Просмотр тип {0}", currentWorkShifts.TypeOfShift);
                typeOfShiftTextEdit.ReadOnly = true;
                WorkingHoursTextEdit.ReadOnly = true;
                shiftTypeTextEdit.ReadOnly = true;
                layoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
            #endregion
            
            if (edit)
            {
                typeOfShiftTextEdit.Text = currentWorkShifts.TypeOfShift;
                WorkingHoursTextEdit.Text = currentWorkShifts.WorkingHours.ToString();
                shiftTypeTextEdit.Text = currentWorkShifts.ShiftType;
            }
        }

        private void WorkShiftsForm_Load(object sender, EventArgs e)
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
                currentWorkShifts.TypeOfShift = typeOfShiftTextEdit.Text;
                currentWorkShifts.WorkingHours = Convert.ToDecimal(WorkingHoursTextEdit.Text);
                currentWorkShifts.ShiftType = shiftTypeTextEdit.Text;

                if (edit)
                {
                    currentWorkShifts.DateOfChange = DateTime.Now;
                    currentWorkShifts.Save();
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

        private void WorkingHoursTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
        char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44) 
            {
                e.Handled = true;
            }
        }

        private void typeOfShiftTextEdit_KeyPress(object sender, KeyPressEventArgs e)
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

        private void shiftTypeTextEdit_KeyPress(object sender, KeyPressEventArgs e)
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

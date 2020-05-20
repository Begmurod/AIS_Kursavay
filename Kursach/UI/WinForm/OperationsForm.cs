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
using DevExpress.Xpo.DB;
using Kursach.DB.Kursach;
using System.Text.RegularExpressions;

namespace Kursach.UI.WinForm
{
    public partial class OperationsForm : DevExpress.XtraEditors.XtraForm
    {
        public bool edit;//при true режим формы переходит в редактирование (это надо еще сделать...)
        public bool view;
        public Guid currentOperationsGuid;

        private device_Operations currentOperations;

        bool formValid = true;//После реализации метода validForm поменять на false
        private UnitOfWork uow = new UnitOfWork();

        public OperationsForm()
        {
            InitializeComponent();
        }
        public OperationsForm(UnitOfWork u)
        {
            InitializeComponent();
            uow = u;
        }

        /// <summary>
        /// Здесь пока все в куче: поднятие/создание объекта, загрузка справочников для списков, настройка внешнего вида...
        /// </summary>
        void initForm()
        {
            if (edit)
            {
                currentOperations = uow.GetObjectByKey<device_Operations>(currentOperationsGuid);
            }
            else
            {
                currentOperations = new device_Operations(uow);
            }

            #region Настройка внешнего вида
            if (edit)
            {
                Text = string.Format("Редактировать операцию {0} ", currentOperations.NameOperations);
                addButton.Text = "Сохранить";
            }

            if (view)
            {
                Text = string.Format("Просмотр операцию {0} ", currentOperations.NameOperations);
                nameOperationsTextEdit.ReadOnly = true;
                typeOperationsGUIDLookUpEdit1.ReadOnly = true;
                timeEdit1.ReadOnly = true;
                workTeamGUIDLookUpEdit.ReadOnly = true;
                layoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
            #endregion


            #region Заполнение выпадающего списка данными
            using (Session u = new Session())
            {
                SelectedData typeOperationsGUIDData = u.ExecuteQuery(@"SELECT GUID,NameOperationsType FROM [device].TypeOperations WHERE[DeletedDate] is null");
                typeOperationsGUIDDataView.LoadData(typeOperationsGUIDData);

            }
            using (Session u = new Session())
            {
                SelectedData workTeamGUID = u.ExecuteQuery(@"SELECT GUID,NumberOfWorkers  FROM [device].WorkTeam WHERE[DeletedDate] is null");
                workTeamGUIDDataView.LoadData(workTeamGUID);

            }
            #endregion

            if (edit)
            {
                nameOperationsTextEdit.Text = currentOperations.NameOperations;
                typeOperationsGUIDLookUpEdit1.EditValue = currentOperations.TypeOperationsGUID;
                timeEdit1.Text = currentOperations.OperationTime.ToString();
                workTeamGUIDLookUpEdit.EditValue = currentOperations.WorkTeamGUID;
            }


        }

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
                currentOperations.NameOperations = nameOperationsTextEdit.Text;
                currentOperations.TypeOperationsGUID = uow.GetObjectByKey<device_TypeOperations>(typeOperationsGUIDLookUpEdit1.EditValue);
                currentOperations.WorkTeamGUID = uow.GetObjectByKey<device_WorkTeam>(workTeamGUIDLookUpEdit.EditValue);
                currentOperations.OperationTime = Convert.ToDateTime(timeEdit1.Text);

                if (edit)
                {
                    currentOperations.DateOfChange = DateTime.Now;
                    currentOperations.Save();
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

     

        private void OperationsForm_Load_1(object sender, EventArgs e)
        {
            initForm();
        }

        private void nameOperationsTextEdit_KeyPress(object sender, KeyPressEventArgs e)
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
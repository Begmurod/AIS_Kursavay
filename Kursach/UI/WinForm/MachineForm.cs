using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Xpo;
using Kursach.DB.DBKursach;

namespace Kursach.UI.WinForm
{
    public partial class MachineForm : DevExpress.XtraEditors.XtraForm
    {
        public bool edit;//при true режим формы переходит в редактирование (это надо еще сделать...)
        public bool view;
        public Guid currentMachineGuid;

        private device_Machine currentMachine;

        bool formValid = true;//После реализации метода validForm поменять на false
        private UnitOfWork uow = new UnitOfWork();
        public MachineForm()
        {
            InitializeComponent();
        }
        public MachineForm(UnitOfWork u)
        {
            InitializeComponent();
            uow = u;
        }

        private void MachineForm_Load(object sender, EventArgs e)
        {
            initForm();
        }/// <summary>
         /// Здесь пока все в куче: поднятие/создание объекта, загрузка справочников для списков, настройка внешнего вида...
         /// </summary>
        void initForm()
        {
            if (edit)
            {
                currentMachine = uow.GetObjectByKey<device_Machine>(currentMachineGuid);
            }
            else
            {
                currentMachine = new device_Machine(uow);
            }

            #region Настройка внешнего вида
            if (edit)
            {
                Text = string.Format("Редактирование единицы {0} ", currentMachine.Name);
                addButton.Text = "Сохранить";
            }

            if (view)
            {
                Text = string.Format("Просмотр единицы {0} ", currentMachine.Name);
                nameTextEdit.ReadOnly = true;
                basetypeGUIDLookUpEdit1.ReadOnly = true;
                baseOperationsGUIDLookUpEdit.ReadOnly = true;
                CommissioningDatedateEdit.ReadOnly = true;
                layoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
            #endregion

            if (edit)
            {
                nameTextEdit.Text = currentMachine.Name;
                basetypeGUIDLookUpEdit1.EditValue = currentMachine.TypeGUID;
                baseOperationsGUIDLookUpEdit.EditValue = currentMachine.OperationsGUID;
                CommissioningDatedateEdit.DateTime = currentMachine.CommissioningDate;
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
                currentMachine.Name = nameTextEdit.Text;
                currentMachine.TypeGUID = uow.GetObjectByKey<device_Type>(baseOperationsGUIDLookUpEdit.EditValue);
                currentMachine.OperationsGUID = uow.GetObjectByKey<device_Operations>(baseOperationsGUIDLookUpEdit.EditValue);
                currentMachine.CommissioningDate = CommissioningDatedateEdit.DateTime;

                if (edit)
                {
                    currentMachine.DateOfChange = DateTime.Now;
                    currentMachine.Save();
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
    }
}
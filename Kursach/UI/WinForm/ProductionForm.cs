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
using DevExpress.XtraEditors.DXErrorProvider;
using System.Text.RegularExpressions;
using Kursach.DB.Kursach;

namespace Kursach.UI.WinForm
{
    public partial class ProductionForm : DevExpress.XtraEditors.XtraForm
    {
        public bool edit;//при true режим формы переходит в редактирование (это надо еще сделать...)
        public bool view;
        public Guid currentProductionGuid;

        private device_Productions currentProduction;

        bool formValid = true;//После реализации метода validForm поменять на false
        private UnitOfWork uow = new UnitOfWork();

        public ProductionForm()
        {
            InitializeComponent();
        }
        public ProductionForm(UnitOfWork u)
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
                currentProduction = uow.GetObjectByKey<device_Productions>(currentProductionGuid);
            }
            else
            {
                currentProduction = new device_Productions(uow);
            }

            #region Настройка внешнего вида
            if (edit)
            {
                Text = string.Format("Редактировать продукцию {0} ", currentProduction.ProductsGUID);
                addButton.Text = "Сохранить";
            }

            if (view)
            {
                Text = string.Format("Просмотрет продуктцию {0} ", currentProduction.ProductsGUID);
                productsGUIDLookUpEdit1.ReadOnly = true;
                operationsGUIDLookUpEdit2.ReadOnly = true;
                volumeTextEdit.ReadOnly = true;
                unitOfMeasurementTextEdit.ReadOnly = true;
                MaterialGUIDLookUpEdit.ReadOnly = true;
                volumeMaterialTextEdit.ReadOnly = true;
                unitOfMeasurementMaterialTextEdit1.ReadOnly = true;
                DateOfTheBeginningDateEdit.ReadOnly = true;
                endDateDateEdit1.Properties.ReadOnly = true;
                layoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
            #endregion


            #region Заполнение выпадающего списка данными
            using (Session u = new Session())
            {
                SelectedData productsGUIDData = u.ExecuteQuery(@"SELECT GUID,Name FROM [device].Products WHERE[DeletedDate] is null");
                productsGUIDDataView.LoadData(productsGUIDData);

            }
            using (Session u = new Session())
            {
                SelectedData operationsGUID = u.ExecuteQuery(@"SELECT GUID,NameOperations FROM [device].Operations WHERE[DeletedDate] is null");
                operationsGUIDDataView.LoadData(operationsGUID);

            }
            using (Session u = new Session())
            {
                SelectedData materialGUID = u.ExecuteQuery(@"SELECT GUID,Name FROM [device].Material WHERE[DeletedDate] is null");
                materialGUIDDataView.LoadData(materialGUID);

            }
            #endregion

            if (edit)
            {
                productsGUIDLookUpEdit1.EditValue = currentProduction.ProductsGUID;
                
                operationsGUIDLookUpEdit2.EditValue = currentProduction.OperationsGUID;
                volumeTextEdit.Text = currentProduction.Volume.ToString();
                unitOfMeasurementTextEdit.Text = currentProduction.UnitOfMeasurement;
                MaterialGUIDLookUpEdit.EditValue = currentProduction.MaterialGUID;
                volumeMaterialTextEdit.Text = currentProduction.VolumeMaterial.ToString();
                unitOfMeasurementMaterialTextEdit1.Text = currentProduction.UnitOfMeasurementMaterial;
                DateOfTheBeginningDateEdit.DateTime = currentProduction.DateOfTheBeginning;
                endDateDateEdit1.DateTime = currentProduction.EndDate;
            }
        }

        private void ProductionForm_Load(object sender, EventArgs e)
        {
            initForm();
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
                currentProduction.ProductsGUID = uow.GetObjectByKey<device_Products>(productsGUIDLookUpEdit1.EditValue);
                currentProduction.OperationsGUID = uow.GetObjectByKey<device_Operations>(operationsGUIDLookUpEdit2.EditValue);
                currentProduction.Volume = Convert.ToDecimal(volumeTextEdit.Text);
                currentProduction.UnitOfMeasurement = unitOfMeasurementTextEdit.Text;
                currentProduction.MaterialGUID = uow.GetObjectByKey<device_Material>(MaterialGUIDLookUpEdit.EditValue);
                currentProduction.UnitOfMeasurementMaterial = unitOfMeasurementMaterialTextEdit1.Text;
                currentProduction.DateOfTheBeginning = Convert.ToDateTime(DateOfTheBeginningDateEdit.Text);
                currentProduction.EndDate = Convert.ToDateTime(endDateDateEdit1.Text);

                if (edit)
                {
                    currentProduction.DateOfChange = DateTime.Now;
                    currentProduction.Save();
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

        private void volumeTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44) // цифры, клавиша BackSpace и запятая
            {
                e.Handled = true;
            }
        }

        private void volumeMaterialTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44) // цифры, клавиша BackSpace и запятая
            {
                e.Handled = true;
            }
        }

        private void unitOfMeasurementTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            if ((char)e.KeyChar == (Char)Keys.CapsLock) return;
            if ((char)e.KeyChar == (Char)Keys.Back) return;
            if ((char)e.KeyChar == '.') return;
            if (char.IsLetter(e.KeyChar)) return;
            e.Handled = true;
            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success)
            {
                e.Handled = true;
            }
        }
    }
}
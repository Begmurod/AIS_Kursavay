﻿using DevExpress.Xpo;
using DevExpress.XtraEditors;
using Kursach.DB.DBKursach;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach.UI.WinForm
{
    public partial class TypeOfRepairForm : Form
    {
        public bool edit;//при true режим формы переходит в редактирование (это надо еще сделать...)
        public bool view;
        public Guid currentTypeOfRepairGuid;
        private device_TypeOfRepair currentTypeOfRepair;

        bool formValid = true;//После реализации метода validForm поменять на false
        private UnitOfWork uow = new UnitOfWork();
        public TypeOfRepairForm()
        {
            InitializeComponent();
        }
        public TypeOfRepairForm(UnitOfWork u)
        {
            InitializeComponent();
            uow = u;
        }
        void initForm()
        {
            if (edit)
            {
                currentTypeOfRepair = uow.GetObjectByKey<device_TypeOfRepair>(currentTypeOfRepairGuid);
            }
            else
            {
                currentTypeOfRepair = new device_TypeOfRepair(uow);
            }

            #region Настройка внешнего вида
            if (edit)
            {
                Text = string.Format("Редактировать ремонт {0}", currentTypeOfRepair.Name);
                addButton.Text = "Сохранить";
            }

            if (view)
            {
                Text = string.Format("Просмотр ремонт {0}", currentTypeOfRepair.Name);
                nameTextEdit.ReadOnly = true;
                layoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
            #endregion


            if (edit)
            {
                nameTextEdit.Text = currentTypeOfRepair.Name;
            }
        }

        private void TypeOfRepairForm_Load(object sender, EventArgs e)
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
                currentTypeOfRepair.Name = nameTextEdit.Text;

                if (edit)
                {
                    currentTypeOfRepair.DateOfChange = DateTime.Now;
                    currentTypeOfRepair.Save();
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
    }
}
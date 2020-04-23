﻿using System;
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
using Kursach.DBKursach;

namespace Kursach.WinForm
{
    public partial class PositionForm : DevExpress.XtraEditors.XtraForm
    {
        public bool edit;//при true режим формы переходит в редактирование (это надо еще сделать...)
        public bool view;
        public Guid currentPositionGuid;

        private device_Position currentPosition;

        bool formValid = true;//После реализации метода validForm поменять на false
        private UnitOfWork uow = new UnitOfWork();
        public PositionForm()
        {
            InitializeComponent();
        }
        public PositionForm(UnitOfWork u)
        {
            InitializeComponent();
            uow = u;
        }

        private void PositionForm_Load(object sender, EventArgs e)
        {
            initForm();
        }
        void initForm()
        {
            if (edit)
            {
                currentPosition = uow.GetObjectByKey<device_Position>(currentPositionGuid);
            }
            else
            {
                currentPosition = new device_Position(uow);
            }

            #region Настройка внешнего вида
            if (edit)
            {
                Text = string.Format("Редактировать должность {0} ", currentPosition.NamePosition);
                addButton.Text = "Сохранить";
            }

            if (view)
            {
                Text = string.Format("Посмотреть должность {0} ", currentPosition.NamePosition);
                NamePositiontextEdit.ReadOnly = true;
                layoutControlItem1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
            #endregion
            if (edit)
            {
                NamePositiontextEdit.Text = currentPosition.NamePosition;

            }

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            validForm();
            SavePosition();
            uow.CommitChanges();//Сохранение объекта в БД       
            Close();
        }
        /// <summary>
        /// Заполнение текущей Должности данными с формы
        /// </summary>
        void SavePosition()
        {
            if (formValid)
            {
                currentPosition.NamePosition = NamePositiontextEdit.Text;
                if (edit)
                {
                    currentPosition.DateOfChange = DateTime.Now;
                    currentPosition.Save();
                }
            }

        }
        private void validForm()
        {
            //TODO  Сделать валидацию формы!!!
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            uow.Dispose();
            Close();
        }
    }
}
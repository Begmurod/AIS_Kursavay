using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Text.RegularExpressions;
using Kursach.DB.Kursach;

namespace Kursach.UI.WinForm
{
    public partial class ProductsForm : Form
    {
        public bool edit;//при true режим формы переходит в редактирование (это надо еще сделать...)
        public bool view;
        public Guid currentProductsGuid;

        private device_Products currentProducts;

        bool formValid = true;//После реализации метода validForm поменять на false
        private UnitOfWork uow = new UnitOfWork();
        public ProductsForm()
        {
            InitializeComponent();
        }

        public ProductsForm(UnitOfWork u)
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
                currentProducts = uow.GetObjectByKey<device_Products>(currentProductsGuid);
            }
            else
            {
                currentProducts = new device_Products(uow);
            }

            #region Настройка внешнего вида
            if (edit)
            {
                Text = string.Format("Редактировать название продукта {0}", currentProducts.Name);
                addButton.Text = "Сохранить";
            }

            if (view)
            {
                Text = string.Format("Просмотр название продукта {0}", currentProducts.Name);
                nameTextEdit.ReadOnly = true;
                layoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
            #endregion


            if (edit)
            {
                nameTextEdit.Text = currentProducts.Name;
            }
        }

        private void ProductsForm_Load(object sender, EventArgs e)
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
                currentProducts.Name = nameTextEdit.Text;

                if (edit)
                {
                    currentProducts.DateOfChange = DateTime.Now;
                    currentProducts.Save();
                }
            }

        }
        private void validForm()
        {
            //TODO  Сделать валидацию формы!!!  formValid = false;
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

        private void nameTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            if ((char)e.KeyChar == (Char)Keys.CapsLock) return;
            if ((char)e.KeyChar == (Char)Keys.Back) return;
            if ((char)e.KeyChar == '@') return;
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

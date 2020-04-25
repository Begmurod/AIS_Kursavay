using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Xpo;
using Kursach.UI.WinForm;
using Kursach.DB.DBKursach;

namespace Kursach.UI
{
    public partial class operationsUC : DevExpress.XtraEditors.XtraUserControl
    {
        #region Для блокировки кнопок. Нужно вынести в отдельный абстрактный класс
        public event EventHandler lockButtons;
        public event EventHandler unlockButtons;

        public virtual void fireLockButtons(EventArgs e)
        {
            if (lockButtons != null)
                lockButtons(this, e);
        }


        public virtual void fireUnlockButtons(EventArgs e)
        {
            if (unlockButtons != null)
                unlockButtons(this, e);
        }
        #endregion
        public operationsUC()
        {
            InitializeComponent();
        }
        public operationsUC(Control _parent)
        {
            InitializeComponent();
            Parent = _parent;

            lockButtons += new EventHandler(OnDimensionSetLockButtons);
            unlockButtons += new EventHandler(OnDimensionUnlockButtons);
        }
        public void OnDimensionSetLockButtons(object sender, EventArgs e)
        {
            barButtonItemView.Enabled = false;
            barButtonItemEdit.Enabled = false;
            barButtonItemDelete.Enabled = false;
        }

        public void OnDimensionUnlockButtons(object sender, EventArgs e)
        {
            barButtonItemView.Enabled = true;
            barButtonItemEdit.Enabled = true;
            barButtonItemDelete.Enabled = true;
        }
        private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (OperationsForm addForm = new OperationsForm())
            {
                addForm.ShowDialog();
                addForm.Dispose();
            }
            loadData();
        }

        private void operationsUC_Load(object sender, EventArgs e)
        {

            loadData();
        }
        private void loadData()
        {
            using (UnitOfWork u = new UnitOfWork())
            {

                //TODO сделать фильтр по критериям
                DevExpress.Xpo.DB.SelectedData _operationsData = u.ExecuteQuery(string.Format(@"
              SELECT  [GUID]
      ,[NameOperations]
      ,[TypeOperationsGUID]
      ,[OperationTime]
      ,[WorkTeamGUID]
      ,[DateOfChange]
      ,[DeletedDate]
  FROM [dbo].[OperationsView]
  WHERE [DeletedDate] is null"
                ));
                operationsDataView.LoadData(_operationsData);
            }
            GC.Collect();
        }

        private void barButtonItemView_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OperationsForm viewForm = new OperationsForm();
            viewForm.currentOperationsGuid = (Guid)operationsGridView.GetFocusedRowCellValue("GUID");
            viewForm.edit = true;
            viewForm.view = true;
            viewForm.ShowDialog();
        }

        private void barButtonItemEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (OperationsForm editForm = new OperationsForm())
            {
                editForm.currentOperationsGuid = (Guid)operationsGridView.GetFocusedRowCellValue("GUID");
                editForm.edit = true;
                editForm.ShowDialog();
            }
            loadData();
        }

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (UnitOfWork u = new UnitOfWork())
            {
                device_Operations currentOperations = u.GetObjectByKey<device_Operations>((Guid)operationsGridView.GetFocusedRowCellValue("GUID"));
                DialogResult d = XtraMessageBox.Show(string.Format("Удалить Измеряемые величины {0}  ?", currentOperations.NameOperations) ,"Подтверждение действия", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    currentOperations.DeletedDate = DateTime.Now;
                    currentOperations.Save();
                    u.CommitChanges();
                }
            }
            loadData();


        }

        private void operationsGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle < 0)
            {
                fireLockButtons(new EventArgs());
            }
            else
            {
                fireUnlockButtons(new EventArgs());
            }
        }
    }
}

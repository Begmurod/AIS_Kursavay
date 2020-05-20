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
using Kursach.DB.Kursach;

namespace Kursach.UI
{
    public partial class productionUC : DevExpress.XtraEditors.XtraUserControl
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
        public productionUC()
        {
            InitializeComponent();
        }
        public productionUC(Control _parent)
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

        private void productionUC_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            using (UnitOfWork u = new UnitOfWork())
            {

                //TODO сделать фильтр по критериям
                DevExpress.Xpo.DB.SelectedData _positionData = u.ExecuteQuery(string.Format(@"
               [GUID]
      ,[ProductsGUID]
      ,[OperationsGUID]
      ,[Volume]
      ,[UnitOfMeasurement]
      ,[MaterialGUID]
      ,[VolumeMaterial]
      ,[UnitOfMeasurementMaterial]
      ,[DateOfTheBeginning]
      ,[EndDate]
      ,[DateOfChange]
      ,[DeletedDate]
  FROM [dbo].[ProductionsView]
  WHERE [DeletedDate] is null"
                ));
                productionDataView.LoadData(_positionData);
            }
            GC.Collect();
        }

        private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (ProductionForm addForm = new ProductionForm())
            {
                addForm.ShowDialog();
                addForm.Dispose();
            }
            loadData();
        }

        private void barButtonItemView_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ProductionForm viewForm = new ProductionForm();
            viewForm.currentProductionGuid = (Guid)productionGridView.GetFocusedRowCellValue("GUID");
            viewForm.edit = true;
            viewForm.view = true;
            viewForm.ShowDialog();
        }

        private void barButtonItemEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (ProductionForm editForm = new ProductionForm())
            {
                editForm.currentProductionGuid = (Guid)productionGridView.GetFocusedRowCellValue("GUID");
                editForm.edit = true;
                editForm.ShowDialog();
            }
            loadData();
        }

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (UnitOfWork u = new UnitOfWork())
            {
                device_Productions currentProduction = u.GetObjectByKey<device_Productions>((Guid)productionGridView.GetFocusedRowCellValue("GUID"));
                DialogResult d = XtraMessageBox.Show(string.Format("Удалить продукт {0} ", currentProduction.ProductsGUID), "Подтверждение действия", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    currentProduction.DeletedDate = DateTime.Now;
                    currentProduction.Save();
                    u.CommitChanges();
                }
                loadData();
            }
        }

        private void productionGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
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

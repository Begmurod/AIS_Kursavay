namespace Kursach.UI
{
    partial class workShiftsUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.workShiftsDataView = new DevExpress.Xpo.XPDataView(this.components);
            this.dimensionRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemView = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.vendorGridControl = new DevExpress.XtraGrid.GridControl();
            this.workShiftsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTypeOfShift = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWorkingHours = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShiftType = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.workShiftsDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workShiftsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // workShiftsDataView
            // 
            this.workShiftsDataView.Properties.AddRange(new DevExpress.Xpo.DataViewProperty[] {
            new DevExpress.Xpo.DataViewProperty("GUID", typeof(object)),
            new DevExpress.Xpo.DataViewProperty("TypeOfShift", typeof(string)),
            new DevExpress.Xpo.DataViewProperty("WorkingHours", typeof(decimal)),
            new DevExpress.Xpo.DataViewProperty("ShiftType", typeof(string))});
            // 
            // dimensionRibbonControl
            // 
            this.dimensionRibbonControl.ExpandCollapseItem.Id = 0;
            this.dimensionRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.dimensionRibbonControl.ExpandCollapseItem,
            this.dimensionRibbonControl.SearchEditItem,
            this.barButtonItemAdd,
            this.barButtonItemEdit,
            this.barButtonItemDelete,
            this.barButtonItemView});
            this.dimensionRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.dimensionRibbonControl.MaxItemId = 7;
            this.dimensionRibbonControl.Name = "dimensionRibbonControl";
            this.dimensionRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.dimensionRibbonControl.Size = new System.Drawing.Size(1019, 150);
            this.dimensionRibbonControl.Click += new System.EventHandler(this.dimensionRibbonControl_Click);
            // 
            // barButtonItemAdd
            // 
            this.barButtonItemAdd.Caption = "Добавить";
            this.barButtonItemAdd.Id = 3;
            this.barButtonItemAdd.Name = "barButtonItemAdd";
            this.barButtonItemAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemAdd_ItemClick);
            // 
            // barButtonItemEdit
            // 
            this.barButtonItemEdit.Caption = "Редактировать";
            this.barButtonItemEdit.Enabled = false;
            this.barButtonItemEdit.Id = 4;
            this.barButtonItemEdit.Name = "barButtonItemEdit";
            this.barButtonItemEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemEdit_ItemClick);
            // 
            // barButtonItemDelete
            // 
            this.barButtonItemDelete.Caption = "Удалить";
            this.barButtonItemDelete.Enabled = false;
            this.barButtonItemDelete.Id = 5;
            this.barButtonItemDelete.Name = "barButtonItemDelete";
            this.barButtonItemDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDelete_ItemClick);
            // 
            // barButtonItemView
            // 
            this.barButtonItemView.Caption = "Просмотр";
            this.barButtonItemView.Enabled = false;
            this.barButtonItemView.Id = 6;
            this.barButtonItemView.Name = "barButtonItemView";
            this.barButtonItemView.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemView_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Главная";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemAdd);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemView);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemDelete);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // vendorGridControl
            // 
            this.vendorGridControl.DataSource = this.workShiftsDataView;
            this.vendorGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vendorGridControl.Location = new System.Drawing.Point(0, 150);
            this.vendorGridControl.MainView = this.workShiftsGridView;
            this.vendorGridControl.MenuManager = this.dimensionRibbonControl;
            this.vendorGridControl.Name = "vendorGridControl";
            this.vendorGridControl.Size = new System.Drawing.Size(1019, 465);
            this.vendorGridControl.TabIndex = 1;
            this.vendorGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.workShiftsGridView});
            // 
            // workShiftsGridView
            // 
            this.workShiftsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGUID,
            this.colTypeOfShift,
            this.colWorkingHours,
            this.colShiftType});
            this.workShiftsGridView.GridControl = this.vendorGridControl;
            this.workShiftsGridView.Name = "workShiftsGridView";
            this.workShiftsGridView.OptionsView.ShowFooter = true;
            this.workShiftsGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.workShiftsGridView_FocusedRowChanged);
            // 
            // colGUID
            // 
            this.colGUID.FieldName = "GUID";
            this.colGUID.Name = "colGUID";
            // 
            // colTypeOfShift
            // 
            this.colTypeOfShift.Caption = "Вид смены";
            this.colTypeOfShift.FieldName = "TypeOfShift";
            this.colTypeOfShift.Name = "colTypeOfShift";
            this.colTypeOfShift.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Name", "{0}")});
            this.colTypeOfShift.Visible = true;
            this.colTypeOfShift.VisibleIndex = 0;
            // 
            // colWorkingHours
            // 
            this.colWorkingHours.Caption = "Рабочие часы";
            this.colWorkingHours.FieldName = "WorkingHours";
            this.colWorkingHours.Name = "colWorkingHours";
            this.colWorkingHours.Visible = true;
            this.colWorkingHours.VisibleIndex = 1;
            // 
            // colShiftType
            // 
            this.colShiftType.Caption = "Тип смены";
            this.colShiftType.FieldName = "ShiftType";
            this.colShiftType.Name = "colShiftType";
            this.colShiftType.Visible = true;
            this.colShiftType.VisibleIndex = 2;
            // 
            // workShiftsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.vendorGridControl);
            this.Controls.Add(this.dimensionRibbonControl);
            this.Name = "workShiftsUC";
            this.Size = new System.Drawing.Size(1019, 615);
            this.Load += new System.EventHandler(this.workShiftsUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workShiftsDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workShiftsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.Xpo.XPDataView workShiftsDataView;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl vendorGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView workShiftsGridView;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAdd;
        private DevExpress.XtraBars.BarButtonItem barButtonItemEdit;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDelete;
        public DevExpress.XtraBars.Ribbon.RibbonControl dimensionRibbonControl;
        private DevExpress.XtraBars.BarButtonItem barButtonItemView;
        private DevExpress.XtraGrid.Columns.GridColumn colGUID;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeOfShift;
        private DevExpress.XtraGrid.Columns.GridColumn colWorkingHours;
        private DevExpress.XtraGrid.Columns.GridColumn colShiftType;
    }
}

namespace Kursach.UI
{
    partial class typeOperationsUC
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
            this.typeOperationsDataView = new DevExpress.Xpo.XPDataView(this.components);
            this.typeOperationsRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemView = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.vendorGridControl = new DevExpress.XtraGrid.GridControl();
            this.typeOperationsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNameOperationsType = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.typeOperationsDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOperationsRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOperationsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // typeOperationsDataView
            // 
            this.typeOperationsDataView.Properties.AddRange(new DevExpress.Xpo.DataViewProperty[] {
            new DevExpress.Xpo.DataViewProperty("GUID", typeof(object)),
            new DevExpress.Xpo.DataViewProperty("NameOperationsType", typeof(string))});
            // 
            // typeOperationsRibbonControl
            // 
            this.typeOperationsRibbonControl.ExpandCollapseItem.Id = 0;
            this.typeOperationsRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.typeOperationsRibbonControl.ExpandCollapseItem,
            this.barButtonItemAdd,
            this.barButtonItemEdit,
            this.barButtonItemDelete,
            this.barButtonItemView,
            this.typeOperationsRibbonControl.SearchEditItem});
            this.typeOperationsRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.typeOperationsRibbonControl.MaxItemId = 7;
            this.typeOperationsRibbonControl.Name = "typeOperationsRibbonControl";
            this.typeOperationsRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.typeOperationsRibbonControl.Size = new System.Drawing.Size(1019, 150);
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
            this.vendorGridControl.DataSource = this.typeOperationsDataView;
            this.vendorGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vendorGridControl.Location = new System.Drawing.Point(0, 150);
            this.vendorGridControl.MainView = this.typeOperationsGridView;
            this.vendorGridControl.MenuManager = this.typeOperationsRibbonControl;
            this.vendorGridControl.Name = "vendorGridControl";
            this.vendorGridControl.Size = new System.Drawing.Size(1019, 465);
            this.vendorGridControl.TabIndex = 1;
            this.vendorGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.typeOperationsGridView});
            // 
            // typeOperationsGridView
            // 
            this.typeOperationsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGUID,
            this.colNameOperationsType});
            this.typeOperationsGridView.GridControl = this.vendorGridControl;
            this.typeOperationsGridView.Name = "typeOperationsGridView";
            this.typeOperationsGridView.OptionsView.ShowFooter = true;
            this.typeOperationsGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.typeOperationsGridView_FocusedRowChanged);
            // 
            // colGUID
            // 
            this.colGUID.FieldName = "GUID";
            this.colGUID.Name = "colGUID";
            // 
            // colNameOperationsType
            // 
            this.colNameOperationsType.Caption = "Наименование типо операции";
            this.colNameOperationsType.FieldName = "NameOperationsType";
            this.colNameOperationsType.Name = "colNameOperationsType";
            this.colNameOperationsType.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Name", "{0}")});
            this.colNameOperationsType.Visible = true;
            this.colNameOperationsType.VisibleIndex = 0;
            // 
            // typeOperationsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.vendorGridControl);
            this.Controls.Add(this.typeOperationsRibbonControl);
            this.Name = "typeOperationsUC";
            this.Size = new System.Drawing.Size(1019, 615);
            this.Load += new System.EventHandler(this.typeOperationsUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.typeOperationsDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOperationsRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOperationsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.Xpo.XPDataView typeOperationsDataView;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl vendorGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView typeOperationsGridView;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAdd;
        private DevExpress.XtraBars.BarButtonItem barButtonItemEdit;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDelete;
        public DevExpress.XtraBars.Ribbon.RibbonControl typeOperationsRibbonControl;
        private DevExpress.XtraBars.BarButtonItem barButtonItemView;
        private DevExpress.XtraGrid.Columns.GridColumn colGUID;
        private DevExpress.XtraGrid.Columns.GridColumn colNameOperationsType;
    }
}

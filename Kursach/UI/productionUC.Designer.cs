namespace Kursach.UI
{
    partial class productionUC
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabbedView = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.positionRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.skinRibbonGalleryBarItem = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.employeesBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.customersBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.skinDropDownButtonItem = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.skinPaletteRibbonGalleryBarItem = new DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem();
            this.barButtonItemAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemView = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDelete = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.employeesNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.positiongridControl = new DevExpress.XtraGrid.GridControl();
            this.productionDataView = new DevExpress.Xpo.XPDataView(this.components);
            this.productionGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductsGUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperationsGUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVolume = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitOfMeasurement = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaterialGUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVolumeMaterial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitOfMeasurementMaterial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateOfTheBeginning = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEndDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateOfChange = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeletedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.employeesLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.customersNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.customersLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).BeginInit();
            this.navigationFrame.SuspendLayout();
            this.employeesNavigationPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.positiongridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionGridView)).BeginInit();
            this.customersNavigationPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // positionRibbonControl
            // 
            this.positionRibbonControl.ExpandCollapseItem.Id = 0;
            this.positionRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.positionRibbonControl.ExpandCollapseItem,
            this.positionRibbonControl.SearchEditItem,
            this.skinRibbonGalleryBarItem,
            this.employeesBarButtonItem,
            this.customersBarButtonItem,
            this.skinDropDownButtonItem,
            this.skinPaletteRibbonGalleryBarItem,
            this.barButtonItemAdd,
            this.barButtonItemView,
            this.barButtonItemEdit,
            this.barButtonItemDelete});
            this.positionRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.positionRibbonControl.MaxItemId = 50;
            this.positionRibbonControl.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.positionRibbonControl.Name = "positionRibbonControl";
            this.positionRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage});
            this.positionRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.positionRibbonControl.Size = new System.Drawing.Size(918, 126);
            this.positionRibbonControl.StatusBar = this.ribbonStatusBar;
            this.positionRibbonControl.Tag = "<Null>";
            this.positionRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // skinRibbonGalleryBarItem
            // 
            this.skinRibbonGalleryBarItem.Id = 14;
            this.skinRibbonGalleryBarItem.Name = "skinRibbonGalleryBarItem";
            // 
            // employeesBarButtonItem
            // 
            this.employeesBarButtonItem.Caption = "Employees";
            this.employeesBarButtonItem.Id = 44;
            this.employeesBarButtonItem.Name = "employeesBarButtonItem";
            // 
            // customersBarButtonItem
            // 
            this.customersBarButtonItem.Caption = "Customers";
            this.customersBarButtonItem.Id = 45;
            this.customersBarButtonItem.Name = "customersBarButtonItem";
            // 
            // skinDropDownButtonItem
            // 
            this.skinDropDownButtonItem.Id = 46;
            this.skinDropDownButtonItem.Name = "skinDropDownButtonItem";
            // 
            // skinPaletteRibbonGalleryBarItem
            // 
            this.skinPaletteRibbonGalleryBarItem.Caption = "$newskinpalettename$";
            this.skinPaletteRibbonGalleryBarItem.Id = 47;
            this.skinPaletteRibbonGalleryBarItem.Name = "skinPaletteRibbonGalleryBarItem";
            // 
            // barButtonItemAdd
            // 
            this.barButtonItemAdd.Caption = "Добавить";
            this.barButtonItemAdd.CloseSubMenuOnClickMode = DevExpress.Utils.DefaultBoolean.True;
            this.barButtonItemAdd.Id = 46;
            this.barButtonItemAdd.Name = "barButtonItemAdd";
            this.barButtonItemAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemAdd_ItemClick);
            // 
            // barButtonItemView
            // 
            this.barButtonItemView.Caption = "Просмотр";
            this.barButtonItemView.CloseSubMenuOnClickMode = DevExpress.Utils.DefaultBoolean.True;
            this.barButtonItemView.Enabled = false;
            this.barButtonItemView.Id = 47;
            this.barButtonItemView.Name = "barButtonItemView";
            this.barButtonItemView.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemView_ItemClick);
            // 
            // barButtonItemEdit
            // 
            this.barButtonItemEdit.Caption = "Редактировать";
            this.barButtonItemEdit.Enabled = false;
            this.barButtonItemEdit.Id = 48;
            this.barButtonItemEdit.Name = "barButtonItemEdit";
            this.barButtonItemEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemEdit_ItemClick);
            // 
            // barButtonItemDelete
            // 
            this.barButtonItemDelete.Caption = "Удалить";
            this.barButtonItemDelete.Enabled = false;
            this.barButtonItemDelete.Id = 49;
            this.barButtonItemDelete.Name = "barButtonItemDelete";
            this.barButtonItemDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDelete_ItemClick);
            // 
            // ribbonPage
            // 
            this.ribbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage.Name = "ribbonPage";
            this.ribbonPage.Text = "Главная";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemAdd);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemView);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemDelete);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 573);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.positionRibbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(918, 27);
            // 
            // navigationFrame
            // 
            this.navigationFrame.Appearance.BackColor = System.Drawing.Color.White;
            this.navigationFrame.Appearance.Options.UseBackColor = true;
            this.navigationFrame.Controls.Add(this.employeesNavigationPage);
            this.navigationFrame.Controls.Add(this.customersNavigationPage);
            this.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame.Location = new System.Drawing.Point(0, 126);
            this.navigationFrame.Name = "navigationFrame";
            this.navigationFrame.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.employeesNavigationPage,
            this.customersNavigationPage});
            this.navigationFrame.RibbonAndBarsMergeStyle = DevExpress.XtraBars.Docking2010.Views.RibbonAndBarsMergeStyle.Always;
            this.navigationFrame.SelectedPage = this.employeesNavigationPage;
            this.navigationFrame.Size = new System.Drawing.Size(918, 447);
            this.navigationFrame.TabIndex = 0;
            this.navigationFrame.Text = "navigationFrame";
            // 
            // employeesNavigationPage
            // 
            this.employeesNavigationPage.Controls.Add(this.positiongridControl);
            this.employeesNavigationPage.Controls.Add(this.employeesLabelControl);
            this.employeesNavigationPage.Name = "employeesNavigationPage";
            this.employeesNavigationPage.Size = new System.Drawing.Size(918, 447);
            // 
            // positiongridControl
            // 
            this.positiongridControl.DataSource = this.productionDataView;
            this.positiongridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.positiongridControl.Location = new System.Drawing.Point(0, 0);
            this.positiongridControl.MainView = this.productionGridView;
            this.positiongridControl.MenuManager = this.positionRibbonControl;
            this.positiongridControl.Name = "positiongridControl";
            this.positiongridControl.Size = new System.Drawing.Size(918, 447);
            this.positiongridControl.TabIndex = 1;
            this.positiongridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.productionGridView});
            // 
            // productionDataView
            // 
            this.productionDataView.Properties.AddRange(new DevExpress.Xpo.DataViewProperty[] {
            new DevExpress.Xpo.DataViewProperty("GUID", typeof(object)),
            new DevExpress.Xpo.DataViewProperty("ProductsGUID", typeof(string)),
            new DevExpress.Xpo.DataViewProperty("OperationsGUID", typeof(string)),
            new DevExpress.Xpo.DataViewProperty("Volume", typeof(decimal)),
            new DevExpress.Xpo.DataViewProperty("UnitOfMeasurement", typeof(string)),
            new DevExpress.Xpo.DataViewProperty("MaterialGUID", typeof(string)),
            new DevExpress.Xpo.DataViewProperty("VolumeMaterial", typeof(decimal)),
            new DevExpress.Xpo.DataViewProperty("UnitOfMeasurementMaterial", typeof(string)),
            new DevExpress.Xpo.DataViewProperty("DateOfTheBeginning", typeof(System.DateTime)),
            new DevExpress.Xpo.DataViewProperty("EndDate", typeof(System.DateTime)),
            new DevExpress.Xpo.DataViewProperty("DateOfChange", typeof(System.DateTime)),
            new DevExpress.Xpo.DataViewProperty("DeletedDate", typeof(System.DateTime))});
            // 
            // productionGridView
            // 
            this.productionGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGUID,
            this.colProductsGUID,
            this.colOperationsGUID,
            this.colVolume,
            this.colUnitOfMeasurement,
            this.colMaterialGUID,
            this.colVolumeMaterial,
            this.colUnitOfMeasurementMaterial,
            this.colDateOfTheBeginning,
            this.colEndDate,
            this.colDateOfChange,
            this.colDeletedDate});
            this.productionGridView.GridControl = this.positiongridControl;
            this.productionGridView.Name = "productionGridView";
            this.productionGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.productionGridView_FocusedRowChanged);
            // 
            // colGUID
            // 
            this.colGUID.Caption = "GUID";
            this.colGUID.FieldName = "GUID";
            this.colGUID.Name = "colGUID";
            // 
            // colProductsGUID
            // 
            this.colProductsGUID.Caption = "Название продукта";
            this.colProductsGUID.FieldName = "ProductsGUID";
            this.colProductsGUID.Name = "colProductsGUID";
            this.colProductsGUID.Visible = true;
            this.colProductsGUID.VisibleIndex = 0;
            // 
            // colOperationsGUID
            // 
            this.colOperationsGUID.Caption = "Название операции";
            this.colOperationsGUID.FieldName = "OperationsGUID";
            this.colOperationsGUID.Name = "colOperationsGUID";
            this.colOperationsGUID.Visible = true;
            this.colOperationsGUID.VisibleIndex = 1;
            // 
            // colVolume
            // 
            this.colVolume.Caption = "Объем продукта";
            this.colVolume.FieldName = "Volume";
            this.colVolume.Name = "colVolume";
            this.colVolume.Visible = true;
            this.colVolume.VisibleIndex = 2;
            // 
            // colUnitOfMeasurement
            // 
            this.colUnitOfMeasurement.Caption = "Единица измериния";
            this.colUnitOfMeasurement.FieldName = "UnitOfMeasurement";
            this.colUnitOfMeasurement.Name = "colUnitOfMeasurement";
            this.colUnitOfMeasurement.Visible = true;
            this.colUnitOfMeasurement.VisibleIndex = 3;
            // 
            // colMaterialGUID
            // 
            this.colMaterialGUID.Caption = "Название материала";
            this.colMaterialGUID.FieldName = "MaterialGUID";
            this.colMaterialGUID.Name = "colMaterialGUID";
            this.colMaterialGUID.Visible = true;
            this.colMaterialGUID.VisibleIndex = 4;
            // 
            // colVolumeMaterial
            // 
            this.colVolumeMaterial.Caption = "Объем материала";
            this.colVolumeMaterial.FieldName = "VolumeMaterial";
            this.colVolumeMaterial.Name = "colVolumeMaterial";
            this.colVolumeMaterial.Visible = true;
            this.colVolumeMaterial.VisibleIndex = 5;
            // 
            // colUnitOfMeasurementMaterial
            // 
            this.colUnitOfMeasurementMaterial.Caption = "Единица измериния материала";
            this.colUnitOfMeasurementMaterial.FieldName = "UnitOfMeasurementMaterial";
            this.colUnitOfMeasurementMaterial.Name = "colUnitOfMeasurementMaterial";
            this.colUnitOfMeasurementMaterial.Visible = true;
            this.colUnitOfMeasurementMaterial.VisibleIndex = 6;
            // 
            // colDateOfTheBeginning
            // 
            this.colDateOfTheBeginning.Caption = "Дата начало";
            this.colDateOfTheBeginning.FieldName = "DateOfTheBeginning";
            this.colDateOfTheBeginning.Name = "colDateOfTheBeginning";
            this.colDateOfTheBeginning.Visible = true;
            this.colDateOfTheBeginning.VisibleIndex = 7;
            // 
            // colEndDate
            // 
            this.colEndDate.Caption = "Дата окончания";
            this.colEndDate.FieldName = "EndDate";
            this.colEndDate.Name = "colEndDate";
            this.colEndDate.Visible = true;
            this.colEndDate.VisibleIndex = 8;
            // 
            // colDateOfChange
            // 
            this.colDateOfChange.Caption = "DateOfChange";
            this.colDateOfChange.FieldName = "DateOfChange";
            this.colDateOfChange.Name = "colDateOfChange";
            // 
            // colDeletedDate
            // 
            this.colDeletedDate.Caption = "DeletedDate";
            this.colDeletedDate.Name = "colDeletedDate";
            // 
            // employeesLabelControl
            // 
            this.employeesLabelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 25.25F);
            this.employeesLabelControl.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.employeesLabelControl.Appearance.Options.UseFont = true;
            this.employeesLabelControl.Appearance.Options.UseForeColor = true;
            this.employeesLabelControl.Appearance.Options.UseTextOptions = true;
            this.employeesLabelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.employeesLabelControl.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.employeesLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.employeesLabelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeesLabelControl.Location = new System.Drawing.Point(0, 0);
            this.employeesLabelControl.Name = "employeesLabelControl";
            this.employeesLabelControl.Size = new System.Drawing.Size(918, 447);
            this.employeesLabelControl.TabIndex = 0;
            this.employeesLabelControl.Text = "Employees";
            // 
            // customersNavigationPage
            // 
            this.customersNavigationPage.Controls.Add(this.customersLabelControl);
            this.customersNavigationPage.Name = "customersNavigationPage";
            this.customersNavigationPage.Size = new System.Drawing.Size(918, 447);
            // 
            // customersLabelControl
            // 
            this.customersLabelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 25.25F);
            this.customersLabelControl.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.customersLabelControl.Appearance.Options.UseFont = true;
            this.customersLabelControl.Appearance.Options.UseForeColor = true;
            this.customersLabelControl.Appearance.Options.UseTextOptions = true;
            this.customersLabelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.customersLabelControl.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.customersLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.customersLabelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersLabelControl.Location = new System.Drawing.Point(0, 0);
            this.customersLabelControl.Name = "customersLabelControl";
            this.customersLabelControl.Size = new System.Drawing.Size(918, 447);
            this.customersLabelControl.TabIndex = 1;
            this.customersLabelControl.Text = "Customers";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Просмотр";
            this.barButtonItem1.CloseSubMenuOnClickMode = DevExpress.Utils.DefaultBoolean.True;
            this.barButtonItem1.Enabled = false;
            this.barButtonItem1.Id = 47;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Просмотр";
            this.barButtonItem5.CloseSubMenuOnClickMode = DevExpress.Utils.DefaultBoolean.True;
            this.barButtonItem5.Enabled = false;
            this.barButtonItem5.Id = 47;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // productionUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.navigationFrame);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.positionRibbonControl);
            this.Name = "productionUC";
            this.Size = new System.Drawing.Size(918, 600);
            this.Load += new System.EventHandler(this.productionUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).EndInit();
            this.navigationFrame.ResumeLayout(false);
            this.employeesNavigationPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.positiongridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionGridView)).EndInit();
            this.customersNavigationPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame;
        private DevExpress.XtraBars.Navigation.NavigationPage employeesNavigationPage;
        private DevExpress.XtraEditors.LabelControl employeesLabelControl;
        private DevExpress.XtraBars.Navigation.NavigationPage customersNavigationPage;
        private DevExpress.XtraEditors.LabelControl customersLabelControl;
        private DevExpress.XtraBars.BarButtonItem employeesBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem customersBarButtonItem;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem;
        private DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem skinPaletteRibbonGalleryBarItem;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAdd;
        private DevExpress.XtraBars.BarButtonItem barButtonItemView;
        private DevExpress.XtraBars.BarButtonItem barButtonItemEdit;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDelete;
        private DevExpress.XtraGrid.GridControl positiongridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView productionGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colGUID;
        private DevExpress.XtraGrid.Columns.GridColumn colProductsGUID;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.Xpo.XPDataView productionDataView;
        public DevExpress.XtraBars.Ribbon.RibbonControl positionRibbonControl;
        public DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.Columns.GridColumn colOperationsGUID;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitOfMeasurement;
        private DevExpress.XtraGrid.Columns.GridColumn colVolume;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterialGUID;
        private DevExpress.XtraGrid.Columns.GridColumn colVolumeMaterial;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitOfMeasurementMaterial;
        private DevExpress.XtraGrid.Columns.GridColumn colDateOfTheBeginning;
        private DevExpress.XtraGrid.Columns.GridColumn colEndDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDateOfChange;
        private DevExpress.XtraGrid.Columns.GridColumn colDeletedDate;
    }
}

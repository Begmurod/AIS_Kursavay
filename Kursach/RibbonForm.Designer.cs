namespace Kursach
{
    partial class RibbonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RibbonForm));
            this.splitContainerControl = new DevExpress.XtraEditors.SplitContainerControl();
            this.navBarControl = new DevExpress.XtraNavBar.NavBarControl();
            this.reportsGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem13 = new DevExpress.XtraNavBar.NavBarItem();
            this.accountingGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.workShifts = new DevExpress.XtraNavBar.NavBarItem();
            this.Position = new DevExpress.XtraNavBar.NavBarItem();
            this.users = new DevExpress.XtraNavBar.NavBarItem();
            this.staff = new DevExpress.XtraNavBar.NavBarItem();
            this.profileWorkTeam = new DevExpress.XtraNavBar.NavBarItem();
            this.typeWorkTeam = new DevExpress.XtraNavBar.NavBarItem();
            this.workTeam = new DevExpress.XtraNavBar.NavBarItem();
            this.eventsItem = new DevExpress.XtraNavBar.NavBarItem();
            this.equipmentGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.Products = new DevExpress.XtraNavBar.NavBarItem();
            this.Production = new DevExpress.XtraNavBar.NavBarItem();
            this.material = new DevExpress.XtraNavBar.NavBarItem();
            this.aggregates = new DevExpress.XtraNavBar.NavBarGroup();
            this.type = new DevExpress.XtraNavBar.NavBarItem();
            this.Machine = new DevExpress.XtraNavBar.NavBarItem();
            this.Operations = new DevExpress.XtraNavBar.NavBarItem();
            this.typeOperations = new DevExpress.XtraNavBar.NavBarItem();
            this.repairSchedule = new DevExpress.XtraNavBar.NavBarItem();
            this.monthPlanNavItem = new DevExpress.XtraNavBar.NavBarItem();
            this.yearPlanItem = new DevExpress.XtraNavBar.NavBarItem();
            this.controlFrqItem = new DevExpress.XtraNavBar.NavBarItem();
            this.actsItem = new DevExpress.XtraNavBar.NavBarItem();
            this.findRequestItem = new DevExpress.XtraNavBar.NavBarItem();
            this.mainContainer = new DevExpress.XtraEditors.PanelControl();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.showHelpButton = new DevExpress.XtraBars.BarButtonItem();
            this.infoButton = new DevExpress.XtraBars.BarButtonItem();
            this.identityInfo = new DevExpress.XtraBars.BarStaticItem();
            this.databaseInfo = new DevExpress.XtraBars.BarStaticItem();
            this.mainHelpPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.infoAndOthers = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.ribbonPage6 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.typeOfRepair = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem4 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem5 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem6 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem7 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem8 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem9 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem10 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem11 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem12 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem3 = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).BeginInit();
            this.splitContainerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl
            // 
            this.splitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl.Location = new System.Drawing.Point(0, 158);
            this.splitContainerControl.Name = "splitContainerControl";
            this.splitContainerControl.Padding = new System.Windows.Forms.Padding(6);
            this.splitContainerControl.Panel1.Controls.Add(this.navBarControl);
            this.splitContainerControl.Panel1.Text = "Panel1";
            this.splitContainerControl.Panel2.Controls.Add(this.mainContainer);
            this.splitContainerControl.Panel2.Text = "Panel2";
            this.splitContainerControl.Size = new System.Drawing.Size(1244, 545);
            this.splitContainerControl.SplitterPosition = 229;
            this.splitContainerControl.TabIndex = 0;
            this.splitContainerControl.Text = "splitContainerControl1";
            // 
            // navBarControl
            // 
            this.navBarControl.ActiveGroup = this.reportsGroup;
            this.navBarControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.accountingGroup,
            this.reportsGroup,
            this.equipmentGroup,
            this.aggregates});
            this.navBarControl.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.monthPlanNavItem,
            this.yearPlanItem,
            this.workShifts,
            this.eventsItem,
            this.controlFrqItem,
            this.actsItem,
            this.findRequestItem,
            this.Products,
            this.Production,
            this.type,
            this.Machine,
            this.Operations,
            this.Position,
            this.material,
            this.typeOperations,
            this.users,
            this.staff,
            this.profileWorkTeam,
            this.repairSchedule,
            this.typeWorkTeam,
            this.workTeam,
            this.navBarItem13});
            this.navBarControl.Location = new System.Drawing.Point(0, 0);
            this.navBarControl.Name = "navBarControl";
            this.navBarControl.OptionsNavPane.ExpandedWidth = 229;
            this.navBarControl.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl.Size = new System.Drawing.Size(229, 533);
            this.navBarControl.StoreDefaultPaintStyleName = true;
            this.navBarControl.TabIndex = 1;
            this.navBarControl.Text = "navBarControl1";
            // 
            // reportsGroup
            // 
            this.reportsGroup.Caption = "Отчеты";
            this.reportsGroup.Expanded = true;
            this.reportsGroup.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large;
            this.reportsGroup.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem13)});
            this.reportsGroup.Name = "reportsGroup";
            // 
            // navBarItem13
            // 
            this.navBarItem13.Caption = "Материлы";
            this.navBarItem13.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItem13.ImageOptions.LargeImage")));
            this.navBarItem13.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem13.ImageOptions.SmallImage")));
            this.navBarItem13.Name = "navBarItem13";
            this.navBarItem13.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem13_LinkClicked);
            // 
            // accountingGroup
            // 
            this.accountingGroup.Caption = "Сотрудники";
            this.accountingGroup.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large;
            this.accountingGroup.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.workShifts),
            new DevExpress.XtraNavBar.NavBarItemLink(this.Position),
            new DevExpress.XtraNavBar.NavBarItemLink(this.users),
            new DevExpress.XtraNavBar.NavBarItemLink(this.staff),
            new DevExpress.XtraNavBar.NavBarItemLink(this.profileWorkTeam),
            new DevExpress.XtraNavBar.NavBarItemLink(this.typeWorkTeam),
            new DevExpress.XtraNavBar.NavBarItemLink(this.workTeam)});
            this.accountingGroup.Name = "accountingGroup";
            // 
            // workShifts
            // 
            this.workShifts.Caption = "Рабочие смены";
            this.workShifts.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("workShifts.ImageOptions.LargeImage")));
            this.workShifts.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("workShifts.ImageOptions.SmallImage")));
            this.workShifts.Name = "workShifts";
            this.workShifts.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.workShifts_LinkClicked);
            // 
            // Position
            // 
            this.Position.Caption = "Должности";
            this.Position.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Position.ImageOptions.LargeImage")));
            this.Position.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("Position.ImageOptions.SmallImage")));
            this.Position.Name = "Position";
            this.Position.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.Position_LinkClicked_1);
            // 
            // users
            // 
            this.users.Caption = "Пользователи";
            this.users.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("users.ImageOptions.LargeImage")));
            this.users.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("users.ImageOptions.SmallImage")));
            this.users.Name = "users";
            this.users.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.users_LinkClicked);
            // 
            // staff
            // 
            this.staff.Caption = "Сотрудники";
            this.staff.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("staff.ImageOptions.LargeImage")));
            this.staff.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("staff.ImageOptions.SmallImage")));
            this.staff.Name = "staff";
            this.staff.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.staff_LinkClicked);
            // 
            // profileWorkTeam
            // 
            this.profileWorkTeam.Caption = "Профиль бригады";
            this.profileWorkTeam.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("profileWorkTeam.ImageOptions.LargeImage")));
            this.profileWorkTeam.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("profileWorkTeam.ImageOptions.SmallImage")));
            this.profileWorkTeam.Name = "profileWorkTeam";
            this.profileWorkTeam.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.profileWorkTeam_LinkClicked);
            // 
            // typeWorkTeam
            // 
            this.typeWorkTeam.Caption = "Тип бригады";
            this.typeWorkTeam.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("typeWorkTeam.ImageOptions.LargeImage")));
            this.typeWorkTeam.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("typeWorkTeam.ImageOptions.SmallImage")));
            this.typeWorkTeam.Name = "typeWorkTeam";
            this.typeWorkTeam.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.typeWorkTeam_LinkClicked);
            // 
            // workTeam
            // 
            this.workTeam.Caption = "Бригада";
            this.workTeam.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("workTeam.ImageOptions.LargeImage")));
            this.workTeam.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("workTeam.ImageOptions.SmallImage")));
            this.workTeam.Name = "workTeam";
            this.workTeam.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.workTeam_LinkClicked);
            // 
            // eventsItem
            // 
            this.eventsItem.Caption = "События";
            this.eventsItem.Name = "eventsItem";
            // 
            // equipmentGroup
            // 
            this.equipmentGroup.Caption = "Продукт";
            this.equipmentGroup.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large;
            this.equipmentGroup.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.Products),
            new DevExpress.XtraNavBar.NavBarItemLink(this.Production),
            new DevExpress.XtraNavBar.NavBarItemLink(this.material)});
            this.equipmentGroup.Name = "equipmentGroup";
            // 
            // Products
            // 
            this.Products.Caption = "Продукт";
            this.Products.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Products.ImageOptions.LargeImage")));
            this.Products.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("Products.ImageOptions.SmallImage")));
            this.Products.Name = "Products";
            this.Products.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.Products_LinkClicked);
            // 
            // Production
            // 
            this.Production.Caption = "Производства продукции";
            this.Production.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Production.ImageOptions.LargeImage")));
            this.Production.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("Production.ImageOptions.SmallImage")));
            this.Production.Name = "Production";
            this.Production.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.Production_LinkClicked);
            // 
            // material
            // 
            this.material.Caption = "Материалы";
            this.material.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("material.ImageOptions.LargeImage")));
            this.material.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("material.ImageOptions.SmallImage")));
            this.material.Name = "material";
            this.material.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.material_LinkClicked);
            // 
            // aggregates
            // 
            this.aggregates.Caption = "Агрегаты";
            this.aggregates.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.type),
            new DevExpress.XtraNavBar.NavBarItemLink(this.Machine),
            new DevExpress.XtraNavBar.NavBarItemLink(this.Operations),
            new DevExpress.XtraNavBar.NavBarItemLink(this.typeOperations),
            new DevExpress.XtraNavBar.NavBarItemLink(this.repairSchedule)});
            this.aggregates.Name = "aggregates";
            // 
            // type
            // 
            this.type.Caption = "Тип";
            this.type.Name = "type";
            this.type.Visible = false;
            this.type.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.type_LinkClicked_1);
            // 
            // Machine
            // 
            this.Machine.Caption = "Агрегаты";
            this.Machine.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Machine.ImageOptions.LargeImage")));
            this.Machine.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("Machine.ImageOptions.SmallImage")));
            this.Machine.Name = "Machine";
            this.Machine.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.Machine_LinkClicked_1);
            // 
            // Operations
            // 
            this.Operations.Caption = "Операции";
            this.Operations.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Operations.ImageOptions.LargeImage")));
            this.Operations.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("Operations.ImageOptions.SmallImage")));
            this.Operations.Name = "Operations";
            this.Operations.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.Operations_LinkClicked_1);
            // 
            // typeOperations
            // 
            this.typeOperations.Caption = "Тип операции";
            this.typeOperations.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("typeOperations.ImageOptions.LargeImage")));
            this.typeOperations.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("typeOperations.ImageOptions.SmallImage")));
            this.typeOperations.Name = "typeOperations";
            this.typeOperations.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.typeOperations_LinkClicked);
            // 
            // repairSchedule
            // 
            this.repairSchedule.Caption = "Ремонт агрегата";
            this.repairSchedule.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("repairSchedule.ImageOptions.LargeImage")));
            this.repairSchedule.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("repairSchedule.ImageOptions.SmallImage")));
            this.repairSchedule.Name = "repairSchedule";
            this.repairSchedule.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.repairSchedule_LinkClicked);
            // 
            // monthPlanNavItem
            // 
            this.monthPlanNavItem.Appearance.BackColor = System.Drawing.Color.White;
            this.monthPlanNavItem.Appearance.Options.UseBackColor = true;
            this.monthPlanNavItem.Caption = "План на месяц";
            this.monthPlanNavItem.Name = "monthPlanNavItem";
            // 
            // yearPlanItem
            // 
            this.yearPlanItem.Caption = "Годовой план";
            this.yearPlanItem.Name = "yearPlanItem";
            this.yearPlanItem.Visible = false;
            // 
            // controlFrqItem
            // 
            this.controlFrqItem.Caption = "Контроль частот и РЭС";
            this.controlFrqItem.Name = "controlFrqItem";
            // 
            // actsItem
            // 
            this.actsItem.Caption = "Акты";
            this.actsItem.Name = "actsItem";
            this.actsItem.Visible = false;
            // 
            // findRequestItem
            // 
            this.findRequestItem.Caption = "Поиск помех";
            this.findRequestItem.Name = "findRequestItem";
            // 
            // mainContainer
            // 
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 0);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(993, 533);
            this.mainContainer.TabIndex = 0;
            // 
            // ribbonControl
            // 
            this.ribbonControl.ApplicationButtonText = null;
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.ribbonControl.SearchEditItem,
            this.showHelpButton,
            this.infoButton,
            this.identityInfo,
            this.databaseInfo});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 66;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainHelpPage});
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(1244, 158);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            // 
            // showHelpButton
            // 
            this.showHelpButton.Caption = "Помощь";
            this.showHelpButton.Id = 62;
            this.showHelpButton.Name = "showHelpButton";
            // 
            // infoButton
            // 
            this.infoButton.Caption = "О программе...";
            this.infoButton.Id = 63;
            this.infoButton.Name = "infoButton";
            // 
            // identityInfo
            // 
            this.identityInfo.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.identityInfo.Caption = "Пользователь";
            this.identityInfo.Id = 64;
            this.identityInfo.Name = "identityInfo";
            // 
            // databaseInfo
            // 
            this.databaseInfo.Caption = "БазаДанных";
            this.databaseInfo.Id = 65;
            this.databaseInfo.Name = "databaseInfo";
            // 
            // mainHelpPage
            // 
            this.mainHelpPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.infoAndOthers});
            this.mainHelpPage.MergeOrder = 999;
            this.mainHelpPage.Name = "mainHelpPage";
            this.mainHelpPage.Text = "Информация";
            // 
            // infoAndOthers
            // 
            this.infoAndOthers.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.infoAndOthers.ItemLinks.Add(this.infoButton);
            this.infoAndOthers.MergeOrder = 999;
            this.infoAndOthers.Name = "infoAndOthers";
            this.infoAndOthers.Text = "Информация и помощь";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.identityInfo);
            this.ribbonStatusBar.ItemLinks.Add(this.databaseInfo);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 703);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1244, 24);
            // 
            // navBarItem1
            // 
            this.navBarItem1.Caption = "Единицы";
            this.navBarItem1.Name = "navBarItem1";
            // 
            // navBarItem2
            // 
            this.navBarItem2.Caption = "Единицы";
            this.navBarItem2.Name = "navBarItem2";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "ribbonPage3";
            // 
            // ribbonPage5
            // 
            this.ribbonPage5.Name = "ribbonPage5";
            this.ribbonPage5.Text = "ribbonPage5";
            // 
            // ribbonPage6
            // 
            this.ribbonPage6.Name = "ribbonPage6";
            this.ribbonPage6.Text = "ribbonPage6";
            // 
            // typeOfRepair
            // 
            this.typeOfRepair.Caption = "Тип  ремонта";
            this.typeOfRepair.Name = "typeOfRepair";
            // 
            // navBarItem4
            // 
            this.navBarItem4.Caption = "Тип ";
            this.navBarItem4.Name = "navBarItem4";
            // 
            // navBarItem5
            // 
            this.navBarItem5.Caption = "Тип ";
            this.navBarItem5.Name = "navBarItem5";
            // 
            // navBarItem6
            // 
            this.navBarItem6.Caption = "Тип ";
            this.navBarItem6.Name = "navBarItem6";
            // 
            // navBarItem7
            // 
            this.navBarItem7.Caption = "Тип ";
            this.navBarItem7.Name = "navBarItem7";
            // 
            // navBarItem8
            // 
            this.navBarItem8.Caption = "Тип ";
            this.navBarItem8.Name = "navBarItem8";
            // 
            // navBarItem9
            // 
            this.navBarItem9.Caption = "Тип ";
            this.navBarItem9.Name = "navBarItem9";
            // 
            // navBarItem10
            // 
            this.navBarItem10.Caption = "Тип ";
            this.navBarItem10.Name = "navBarItem10";
            // 
            // navBarItem11
            // 
            this.navBarItem11.Caption = "Тип ";
            this.navBarItem11.Name = "navBarItem11";
            // 
            // navBarItem12
            // 
            this.navBarItem12.Caption = "Тип ";
            this.navBarItem12.Name = "navBarItem12";
            // 
            // navBarItem3
            // 
            this.navBarItem3.Caption = "Рабочие смены";
            this.navBarItem3.Name = "navBarItem3";
            // 
            // RibbonForm
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 727);
            this.Controls.Add(this.splitContainerControl);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
            this.IsMdiContainer = true;
            this.Name = "RibbonForm";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Kursach";
            this.Load += new System.EventHandler(this.RibbonForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).EndInit();
            this.splitContainerControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraNavBar.NavBarControl navBarControl;
        private DevExpress.XtraNavBar.NavBarItem monthPlanNavItem;
        private DevExpress.XtraEditors.PanelControl mainContainer;
        private DevExpress.XtraBars.Ribbon.RibbonPage mainHelpPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup infoAndOthers;
        private DevExpress.XtraBars.BarButtonItem showHelpButton;
        private DevExpress.XtraBars.BarButtonItem infoButton;
        private DevExpress.XtraBars.BarStaticItem identityInfo;
        private DevExpress.XtraBars.BarStaticItem databaseInfo;
        private DevExpress.XtraNavBar.NavBarItem yearPlanItem;
        private DevExpress.XtraNavBar.NavBarGroup accountingGroup;
        private DevExpress.XtraNavBar.NavBarItem workShifts;
        private DevExpress.XtraNavBar.NavBarItem eventsItem;
        private DevExpress.XtraNavBar.NavBarItem controlFrqItem;
        private DevExpress.XtraNavBar.NavBarItem actsItem;
        private DevExpress.XtraNavBar.NavBarGroup reportsGroup;
        private DevExpress.XtraNavBar.NavBarGroup equipmentGroup;
        private DevExpress.XtraNavBar.NavBarItem findRequestItem;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage6;
        private DevExpress.XtraNavBar.NavBarItem Products;
        private DevExpress.XtraNavBar.NavBarItem Production;
        private DevExpress.XtraNavBar.NavBarGroup aggregates;
        private DevExpress.XtraNavBar.NavBarItem type;
        private DevExpress.XtraNavBar.NavBarItem Machine;
        private DevExpress.XtraNavBar.NavBarItem typeOfRepair;
        private DevExpress.XtraNavBar.NavBarItem navBarItem4;
        private DevExpress.XtraNavBar.NavBarItem navBarItem5;
        private DevExpress.XtraNavBar.NavBarItem navBarItem6;
        private DevExpress.XtraNavBar.NavBarItem navBarItem7;
        private DevExpress.XtraNavBar.NavBarItem navBarItem8;
        private DevExpress.XtraNavBar.NavBarItem navBarItem9;
        private DevExpress.XtraNavBar.NavBarItem navBarItem10;
        private DevExpress.XtraNavBar.NavBarItem navBarItem11;
        private DevExpress.XtraNavBar.NavBarItem navBarItem12;
        private DevExpress.XtraNavBar.NavBarItem Operations;
        private DevExpress.XtraNavBar.NavBarItem Position;
        private DevExpress.XtraNavBar.NavBarItem material;
        private DevExpress.XtraNavBar.NavBarItem typeOperations;
        private DevExpress.XtraNavBar.NavBarItem users;
        private DevExpress.XtraNavBar.NavBarItem staff;
        private DevExpress.XtraNavBar.NavBarItem profileWorkTeam;
        private DevExpress.XtraNavBar.NavBarItem repairSchedule;
        private DevExpress.XtraNavBar.NavBarItem typeWorkTeam;
        private DevExpress.XtraNavBar.NavBarItem workTeam;
        private DevExpress.XtraNavBar.NavBarItem navBarItem13;
        private DevExpress.XtraNavBar.NavBarItem navBarItem3;
    }
}
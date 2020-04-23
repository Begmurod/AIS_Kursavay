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
            this.splitContainerControl = new DevExpress.XtraEditors.SplitContainerControl();
            this.navBarControl = new DevExpress.XtraNavBar.NavBarControl();
            this.equipmentGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.Position = new DevExpress.XtraNavBar.NavBarItem();
            this.serviceItem = new DevExpress.XtraNavBar.NavBarItem();
            this.Machine = new DevExpress.XtraNavBar.NavBarItem();
            this.planGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.monthPlanNavItem = new DevExpress.XtraNavBar.NavBarItem();
            this.yearPlanItem = new DevExpress.XtraNavBar.NavBarItem();
            this.accountingGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.resItem = new DevExpress.XtraNavBar.NavBarItem();
            this.customerItem = new DevExpress.XtraNavBar.NavBarItem();
            this.eventsGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.eventsItem = new DevExpress.XtraNavBar.NavBarItem();
            this.reportsGroup = new DevExpress.XtraNavBar.NavBarGroup();
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
            this.splitContainerControl.Location = new System.Drawing.Point(0, 130);
            this.splitContainerControl.Name = "splitContainerControl";
            this.splitContainerControl.Padding = new System.Windows.Forms.Padding(6);
            this.splitContainerControl.Panel1.Controls.Add(this.navBarControl);
            this.splitContainerControl.Panel1.Text = "Panel1";
            this.splitContainerControl.Panel2.Controls.Add(this.mainContainer);
            this.splitContainerControl.Panel2.Text = "Panel2";
            this.splitContainerControl.Size = new System.Drawing.Size(1244, 577);
            this.splitContainerControl.SplitterPosition = 235;
            this.splitContainerControl.TabIndex = 0;
            this.splitContainerControl.Text = "splitContainerControl1";
            // 
            // navBarControl
            // 
            this.navBarControl.ActiveGroup = this.equipmentGroup;
            this.navBarControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.planGroup,
            this.accountingGroup,
            this.eventsGroup,
            this.reportsGroup,
            this.equipmentGroup});
            this.navBarControl.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.monthPlanNavItem,
            this.yearPlanItem,
            this.resItem,
            this.customerItem,
            this.eventsItem,
            this.controlFrqItem,
            this.actsItem,
            this.Position,
            this.serviceItem,
            this.findRequestItem,
            this.Machine});
            this.navBarControl.Location = new System.Drawing.Point(0, 0);
            this.navBarControl.Name = "navBarControl";
            this.navBarControl.OptionsNavPane.ExpandedWidth = 235;
            this.navBarControl.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl.Size = new System.Drawing.Size(235, 565);
            this.navBarControl.StoreDefaultPaintStyleName = true;
            this.navBarControl.TabIndex = 1;
            this.navBarControl.Text = "navBarControl1";
            // 
            // equipmentGroup
            // 
            this.equipmentGroup.Caption = "Сотрудники";
            this.equipmentGroup.Expanded = true;
            this.equipmentGroup.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large;
            this.equipmentGroup.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.Position),
            new DevExpress.XtraNavBar.NavBarItemLink(this.serviceItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.Machine)});
            this.equipmentGroup.Name = "equipmentGroup";
            // 
            // Position
            // 
            this.Position.Caption = "Должность";
            this.Position.Name = "Position";
            this.Position.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.Position_LinkClicked);
            // 
            // serviceItem
            // 
            this.serviceItem.Caption = "Обслуживание";
            this.serviceItem.Name = "serviceItem";
            this.serviceItem.Visible = false;
            // 
            // Machine
            // 
            this.Machine.Caption = "Агрегаты";
            this.Machine.Name = "Machine";
            this.Machine.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.Machine_LinkClicked);
            // 
            // planGroup
            // 
            this.planGroup.Caption = "Экраны";
            this.planGroup.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large;
            this.planGroup.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText;
            this.planGroup.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.monthPlanNavItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.yearPlanItem)});
            this.planGroup.Name = "planGroup";
            this.planGroup.Visible = false;
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
            // accountingGroup
            // 
            this.accountingGroup.Caption = "Учетные данные";
            this.accountingGroup.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large;
            this.accountingGroup.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.resItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.customerItem)});
            this.accountingGroup.Name = "accountingGroup";
            this.accountingGroup.Visible = false;
            // 
            // resItem
            // 
            this.resItem.Caption = "РЭС";
            this.resItem.Name = "resItem";
            // 
            // customerItem
            // 
            this.customerItem.Caption = "Клиенты";
            this.customerItem.Name = "customerItem";
            // 
            // eventsGroup
            // 
            this.eventsGroup.Caption = "Журналы";
            this.eventsGroup.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large;
            this.eventsGroup.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.eventsItem)});
            this.eventsGroup.Name = "eventsGroup";
            // 
            // eventsItem
            // 
            this.eventsItem.Caption = "События";
            this.eventsItem.Name = "eventsItem";
            // 
            // reportsGroup
            // 
            this.reportsGroup.Caption = "Отчеты";
            this.reportsGroup.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large;
            this.reportsGroup.Name = "reportsGroup";
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
            this.mainContainer.Size = new System.Drawing.Size(987, 565);
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
            this.ribbonControl.Size = new System.Drawing.Size(1244, 130);
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
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 707);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1244, 20);
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
        private DevExpress.XtraNavBar.NavBarGroup planGroup;
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
        private DevExpress.XtraNavBar.NavBarItem resItem;
        private DevExpress.XtraNavBar.NavBarItem customerItem;
        private DevExpress.XtraNavBar.NavBarGroup eventsGroup;
        private DevExpress.XtraNavBar.NavBarItem eventsItem;
        private DevExpress.XtraNavBar.NavBarItem controlFrqItem;
        private DevExpress.XtraNavBar.NavBarItem actsItem;
        private DevExpress.XtraNavBar.NavBarGroup reportsGroup;
        private DevExpress.XtraNavBar.NavBarGroup equipmentGroup;
        private DevExpress.XtraNavBar.NavBarItem Position;
        private DevExpress.XtraNavBar.NavBarItem serviceItem;
        private DevExpress.XtraNavBar.NavBarItem findRequestItem;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem2;
        private DevExpress.XtraNavBar.NavBarItem Machine;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage6;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraSplashScreen;
using Kursach.UI;
using Kursach.UI.WinForm;

namespace Kursach
{
    public partial class RibbonForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        //private Lazy<positionUС> UserControl1;
        private Lazy<machineUserC> machineUserC;
        private Lazy<positionUI> positionUI;
        private Lazy<operationsUC> operationsUC;
        private Lazy<productsUC> productsUC;
        private Lazy<productionUC> productionUC;
        
        private Lazy<typeOfRepairUC> typeOfRepairUC;
        private Lazy<workShiftsUC> workShiftsUC;
        private Lazy<materialUC> materialUC;
        private Lazy<typeOperationsUC> typeOperationsUC;
        private Lazy<usersUC> usersUC;
        private Lazy<staffUC> staffUC;
        private Lazy<profileWorkTeamUC> profileWorkTeamUC;
        private Lazy<repairScheduleUC> repairScheduleUC;
        private Lazy<typeWorkTeamUC> typeWorkTeamUC;
        private Lazy<workTeamUC> workTeamUC;

        public RibbonForm()
        {
            InitializeComponent();
        }
        private void hideAllContainerControls(Control container)
        {
            foreach (Control child in container.Controls)
                child.Hide();
        }

        void initpositionUI()
        {
            hideAllContainerControls(mainContainer);
            ribbonControl.UnMergeRibbon();
            SplashScreenManager.ShowForm(typeof(UI.Common.LoadingIndicator));
            if (positionUI == null)
            {
                positionUI = new Lazy<positionUI>(() => new positionUI(mainContainer));
                positionUI.Value.Dock = DockStyle.Fill;
            }
            Text = "Kursach - Позиции";
            positionUI.Value.Show();
            ribbonControl.MergeRibbon(positionUI.Value.positionRibbonControl);
            ribbonControl.SelectedPage = positionUI.Value.positionRibbonControl.SelectedPage;
            SplashScreenManager.CloseForm();
        }
        void initMachineUC()
        {
            hideAllContainerControls(mainContainer);
            ribbonControl.UnMergeRibbon();
            SplashScreenManager.ShowForm(typeof(UI.Common.LoadingIndicator));
            if (machineUserC == null)
            {
                machineUserC = new Lazy<machineUserC>(() => new machineUserC(mainContainer));
                machineUserC.Value.Dock = DockStyle.Fill;
            }
            Text = "Kursach - Агрегаты";
            machineUserC.Value.Show();
            ribbonControl.MergeRibbon(machineUserC.Value.positionRibbonControl);
            ribbonControl.SelectedPage = machineUserC.Value.positionRibbonControl.SelectedPage;
            SplashScreenManager.CloseForm();
        }
        void initOperationsUC()
        {
            hideAllContainerControls(mainContainer);
            ribbonControl.UnMergeRibbon();
            SplashScreenManager.ShowForm(typeof(UI.Common.LoadingIndicator));
            if (operationsUC == null)
            {
                operationsUC = new Lazy<operationsUC>(() => new operationsUC(mainContainer));
                operationsUC.Value.Dock = DockStyle.Fill;
            }
            Text = "Kursach - Операции";
            operationsUC.Value.Show();
            ribbonControl.MergeRibbon(operationsUC.Value.positionRibbonControl);
            ribbonControl.SelectedPage = operationsUC.Value.positionRibbonControl.SelectedPage;
            SplashScreenManager.CloseForm();
        }
        void initProductsUC()
        {
            hideAllContainerControls(mainContainer);
            ribbonControl.UnMergeRibbon();
            SplashScreenManager.ShowForm(typeof(UI.Common.LoadingIndicator));
            if (productsUC == null)
            {
                productsUC = new Lazy<productsUC>(() => new productsUC(mainContainer));
                productsUC.Value.Dock = DockStyle.Fill;
            }
            Text = "Kursach - Продукты";
            productsUC.Value.Show();
            ribbonControl.MergeRibbon(productsUC.Value.dimensionRibbonControl);
            ribbonControl.SelectedPage = productsUC.Value.dimensionRibbonControl.SelectedPage;
            SplashScreenManager.CloseForm();
        }
        void initProductionUC()
        {
            hideAllContainerControls(mainContainer);
            ribbonControl.UnMergeRibbon();
            SplashScreenManager.ShowForm(typeof(UI.Common.LoadingIndicator));
            if (productionUC == null)
            {
                productionUC = new Lazy<productionUC>(() => new productionUC(mainContainer));
                productionUC.Value.Dock = DockStyle.Fill;
            }
            Text = "Kursach - Производства";
            productionUC.Value.Show();
            ribbonControl.MergeRibbon(productionUC.Value.positionRibbonControl);
            ribbonControl.SelectedPage = productionUC.Value.positionRibbonControl.SelectedPage;
            SplashScreenManager.CloseForm();
        }
        void initTypeUC()
        {
            //hideAllContainerControls(mainContainer);
            //ribbonControl.UnMergeRibbon();
            //SplashScreenManager.ShowForm(typeof(UI.Common.LoadingIndicator));
            //if (TypeUC == null)
            //{
            //    TypeUC = new Lazy<TypeUC>(() => new TypeUC(mainContainer));
            //    TypeUC.Value.Dock = DockStyle.Fill;
            //}
            //Text = "Kursach - Типы агрегатов";
            //TypeUC.Value.Show();
            //ribbonControl.MergeRibbon(TypeUC.Value.dimensionRibbonControl);
            //ribbonControl.SelectedPage = TypeUC.Value.dimensionRibbonControl.SelectedPage;
            //SplashScreenManager.CloseForm();
            
        }
        void initTypeOfRepairUC()
        {
            hideAllContainerControls(mainContainer);
            ribbonControl.UnMergeRibbon();
            SplashScreenManager.ShowForm(typeof(UI.Common.LoadingIndicator));
            if (typeOfRepairUC == null)
            {
                typeOfRepairUC = new Lazy<typeOfRepairUC>(() => new typeOfRepairUC(mainContainer));
                typeOfRepairUC.Value.Dock = DockStyle.Fill;
            }
            Text = "Kursach - Типы ремонта агрегата";
            typeOfRepairUC.Value.Show();
            ribbonControl.MergeRibbon(typeOfRepairUC.Value.dimensionRibbonControl);
            ribbonControl.SelectedPage = typeOfRepairUC.Value.dimensionRibbonControl.SelectedPage;
            SplashScreenManager.CloseForm();
        }
        void initWorkShiftsUC()
        {
            hideAllContainerControls(mainContainer);
            ribbonControl.UnMergeRibbon();
            SplashScreenManager.ShowForm(typeof(UI.Common.LoadingIndicator));
            if (workShiftsUC == null)
            {
                workShiftsUC = new Lazy<workShiftsUC>(() => new workShiftsUC(mainContainer));
                workShiftsUC.Value.Dock = DockStyle.Fill;
            }
            Text = "Kursach - Рабочие смены";
            workShiftsUC.Value.Show();
            ribbonControl.MergeRibbon(workShiftsUC.Value.dimensionRibbonControl);
            ribbonControl.SelectedPage = workShiftsUC.Value.dimensionRibbonControl.SelectedPage;
            SplashScreenManager.CloseForm();
        }
        void initMaterialUC()
        {
            hideAllContainerControls(mainContainer);
            ribbonControl.UnMergeRibbon();
            SplashScreenManager.ShowForm(typeof(UI.Common.LoadingIndicator));
            if (materialUC == null)
            {
                materialUC = new Lazy<materialUC>(() => new materialUC(mainContainer));
                materialUC.Value.Dock = DockStyle.Fill;
            }
            Text = "Kursach - Материалы";
            materialUC.Value.Show();
            ribbonControl.MergeRibbon(materialUC.Value.positionRibbonControl);
            ribbonControl.SelectedPage = materialUC.Value.positionRibbonControl.SelectedPage;
            SplashScreenManager.CloseForm();
        }
        void initTypeOperationsUC()
        {
            hideAllContainerControls(mainContainer);
            ribbonControl.UnMergeRibbon();
            SplashScreenManager.ShowForm(typeof(UI.Common.LoadingIndicator));
            if (typeOperationsUC == null)
            {
                typeOperationsUC = new Lazy<typeOperationsUC>(() => new typeOperationsUC(mainContainer));
                typeOperationsUC.Value.Dock = DockStyle.Fill;
            }
            Text = "Kursach - Типы операции";
            typeOperationsUC.Value.Show();
            ribbonControl.MergeRibbon(typeOperationsUC.Value.typeOperationsRibbonControl);
            ribbonControl.SelectedPage = typeOperationsUC.Value.typeOperationsRibbonControl.SelectedPage;
            SplashScreenManager.CloseForm();
        }
        void initUsersUC()
        {
            hideAllContainerControls(mainContainer);
            ribbonControl.UnMergeRibbon();
            SplashScreenManager.ShowForm(typeof(UI.Common.LoadingIndicator));
            if (usersUC == null)
            {
                usersUC = new Lazy<usersUC>(() => new usersUC(mainContainer));
                usersUC.Value.Dock = DockStyle.Fill;
            }
            Text = "Kursach - Типы агрегатов";
            usersUC.Value.Show();
            ribbonControl.MergeRibbon(usersUC.Value.usersRibbonControl);
            ribbonControl.SelectedPage = usersUC.Value.usersRibbonControl.SelectedPage;
            SplashScreenManager.CloseForm();
        }
        void initSteffUC()
        {
            hideAllContainerControls(mainContainer);
            ribbonControl.UnMergeRibbon();
            SplashScreenManager.ShowForm(typeof(UI.Common.LoadingIndicator));
            if (staffUC == null)
            {
                staffUC = new Lazy<staffUC>(() => new staffUC(mainContainer));
                staffUC.Value.Dock = DockStyle.Fill;
            }
            Text = "Kursach - Типы агрегатов";
            staffUC.Value.Show();
            ribbonControl.MergeRibbon(staffUC.Value.usersRibbonControl);
            ribbonControl.SelectedPage = staffUC.Value.usersRibbonControl.SelectedPage;
            SplashScreenManager.CloseForm();
        }
        void initProfileWorkTeamUC()
        {
            hideAllContainerControls(mainContainer);
            ribbonControl.UnMergeRibbon();
            SplashScreenManager.ShowForm(typeof(UI.Common.LoadingIndicator));
            if (profileWorkTeamUC == null)
            {
                profileWorkTeamUC = new Lazy<profileWorkTeamUC>(() => new profileWorkTeamUC(mainContainer));
                profileWorkTeamUC.Value.Dock = DockStyle.Fill;
            }
            Text = "Kursach - Профиль бригады";
            profileWorkTeamUC.Value.Show();
            ribbonControl.MergeRibbon(profileWorkTeamUC.Value.profileWorkTeamRibbonControl);
            ribbonControl.SelectedPage = profileWorkTeamUC.Value.profileWorkTeamRibbonControl.SelectedPage;
            SplashScreenManager.CloseForm();
        }
        void initRepairScheduleUC()
        {
            hideAllContainerControls(mainContainer);
            ribbonControl.UnMergeRibbon();
            SplashScreenManager.ShowForm(typeof(UI.Common.LoadingIndicator));
            if (repairScheduleUC == null)
            {
                repairScheduleUC = new Lazy<repairScheduleUC>(() => new repairScheduleUC(mainContainer));
                repairScheduleUC.Value.Dock = DockStyle.Fill;
            }
            Text = "Kursach - Ремон агрегата";
            repairScheduleUC.Value.Show();
            ribbonControl.MergeRibbon(repairScheduleUC.Value.repairScheduleRibbonControl);
            ribbonControl.SelectedPage = repairScheduleUC.Value.repairScheduleRibbonControl.SelectedPage;
            SplashScreenManager.CloseForm();
        }
        void initTypeWorkTeamUC()
        {
            hideAllContainerControls(mainContainer);
            ribbonControl.UnMergeRibbon();
            SplashScreenManager.ShowForm(typeof(UI.Common.LoadingIndicator));
            if (typeWorkTeamUC == null)
            {
                typeWorkTeamUC = new Lazy<typeWorkTeamUC>(() => new typeWorkTeamUC(mainContainer));
                typeWorkTeamUC.Value.Dock = DockStyle.Fill;
            }
            Text = "Kursach - Тип бригады";
            typeWorkTeamUC.Value.Show();
            ribbonControl.MergeRibbon(typeWorkTeamUC.Value.typeWorkTeamRibbonControl);
            ribbonControl.SelectedPage = typeWorkTeamUC.Value.typeWorkTeamRibbonControl.SelectedPage;
            SplashScreenManager.CloseForm();
        }
        void initWorkTeamUC()
        {
            hideAllContainerControls(mainContainer);
            ribbonControl.UnMergeRibbon();
            SplashScreenManager.ShowForm(typeof(UI.Common.LoadingIndicator));
            if (workTeamUC == null)
            {
                workTeamUC = new Lazy<workTeamUC>(() => new workTeamUC(mainContainer));
                workTeamUC.Value.Dock = DockStyle.Fill;
            }
            Text = "Kursach - Тип бригады";
            workTeamUC.Value.Show();
            ribbonControl.MergeRibbon(workTeamUC.Value.workTeamRibbonControl);
            ribbonControl.SelectedPage = workTeamUC.Value.workTeamRibbonControl.SelectedPage;
            SplashScreenManager.CloseForm();
        }
        //void initReportUC()
        //{
        //    hideAllContainerControls(mainContainer);
        //    ribbonControl.UnMergeRibbon();
        //    SplashScreenManager.ShowForm(typeof(UI.Common.LoadingIndicator));
        //    if (reportUC == null)
        //    {
        //        reportUC = new Lazy<reportUC>(() => new reportUC(ribbonControl1));
        //        reportUC.Value.Dock = DockStyle.Fill;
        //    }
        //    Text = "Kursach - Тип бригады";
        //    reportUC.Value.Show();
        //    ribbonControl.MergeRibbon(reportUC.Value.ribbonControl1);
        //    ribbonControl.SelectedPage = reportUC.Value.ribbonControl1.SelectedPage;
        //    SplashScreenManager.CloseForm();
        //}
        private void RibbonForm_Load(object sender, EventArgs e)
        {
            //identityInfo.Caption = Security.Session.CurrentWindowsPrincipal.Identity.Name;
            //databaseInfo.Caption = string.Format("{0}\\{1}", DB.Session.currentDatabaseServer, Database.Session.currentDatabase);

            //initOperationsUC();
            initWorkShiftsUC();
        }
        
        private void Products_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            initProductsUC();
        }

        private void Production_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            initProductionUC();
        }

        private void type_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            initTypeUC();
        }

        private void typeOfRepair_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            initTypeOfRepairUC();
        }

        private void type_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            initTypeUC();
        }

        private void Machine_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            initMachineUC();
        }

        private void Operations_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            initOperationsUC();
        }

        private void workShifts_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            initWorkShiftsUC();
        }

        private void Position_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            initpositionUI();
        }

        private void material_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            initMaterialUC();
        }

        private void typeOperations_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            initTypeOperationsUC();
        }

        private void users_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            initUsersUC();
        }

        private void staff_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            initSteffUC();
        }

        private void profileWorkTeam_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            initProfileWorkTeamUC();
        }

        private void repairSchedule_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            initRepairScheduleUC();
        }

        private void typeWorkTeam_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            initTypeWorkTeamUC();
        }

        private void workTeam_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            initWorkTeamUC();
        }

        private void navBarItem13_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            this.Hide();
            Form1 Af = new Form1();
            Af.ShowDialog();
        }
    }
}
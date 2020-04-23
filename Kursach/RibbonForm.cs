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
        private Lazy<machineUC1> machineUC1;
        private Lazy<positionUI> positionUI;

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
            Text = "Kursach - Должности";
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
            if (machineUC1 == null)
            {
                machineUC1 = new Lazy<machineUC1>(() => new machineUC1(mainContainer));
                machineUC1.Value.Dock = DockStyle.Fill;
            }
            Text = "Kursach - Должности";
            machineUC1.Value.Show();
            ribbonControl.MergeRibbon(machineUC1.Value.positionRibbonControl);
            ribbonControl.SelectedPage = machineUC1.Value.positionRibbonControl.SelectedPage;
            SplashScreenManager.CloseForm();
        }
        private void RibbonForm_Load(object sender, EventArgs e)
        {
            //identityInfo.Caption = Security.Session.CurrentWindowsPrincipal.Identity.Name;
            //databaseInfo.Caption = string.Format("{0}\\{1}", DB.Session.currentDatabaseServer, Database.Session.currentDatabase);

            //initpositionUI();
        }

        private void Position_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            initpositionUI();
        }

        private void Machine_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            initMachineUC();
        }
    }
}
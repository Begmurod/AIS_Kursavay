using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach
{
    public partial class mainForm : Form
    {
        private Lazy<UI.positionUI> UserControl1;
        public mainForm()
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
            if (UserControl1 == null)
            {
                UserControl1 = new Lazy<UI.positionUI>(() => new UI.positionUI(mainContainer));
                UserControl1.Value.Dock = DockStyle.Fill;
            }
            Text = "Kursach - Должности";
            UserControl1.Value.Show();
            ribbonControl.MergeRibbon(UserControl1.Value.positionRibbonControl);
            ribbonControl.SelectedPage = UserControl1.Value.positionRibbonControl.SelectedPage;
            SplashScreenManager.CloseForm();
        }
        private void serviceItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            initpositionUI();
        }

        private void Operations_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            initpositionUI();
        }
    }
}

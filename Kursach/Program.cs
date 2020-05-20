using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using Kursach.UI.WinForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           
            try
            {
                XpoDefault.Session = null;
                XpoDefault.DataLayer = new SimpleDataLayer(new DataCacheNode(new DataCacheRoot(XpoDefault.GetConnectionProvider(@"XpoProvider=MSSqlServer;data source=.\;
                    integrated security=false;initial catalog=Kursach;User Id=begmurod;Password=1", AutoCreateOption.None))));
                //XpoDefault.DataLayer = new SimpleDataLayer(new DataCacheNode(new DataCacheRoot(XpoDefault.GetConnectionProvider(Properties.Settings.Default.ConnectionString, AutoCreateOption.None))));
            }
            catch (Exception e)
            {
                throw (e);
            }
             Application.Run(new RibbonForm());

        }
    }
}

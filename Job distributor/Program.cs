using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskDistributor
{
    static class Program
    {

        private static MainForm mainForm;


    /// ENTRY POINT

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainForm = new MainForm();
            Application.Run(mainForm);
            


        }

        public static MainForm getMainForm()
        {
            return mainForm;
        }
    }
}

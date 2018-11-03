using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facebook;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;


namespace A19_Nadav_308426048_David_311338016
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        static readonly string s_AppID = "249075922425991";

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());

        }
    }
}

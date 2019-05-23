using System;
using System.Windows.Forms;
using Moshi_Bank.Views;
using Moshi_Bank.Client;

namespace Moshi_Bank
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                database.OpenConnection();
            }
            catch
            {
                API.Message("Unable to connect to Database Server ..\nTry Again Later ", MessageBoxIcon.Error);
                return;
            }
            Application.Run(new About());
        }
    }
}

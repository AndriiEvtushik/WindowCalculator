using System;
using WindowCalculator.Forms;
using System.Windows.Forms;

namespace WindowCalculator
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginForm login = new LoginForm();

            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainForm(login.Role));
            }
        }

        public static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=WindowCalculatorDB; Integrated Security=true; TrustServerCertificate=True";
    }
}
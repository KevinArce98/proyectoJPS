using System;
using System.Windows.Forms;
using DBAccess;
using JPS.Vistas;

namespace JPS
{
    static class Program
    {
        public static DBAccess.DBAccess da;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Pg"].ConnectionString;
            Program.da = new PgAccess(connectionString);
            Application.Run(new frmLogin());
            Application.Run(new frmPrincipal());
        }
    }
}

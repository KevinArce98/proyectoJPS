using System;
using JPS.Vistas;
using System.Windows.Forms;

namespace JPS
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
            Application.Run(new frmPrincipal());
        }
    }
}

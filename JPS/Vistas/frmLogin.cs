using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JPS.Vistas
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            frmPrincipal oPrincipal = new frmPrincipal();
            oPrincipal.Show();
            this.Close();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            frmRegistro oRegistrar = new frmRegistro();
            oRegistrar.ShowDialog();
        }
    }
}

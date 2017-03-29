using System;
using System.Windows.Forms;
using JPS.Controladores;
using JPS.Utils;
using System.Data;

namespace JPS.Vistas
{
    public partial class frmLogin : Form
    {
        private Usuario oUsuario;
        public frmLogin()
        {
            InitializeComponent();
            this.CenterToScreen();
            oUsuario = new Usuario();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtCorreo.Text.Equals("") || txtPass.Text.Equals(""))
            {
                MessageBox.Show("Faltan datos requeridos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                string correo = txtCorreo.Text;
                string pass = txtPass.Text;
                pass = Encriptacion.EncriptarMd5(pass);
                RuntimeData.oUsuario = oUsuario.SelectLogin(correo, pass);
                if (RuntimeData.oUsuario.id != -1)
                {
                    frmPrincipal oPrincipal = new frmPrincipal();
                    oPrincipal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Datos incorrectos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }        
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            VistasEdicion.EditaUsuario oEdita = new VistasEdicion.EditaUsuario();
            oEdita.ShowDialog();
        }

    }
}

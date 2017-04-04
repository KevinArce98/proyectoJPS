using System;
using JPS.Controladores;
using System.Windows.Forms;

namespace JPS.Vistas.VistasEdicion
{
    public partial class EditaUsuario : Form
    {
        public Usuario oUsuario { get; set; }
        public EditaUsuario()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.oUsuario = new Usuario();
            this.txtId.Enabled = false;
        }
        public EditaUsuario(int id, string nombre, string apellido, string correo, bool admin)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.oUsuario = new Usuario();
            this.txtId.Enabled = false;
            this.txtId.Text = Convert.ToString(id);
            this.txtNombre.Text = nombre;
            this.txtApellido.Text = apellido;
            this.txtCorreo.Text = correo;
         
        }
        private string verificaClave()
        {
            string clave1 = txtClave.Text;
            string clave2 = txtConfirmacionClave.Text;

            if (clave1.Equals(clave2))
            {
                clave1 = Utils.Encriptacion.EncriptarMd5(clave2);
            }
            else
            {
                clave1 = "";
            }
            return clave1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Trim().Equals(""))
            {
                if (txtNombre.Text.Equals("") || txtApellido.Text.Equals("") ||
                    txtCorreo.Text.Equals("") || txtClave.Text.Equals("") ||
                    txtConfirmacionClave.Text.Equals(""))
                {
                    MessageBox.Show("Faltan datos requeridos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string contra = this.verificaClave();
                    if (!contra.Equals(""))
                    {

                        this.oUsuario.Insert(txtNombre.Text, txtApellido.Text, false, txtCorreo.Text, contra);
                        if (this.oUsuario.isError)
                        {
                            MessageBox.Show(this.oUsuario.errorDescription);
                            return;
                        }
                        MessageBox.Show("Usuario Agregado", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Contraseñas distintas", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                if (txtNombre.Text.Equals("") || txtApellido.Text.Equals("") ||
                     txtCorreo.Text.Equals("") || txtClave.Text.Equals("") ||
                     txtConfirmacionClave.Text.Equals(""))
                {
                    MessageBox.Show("Faltan datos requeridos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int id = Convert.ToInt32(txtId.Text);
                    string nombre = txtNombre.Text;
                    string apellido = txtApellido.Text;
                    string correo = txtCorreo.Text;
                    string contra = this.verificaClave();

                    if (!contra.Equals(""))
                    {
                        this.oUsuario.Update(id, nombre, apellido, false, correo, contra);
                        if (this.oUsuario.isError)
                        {
                            MessageBox.Show(this.oUsuario.errorDescription);
                            return;
                        }
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Contraseñas distintas", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void EditaUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}

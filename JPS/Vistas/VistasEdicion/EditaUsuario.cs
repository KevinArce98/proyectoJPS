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
            this.oUsuario = new Usuario();
            this.txtId.Enabled = false;
            this.cargarCombo();
        }
        public EditaUsuario(int id, string nombre, string apellido, string correo, string admin)
        {
            InitializeComponent();
            this.oUsuario = new Usuario();
            this.txtId.Enabled = false;
            this.cargarCombo();
            this.txtId.Text = Convert.ToString(id);
            this.txtNombre.Text = nombre;
            this.txtApellido.Text = apellido;
            this.txtCorreo.Text = correo;
            this.cmbAdmin.SelectedItem = char.Parse(admin);
        }
        private void cargarCombo()
        {
            this.cmbAdmin.Items.Add('S');
            this.cmbAdmin.Items.Add('N');
        }
        private string verificaClave()
        {
            string clave1 = txtClave.Text;
            string clave2 = txtConfirmacionClave.Text;

            if (clave1.Equals(clave2))
            {
                clave1 = Utils.Encriptacion.encriptarClave(clave2);
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
                    MessageBox.Show("Ingrese los datos");
                }
                else
                {
                    string contra = this.verificaClave();
                    if (!contra.Equals(""))
                    {
                        this.oUsuario.Insert(txtNombre.Text, txtApellido.Text, 
                            char.Parse(cmbAdmin.SelectedItem.ToString()), txtCorreo.Text, contra);
                        if (this.oUsuario.isError)
                        {
                            MessageBox.Show(this.oUsuario.errorDescription);
                            return;
                        }
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Contraseñas distintas");
                    }
                }

            }
            else
            {
                if (txtNombre.Text.Equals("") || txtApellido.Text.Equals("") ||
                     txtCorreo.Text.Equals("") || txtClave.Text.Equals("") ||
                     txtConfirmacionClave.Text.Equals(""))
                {
                    MessageBox.Show("Ingrese los datos");
                }
                else
                {
                    int id = Convert.ToInt32(txtId.Text);
                    string nombre = txtNombre.Text;
                    string apellido = txtApellido.Text;
                    string correo = txtCorreo.Text;
                    char admin = char.Parse(cmbAdmin.SelectedItem.ToString());
                    string contra = this.verificaClave();

                    if (!contra.Equals(""))
                    {
                        this.oUsuario.Update(id, nombre, apellido, admin, correo, contra);
                        if (this.oUsuario.isError)
                        {
                            MessageBox.Show(this.oUsuario.errorDescription);
                            return;
                        }
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Contraseñas distintas");
                    }

                }
            }
        }

        private void EditaUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}

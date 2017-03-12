using System;
using System.Data;
using JPS.Controladores;
using JPS.Vistas;
using System.Windows.Forms;
using JPS.Vistas.VistasEdicion;

namespace JPS.Vistas
{
    public partial class frmUsuarios : Form
    {
        private Usuario oUsuario;
        public frmUsuarios()
        {
            InitializeComponent();
            this.oUsuario = new Usuario();
            this.Refrescar();
        }
        private void Refrescar()
        {
            DataTable result = new DataTable();
            result = this.oUsuario.Select(txtNombre.Text, txtApellido.Text, txtCorreo.Text);
            if (this.oUsuario.isError)
            {
                MessageBox.Show(this.oUsuario.errorDescription);
                return;
            }
            this.dtgUsuarios.DataSource = result;
        }

        private void dtgUsuarios_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = int.Parse(this.dtgUsuarios.CurrentRow.Cells[0].Value.ToString());
            string nombre = this.dtgUsuarios.CurrentRow.Cells[1].Value.ToString();
            string apellido = this.dtgUsuarios.CurrentRow.Cells[2].Value.ToString();
            string correo = this.dtgUsuarios.CurrentRow.Cells[4].Value.ToString();
            string administrador = this.dtgUsuarios.CurrentRow.Cells[3].Value.ToString();

            EditaUsuario oEdita = new EditaUsuario(id,nombre,apellido,correo, administrador);
            oEdita.ShowDialog();
            this.Refrescar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EditaUsuario oEdita = new EditaUsuario();
            oEdita.ShowDialog();
            this.Refrescar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var row = this.dtgUsuarios.CurrentRow.Cells[0];
            int id = Convert.ToInt32(row.Value);
            this.oUsuario.Delete(id);
            if (this.oUsuario.isError)
            {
                MessageBox.Show(this.oUsuario.errorDescription);
                return;
            }
            this.Refrescar();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {

        }

        private void dtgUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

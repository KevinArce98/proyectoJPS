using System;
using JPS.Controladores;
using System.Windows.Forms;
using JPS.Vistas.VistasEdicion;
using System.Data;

namespace JPS.Vistas
{
    public partial class frmSorteo : Form
    {
        private Sorteo oSorteo;
        public frmSorteo()
        {
            InitializeComponent();
            this.oSorteo = new Sorteo();
            this.Refrescar();
        }
        private void Refrescar()
        {
            DataTable result = new DataTable();
            result = this.oSorteo.SelecAll();
            if (this.oSorteo.isError)
            {
                MessageBox.Show(this.oSorteo.errorDescription);
                return;
            }
            this.dtgSorteos.DataSource = result;
        }

        private void RefrescarFiltrado()
        {
            DataTable result = new DataTable();
            char activo = ' ';
            if (this.cmbActivo.SelectedIndex != -1)
            {
                activo = char.Parse(this.cmbActivo.SelectedItem.ToString());
            }
            result = this.oSorteo.Select(this.dtFecha.Value, activo,
                                this.txtDescripcion.Text);
            if (this.oSorteo.isError)
            {
                MessageBox.Show(this.oSorteo.errorDescription);
                return;
            }
            this.dtgSorteos.DataSource = result;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EditaSorteo oEditaSorteo = new EditaSorteo();
            oEditaSorteo.ShowDialog();
            this.Refrescar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var row = this.dtgSorteos.CurrentRow.Cells[0];
            int id = Convert.ToInt32(row.Value);
            this.oSorteo.Delete(id);
            if (this.oSorteo.isError)
            {
                MessageBox.Show(this.oSorteo.errorDescription);
                return;
            }
            this.Refrescar();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            this.RefrescarFiltrado();

        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            this.Refrescar();
        }

        private void dtgSorteos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = int.Parse(this.dtgSorteos.CurrentRow.Cells[0].Value.ToString());
            DateTime fecha = DateTime.Parse(this.dtgSorteos.CurrentRow.Cells[1].Value.ToString());
            string activo = (this.dtgSorteos.CurrentRow.Cells[2].Value.ToString());
            string descripcion = this.dtgSorteos.CurrentRow.Cells[3].Value.ToString();
            EditaSorteo oEdita = new EditaSorteo(id, fecha, activo, descripcion);
            oEdita.ShowDialog();
            this.Refrescar();
        }
    }
}

using System;
using JPS.Controladores;
using System.Windows.Forms;

namespace JPS.Vistas.VistasEdicion
{
    public partial class EditaSorteo : Form
    {

        public Sorteo oSorteo { get; set; }
        public EditaSorteo()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.oSorteo = new Sorteo();
        }

        public EditaSorteo(int id, DateTime fecha, bool activo, string descripcion)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.oSorteo = new Sorteo();
            this.txtId.Text = id.ToString();
            this.txtDescripcion.Text = descripcion;
            this.dtFecha.Value = fecha;
            this.ckbActivo.Checked = activo;

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.txtId.Text.Equals(""))
            {
                if (this.txtDescripcion.Text.Trim().Equals("") || this.dtFecha.Value == null)
                {
                    MessageBox.Show("Falta datos requeridos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    this.oSorteo.Insert(this.dtFecha.Value, ckbActivo.Checked,
                                         this.txtDescripcion.Text);
                    if (this.oSorteo.isError)
                    {
                        MessageBox.Show(this.oSorteo.errorDescription);
                        return;
                    }
                    this.Close();
                }
            }
            else
            {
                if (this.txtDescripcion.Text.Trim().Equals("") || this.dtFecha.Value == null)
                {
                    MessageBox.Show("Falta datos requeridos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    this.oSorteo.Update(int.Parse(this.txtId.Text), this.dtFecha.Value, ckbActivo.Checked, this.txtDescripcion.Text);
                    if (this.oSorteo.isError)
                    {
                        MessageBox.Show(this.oSorteo.errorDescription);
                        return;
                    }
                    this.Close();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
            this.oSorteo = new Sorteo();
            //this.txtId.Enabled = false;
            this.cargarCombo();
        }

        public EditaSorteo(int id, DateTime fecha, string activo, string descripcion)
        {
            InitializeComponent();
            this.oSorteo = new Sorteo();
            this.cargarCombo();
            this.txtId.Text = id.ToString();
            this.txtDescripcion.Text = descripcion;
            this.dtFecha.Value = fecha;
            this.cmbActivo.SelectedItem = char.Parse(activo);

            //this.txtId.Enabled = false;

        }

        private void cargarCombo()
        {
            this.cmbActivo.Items.Add('S');
            this.cmbActivo.Items.Add('N');
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.txtId.Text.Equals(""))
            {
                if (this.txtDescripcion.Text.Trim().Equals("") || this.dtFecha.Value == null ||
                this.cmbActivo.SelectedIndex == -1)
                {
                    MessageBox.Show("Falta datos requeridos.");

                }
                else
                {
                    this.oSorteo.Insert(this.dtFecha.Value, char.Parse(this.cmbActivo.SelectedItem.ToString()),
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
                if (this.txtDescripcion.Text.Trim().Equals("") || this.dtFecha.Value == null ||
                this.cmbActivo.SelectedIndex == -1)
                {
                    MessageBox.Show("Falta datos requeridos.");

                }
                else
                {
                    this.oSorteo.Update(int.Parse(this.txtId.Text), this.dtFecha.Value, 
                        char.Parse(this.cmbActivo.SelectedItem.ToString()),
                                   this.txtDescripcion.Text);
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

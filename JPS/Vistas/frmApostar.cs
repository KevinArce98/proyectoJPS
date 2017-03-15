using System;
using System.Collections.Generic;
using System.Windows.Forms;
using JPS.Controladores;
using JPS.Utils;

namespace JPS.Vistas
{
    public partial class frmApostar : Form
    {
        private Apuesta oApuesta;
        public frmApostar()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.oApuesta = new Apuesta();
            this.cargarComboSorteo();
            this.resetFields();
        }
        private void resetFields() {
            txtMonto.Text = string.Empty;
            txtNumero.Text = string.Empty;
            cmbSorteos.SelectedIndex = -1;
        }

        private void cargarComboSorteo()
        {
            foreach (var item in RuntimeData.cargarComboSorteo())
            {
                cmbSorteos.Items.Add(item);
            }
        }

        private void cmbSorteos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMonto.Text.Equals("") || txtNumero.Text.Equals("") || cmbSorteos.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese los datos");
            }
            else
            {
                double monto = double.Parse(txtMonto.Text);
                int num = int.Parse(txtNumero.Text);
                Modelos.Sorteo oSorteo = (Modelos.Sorteo)cmbSorteos.SelectedItem;

                Modelos.Apuesta oApuestaM = oApuesta.Select(RuntimeData.oUsuario.id, oSorteo.id, num);

                if (oApuestaM.id == -1)
                {
                    oApuesta.Insert(RuntimeData.oUsuario, oSorteo, num, monto);
                    this.resetFields();
                    MessageBox.Show("Apuesta Agregada");
                }
                else
                {
                    monto = monto + oApuestaM.monto;
                    oApuesta.Update(oApuestaM.id,RuntimeData.oUsuario, oSorteo, num, monto);
                    this.resetFields();
                    MessageBox.Show("Apuesta Modificada");
                }
                
            }
        }
    }
}

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
                Configuracion oConfig = new Configuracion();
                double monto = double.Parse(txtMonto.Text);
                int num = int.Parse(txtNumero.Text);
                double montoCasa = -1;
                Modelos.Sorteo oSorteo = (Modelos.Sorteo)cmbSorteos.SelectedItem;
                double verifica = Bets.calcularApuesta(num,monto, oSorteo.id);
                if (verifica == 0)
                {
                        oApuesta.Insert(RuntimeData.oUsuario, oSorteo, num, monto);
                        montoCasa = oConfig.Select() + monto;
                        oConfig.Update(montoCasa);
                        this.resetFields();
                        MessageBox.Show("Apuesta Agregada");                  
                }
                else if (verifica == -1)
                {
                    MessageBox.Show("Apuesta Denegada (La casa nunca pierde)");
                }
            }
        }
    }
}

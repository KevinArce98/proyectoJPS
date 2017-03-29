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
                MessageBox.Show("Faltan datos requeridos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Configuracion oConfig = new Configuracion();
                Sorteo oSorteo = new Sorteo();
                double monto = double.Parse(txtMonto.Text);
                int num = int.Parse(txtNumero.Text);
                double montoCasa = -1;
                Modelos.Sorteo oSorteoM = (Modelos.Sorteo)cmbSorteos.SelectedItem;
    
                
                if (oSorteo.SelectInactive(oSorteoM.id).Rows.Count == 0)
                {
                    MessageBox.Show("La fecha del sorteo ha expirado", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetFields();
                }
                else
                {

                    double peorCaso = Bets.calcularApuesta();
                    montoCasa = oConfig.Select();
                    montoCasa = montoCasa - peorCaso;
                    double maximo = montoCasa / 60;

                    if (monto <= maximo)
                    {
                        oApuesta.Insert(RuntimeData.oUsuario, oSorteoM, num, monto);
                        montoCasa = oConfig.Select() + monto;
                        oConfig.Update(montoCasa);
                        this.resetFields();
                        MessageBox.Show("Apuesta Agregada", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        maximo = Math.Truncate(maximo);
                        this.resetFields();
                        MessageBox.Show("Apuesta Denegada (La casa nunca pierde)" + " \nPuede apostar ₡" + maximo, "ERROR",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }
    }
}

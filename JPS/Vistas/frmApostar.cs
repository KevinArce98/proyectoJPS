using System;
using System.Collections.Generic;
using System.Windows.Forms;
using JPS.Controladores;
using JPS.Utils;
using System.Globalization;

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
            if (txtMonto.Text.Equals("") || txtNumero.Text.Equals("") || 
                cmbSorteos.SelectedIndex == -1 || txtMonto.Text.Trim().Equals("."))
            {
                MessageBox.Show("Faltan datos requeridos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (this.verificaString(txtMonto.Text))
                {
                    Configuracion oConfig = new Configuracion();
                Sorteo oSorteo = new Sorteo();
                double monto = double.Parse(txtMonto.Text);
                int num = int.Parse(txtNumero.Text);
                double montoCasa = -1;
                Modelos.Sorteo oSorteoM = (Modelos.Sorteo)cmbSorteos.SelectedItem;


                    if (oSorteo.SelectInactive(oSorteoM.id).id == -1)
                    {
                        MessageBox.Show("La fecha del sorteo ha expirado", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetFields();
                    }
                    else
                    {
                        if (oConfig.Select() != -1)
                        {
                            Program.da.BeginTransaction();
                            oApuesta.Insert(RuntimeData.oUsuario, oSorteoM, num, monto);
                            montoCasa = oConfig.Select() + monto;
                            oConfig.Update(montoCasa);
                            double peorCaso = Bets.calcularApuesta();
                            if (montoCasa >= peorCaso)
                            {
                                Program.da.CommitTransaction();
                                this.resetFields();
                                MessageBox.Show("Apuesta Agregada", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                Program.da.RollbackTransaction();
                                double maxima = Bets.mostarApuestaMaximaa(oSorteoM.id, monto, num);
                                this.resetFields();
                                MessageBox.Show("Apuesta Denegada (La casa nunca pierde)" + " \nPuede apostar ₡" + maxima, "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No hay dinero en casa", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Solo ingrese un punto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
            if (char.IsNumber(e.KeyChar) ||
                e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator || (e.KeyChar == (char)Keys.Back)
                )
                e.Handled = false;
            else
                e.Handled = true;
        }

        private bool verificaString(string texto)
        {
            bool encotrado = false;
            int contador = 0;
            foreach (char item in texto)
            {
                if (item == '.')
                {
                    contador++;
                }
            }
            if (contador == 1 || contador == 0)
            {
                encotrado = true;

            }
            return encotrado;
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
            if (char.IsNumber(e.KeyChar) || (e.KeyChar == (char)Keys.Back))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}

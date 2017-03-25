using System;
using JPS.Controladores;
using System.Windows.Forms;
using System.Data;
using JPS.Utils;

namespace JPS.Vistas
{
    public partial class frmConfiguracion : Form
    {
        private Configuracion oConfig;
        private Ganador oGanador;
        public frmConfiguracion()
        {
            InitializeComponent();
            this.CenterToScreen();
            oConfig = new Configuracion();
            oGanador = new Ganador();
            this.cargarComboSorteo();
            this.checkConfig();
        }
        private void resetFields()
        {
            txtNumero1.Text = string.Empty;
            txtNumero2.Text = string.Empty;
            txtNumero3.Text = string.Empty;
            txtMonto.Text = string.Empty;
            cmbSorteo.SelectedIndex = -1;
        }
        private void cargarComboSorteo()
        {
            foreach (var item in RuntimeData.cargarComboSorteo())
            {
                cmbSorteo.Items.Add(item);
                cmbSor.Items.Add(item);
                cmbSorteoPeor.Items.Add(item);
            }
        }
       
        private void checkConfig()
        {
            double monto = oConfig.Select();
            if (monto != -1)
            {
                txtMonto.Text = monto.ToString();
            }
        }
        private void btnGuardarDinero_Click(object sender, EventArgs e)
        {
            if (oConfig.Select() == -1)
            {
                oConfig.Insert(double.Parse(txtMonto.Text));
                this.resetFields();
                MessageBox.Show("Monto agregado");
            }
            else
            {
                oConfig.Update(double.Parse(txtMonto.Text));
                this.resetFields();
                MessageBox.Show("Monto modificado");
            }
                
           
        }

        private void cmbSorteo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnGuardarFavo_Click(object sender, EventArgs e)
        {
            if (cmbSorteo.SelectedIndex == -1 || txtNumero1.Text.Equals("")
                || txtNumero2.Text.Equals("") || txtNumero3.Text.Equals(""))
            {
                MessageBox.Show("Ingrese los datos");
            }
            else
            {
                Modelos.Sorteo oSorteo = (Modelos.Sorteo)cmbSorteo.SelectedItem;
                int idSorteo = oSorteo.id;
                if (oGanador.Select(idSorteo).id == -1 )
                {
                    int num1 = int.Parse(txtNumero1.Text);
                    int num2 = int.Parse(txtNumero2.Text);
                    int num3 = int.Parse(txtNumero3.Text);
                    if ((num1 != num2) && (num2 != num3) && (num3 != num1))
                    {
                        oGanador.Insert(num1, num2, num3, oSorteo);
                        this.resetFields();
                        MessageBox.Show("Numeros Agregados para " + oSorteo.descripcion);
                        double montoCasa = oConfig.Select() - Bets.restarMontoCasa(num1, num2, num3, idSorteo);
                        oConfig.Update(montoCasa);
                        Bets.enviarCorreo(num1, num2, num3, idSorteo);
                    }
                    else
                    {
                        MessageBox.Show("Los numero no pueden ser iguales");
                    }
                   
                }
                else
                {
                    MessageBox.Show("El sorteo ya tiene numeros favorecidos");
                    this.resetFields();
                }  
            }
        }

        private void cmbSor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Modelos.Sorteo oSorteo = (Modelos.Sorteo)cmbSor.SelectedItem;
            txtMaxima.Text = Convert.ToString(Bets.GananciaMaximaPorSorteo(oSorteo.id));
            txtMinima.Text = Convert.ToString(Bets.GananciaMinimaPorSorteo(oSorteo.id));
        }

        private void cmbSorteoPeor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Modelos.Sorteo oSorteo = (Modelos.Sorteo)cmbSorteoPeor.SelectedItem;
            txtPeor.Text = Convert.ToString(Bets.PeorCasosSorteo(oSorteo.id));
        }
    }
}

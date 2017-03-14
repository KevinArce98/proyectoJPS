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
        public frmConfiguracion()
        {
            InitializeComponent();
            this.CenterToScreen();
            oConfig = new Configuracion();
            this.cargarComboSorteo();
        }
        private void cargarComboSorteo()
        {
            foreach (var item in RuntimeData.cargarComboSorteo())
            {
                cmbSorteo.Items.Add(item);
            }
        }
        private void btnGuardarDinero_Click(object sender, EventArgs e)
        {
            if (oConfig.Select() == -1)
            {
                oConfig.Insert(double.Parse(txtMonto.Text));
            }
            else
            {
                oConfig.Update(double.Parse(txtMonto.Text));
            }
                
           
        }

        private void btnGuardarFavo_Click(object sender, EventArgs e)
        {

        }

        private void cmbSorteo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}

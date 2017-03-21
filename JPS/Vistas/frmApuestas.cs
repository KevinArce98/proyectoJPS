using JPS.Utils;
using System;
using System.Data;
using System.Windows.Forms;
using JPS.Controladores;
using JPS.Utils;
using System.Collections;

namespace JPS.Vistas
{
    public partial class frmApuestas : Form
    {
        private Apuesta oApuesta;
        
        public frmApuestas()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.oApuesta = new Apuesta();
            this.cargarComboSorteo();
        }

        private void cargarComboSorteo()
        {
            foreach (var item in RuntimeData.cargarComboSorteo())
            {
                cmbSorteos.Items.Add(item);
            }
        }
        private void Refrescar()
        {
            if (cmbSorteos.SelectedIndex != -1)
            {
                Modelos.Sorteo oSorteo = (Modelos.Sorteo)cmbSorteos.SelectedItem;
                DataTable result = new DataTable();
                result = this.oApuesta.SelectTable(oSorteo.id);
                if (this.oApuesta.isError)
                {
                    MessageBox.Show(this.oApuesta.errorDescription);
                    return;
                }
                this.dtgApuestas.DataSource = result;
            }
            else
            {
                MessageBox.Show("Seleccione un sorteo");
            }
            
        }
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            this.Refrescar();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Numero"));
            dt.Columns.Add(new DataColumn("Total Apostado"));
            if (cmbSorteos.SelectedIndex != -1)
            {
                Modelos.Sorteo oSorteo = (Modelos.Sorteo)cmbSorteos.SelectedItem;
                ArrayList oList = Bets.apuestasTotales(oSorteo.id);

                if (oList.Count == 0)
                {
                    MessageBox.Show("No hay apuestas");
                }
                for (int i = 0; i < oList.Count; i++)
                {
                    ApuestasTotales oApuesta = (ApuestasTotales)oList[i];
                    DataRow dr = dt.NewRow();
                    dr[0] = oApuesta.numero;
                    dr[1] = oApuesta.monto;
                    dt.Rows.Add(dr);
                }
                this.dtgApuestas.DataSource = dt;
            }
        }
    
    }
}

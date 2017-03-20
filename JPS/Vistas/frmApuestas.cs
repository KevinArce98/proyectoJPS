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
            this.Refrescar();
        }
        private void Refrescar()
        {
            DataTable result = new DataTable();
            result = this.oApuesta.SelectTable();
            if (this.oApuesta.isError)
            {
                MessageBox.Show(this.oApuesta.errorDescription);
                return;
            }
            this.dtgApuestas.DataSource = result;
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

            ArrayList oList = Bets.apuestasTotales();

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

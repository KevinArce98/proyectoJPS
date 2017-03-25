using JPS.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JPS.Vistas
{
    public partial class frmResultados : Form
    {
        public frmResultados()
        {
            InitializeComponent();
            this.CenterToScreen();
            cargarComboSorteo();
        }
        private void cargarComboSorteo()
        {
            foreach (var item in RuntimeData.cargarComboSorteo())
            {
                cmbSorteos.Items.Add(item);
            }
        }
        private void llenarGanadas()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Id Apuesta"));
            dt.Columns.Add(new DataColumn("Id Sorteo"));
            dt.Columns.Add(new DataColumn("Numero Favorecido"));
            dt.Columns.Add(new DataColumn("Monto Apostado"));
            dt.Columns.Add(new DataColumn("Monto Ganado"));

            Modelos.Sorteo oSorteo = (Modelos.Sorteo)cmbSorteos.SelectedItem;

            ArrayList oList = Bets.mostrarGanadas( RuntimeData.oUsuario.id, oSorteo.id);
            if (oList.Count == 0)
            {
                MessageBox.Show("Gracias por participar");
            }
            for (int i = 0; i < oList.Count; i++)
            {
                Modelos.Apuesta oApuesta= (Modelos.Apuesta)oList[i];
                DataRow dr = dt.NewRow();
                dr[0] = oApuesta.id.ToString();
                dr[1] = oApuesta.oSorteo.id.ToString();
                dr[2] = oApuesta.numero.ToString();
                dr[3] = oApuesta.monto.ToString();
                dr[4] = oApuesta.montoGanado.ToString();
                dt.Rows.Add(dr);
            }
            this.dtgResultados.DataSource = dt;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cmbSorteos.SelectedIndex != -1)
            {
                llenarGanadas();
            }
            else
            {
                MessageBox.Show("Seleccione un sorteo");
            }
        }
    }
}

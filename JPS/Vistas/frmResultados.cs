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
            this.llenarGanadas();
        }
        private void llenarGanadas()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Id Apuesta"));
            dt.Columns.Add(new DataColumn("Id Sorteo"));
            dt.Columns.Add(new DataColumn("Numero"));
            dt.Columns.Add(new DataColumn("Monto"));

            ArrayList oList = Bets.mostrarGanadas(RuntimeData.oUsuario.id);
            for (int i = 0; i < oList.Count; i++)
            {
                Modelos.Apuesta oApuesta= (Modelos.Apuesta)oList[i];
                DataRow dr = dt.NewRow();
                dr[0] = oApuesta.id.ToString();
                dr[1] = oApuesta.oSorteo.id.ToString();
                dr[2] = oApuesta.numero.ToString();
                dr[3] = oApuesta.monto.ToString();
                dt.Rows.Add(dr);
            }
            this.dtgResultados.DataSource = dt;
        }
    }
}

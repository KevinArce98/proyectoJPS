using JPS.Utils;
using System;
using System.Data;
using System.Windows.Forms;
using JPS.Controladores;
using JPS.Utils;
using System.Collections;
using System.Drawing;

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
                ArrayList oList = this.oApuesta.SelectTable(oSorteo.id);

                DataTable dt = new DataTable();
                dt.Columns.Add(new DataColumn("Id Apuesta"));
                dt.Columns.Add(new DataColumn("Sorteo"));
                dt.Columns.Add(new DataColumn("Nombre Usuario"));
                dt.Columns.Add(new DataColumn("Apellido Usuario"));
                dt.Columns.Add(new DataColumn("Numero"));
                dt.Columns.Add(new DataColumn("Monto Apostado"));
                dt.Columns.Add(new DataColumn("Monto Ganado"));

                    if (oList.Count == 0)
                    {
                        MessageBox.Show("No hay apuestas");
                    }
                    for (int i = 0; i < oList.Count; i++)
                    {
                        Modelos.Apuesta oApuesta = (Modelos.Apuesta)oList[i];
                        DataRow dr = dt.NewRow();
                    dr[0] = oApuesta.id;
                    dr[1] = oApuesta.oSorteo.descripcion;
                    dr[2] = oApuesta.oUsuario.nombre;
                    dr[3] = oApuesta.oUsuario.apellido;
                    dr[4] = oApuesta.numero;
                    dr[5] = oApuesta.monto;
                    dr[6] = oApuesta.montoGanado;

                    dt.Rows.Add(dr);
                    }
                    this.dtgApuestas.DataSource = dt;   
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
                ArrayList oList = oApuesta.SelectTotal(oSorteo.id);

                if (oList.Count == 0)
                {
                    MessageBox.Show("No hay apuestas");
                }
                for (int i = 0; i < oList.Count; i++)
                {
                    Modelos.Apuesta oApuesta = (Modelos.Apuesta)oList[i];
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

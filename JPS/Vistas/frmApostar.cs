using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JPS.Controladores;
using JPS.Modelos;

namespace JPS.Vistas
{
    public partial class frmApostar : Form
    {
        Controladores.Sorteo oSorteo;

        public frmApostar()
        {
            InitializeComponent();
            this.oSorteo = new Controladores.Sorteo();
            
            this.cargarComboSorteo();
        }

        private void cargarComboSorteo()
        {
            
            DataTable temp = oSorteo.SelecAll();
            List<Modelos.Sorteo> sorteos = new List<Modelos.Sorteo>();
            for (int i = 0; i < temp.Rows.Count; i++)
            {
                Modelos.Sorteo oSorteoE = new Modelos.Sorteo();
                oSorteoE.id = int.Parse(temp.Rows[i]["id_sorteo"].ToString());
                oSorteoE.fecha_hora = DateTime.Parse(temp.Rows[i]["fecha_hora"].ToString());
                oSorteoE.descripcion = temp.Rows[i]["descripcion"].ToString();
                sorteos.Add(oSorteoE);
            }
            for (int i = 0; i < sorteos.Count; i++)
            {
                cmbSorteos.Items.Add(sorteos[i]);
            }
        }

        private void cmbSorteos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}

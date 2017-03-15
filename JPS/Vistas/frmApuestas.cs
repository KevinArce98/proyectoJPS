using JPS.Utils;
using System;
using System.Data;
using System.Windows.Forms;
using JPS.Controladores;
using JPS.Utils;

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

        private void btnCorreo_Click(object sender, EventArgs e)
        {
            MailHandler oMail = new MailHandler();
            oMail.sendEmail();
        }
    }
}

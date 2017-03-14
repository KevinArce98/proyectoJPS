using System;
using System.Linq;
using System.Windows.Forms;

namespace JPS.Vistas
{
    public partial class frmPrincipal : Form
    {
        private frmConfiguracion oConfig;
        private frmSorteo oSorteo;
        private frmGanadores oGanadores;
        private frmUsuarios oUsuarios;
        private frmApostar oApostar;
        private frmResultados oResultado;

        public frmPrincipal()
        {
            InitializeComponent();
           
        }
        private bool HandleForm(Form currentForm)
        {
            if (this.MdiChildren.Contains(currentForm))
            {
                currentForm.WindowState = FormWindowState.Maximized;
                currentForm.Activate();
                return false;
            }
            return true;
        }

        private void configuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.HandleForm(this.oConfig))
            {
                oConfig = new frmConfiguracion();
                oConfig.MdiParent = this;
                oConfig.Show();
            }
        }

        private void sorteosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.HandleForm(this.oSorteo))
            {
                oSorteo = new frmSorteo();
                oSorteo.MdiParent = this;
                oSorteo.Show();
            }
        }

        private void ganadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.HandleForm(this.oGanadores))
            {
                oGanadores = new frmGanadores();
                oGanadores.MdiParent = this;
                oGanadores.Show();
            }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.HandleForm(this.oUsuarios))
            {
                oUsuarios = new frmUsuarios();
                oUsuarios.MdiParent = this;
                oUsuarios.Show();
            }
        }

        private void apostarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.HandleForm(this.oApostar))
            {
                oApostar = new frmApostar();
                oApostar.MdiParent = this;
                oApostar.Show();
            }
        }

        private void resultadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.HandleForm(this.oResultado))
            {
                oResultado = new frmResultados();
                oResultado.MdiParent = this;
                oResultado.Show();
            }
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

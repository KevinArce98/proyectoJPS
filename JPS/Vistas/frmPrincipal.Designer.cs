namespace JPS.Vistas
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sorteosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ganadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.votacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apostarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administracionToolStripMenuItem,
            this.votacionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(778, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administracionToolStripMenuItem
            // 
            this.administracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sorteosToolStripMenuItem,
            this.ganadoresToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.configuracionToolStripMenuItem});
            this.administracionToolStripMenuItem.Name = "administracionToolStripMenuItem";
            this.administracionToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.administracionToolStripMenuItem.Text = "Administracion";
            // 
            // sorteosToolStripMenuItem
            // 
            this.sorteosToolStripMenuItem.Name = "sorteosToolStripMenuItem";
            this.sorteosToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.sorteosToolStripMenuItem.Text = "Sorteos";
            // 
            // ganadoresToolStripMenuItem
            // 
            this.ganadoresToolStripMenuItem.Name = "ganadoresToolStripMenuItem";
            this.ganadoresToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.ganadoresToolStripMenuItem.Text = "Ganadores";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.configuracionToolStripMenuItem.Text = "Configuracion";
            // 
            // votacionToolStripMenuItem
            // 
            this.votacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apostarToolStripMenuItem,
            this.resultadoToolStripMenuItem});
            this.votacionToolStripMenuItem.Name = "votacionToolStripMenuItem";
            this.votacionToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.votacionToolStripMenuItem.Text = "Tiempos";
            // 
            // apostarToolStripMenuItem
            // 
            this.apostarToolStripMenuItem.Name = "apostarToolStripMenuItem";
            this.apostarToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.apostarToolStripMenuItem.Text = "Apostar";
            // 
            // resultadoToolStripMenuItem
            // 
            this.resultadoToolStripMenuItem.Name = "resultadoToolStripMenuItem";
            this.resultadoToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.resultadoToolStripMenuItem.Text = "Resultado";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 559);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sorteosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ganadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem votacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apostarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultadoToolStripMenuItem;
    }
}




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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminButton = new System.Windows.Forms.ToolStripMenuItem();
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
            this.adminButton,
            this.votacionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(778, 34);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminButton
            // 
            this.adminButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sorteosToolStripMenuItem,
            this.ganadoresToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.configuracionToolStripMenuItem});
            this.adminButton.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminButton.Image = ((System.Drawing.Image)(resources.GetObject("adminButton.Image")));
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(155, 30);
            this.adminButton.Text = "Administracion";
            // 
            // sorteosToolStripMenuItem
            // 
            this.sorteosToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 9.75F);
            this.sorteosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sorteosToolStripMenuItem.Image")));
            this.sorteosToolStripMenuItem.Name = "sorteosToolStripMenuItem";
            this.sorteosToolStripMenuItem.Size = new System.Drawing.Size(173, 28);
            this.sorteosToolStripMenuItem.Text = "Sorteos";
            this.sorteosToolStripMenuItem.Click += new System.EventHandler(this.sorteosToolStripMenuItem_Click);
            // 
            // ganadoresToolStripMenuItem
            // 
            this.ganadoresToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 9.75F);
            this.ganadoresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ganadoresToolStripMenuItem.Image")));
            this.ganadoresToolStripMenuItem.Name = "ganadoresToolStripMenuItem";
            this.ganadoresToolStripMenuItem.Size = new System.Drawing.Size(173, 28);
            this.ganadoresToolStripMenuItem.Text = "Apuestas";
            this.ganadoresToolStripMenuItem.Click += new System.EventHandler(this.ganadoresToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 9.75F);
            this.usuariosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usuariosToolStripMenuItem.Image")));
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(173, 28);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 9.75F);
            this.configuracionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("configuracionToolStripMenuItem.Image")));
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(173, 28);
            this.configuracionToolStripMenuItem.Text = "Configuracion";
            this.configuracionToolStripMenuItem.Click += new System.EventHandler(this.configuracionToolStripMenuItem_Click);
            // 
            // votacionToolStripMenuItem
            // 
            this.votacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apostarToolStripMenuItem,
            this.resultadoToolStripMenuItem});
            this.votacionToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.votacionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("votacionToolStripMenuItem.Image")));
            this.votacionToolStripMenuItem.Name = "votacionToolStripMenuItem";
            this.votacionToolStripMenuItem.Size = new System.Drawing.Size(101, 30);
            this.votacionToolStripMenuItem.Text = "Tiempos";
            // 
            // apostarToolStripMenuItem
            // 
            this.apostarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("apostarToolStripMenuItem.Image")));
            this.apostarToolStripMenuItem.Name = "apostarToolStripMenuItem";
            this.apostarToolStripMenuItem.Size = new System.Drawing.Size(156, 30);
            this.apostarToolStripMenuItem.Text = "Apostar";
            this.apostarToolStripMenuItem.Click += new System.EventHandler(this.apostarToolStripMenuItem_Click);
            // 
            // resultadoToolStripMenuItem
            // 
            this.resultadoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("resultadoToolStripMenuItem.Image")));
            this.resultadoToolStripMenuItem.Name = "resultadoToolStripMenuItem";
            this.resultadoToolStripMenuItem.Size = new System.Drawing.Size(156, 30);
            this.resultadoToolStripMenuItem.Text = "Resultado";
            this.resultadoToolStripMenuItem.Click += new System.EventHandler(this.resultadoToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(778, 559);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminButton;
        private System.Windows.Forms.ToolStripMenuItem sorteosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ganadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem votacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apostarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultadoToolStripMenuItem;
    }
}




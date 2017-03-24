namespace JPS.Vistas
{
    partial class frmApuestas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgApuestas = new System.Windows.Forms.DataGridView();
            this.btnTodas = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.cmbSorteos = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgApuestas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgApuestas
            // 
            this.dtgApuestas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgApuestas.Location = new System.Drawing.Point(12, 67);
            this.dtgApuestas.Name = "dtgApuestas";
            this.dtgApuestas.Size = new System.Drawing.Size(790, 322);
            this.dtgApuestas.TabIndex = 0;
            // 
            // btnTodas
            // 
            this.btnTodas.Location = new System.Drawing.Point(176, 21);
            this.btnTodas.Name = "btnTodas";
            this.btnTodas.Size = new System.Drawing.Size(143, 23);
            this.btnTodas.TabIndex = 2;
            this.btnTodas.Text = "Todas las Apuestas";
            this.btnTodas.UseVisualStyleBackColor = true;
            this.btnTodas.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(325, 21);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(151, 23);
            this.btnFiltrar.TabIndex = 5;
            this.btnFiltrar.Text = "Apuestas totales";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // cmbSorteos
            // 
            this.cmbSorteos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSorteos.FormattingEnabled = true;
            this.cmbSorteos.Location = new System.Drawing.Point(30, 23);
            this.cmbSorteos.Name = "cmbSorteos";
            this.cmbSorteos.Size = new System.Drawing.Size(121, 21);
            this.cmbSorteos.TabIndex = 6;
            // 
            // frmApuestas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 405);
            this.Controls.Add(this.cmbSorteos);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.btnTodas);
            this.Controls.Add(this.dtgApuestas);
            this.Name = "frmApuestas";
            this.Text = "Apuestas";
            ((System.ComponentModel.ISupportInitialize)(this.dtgApuestas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgApuestas;
        private System.Windows.Forms.Button btnTodas;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ComboBox cmbSorteos;
    }
}
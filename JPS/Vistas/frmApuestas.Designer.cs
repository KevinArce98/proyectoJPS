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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmApuestas));
            this.dtgApuestas = new System.Windows.Forms.DataGridView();
            this.btnTodas = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.cmbSorteos = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgApuestas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgApuestas
            // 
            this.dtgApuestas.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgApuestas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgApuestas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgApuestas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgApuestas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgApuestas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgApuestas.Location = new System.Drawing.Point(0, 71);
            this.dtgApuestas.Name = "dtgApuestas";
            this.dtgApuestas.ReadOnly = true;
            this.dtgApuestas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dtgApuestas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgApuestas.Size = new System.Drawing.Size(814, 334);
            this.dtgApuestas.TabIndex = 0;
            // 
            // btnTodas
            // 
            this.btnTodas.Font = new System.Drawing.Font("Segoe Print", 9.75F);
            this.btnTodas.Location = new System.Drawing.Point(221, 16);
            this.btnTodas.Name = "btnTodas";
            this.btnTodas.Size = new System.Drawing.Size(181, 31);
            this.btnTodas.TabIndex = 2;
            this.btnTodas.Text = "Todas las Apuestas";
            this.btnTodas.UseVisualStyleBackColor = true;
            this.btnTodas.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Font = new System.Drawing.Font("Segoe Print", 9.75F);
            this.btnFiltrar.Location = new System.Drawing.Point(408, 16);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(151, 31);
            this.btnFiltrar.TabIndex = 5;
            this.btnFiltrar.Text = "Apuestas totales";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // cmbSorteos
            // 
            this.cmbSorteos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSorteos.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cmbSorteos.FormattingEnabled = true;
            this.cmbSorteos.Location = new System.Drawing.Point(38, 19);
            this.cmbSorteos.Name = "cmbSorteos";
            this.cmbSorteos.Size = new System.Drawing.Size(161, 28);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
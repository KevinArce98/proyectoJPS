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
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnCorreo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgApuestas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgApuestas
            // 
            this.dtgApuestas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgApuestas.Location = new System.Drawing.Point(12, 67);
            this.dtgApuestas.Name = "dtgApuestas";
            this.dtgApuestas.Size = new System.Drawing.Size(724, 322);
            this.dtgApuestas.TabIndex = 0;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(12, 21);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(75, 23);
            this.btnRefrescar.TabIndex = 2;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnCorreo
            // 
            this.btnCorreo.Location = new System.Drawing.Point(152, 21);
            this.btnCorreo.Name = "btnCorreo";
            this.btnCorreo.Size = new System.Drawing.Size(75, 23);
            this.btnCorreo.TabIndex = 3;
            this.btnCorreo.Text = "Enviar Correo";
            this.btnCorreo.UseVisualStyleBackColor = true;
            this.btnCorreo.Click += new System.EventHandler(this.btnCorreo_Click);
            // 
            // frmApuestas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 401);
            this.Controls.Add(this.btnCorreo);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.dtgApuestas);
            this.Name = "frmApuestas";
            this.Text = "Apuestas";
            ((System.ComponentModel.ISupportInitialize)(this.dtgApuestas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgApuestas;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnCorreo;
    }
}
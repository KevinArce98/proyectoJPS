namespace JPS.Vistas
{
    partial class frmConfiguracion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMonto = new System.Windows.Forms.MaskedTextBox();
            this.btnGuardarDinero = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Favorecidos = new System.Windows.Forms.GroupBox();
            this.btnGuardarFavo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSorteo = new System.Windows.Forms.ComboBox();
            this.txtNumero3 = new System.Windows.Forms.MaskedTextBox();
            this.txtNumero2 = new System.Windows.Forms.MaskedTextBox();
            this.txtNumero1 = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.Favorecidos.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMonto);
            this.groupBox1.Controls.Add(this.btnGuardarDinero);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dinero";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(71, 13);
            this.txtMonto.Mask = "9999999999";
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(123, 20);
            this.txtMonto.TabIndex = 6;
            // 
            // btnGuardarDinero
            // 
            this.btnGuardarDinero.Location = new System.Drawing.Point(119, 47);
            this.btnGuardarDinero.Name = "btnGuardarDinero";
            this.btnGuardarDinero.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarDinero.TabIndex = 2;
            this.btnGuardarDinero.Text = "Guardar";
            this.btnGuardarDinero.UseVisualStyleBackColor = true;
            this.btnGuardarDinero.Click += new System.EventHandler(this.btnGuardarDinero_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monto casa:";
            // 
            // Favorecidos
            // 
            this.Favorecidos.Controls.Add(this.btnGuardarFavo);
            this.Favorecidos.Controls.Add(this.label5);
            this.Favorecidos.Controls.Add(this.cmbSorteo);
            this.Favorecidos.Controls.Add(this.txtNumero3);
            this.Favorecidos.Controls.Add(this.txtNumero2);
            this.Favorecidos.Controls.Add(this.txtNumero1);
            this.Favorecidos.Controls.Add(this.label4);
            this.Favorecidos.Controls.Add(this.label3);
            this.Favorecidos.Controls.Add(this.label2);
            this.Favorecidos.Location = new System.Drawing.Point(21, 94);
            this.Favorecidos.Name = "Favorecidos";
            this.Favorecidos.Size = new System.Drawing.Size(329, 121);
            this.Favorecidos.TabIndex = 1;
            this.Favorecidos.TabStop = false;
            this.Favorecidos.Text = "Favorecidos";
            // 
            // btnGuardarFavo
            // 
            this.btnGuardarFavo.Location = new System.Drawing.Point(231, 84);
            this.btnGuardarFavo.Name = "btnGuardarFavo";
            this.btnGuardarFavo.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarFavo.TabIndex = 7;
            this.btnGuardarFavo.Text = "Guardar";
            this.btnGuardarFavo.UseVisualStyleBackColor = true;
            this.btnGuardarFavo.Click += new System.EventHandler(this.btnGuardarFavo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sorteo:";
            // 
            // cmbSorteo
            // 
            this.cmbSorteo.FormattingEnabled = true;
            this.cmbSorteo.Location = new System.Drawing.Point(67, 86);
            this.cmbSorteo.Name = "cmbSorteo";
            this.cmbSorteo.Size = new System.Drawing.Size(124, 21);
            this.cmbSorteo.TabIndex = 7;
            this.cmbSorteo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbSorteo_KeyPress);
            // 
            // txtNumero3
            // 
            this.txtNumero3.Location = new System.Drawing.Point(68, 60);
            this.txtNumero3.Mask = "99";
            this.txtNumero3.Name = "txtNumero3";
            this.txtNumero3.Size = new System.Drawing.Size(123, 20);
            this.txtNumero3.TabIndex = 5;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(69, 36);
            this.txtNumero2.Mask = "99";
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(123, 20);
            this.txtNumero2.TabIndex = 4;
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(68, 13);
            this.txtNumero1.Mask = "99";
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(123, 20);
            this.txtNumero1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Numero 3:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Numero 2:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Numero 1:";
            // 
            // frmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 223);
            this.Controls.Add(this.Favorecidos);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmConfiguracion";
            this.Text = "frmConfiguracion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Favorecidos.ResumeLayout(false);
            this.Favorecidos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtMonto;
        private System.Windows.Forms.Button btnGuardarDinero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Favorecidos;
        private System.Windows.Forms.Button btnGuardarFavo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbSorteo;
        private System.Windows.Forms.MaskedTextBox txtNumero3;
        private System.Windows.Forms.MaskedTextBox txtNumero2;
        private System.Windows.Forms.MaskedTextBox txtNumero1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
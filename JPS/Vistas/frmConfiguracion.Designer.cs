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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGuardarFavo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSorteo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumero3 = new System.Windows.Forms.MaskedTextBox();
            this.txtNumero1 = new System.Windows.Forms.MaskedTextBox();
            this.txtNumero2 = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGuardarFavo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmbSorteo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtNumero3);
            this.groupBox2.Controls.Add(this.txtNumero1);
            this.groupBox2.Controls.Add(this.txtNumero2);
            this.groupBox2.Location = new System.Drawing.Point(12, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 198);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Favorecidos";
            // 
            // btnGuardarFavo
            // 
            this.btnGuardarFavo.Location = new System.Drawing.Point(115, 151);
            this.btnGuardarFavo.Name = "btnGuardarFavo";
            this.btnGuardarFavo.Size = new System.Drawing.Size(87, 29);
            this.btnGuardarFavo.TabIndex = 15;
            this.btnGuardarFavo.Text = "Guardar";
            this.btnGuardarFavo.UseVisualStyleBackColor = true;
            this.btnGuardarFavo.Click += new System.EventHandler(this.btnGuardarFavo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Numero 1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Sorteo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Numero 2:";
            // 
            // cmbSorteo
            // 
            this.cmbSorteo.FormattingEnabled = true;
            this.cmbSorteo.Location = new System.Drawing.Point(77, 98);
            this.cmbSorteo.Name = "cmbSorteo";
            this.cmbSorteo.Size = new System.Drawing.Size(199, 21);
            this.cmbSorteo.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Numero 3:";
            // 
            // txtNumero3
            // 
            this.txtNumero3.Location = new System.Drawing.Point(78, 72);
            this.txtNumero3.Mask = "99";
            this.txtNumero3.Name = "txtNumero3";
            this.txtNumero3.Size = new System.Drawing.Size(198, 20);
            this.txtNumero3.TabIndex = 14;
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(78, 25);
            this.txtNumero1.Mask = "99";
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(198, 20);
            this.txtNumero1.TabIndex = 12;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(79, 48);
            this.txtNumero2.Mask = "99";
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(197, 20);
            this.txtNumero2.TabIndex = 13;
            // 
            // frmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 307);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmConfiguracion";
            this.Text = "frmConfiguracion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtMonto;
        private System.Windows.Forms.Button btnGuardarDinero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGuardarFavo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSorteo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtNumero3;
        private System.Windows.Forms.MaskedTextBox txtNumero1;
        private System.Windows.Forms.MaskedTextBox txtNumero2;
    }
}
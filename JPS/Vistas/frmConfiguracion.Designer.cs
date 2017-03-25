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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPeor = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbSor = new System.Windows.Forms.ComboBox();
            this.btnProbar = new System.Windows.Forms.Button();
            this.txtMaxima = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMinima = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.cmbSorteo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtPeor);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(231, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(334, 70);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Montos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Para premios en el peor de los casos";
            // 
            // txtPeor
            // 
            this.txtPeor.Location = new System.Drawing.Point(199, 29);
            this.txtPeor.Name = "txtPeor";
            this.txtPeor.ReadOnly = true;
            this.txtPeor.Size = new System.Drawing.Size(129, 20);
            this.txtPeor.TabIndex = 1;
            this.txtPeor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtMinima);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtMaxima);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.btnProbar);
            this.groupBox4.Controls.Add(this.cmbSor);
            this.groupBox4.Location = new System.Drawing.Point(315, 94);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(250, 198);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ganancias";
            // 
            // cmbSor
            // 
            this.cmbSor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSor.FormattingEnabled = true;
            this.cmbSor.Location = new System.Drawing.Point(9, 43);
            this.cmbSor.Name = "cmbSor";
            this.cmbSor.Size = new System.Drawing.Size(121, 21);
            this.cmbSor.TabIndex = 0;
            // 
            // btnProbar
            // 
            this.btnProbar.Location = new System.Drawing.Point(154, 41);
            this.btnProbar.Name = "btnProbar";
            this.btnProbar.Size = new System.Drawing.Size(82, 23);
            this.btnProbar.TabIndex = 1;
            this.btnProbar.Text = "Probalidades";
            this.btnProbar.UseVisualStyleBackColor = true;
            this.btnProbar.Click += new System.EventHandler(this.btnProbar_Click);
            // 
            // txtMaxima
            // 
            this.txtMaxima.Location = new System.Drawing.Point(107, 89);
            this.txtMaxima.Name = "txtMaxima";
            this.txtMaxima.ReadOnly = true;
            this.txtMaxima.Size = new System.Drawing.Size(129, 20);
            this.txtMaxima.TabIndex = 3;
            this.txtMaxima.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Ganancia Maxima:";
            // 
            // txtMinima
            // 
            this.txtMinima.Location = new System.Drawing.Point(107, 118);
            this.txtMinima.Name = "txtMinima";
            this.txtMinima.ReadOnly = true;
            this.txtMinima.Size = new System.Drawing.Size(129, 20);
            this.txtMinima.TabIndex = 5;
            this.txtMinima.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Ganancia Minima:";
            // 
            // frmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 307);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmConfiguracion";
            this.Text = "Configuración";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtPeor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtMinima;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaxima;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnProbar;
        private System.Windows.Forms.ComboBox cmbSor;
    }
}
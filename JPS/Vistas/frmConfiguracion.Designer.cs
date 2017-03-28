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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguracion));
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
            this.label10 = new System.Windows.Forms.Label();
            this.txtPeor = new System.Windows.Forms.TextBox();
            this.cmbSorteoPeor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMinima = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaxima = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbSor = new System.Windows.Forms.ComboBox();
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
            this.groupBox1.Location = new System.Drawing.Point(16, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(267, 99);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dinero";
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtMonto.Location = new System.Drawing.Point(95, 17);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(4);
            this.txtMonto.Mask = "9999999999";
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(163, 27);
            this.txtMonto.TabIndex = 6;
            // 
            // btnGuardarDinero
            // 
            this.btnGuardarDinero.Font = new System.Drawing.Font("Segoe Print", 9.75F);
            this.btnGuardarDinero.Image = global::JPS.Properties.Resources._1490598392_floppy_disk_save;
            this.btnGuardarDinero.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarDinero.Location = new System.Drawing.Point(151, 54);
            this.btnGuardarDinero.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarDinero.Name = "btnGuardarDinero";
            this.btnGuardarDinero.Size = new System.Drawing.Size(108, 38);
            this.btnGuardarDinero.TabIndex = 2;
            this.btnGuardarDinero.Text = "Guardar";
            this.btnGuardarDinero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarDinero.UseVisualStyleBackColor = true;
            this.btnGuardarDinero.Click += new System.EventHandler(this.btnGuardarDinero_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 11.25F);
            this.label1.Location = new System.Drawing.Point(8, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
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
            this.groupBox2.Font = new System.Drawing.Font("Modern No. 20", 11.25F);
            this.groupBox2.Location = new System.Drawing.Point(16, 123);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(396, 215);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Favorecidos";
            // 
            // btnGuardarFavo
            // 
            this.btnGuardarFavo.Font = new System.Drawing.Font("Segoe Print", 9.75F);
            this.btnGuardarFavo.Image = global::JPS.Properties.Resources._1490598392_floppy_disk_save;
            this.btnGuardarFavo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarFavo.Location = new System.Drawing.Point(159, 172);
            this.btnGuardarFavo.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarFavo.Name = "btnGuardarFavo";
            this.btnGuardarFavo.Size = new System.Drawing.Size(108, 38);
            this.btnGuardarFavo.TabIndex = 15;
            this.btnGuardarFavo.Text = "Guardar";
            this.btnGuardarFavo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarFavo.UseVisualStyleBackColor = true;
            this.btnGuardarFavo.Click += new System.EventHandler(this.btnGuardarFavo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 11.25F);
            this.label2.Location = new System.Drawing.Point(21, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Numero 1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 11.25F);
            this.label5.Location = new System.Drawing.Point(21, 132);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Sorteo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 11.25F);
            this.label3.Location = new System.Drawing.Point(21, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Numero 2:";
            // 
            // cmbSorteo
            // 
            this.cmbSorteo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSorteo.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cmbSorteo.FormattingEnabled = true;
            this.cmbSorteo.Location = new System.Drawing.Point(103, 128);
            this.cmbSorteo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSorteo.Name = "cmbSorteo";
            this.cmbSorteo.Size = new System.Drawing.Size(264, 28);
            this.cmbSorteo.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 11.25F);
            this.label4.Location = new System.Drawing.Point(21, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Numero 3:";
            // 
            // txtNumero3
            // 
            this.txtNumero3.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtNumero3.Location = new System.Drawing.Point(104, 94);
            this.txtNumero3.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumero3.Mask = "99";
            this.txtNumero3.Name = "txtNumero3";
            this.txtNumero3.Size = new System.Drawing.Size(263, 27);
            this.txtNumero3.TabIndex = 14;
            // 
            // txtNumero1
            // 
            this.txtNumero1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtNumero1.Location = new System.Drawing.Point(104, 33);
            this.txtNumero1.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumero1.Mask = "99";
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(263, 27);
            this.txtNumero1.TabIndex = 12;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtNumero2.Location = new System.Drawing.Point(105, 63);
            this.txtNumero2.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumero2.Mask = "99";
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(261, 27);
            this.txtNumero2.TabIndex = 13;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtPeor);
            this.groupBox3.Controls.Add(this.cmbSorteoPeor);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(308, 16);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(445, 92);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Montos";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 11.25F);
            this.label10.Location = new System.Drawing.Point(188, 29);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Sorteo:";
            // 
            // txtPeor
            // 
            this.txtPeor.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtPeor.Location = new System.Drawing.Point(256, 58);
            this.txtPeor.Margin = new System.Windows.Forms.Padding(4);
            this.txtPeor.Name = "txtPeor";
            this.txtPeor.ReadOnly = true;
            this.txtPeor.Size = new System.Drawing.Size(171, 27);
            this.txtPeor.TabIndex = 1;
            this.txtPeor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbSorteoPeor
            // 
            this.cmbSorteoPeor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSorteoPeor.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cmbSorteoPeor.FormattingEnabled = true;
            this.cmbSorteoPeor.Location = new System.Drawing.Point(256, 25);
            this.cmbSorteoPeor.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSorteoPeor.Name = "cmbSorteoPeor";
            this.cmbSorteoPeor.Size = new System.Drawing.Size(171, 28);
            this.cmbSorteoPeor.TabIndex = 7;
            this.cmbSorteoPeor.SelectedIndexChanged += new System.EventHandler(this.cmbSorteoPeor_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 11.25F);
            this.label6.Location = new System.Drawing.Point(8, 61);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Para premios en el peor de los casos";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtMinima);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtMaxima);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.cmbSor);
            this.groupBox4.Font = new System.Drawing.Font("Modern No. 20", 11.25F);
            this.groupBox4.Location = new System.Drawing.Point(420, 123);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(333, 215);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ganancias";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 11.25F);
            this.label9.Location = new System.Drawing.Point(40, 47);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Sorteo:";
            // 
            // txtMinima
            // 
            this.txtMinima.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtMinima.Location = new System.Drawing.Point(139, 132);
            this.txtMinima.Margin = new System.Windows.Forms.Padding(4);
            this.txtMinima.Name = "txtMinima";
            this.txtMinima.ReadOnly = true;
            this.txtMinima.Size = new System.Drawing.Size(165, 27);
            this.txtMinima.TabIndex = 5;
            this.txtMinima.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 11.25F);
            this.label8.Location = new System.Drawing.Point(8, 136);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Ganancia Mínima:";
            // 
            // txtMaxima
            // 
            this.txtMaxima.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtMaxima.Location = new System.Drawing.Point(139, 94);
            this.txtMaxima.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaxima.Name = "txtMaxima";
            this.txtMaxima.ReadOnly = true;
            this.txtMaxima.Size = new System.Drawing.Size(165, 27);
            this.txtMaxima.TabIndex = 3;
            this.txtMaxima.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 11.25F);
            this.label7.Location = new System.Drawing.Point(8, 98);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Ganancia Máxima:";
            // 
            // cmbSor
            // 
            this.cmbSor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSor.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cmbSor.FormattingEnabled = true;
            this.cmbSor.Location = new System.Drawing.Point(139, 37);
            this.cmbSor.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSor.Name = "cmbSor";
            this.cmbSor.Size = new System.Drawing.Size(165, 28);
            this.cmbSor.TabIndex = 0;
            this.cmbSor.SelectedIndexChanged += new System.EventHandler(this.cmbSor_SelectedIndexChanged);
            // 
            // frmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 346);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Modern No. 20", 11.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.ComboBox cmbSor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbSorteoPeor;
        private System.Windows.Forms.Label label9;
    }
}
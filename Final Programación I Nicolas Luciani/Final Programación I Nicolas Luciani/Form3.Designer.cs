namespace Final_Programación_I_Nicolas_Luciani
{
    partial class Form3
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
            this.lblMother = new System.Windows.Forms.Label();
            this.lblRam = new System.Windows.Forms.Label();
            this.lblMicro = new System.Windows.Forms.Label();
            this.lblHdd = new System.Windows.Forms.Label();
            this.lblGabinete = new System.Windows.Forms.Label();
            this.lblMonitor = new System.Windows.Forms.Label();
            this.lblFuente = new System.Windows.Forms.Label();
            this.lblKit = new System.Windows.Forms.Label();
            this.cmbMother = new System.Windows.Forms.ComboBox();
            this.cmbRam = new System.Windows.Forms.ComboBox();
            this.cmbMicro = new System.Windows.Forms.ComboBox();
            this.cmbHdd = new System.Windows.Forms.ComboBox();
            this.cmbGabinete = new System.Windows.Forms.ComboBox();
            this.cmbMonitor = new System.Windows.Forms.ComboBox();
            this.txtFuente = new System.Windows.Forms.TextBox();
            this.txtKit = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMother
            // 
            this.lblMother.AutoSize = true;
            this.lblMother.Location = new System.Drawing.Point(12, 23);
            this.lblMother.Name = "lblMother";
            this.lblMother.Size = new System.Drawing.Size(67, 13);
            this.lblMother.TabIndex = 0;
            this.lblMother.Text = "Motherboard";
            // 
            // lblRam
            // 
            this.lblRam.AutoSize = true;
            this.lblRam.Location = new System.Drawing.Point(12, 65);
            this.lblRam.Name = "lblRam";
            this.lblRam.Size = new System.Drawing.Size(31, 13);
            this.lblRam.TabIndex = 1;
            this.lblRam.Text = "RAM";
            // 
            // lblMicro
            // 
            this.lblMicro.AutoSize = true;
            this.lblMicro.Location = new System.Drawing.Point(12, 110);
            this.lblMicro.Name = "lblMicro";
            this.lblMicro.Size = new System.Drawing.Size(86, 13);
            this.lblMicro.TabIndex = 2;
            this.lblMicro.Text = "Microprocesador";
            // 
            // lblHdd
            // 
            this.lblHdd.AutoSize = true;
            this.lblHdd.Location = new System.Drawing.Point(12, 146);
            this.lblHdd.Name = "lblHdd";
            this.lblHdd.Size = new System.Drawing.Size(31, 13);
            this.lblHdd.TabIndex = 3;
            this.lblHdd.Text = "HDD";
            // 
            // lblGabinete
            // 
            this.lblGabinete.AutoSize = true;
            this.lblGabinete.Location = new System.Drawing.Point(12, 187);
            this.lblGabinete.Name = "lblGabinete";
            this.lblGabinete.Size = new System.Drawing.Size(50, 13);
            this.lblGabinete.TabIndex = 4;
            this.lblGabinete.Text = "Gabinete";
            // 
            // lblMonitor
            // 
            this.lblMonitor.AutoSize = true;
            this.lblMonitor.Location = new System.Drawing.Point(12, 226);
            this.lblMonitor.Name = "lblMonitor";
            this.lblMonitor.Size = new System.Drawing.Size(42, 13);
            this.lblMonitor.TabIndex = 5;
            this.lblMonitor.Text = "Monitor";
            // 
            // lblFuente
            // 
            this.lblFuente.AutoSize = true;
            this.lblFuente.Location = new System.Drawing.Point(12, 266);
            this.lblFuente.Name = "lblFuente";
            this.lblFuente.Size = new System.Drawing.Size(40, 13);
            this.lblFuente.TabIndex = 6;
            this.lblFuente.Text = "Fuente";
            // 
            // lblKit
            // 
            this.lblKit.AutoSize = true;
            this.lblKit.Location = new System.Drawing.Point(12, 307);
            this.lblKit.Name = "lblKit";
            this.lblKit.Size = new System.Drawing.Size(169, 13);
            this.lblKit.TabIndex = 7;
            this.lblKit.Text = "KIT Mouse + Teclado + Parlantes ";
            // 
            // cmbMother
            // 
            this.cmbMother.FormattingEnabled = true;
            this.cmbMother.Location = new System.Drawing.Point(270, 23);
            this.cmbMother.Name = "cmbMother";
            this.cmbMother.Size = new System.Drawing.Size(175, 21);
            this.cmbMother.TabIndex = 8;
            this.cmbMother.SelectedIndexChanged += new System.EventHandler(this.cmbMother_SelectedIndexChanged);
            // 
            // cmbRam
            // 
            this.cmbRam.FormattingEnabled = true;
            this.cmbRam.Location = new System.Drawing.Point(270, 65);
            this.cmbRam.Name = "cmbRam";
            this.cmbRam.Size = new System.Drawing.Size(175, 21);
            this.cmbRam.TabIndex = 9;
            this.cmbRam.SelectedIndexChanged += new System.EventHandler(this.cmbRam_SelectedIndexChanged);
            // 
            // cmbMicro
            // 
            this.cmbMicro.FormattingEnabled = true;
            this.cmbMicro.Location = new System.Drawing.Point(270, 110);
            this.cmbMicro.Name = "cmbMicro";
            this.cmbMicro.Size = new System.Drawing.Size(175, 21);
            this.cmbMicro.TabIndex = 10;
            this.cmbMicro.SelectedIndexChanged += new System.EventHandler(this.cmbMicro_SelectedIndexChanged);
            // 
            // cmbHdd
            // 
            this.cmbHdd.FormattingEnabled = true;
            this.cmbHdd.Location = new System.Drawing.Point(270, 146);
            this.cmbHdd.Name = "cmbHdd";
            this.cmbHdd.Size = new System.Drawing.Size(175, 21);
            this.cmbHdd.TabIndex = 11;
            this.cmbHdd.SelectedIndexChanged += new System.EventHandler(this.cmbHdd_SelectedIndexChanged);
            // 
            // cmbGabinete
            // 
            this.cmbGabinete.FormattingEnabled = true;
            this.cmbGabinete.Location = new System.Drawing.Point(270, 187);
            this.cmbGabinete.Name = "cmbGabinete";
            this.cmbGabinete.Size = new System.Drawing.Size(175, 21);
            this.cmbGabinete.TabIndex = 12;
            this.cmbGabinete.SelectedIndexChanged += new System.EventHandler(this.cmbGabinete_SelectedIndexChanged);
            // 
            // cmbMonitor
            // 
            this.cmbMonitor.FormattingEnabled = true;
            this.cmbMonitor.Location = new System.Drawing.Point(270, 226);
            this.cmbMonitor.Name = "cmbMonitor";
            this.cmbMonitor.Size = new System.Drawing.Size(175, 21);
            this.cmbMonitor.TabIndex = 13;
            this.cmbMonitor.SelectedIndexChanged += new System.EventHandler(this.cmbMonitor_SelectedIndexChanged);
            // 
            // txtFuente
            // 
            this.txtFuente.Location = new System.Drawing.Point(270, 266);
            this.txtFuente.Name = "txtFuente";
            this.txtFuente.ReadOnly = true;
            this.txtFuente.Size = new System.Drawing.Size(100, 20);
            this.txtFuente.TabIndex = 14;
            this.txtFuente.Text = "$500";
            // 
            // txtKit
            // 
            this.txtKit.Location = new System.Drawing.Point(270, 307);
            this.txtKit.Name = "txtKit";
            this.txtKit.ReadOnly = true;
            this.txtKit.Size = new System.Drawing.Size(100, 20);
            this.txtKit.TabIndex = 15;
            this.txtKit.Text = "$300";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(151, 359);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(96, 37);
            this.btnCalcular.TabIndex = 16;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 409);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtKit);
            this.Controls.Add(this.txtFuente);
            this.Controls.Add(this.cmbMonitor);
            this.Controls.Add(this.cmbGabinete);
            this.Controls.Add(this.cmbHdd);
            this.Controls.Add(this.cmbMicro);
            this.Controls.Add(this.cmbRam);
            this.Controls.Add(this.cmbMother);
            this.Controls.Add(this.lblKit);
            this.Controls.Add(this.lblFuente);
            this.Controls.Add(this.lblMonitor);
            this.Controls.Add(this.lblGabinete);
            this.Controls.Add(this.lblHdd);
            this.Controls.Add(this.lblMicro);
            this.Controls.Add(this.lblRam);
            this.Controls.Add(this.lblMother);
            this.Name = "Form3";
            this.Text = "Armado de PC";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMother;
        private System.Windows.Forms.Label lblRam;
        private System.Windows.Forms.Label lblMicro;
        private System.Windows.Forms.Label lblHdd;
        private System.Windows.Forms.Label lblGabinete;
        private System.Windows.Forms.Label lblMonitor;
        private System.Windows.Forms.Label lblFuente;
        private System.Windows.Forms.Label lblKit;
        private System.Windows.Forms.ComboBox cmbMother;
        private System.Windows.Forms.ComboBox cmbRam;
        private System.Windows.Forms.ComboBox cmbMicro;
        private System.Windows.Forms.ComboBox cmbHdd;
        private System.Windows.Forms.ComboBox cmbGabinete;
        private System.Windows.Forms.ComboBox cmbMonitor;
        private System.Windows.Forms.TextBox txtFuente;
        private System.Windows.Forms.TextBox txtKit;
        private System.Windows.Forms.Button btnCalcular;
    }
}
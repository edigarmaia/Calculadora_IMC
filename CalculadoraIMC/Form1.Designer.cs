namespace CalculadoraIMC
{
    partial class Form1
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
            this.lbPeso = new System.Windows.Forms.Label();
            this.tbPeso = new System.Windows.Forms.TextBox();
            this.lbAltura = new System.Windows.Forms.Label();
            this.tbAltura = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.gpbIMC = new System.Windows.Forms.GroupBox();
            this.rbtObesidadeIII = new System.Windows.Forms.RadioButton();
            this.rbtObesidadeII = new System.Windows.Forms.RadioButton();
            this.rbtObesidadeI = new System.Windows.Forms.RadioButton();
            this.rbtAcimaPeso = new System.Windows.Forms.RadioButton();
            this.rbtPesoIdeal = new System.Windows.Forms.RadioButton();
            this.rbtAbaixoPeso = new System.Windows.Forms.RadioButton();
            this.rbtMabaixoPeso = new System.Windows.Forms.RadioButton();
            this.gpbIMC.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPeso
            // 
            this.lbPeso.AutoSize = true;
            this.lbPeso.Location = new System.Drawing.Point(17, 18);
            this.lbPeso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPeso.Name = "lbPeso";
            this.lbPeso.Size = new System.Drawing.Size(55, 13);
            this.lbPeso.TabIndex = 0;
            this.lbPeso.Text = "Peso (kg):";
            // 
            // tbPeso
            // 
            this.tbPeso.Location = new System.Drawing.Point(83, 18);
            this.tbPeso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPeso.Name = "tbPeso";
            this.tbPeso.Size = new System.Drawing.Size(97, 20);
            this.tbPeso.TabIndex = 1;
            // 
            // lbAltura
            // 
            this.lbAltura.AutoSize = true;
            this.lbAltura.Location = new System.Drawing.Point(17, 46);
            this.lbAltura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAltura.Name = "lbAltura";
            this.lbAltura.Size = new System.Drawing.Size(54, 13);
            this.lbAltura.TabIndex = 2;
            this.lbAltura.Text = "Altura (m):";
            // 
            // tbAltura
            // 
            this.tbAltura.Location = new System.Drawing.Point(83, 44);
            this.tbAltura.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbAltura.Name = "tbAltura";
            this.tbAltura.Size = new System.Drawing.Size(97, 20);
            this.tbAltura.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.Window;
            this.btnCalcular.Location = new System.Drawing.Point(19, 73);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(159, 153);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcule";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // gpbIMC
            // 
            this.gpbIMC.Controls.Add(this.rbtMabaixoPeso);
            this.gpbIMC.Controls.Add(this.rbtObesidadeIII);
            this.gpbIMC.Controls.Add(this.rbtObesidadeII);
            this.gpbIMC.Controls.Add(this.rbtObesidadeI);
            this.gpbIMC.Controls.Add(this.rbtAcimaPeso);
            this.gpbIMC.Controls.Add(this.rbtPesoIdeal);
            this.gpbIMC.Controls.Add(this.rbtAbaixoPeso);
            this.gpbIMC.Location = new System.Drawing.Point(205, 18);
            this.gpbIMC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbIMC.Name = "gpbIMC";
            this.gpbIMC.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbIMC.Size = new System.Drawing.Size(244, 208);
            this.gpbIMC.TabIndex = 5;
            this.gpbIMC.TabStop = false;
            this.gpbIMC.Text = "IMC";
            // 
            // rbtObesidadeIII
            // 
            this.rbtObesidadeIII.AutoSize = true;
            this.rbtObesidadeIII.Location = new System.Drawing.Point(13, 182);
            this.rbtObesidadeIII.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtObesidadeIII.Name = "rbtObesidadeIII";
            this.rbtObesidadeIII.Size = new System.Drawing.Size(88, 17);
            this.rbtObesidadeIII.TabIndex = 6;
            this.rbtObesidadeIII.Text = "Obesidade III";
            this.rbtObesidadeIII.UseVisualStyleBackColor = true;
            // 
            // rbtObesidadeII
            // 
            this.rbtObesidadeII.AutoSize = true;
            this.rbtObesidadeII.Location = new System.Drawing.Point(13, 153);
            this.rbtObesidadeII.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtObesidadeII.Name = "rbtObesidadeII";
            this.rbtObesidadeII.Size = new System.Drawing.Size(85, 17);
            this.rbtObesidadeII.TabIndex = 5;
            this.rbtObesidadeII.Text = "Obesidade II";
            this.rbtObesidadeII.UseVisualStyleBackColor = true;
            // 
            // rbtObesidadeI
            // 
            this.rbtObesidadeI.AutoSize = true;
            this.rbtObesidadeI.Location = new System.Drawing.Point(13, 123);
            this.rbtObesidadeI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtObesidadeI.Name = "rbtObesidadeI";
            this.rbtObesidadeI.Size = new System.Drawing.Size(82, 17);
            this.rbtObesidadeI.TabIndex = 4;
            this.rbtObesidadeI.Text = "Obesidade I";
            this.rbtObesidadeI.UseVisualStyleBackColor = true;
            // 
            // rbtAcimaPeso
            // 
            this.rbtAcimaPeso.AutoSize = true;
            this.rbtAcimaPeso.Location = new System.Drawing.Point(13, 95);
            this.rbtAcimaPeso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtAcimaPeso.Name = "rbtAcimaPeso";
            this.rbtAcimaPeso.Size = new System.Drawing.Size(95, 17);
            this.rbtAcimaPeso.TabIndex = 3;
            this.rbtAcimaPeso.Text = "Acima do peso";
            this.rbtAcimaPeso.UseVisualStyleBackColor = true;
            // 
            // rbtPesoIdeal
            // 
            this.rbtPesoIdeal.AutoSize = true;
            this.rbtPesoIdeal.Location = new System.Drawing.Point(13, 68);
            this.rbtPesoIdeal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtPesoIdeal.Name = "rbtPesoIdeal";
            this.rbtPesoIdeal.Size = new System.Drawing.Size(74, 17);
            this.rbtPesoIdeal.TabIndex = 2;
            this.rbtPesoIdeal.Text = "Peso ideal";
            this.rbtPesoIdeal.UseVisualStyleBackColor = true;
            // 
            // rbtAbaixoPeso
            // 
            this.rbtAbaixoPeso.AutoSize = true;
            this.rbtAbaixoPeso.Location = new System.Drawing.Point(13, 42);
            this.rbtAbaixoPeso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtAbaixoPeso.Name = "rbtAbaixoPeso";
            this.rbtAbaixoPeso.Size = new System.Drawing.Size(98, 17);
            this.rbtAbaixoPeso.TabIndex = 1;
            this.rbtAbaixoPeso.Text = "Abaixo do peso";
            this.rbtAbaixoPeso.UseVisualStyleBackColor = true;
            // 
            // rbtMabaixoPeso
            // 
            this.rbtMabaixoPeso.AutoSize = true;
            this.rbtMabaixoPeso.Location = new System.Drawing.Point(13, 18);
            this.rbtMabaixoPeso.Name = "rbtMabaixoPeso";
            this.rbtMabaixoPeso.Size = new System.Drawing.Size(126, 17);
            this.rbtMabaixoPeso.TabIndex = 7;
            this.rbtMabaixoPeso.TabStop = true;
            this.rbtMabaixoPeso.Text = "Muito abaixo do peso";
            this.rbtMabaixoPeso.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 285);
            this.Controls.Add(this.gpbIMC);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.tbAltura);
            this.Controls.Add(this.lbAltura);
            this.Controls.Add(this.tbPeso);
            this.Controls.Add(this.lbPeso);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Calculadora de IMC";
            this.gpbIMC.ResumeLayout(false);
            this.gpbIMC.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPeso;
        private System.Windows.Forms.TextBox tbPeso;
        private System.Windows.Forms.Label lbAltura;
        private System.Windows.Forms.TextBox tbAltura;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox gpbIMC;
        private System.Windows.Forms.RadioButton rbtAbaixoPeso;
        private System.Windows.Forms.RadioButton rbtPesoIdeal;
        private System.Windows.Forms.RadioButton rbtObesidadeIII;
        private System.Windows.Forms.RadioButton rbtObesidadeII;
        private System.Windows.Forms.RadioButton rbtObesidadeI;
        private System.Windows.Forms.RadioButton rbtAcimaPeso;
        private System.Windows.Forms.RadioButton rbtMabaixoPeso;
    }
}


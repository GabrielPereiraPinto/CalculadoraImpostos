namespace CalculadoraDeImpostos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ValorBruto = new System.Windows.Forms.TextBox();
            this.Ir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cofins = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Pis = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Csll = new System.Windows.Forms.TextBox();
            this.Texto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ValorLiquido = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ISS = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor Bruto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "IR";
            // 
            // ValorBruto
            // 
            this.ValorBruto.AccessibleName = "ValorBruto";
            this.ValorBruto.Location = new System.Drawing.Point(163, 27);
            this.ValorBruto.Name = "ValorBruto";
            this.ValorBruto.Size = new System.Drawing.Size(109, 20);
            this.ValorBruto.TabIndex = 2;
            this.ValorBruto.TextChanged += new System.EventHandler(this.ValorBruto_TextChange);
            // 
            // Ir
            // 
            this.Ir.AccessibleName = "IR";
            this.Ir.Location = new System.Drawing.Point(65, 119);
            this.Ir.Name = "Ir";
            this.Ir.Size = new System.Drawing.Size(100, 20);
            this.Ir.TabIndex = 3;
            this.Ir.TextChanged += new System.EventHandler(this.IR_TextChange);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cofins";
            // 
            // Cofins
            // 
            this.Cofins.AccessibleName = "Cofins";
            this.Cofins.Location = new System.Drawing.Point(267, 120);
            this.Cofins.Name = "Cofins";
            this.Cofins.Size = new System.Drawing.Size(100, 20);
            this.Cofins.TabIndex = 5;
            this.Cofins.TextChanged += new System.EventHandler(this.Cofins_TextChange);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pis";
            // 
            // Pis
            // 
            this.Pis.AccessibleName = "Pis";
            this.Pis.Location = new System.Drawing.Point(65, 177);
            this.Pis.Name = "Pis";
            this.Pis.Size = new System.Drawing.Size(100, 20);
            this.Pis.TabIndex = 7;
            this.Pis.TextChanged += new System.EventHandler(this.Pis_TextChange);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "CSLL";
            // 
            // Csll
            // 
            this.Csll.AccessibleName = "Csll";
            this.Csll.Location = new System.Drawing.Point(267, 177);
            this.Csll.Name = "Csll";
            this.Csll.Size = new System.Drawing.Size(100, 20);
            this.Csll.TabIndex = 9;
            this.Csll.TextChanged += new System.EventHandler(this.CSLL_TextChange);
            // 
            // Texto
            // 
            this.Texto.AccessibleName = "Texto";
            this.Texto.Location = new System.Drawing.Point(65, 283);
            this.Texto.Multiline = true;
            this.Texto.Name = "Texto";
            this.Texto.Size = new System.Drawing.Size(302, 69);
            this.Texto.TabIndex = 10;
            this.Texto.TextChanged += new System.EventHandler(this.Texto_TextChange);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 26);
            this.label6.TabIndex = 11;
            this.label6.Text = "Valor \r\nLiquido";
            // 
            // ValorLiquido
            // 
            this.ValorLiquido.AccessibleName = "ValorLiquido";
            this.ValorLiquido.Location = new System.Drawing.Point(65, 232);
            this.ValorLiquido.Name = "ValorLiquido";
            this.ValorLiquido.Size = new System.Drawing.Size(100, 20);
            this.ValorLiquido.TabIndex = 12;
            this.ValorLiquido.TextChanged += new System.EventHandler(this.ValorLiquido_TextChange);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(302, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Calcular);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(205, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "ISS";
            // 
            // ISS
            // 
            this.ISS.AccessibleName = "ISS";
            this.ISS.Location = new System.Drawing.Point(267, 231);
            this.ISS.Name = "ISS";
            this.ISS.Size = new System.Drawing.Size(100, 20);
            this.ISS.TabIndex = 15;
            this.ISS.TextChanged += new System.EventHandler(this.ISS_TextChanged);
            // 
            // Form1
            // 
            this.AccessibleName = "Calculadora de Impostos";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 379);
            this.Controls.Add(this.ISS);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ValorLiquido);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Texto);
            this.Controls.Add(this.Csll);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Pis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cofins);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Ir);
            this.Controls.Add(this.ValorBruto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculadora de Impostos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ValorBruto;
        private System.Windows.Forms.TextBox Ir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Cofins;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Pis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Csll;
        private System.Windows.Forms.TextBox Texto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ValorLiquido;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ISS;
    }
}


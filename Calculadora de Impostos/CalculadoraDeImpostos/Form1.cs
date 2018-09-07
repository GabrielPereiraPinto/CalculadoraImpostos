using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraDeImpostos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) { }
        private void Calcular(object sender, EventArgs e)
        {
            String valor = ValorBruto.Text;
            double bruto = Convert.ToDouble(valor);

            Ir.Text = Convert.ToString(Math.Round(bruto * 0.015, 2));
            Cofins.Text = Convert.ToString(Math.Round(bruto * 0.03, 2));
            Pis.Text = Convert.ToString(Math.Round(bruto * 0.0065, 2));
            Csll.Text = Convert.ToString(Math.Round(bruto * 0.01, 2)); ;
            ISS.Text= Convert.ToString(Math.Round(bruto * 0.02, 2));
            Texto.Text= "serviços médicos prestados" + Environment.NewLine + "valor aproximado total de tributos R$:" +" " +Convert.ToString(Math.Round(bruto * 0.0465,2));
            ValorLiquido.Text = Convert.ToString(Math.Round ((bruto - bruto * 0.015 - bruto * 0.03 - bruto * 0.0065 - bruto * 0.01 - bruto * 0.02), 2));
        }

        private void ValorBruto_TextChange(object sender, EventArgs e) {}
        private void IR_TextChange(object sender, EventArgs e) { }
        private void Cofins_TextChange(object sender, EventArgs e) { }
        private void Pis_TextChange(object sender, EventArgs e) { }
        private void CSLL_TextChange(object sender, EventArgs e) { }
        private void ValorLiquido_TextChange(object sender, EventArgs e) { }
        private void Texto_TextChange(object sender, EventArgs e) { }

        private void ISS_TextChanged(object sender, EventArgs e){}
    }
}

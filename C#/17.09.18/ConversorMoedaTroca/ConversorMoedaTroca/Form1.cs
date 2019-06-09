using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorMoedaTroca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Val_Click(object sender, EventArgs e)
        {

        }

        private void Txt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            //Definir as variaveis e inicializa-las
            decimal ValorCompra = 0;
            decimal ValorPago = 0;
            decimal Resto = 0;

            //Converter os valores de tela para os tipos
            //correspondentes das variaveis
            ValorCompra = Convert.ToDecimal(ValorDaCompra.Text);
            ValorPago = Convert.ToDecimal(ValorPagoEmDinheiro.Text);

            //calcular a diferença a ser devolvida
            //troco a ser devolvido
            Resto = ValorPago - ValorCompra;

            //deifinir e atribuir 
            int moedas1 = (int)(Resto / 1);
            Resto = Resto % 1;
            troco1.Text = moedas1.ToString();

            int moedas50 = (int)(Resto / 0.50m);
            Resto = Resto % 0.50m;
            troco50.Text = moedas50.ToString();

            int moedas25 = (int)(Resto / 0.25m);
            Resto = Resto % 0.25m;
            troco25.Text = moedas25.ToString();

            int moedas10 = (int)(Resto / 0.10m);
            Resto = Resto % 0.10m;
            troco10.Text = moedas10.ToString();

            int moedas5 = (int)(Resto / 0.05m);
            Resto = Resto % 0.05m;
            troco05.Text = moedas5.ToString();

            int moedas01 = (int)(Resto / 0.01m);
            Resto = Resto % 0.01m;
            troco01.Text = moedas01.ToString();

            TrocoFinal.Text =
                (moedas1 +
                moedas50 * 0.5 +
                moedas25 * 0.25 +
                moedas10 * 0.10 +
                moedas5 * 0.05 +
                moedas01 * 0.01).ToString("C2");
        }
    }
}

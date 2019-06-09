using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LeitorNumerosAleatorios
{
    public partial class LeitorNumerosAleatórios : Form
    {
        public LeitorNumerosAleatórios()
        {
            InitializeComponent();
        }

        private void BtnLerArquivo_Click(object sender, EventArgs e)
        {
            ofdAbrirArquivo.ShowDialog();
            if(ofdAbrirArquivo.ShowDialog() == DialogResult.OK)
            {
                double soma = 0;
                double contador = 0;
                double numero;

                StreamReader inputFile = new StreamReader(ofdAbrirArquivo.FileName);

                while (!inputFile.EndOfStream)
                {
                    numero = Convert.ToDouble(inputFile.ReadLine());
                    soma += numero;
                    contador++;

                    listaSaida.Items.Add(numero);
                }

                listaSaida.Items.Add("Total de números na lista: " + contador);
                listaSaida.Items.Add("Soma de todos de nùmero: " + soma);
            }
        }
    }
}

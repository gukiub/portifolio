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

namespace TotalVendas
{
    public partial class frmTotalVendas : Form
    {
        public frmTotalVendas()
        {
            InitializeComponent();
        }

        private void frmTotalVendas_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                String[] todasAsLinhas = File.ReadAllLines("E:/Uninove/C#/29.10.18/vendas.txt");
                double[] numeros = new double[todasAsLinhas.Length];
                int contador = 0;
                double soma = 0;

                foreach (String value in todasAsLinhas)
                {
                    numeros[contador] = Convert.ToDouble(value);
                    soma += numeros[contador];
                    listaSaida.Items.Add(numeros[contador]);
                    contador++;
                }
                listaSaida.Items.Add("\nValor Total: " + soma.ToString("n"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

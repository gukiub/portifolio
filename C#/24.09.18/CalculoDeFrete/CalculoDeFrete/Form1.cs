using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoDeFrete
{
    public partial class FormCalculaFrete : Form
    {
        public FormCalculaFrete()
        {
            InitializeComponent();
        }

        //metodo para calcular
        private void Calcular()
        {
            decimal valor = 0;
            decimal perc = 0;
            valor = Convert.ToDecimal(txtValor.Text);


            switch (listaUF.Text.ToUpper())
            {
                case "AM":
                    perc = 0.6m;
                    break;
                case "MG":
                    perc = 0.35m;
                    break;
                case "RJ":
                    perc = 0.3m;
                    break;
                case "SP":
                    perc = 0.2m;
                    break;
                default:
                    perc = 0.75m;
                    break;
            }
            txtValor.Text = valor.ToString("N2");
            labelFrete.Text = perc.ToString("P1");
            totallabel.Text = (valor * (1 + perc)).ToString("C2");
        }
            


        //metodo para limpar a tela
        private void LimparTela()
        {
            txtCliente.Clear();
            txtValor.Clear();
            listaUF.SelectedIndex = -1;
            labelFrete.Text = string.Empty;
            totallabel.Text = string.Empty;
            labelFrete.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

        }

        private void FormCalculaFrete_Load(object sender, EventArgs e)
        {

        }
    }
}

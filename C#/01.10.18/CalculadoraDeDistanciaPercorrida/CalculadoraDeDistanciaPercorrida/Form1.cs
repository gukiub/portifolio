using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraDeDistanciaPercorrida
{
    public partial class calcularKm : Form
    {
        public calcularKm()
        {
            InitializeComponent();
        }

      private void LimparTela() {

            txtVelocidade.Clear();
            txtHoras.Clear();
            listaSaida.ClearSelected();
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            int velocidade;
            int horas;
            int distancia;

            listaSaida.Items.Clear();

            if (int.TryParse(txtVelocidade.Text, out velocidade) && int.TryParse(txtHoras.Text, out horas))
            {
                for (int i = 1; i <= horas; i++)
                {
                    distancia = velocidade * i;
                    listaSaida.Items.Add("Depois da Hora " + i + " o veiculo viajou " + distancia.ToString("n") + " quilometros");
                }
            }

            else
                MessageBox.Show("Por favor, Digite valores válidos", "Entrada Inválida");
        }

        private void calcularKm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                LimparTela();
            }
        }


    }
}

using System;
using System.Windows.Forms;
using System.Drawing;

namespace CaminhaoTruck
{
    public partial class Corpo : Form
    {
        public Corpo()
        {
            InitializeComponent();
        }


        private void LimparCampos()
        {
            txtToneladas.Text = "";
            txtKm.Text = "";
            txtDespesas.Text = "";
            txtTempo.Text = "";
            txtLucro.Text = "";       
        }

        public double CalculaFrete(double frete)
        {
            double toneladas = Convert.ToDouble(txtToneladas.Text);

            if (toneladas == 12)
            {
                return frete += frete * 0.02;
            }
            else if (toneladas == 13)
            {
                return frete += frete * 0.03;
            }
            else if (toneladas == 14)
            {
                return frete += frete * 0.04;
            }
            else
            {
                return frete += frete * 0.05;
            }

        }

        private void Btn_Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                double toneladas = Convert.ToDouble(txtToneladas.Text);
                double km = Convert.ToDouble(txtKm.Text);
                double despesas = Convert.ToDouble(txtDespesas.Text);
                double tempo = Convert.ToDouble(txtTempo.Text);
                double lucro = Convert.ToDouble(txtLucro.Text);
                double frete = 3.89;
                double MaoDeObra = tempo * 150;
                double KmReais = km * CalculaFrete(frete);
                double Diaria = 150;
                double CustoViagem = KmReais + MaoDeObra;
                double Total = CustoViagem - despesas;
                double MargemLucro = (Total * 100) / CustoViagem;
                MargemLucro = Math.Round(MargemLucro, 1);
                double FretePKm = CalculaFrete(frete);
                string ValeApena;

                if (MargemLucro > 20)
                {
                    ValeApena = "Vale";
                }
                else
                {
                    ValeApena = "Não";
                }
                if (toneladas < 12 || toneladas > 15)
                {
                    MessageBox.Show("Insira um Número de 12 a 15", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dtView.Rows.Add(CustoViagem, KmReais, Total, MargemLucro + "%", FretePKm, Diaria, ValeApena);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor Preencha os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
  
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void BtnLimparCampos_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        

        private void Corpo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                LimparCampos();
            }
        }


       
        private void txtToneladas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void txtKm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void txtDespesas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void txtTempo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void txtLucro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void BtnLimparDados_Click(object sender, EventArgs e)
        {
  
            if (dtView.Rows.Count > 0)
            {
                if (MessageBox.Show("Deseja Mesmo Apagar esta linha ? ", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dtView.Rows.RemoveAt(dtView.CurrentRow.Index);
                }
            }
        }

        private void txtToneladas_TextChanged(object sender, EventArgs e)
        {
            if (txtToneladas.Text != string.Empty && txtToneladas.TextLength == 2)
            {
                double toneladas = Convert.ToDouble(txtToneladas.Text);
                if (toneladas < 12 || toneladas > 15)
                {
                    txtToneladas.BackColor = Color.Red;
                    txtToneladas.ForeColor = Color.White;
                    MessageBox.Show("Insira um Número de 12 a 15", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtToneladas.Clear();
                    txtToneladas.BackColor = Color.White;
                    txtToneladas.ForeColor = Color.Black;
                }
            }
        }
    }
}

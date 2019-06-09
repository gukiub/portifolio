using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using calculadora;

namespace AgendaDoAluno
{
    
   
    
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
            txtCampo.RightToLeft = RightToLeft.Yes;
            txtCampo.MaxLength = 20;
            
        }

        //Recebendo parâmetro com o usuário logado
        public Calculadora(string texto)
        {
            InitializeComponent();
            label3.Text = texto;
            txtCampo.RightToLeft = RightToLeft.Yes;
            txtCampo.MaxLength = 20;
        }

        //Criando um objeto da classe calc da dll calculadora
        calc contas = new calc();

        string escolha,valor1;
        bool posconta ;
        
        private void Calculadora_Load(object sender, EventArgs e)
        {

        }
       
        //Método para verificar a operação escolhida pelo usuário e calcular utilizando os métodos da dll calculadora
        private void operacaoescolhida()
        {
            
            try {
                switch (escolha)
                {
                    case "+":
                        txtCampo.Text = Convert.ToString(contas.Soma(Double.Parse(valor1), Double.Parse(txtCampo.Text)));

                        break;
                    case "-":
                        txtCampo.Text = Convert.ToString(contas.Sub(Double.Parse(valor1), Double.Parse(txtCampo.Text)));

                        break;
                    case "*":
                        txtCampo.Text = Convert.ToString(contas.Multi(Double.Parse(valor1), Double.Parse(txtCampo.Text)));
                        break;
                    case "/":
                        if (txtCampo.Text == "0")
                        {
                            txtCampo.Text = "Não é possível dividir por 0";
                        }
                        else
                        {
                            txtCampo.Text = Convert.ToString(contas.Div(Double.Parse(valor1), Double.Parse(txtCampo.Text)));
                        }
                            break;
                }
            
        
            }
            catch (Exception ex)
            {
                MessageBox.Show("Operação Inválida !","Erro !",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtCampo.Text = string.Empty;
            }
        }
        
        //Abrindo o form Calculadora
        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Calculadora a = new Calculadora(label3.Text);
            a.ShowDialog();
        }

        //Abrindo o form Alterarsenha
        private void alterarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AlterarSenha a = new AlterarSenha(label3.Text);
            a.ShowDialog();
        }

        //Abrindo o form ExcluirConta
        private void excluirContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ExcluirConta a = new ExcluirConta(label3.Text);
            a.ShowDialog();
        }

        
        //Fechando o programa
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        //Abrindo o form PosLogin
        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            PosLogin a = new PosLogin(label3.Text);
            a.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //text box txtcampo recebe o valor do botão
        private void btn7_Click(object sender, EventArgs e)
        {
            if (posconta == true)
            {
                txtCampo.Text += btn7.Text;
            }
            else
            {
                txtCampo.Text = btn7.Text;
                posconta = true;
            }
        }
        
        //text box txtcampo recebe o valor do botão
        private void btn8_Click(object sender, EventArgs e)
        {
            if (posconta == true)
            {
                txtCampo.Text += btn8.Text;
            }
            else
            {
                txtCampo.Text = btn8.Text;
                posconta = true;
            }
        }

        //text box txtcampo recebe o valor do botão
        private void btn9_Click(object sender, EventArgs e)
        {
            if (posconta == true)
            {
                txtCampo.Text += btn9.Text;
            }
            else
            {
                txtCampo.Text = btn9.Text;
                posconta = true;
            }
        }

        //text box txtcampo recebe o valor do botão
        private void btn4_Click(object sender, EventArgs e)
        {
            if (posconta == true)
            {
                txtCampo.Text += btn4.Text;
            }
            else
            {
                txtCampo.Text = btn4.Text;
                posconta = true;
            }
        }

        //text box txtcampo recebe o valor do botão
        private void btn5_Click(object sender, EventArgs e)
        {
            if (posconta == true)
            {
                txtCampo.Text += btn5.Text;
            }
            else
            {
                txtCampo.Text = btn5.Text;
                posconta = true;
            }
        }

        //text box txtcampo recebe o valor do botão
        private void btn6_Click(object sender, EventArgs e)
        {
            if (posconta == true)
            {
                txtCampo.Text += btn6.Text;
            }
            else
            {
                txtCampo.Text = btn6.Text;
                posconta = true;
            }
        }

        //text box txtcampo recebe o valor do botão
        private void btn1_Click(object sender, EventArgs e)
        {
            if (posconta == true)
            {
                txtCampo.Text += btn1.Text;
            }
            else
            {
                txtCampo.Text = btn1.Text;
                posconta = true;
            }
        }

        //text box txtcampo recebe o valor do botão
        private void btn2_Click(object sender, EventArgs e)
        {
            if (posconta == true)
            {
                txtCampo.Text += btn2.Text;
            }
            else
            {
                txtCampo.Text = btn2.Text;
                posconta = true;
            }
        }

        //text box txtcampo recebe o valor do botão
        private void btn3_Click(object sender, EventArgs e)
        {
            if (posconta == true)
            {
                txtCampo.Text += btn3.Text;
            }
            else
            {
                txtCampo.Text = btn3.Text;
                posconta = true;
            }
        }

        //text box txtcampo recebe o valor do botão
        private void btn0_Click(object sender, EventArgs e)
        {
            if (posconta == true)
            {
                txtCampo.Text += btn0.Text;
            }
            else
            {
                txtCampo.Text = btn0.Text;
                posconta = true;
            }
        }

        //Botao para limpar o campo txtCampo
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCampo.Text = string.Empty;
        }

        //text box txtcampo recebe o valor do botão
        private void btnPonto_Click(object sender, EventArgs e)
        {
            if (posconta == true)
            {
                txtCampo.Text += btnVirgula.Text;
            }
            else
            {
                txtCampo.Text = btnVirgula.Text;
                posconta = true;
            }
        }

        //botão parar excluir o último campo digitado pelo usuário
        private void btnBack_Click(object sender, EventArgs e)
        {
            string contacampos = txtCampo.Text;
            int excluicampo = contacampos.Length;
            if (contacampos.Length > 0)
            {
                txtCampo.Text = (contacampos.Substring(0, excluicampo - 1));
            }
            else
            {

            }
        }

        //Botao para fazer uma Divisão
        private void btnDiv_Click(object sender, EventArgs e)
        {
            valor1 = txtCampo.Text;
            txtCampo.Text = "";
            escolha = "/";
        }

        //Botão para fazer uma soma
        private void btnSoma_Click(object sender, EventArgs e)
        {
            valor1 = txtCampo.Text;
            txtCampo.Text = "";
            escolha = "+";
        }

        //botão para fazer uma subtração
        private void btnSub_Click(object sender, EventArgs e)
        {
            valor1 = txtCampo.Text;
            txtCampo.Text = "";
            escolha = "-";
        }

        //Botão para fazer uma multiplicação
        private void btnMulti_Click(object sender, EventArgs e)
        {
            valor1 = txtCampo.Text;
            txtCampo.Text = "";
            escolha = "*";
        }

        //Botão para Calcular os valores digitados pelo usuário e exibir
        private void btnIgual_Click(object sender, EventArgs e)
        {
            operacaoescolhida();
            posconta = false;
        }
    }
}

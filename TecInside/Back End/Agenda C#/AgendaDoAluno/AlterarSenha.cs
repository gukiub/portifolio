using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AgendaDoAluno
{
    public partial class AlterarSenha : Form
    {
        public AlterarSenha()
        {
            InitializeComponent();
            txtn2.PasswordChar = '*';
            txtn3.PasswordChar = '*';
        }
        
        conexaocomMysql conect = new conexaocomMysql();
        
        //Recebendo parâmetro com o usuário logado ao iniciar o form e mudando propriedades de alguns campos
        public AlterarSenha(string texto)
        {
            InitializeComponent();
            label3.Text = texto;
            txtn2.PasswordChar = '*';
            txtn3.PasswordChar = '*';
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel25_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AlterarSenha_Load(object sender, EventArgs e)
        {
            

        }

        //Abrindo o form Calculadora
        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Calculadora a = new Calculadora(label3.Text);
            a.ShowDialog();
        }

        //Abrindo o form AlterarSenha
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

        //Método para Alterar a Senha da conta do usuário
        private void alteraSenha()
        {

            try
            {
                string codigo2 = "select senha from login where usuario=@usuario";
                MySqlCommand comando2 = new MySqlCommand(codigo2, conect.conexao);
                comando2.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = label3.Text;
                MySqlDataReader dr = comando2.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    if (dr["senha"].ToString().Equals(txtAtual.Text.Trim()))
                    {
                        if ((MessageBox.Show("Deseja realmente alterar a senha da sua conta", "Confirmação ! ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                        {
                            dr.Close();
                            string codigo = "update login set senha=@senha where usuario=@usuario";
                            MySqlCommand comando = new MySqlCommand(codigo, conect.conexao);
                            comando.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = label3.Text.Trim();
                            comando.Parameters.Add("@senha", MySqlDbType.VarChar).Value = txtn2.Text.Trim();
                            comando.ExecuteNonQuery();
                            MessageBox.Show("Senha alterada com sucesso");
                            this.Visible = false;
                            Login a = new Login();
                            a.ShowDialog();
                        }
                        else
                        {
                            dr.Close();
                        }
                    }
                    else
                    {
                        dr.Close();
                        MessageBox.Show("Senha Incorreta","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    dr.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
            
        }

        //botão para alterar a senha do usuário
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtAtual.Text != string.Empty)
            {
                if (txtn2.Text.Equals(txtn3.Text))
                {
                    if (txtn2.Text != string.Empty || txtn3.Text != string.Empty)
                    {
                        
                      
                            alteraSenha();
                      
                    }
                    else
                    {
                        MessageBox.Show("Não é possível deixar a senha em branco","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
                else
                {
                    lblerro1.Visible = true;
                }

            }
            else
            {
                MessageBox.Show("Por favor, digite a senha atual da conta","Mensagem",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}

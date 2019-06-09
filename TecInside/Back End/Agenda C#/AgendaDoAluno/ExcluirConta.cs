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
    public partial class ExcluirConta : Form
    {
        public ExcluirConta()
        {
            InitializeComponent();
        }

        conexaocomMysql conect = new conexaocomMysql();

        //Recebendo parâmetro com o usuário logado ao iniciar o form
        public ExcluirConta(string texto)
        {
            InitializeComponent();
            label3.Text = texto;
        }

        private void ExcluirConta_Load(object sender, EventArgs e)
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

        //Abrindo o form Excluir Conta
        private void excluirContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ExcluirConta a = new ExcluirConta(label3.Text);
            a.ShowDialog();
        }

        

        //Fechando o Programa
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

        //Método Para deletar a conta do usuário
        public void deletaConta()
        {
            try
            {
                string codigo2 = "select senha from login where usuario=@usuario1";
                MySqlCommand comando2 = new MySqlCommand(codigo2, conect.conexao);
                comando2.Parameters.Add("@usuario1", MySqlDbType.VarChar).Value = label3.Text;
                MySqlDataReader dr = comando2.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {

                    if (dr["senha"].ToString().Equals(txtn1.Text.Trim()))
                    {
                        dr.Close();
                        string codigo = "delete from login where usuario=@usuario2";
                        MySqlCommand comando = new MySqlCommand(codigo, conect.conexao);
                        comando.Parameters.Add("@usuario2", MySqlDbType.VarChar).Value = label3.Text;
                        comando.ExecuteNonQuery();

                        string codigo3 = "delete from contatos where nomecriador=@usuario3";
                        MySqlCommand comando3 = new MySqlCommand(codigo3, conect.conexao);
                        comando3.Parameters.Add("@usuario3", MySqlDbType.VarChar).Value = label3.Text;
                        comando3.ExecuteNonQuery();

                        string codigo4 = "delete from anotacoes where nomecriador=@usuario4";
                        MySqlCommand comando4 = new MySqlCommand(codigo4, conect.conexao);
                        comando4.Parameters.Add("@usuario4", MySqlDbType.VarChar).Value = label3.Text;
                        comando4.ExecuteNonQuery();

                        this.Visible = false;
                        Login a = new Login();
                        a.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("Senha incorreta");
                        dr.Close();
                    }
                }
                else
                {
                    dr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Botão para verificar se o Usuário deseja excluir a conta dele, e excluir
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtn1.Text.Equals(txtn2.Text))
            {
                if (txtn2.Text != string.Empty && txtn1.Text != string.Empty)
                {
                    if (MessageBox.Show("Deseja Realmente excluir a sua conta?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {


                        deletaConta();
                    }
                }
                else
                {
                    MessageBox.Show("Por Favor, Insira a senha atual da sua conta","Mensagem",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("As duas senhas não coincidem", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

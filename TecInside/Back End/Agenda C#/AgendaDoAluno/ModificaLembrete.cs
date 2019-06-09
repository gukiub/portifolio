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
    public partial class ModificaLembrete : Form
    {
        public ModificaLembrete()
        {
            InitializeComponent();
        }
        
        //Recebendo parâmetro com o usuário logado ao iniciar o form
        public ModificaLembrete(string texto)
        {
            InitializeComponent();
            label3.Text = texto;
        }

        conexaocomMysql conect = new conexaocomMysql();

        //Abrindo o form PosLembretes
        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            PosLembretes a = new PosLembretes(label3.Text);
            a.ShowDialog();

        }

        //Método Para Excluir um Lembrete
        public void excluirlembrete()
        {
            try
            {
                if (txtCod.Text != String.Empty || txtData.Text != String.Empty || txtAgenda.Text != String.Empty)
                {
                    if (txtCod.Text != String.Empty)
                    {
                        if (MessageBox.Show("Tem certeza que deseja apagar esse lembrete ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            string codigo = "delete from anotacoes where id=@id";
                            MySqlCommand comando = new MySqlCommand(codigo, conect.conexao);
                            comando.Parameters.Add("@id", MySqlDbType.VarChar).Value = txtCod.Text.Trim();
                            comando.ExecuteNonQuery();
                            MessageBox.Show("Lembrete Excluido com sucesso", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtPesq.Text = String.Empty;
                            txtCod.Text = String.Empty;
                            txtData.Text = String.Empty;
                            txtAgenda.Text = String.Empty;
                            txtAssunto.Text = String.Empty;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Para Excluir um lembrete é necessário pesquisá-lo primeiro ! ","Mensagem",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Método para Consultar um Lembrete
        public void consultarlembrete()
        {

            try
            {
                if (txtPesq.Text != String.Empty)
                {
                    string codigo = "select id,data,lembrete,assunto from anotacoes where id=@id";
                    MySqlCommand comando = new MySqlCommand(codigo, conect.conexao);
                    comando.Parameters.Add("@id", MySqlDbType.VarChar).Value = txtPesq.Text.Trim();
                    MySqlDataReader dr = comando.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {

                        txtCod.Text = Convert.ToString(dr["id"]);
                        txtAssunto.Text = Convert.ToString(dr["assunto"]);
                        txtData.Text = Convert.ToString(dr["data"]);
                        txtAgenda.Text = Convert.ToString(dr["lembrete"]);

                        dr.Close();
                    }
                    else
                    {
                        MessageBox.Show("O lembrete pesquisado não existe","Mensagem",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        dr.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Para pesquisar é necessário digitar o id de um lembrete !", "Campo em Branco !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       
        //Método para Alterar os dados de um lembrete
        public void alterarlembrete()
        {
            try
            {


                string codigo1 = "select id,data,lembrete,assunto from anotacoes where nomecriador=@criador";
                MySqlCommand comando1 = new MySqlCommand(codigo1, conect.conexao);
                comando1.Parameters.Add("@criador", MySqlDbType.VarChar).Value = label3.Text;
                MySqlDataReader dr = comando1.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                    if (dr["id"].ToString().Equals(txtCod.Text.Trim()) && dr["data"].ToString().Equals(txtData.Text.Trim()) && dr["lembrete"].ToString().Equals(txtAgenda.Text.Trim()) && dr["assunto"].ToString().Equals(txtAssunto.Text.Trim()))
                    {
                        dr.Close();
                    }
                    else
                    {
                        dr.Close();
                        if (txtCod.Text != String.Empty || txtData.Text != String.Empty || txtAgenda.Text != String.Empty)
                        {
                            if (MessageBox.Show("Tem certeza que deseja alterar esse lembrete ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                dr.Close();
                                string codigo = "update anotacoes set data=@data,lembrete=@lembrete,assunto=@assunto where id=@id";
                                MySqlCommand comando = new MySqlCommand(codigo, conect.conexao);
                                comando.Parameters.Add("@id", MySqlDbType.VarChar).Value = txtCod.Text.Trim();

                                comando.Parameters.Add("@data", MySqlDbType.VarChar).Value = txtData.Text.Trim();
                                comando.Parameters.Add("@lembrete", MySqlDbType.VarChar).Value = txtAgenda.Text.Trim();
                                comando.Parameters.Add("@assunto", MySqlDbType.VarChar).Value = txtAssunto.Text.Trim();

                                comando.ExecuteNonQuery();

                                MessageBox.Show("Lembrete Alterado com sucesso", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtPesq.Text = String.Empty;
                                txtCod.Text = String.Empty;
                                txtData.Text = String.Empty;
                                txtAgenda.Text = String.Empty;
                                txtAssunto.Text = String.Empty;
                                dr.Close();

                            }
                            else
                            {
                                dr.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Para alterar um contato é necessário pesquisá-lo primeiro","Campo em Branco",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            dr.Close();
                        }
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

        //chamando o método para excluir um lembrete
        private void button3_Click(object sender, EventArgs e)
        {
            excluirlembrete();
        }

        //chamando o método para consultar um lembrete
        private void button5_Click(object sender, EventArgs e)
        {
            consultarlembrete();
        }

        //chamando o método para alterar um lembrete
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtData.Text != String.Empty)
            {
                if (txtAgenda.Text != String.Empty)
                {
                    alterarlembrete();
                }
                else
                {
                    MessageBox.Show("Não é possível deixar o corpo do lembrete em branco","Mensagem",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Não é possível salvar um lembrete sem data", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        //Botão para Limpar todos os campos
        private void button1_Click(object sender, EventArgs e)
        {
            txtPesq.Text = String.Empty;
            txtCod.Text = String.Empty;
            txtData.Text = String.Empty;
            txtAgenda.Text = String.Empty;
        }

        private void configuraçõesDaContaToolStripMenuItem_Click(object sender, EventArgs e)
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

        //Abrindo o form Excluirconta
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

        private void ModificaLembrete_Load(object sender, EventArgs e)
        {

        }
    }
}

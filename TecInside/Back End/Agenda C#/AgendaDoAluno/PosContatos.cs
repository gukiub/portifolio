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
using interfaces;

namespace AgendaDoAluno
{


    public partial class PosContatos : Form
    {
        conexaocomMysql conect = new conexaocomMysql();

        public PosContatos()
        {
            InitializeComponent();
        }

        //recebendo parâmetro com o usuário logado ao iniciar o form
        public PosContatos(string texto)
        {
            InitializeComponent();
            label3.Text = texto;
        }

        private string codigo;

        //método para consultar os contatos do usuário
        private void consultarContato()
        {

            try
            {
                codigo = "select * from contatos where nome=@nome and nomecriador=@criador";
                MySqlCommand comando = new MySqlCommand(codigo, conect.conexao);

                comando.Parameters.Add("@nome", MySqlDbType.VarChar).Value = txtPesq.Text.Trim();
                comando.Parameters.Add("@criador", MySqlDbType.VarChar).Value = label3.Text;
                MySqlDataReader dr = comando.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    txtCod.Text = Convert.ToString(dr["cod"]);
                    txtNome.Text = Convert.ToString(dr["nome"]);
                    txtTel.Text = Convert.ToString(dr["tel"]);
                    txtEmail.Text = Convert.ToString(dr["email"]);
                    txtEnd.Text = Convert.ToString(dr["endereco"]);
                    txtCid.Text = Convert.ToString(dr["uf"]);
                    txtObs.Text = Convert.ToString(dr["obs"]);

                    dr.Close();


                }
                else
                {

                    MessageBox.Show("Não Existe Nenhum contato com esse nome!", "Contato não encontrado!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtPesq.Text = string.Empty;
                    txtNome.Text = string.Empty;
                    txtTel.Text = string.Empty;
                    txtEmail.Text = string.Empty;
                    txtEnd.Text = string.Empty;
                    txtCid.Text = string.Empty;
                    txtObs.Text = string.Empty;
                    dr.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       
        //Método para alterar dados de um contato
        private void alterarContato()
        {

            try
            {
                string codigo1 = "select nome,tel,email,endereco,obs,uf,cod from contatos where nomecriador=@criador";
                MySqlCommand comando1 = new MySqlCommand(codigo1, conect.conexao);
                comando1.Parameters.Add("@criador", MySqlDbType.VarChar).Value = label3.Text;
                MySqlDataReader dr = comando1.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                    if (dr["nome"].ToString().Equals(txtNome.Text.Trim()) && dr["tel"].ToString().Equals(txtTel.Text.Trim()) && dr["email"].ToString().Equals(txtEmail.Text.Trim()) && dr["endereco"].ToString().Equals(txtEnd.Text.Trim()) && dr["obs"].ToString().Equals(txtObs.Text.Trim()) && dr["uf"].ToString().Equals(txtCid.Text.Trim()) && dr["cod"].ToString().Equals(txtCod.Text.Trim()))
                    {
                        dr.Close();
                    }
                    else
                    {

                        if (txtCod.Text != String.Empty || txtPesq.Text != String.Empty || txtNome.Text != String.Empty || txtTel.Text != String.Empty || txtEmail.Text != String.Empty || txtEnd.Text != String.Empty || txtCid.Text != String.Empty || txtObs.Text != String.Empty)
                        {
                            if (txtNome.Text != String.Empty)
                            {
                                if (txtCod.Text != String.Empty)
                                {
                                    if (MessageBox.Show("Deseja Realmente alterar os dados desse Contato ?", "Alteração de Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {

                                        dr.Close();
                                        codigo = "update contatos set nome=@nome,tel=@tel,email=@email,endereco=@endereco,uf=@uf,obs=@obs where cod=@busca";
                                        MySqlCommand comando = new MySqlCommand(codigo, conect.conexao);
                                        comando.Parameters.AddWithValue("@busca", txtCod.Text.Trim());
                                        comando.Parameters.AddWithValue("@nome", txtNome.Text.Trim());
                                        comando.Parameters.AddWithValue("@tel", txtTel.Text.Trim());
                                        comando.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                                        comando.Parameters.AddWithValue("@endereco", txtEnd.Text.Trim());
                                        comando.Parameters.AddWithValue("@uf", txtCid.Text.Trim());
                                        comando.Parameters.AddWithValue("@obs", txtObs.Text.Trim());




                                        comando.ExecuteNonQuery();
                                        txtPesq.Text = string.Empty;
                                        txtNome.Text = string.Empty;
                                        txtTel.Text = string.Empty;
                                        txtEmail.Text = string.Empty;
                                        txtEnd.Text = string.Empty;
                                        txtCid.Text = string.Empty;
                                        txtObs.Text = string.Empty;
                                        txtCod.Text = string.Empty;
                                    }
                                    else
                                    {
                                        dr.Close();
                                    }
                                }

                                else
                                {
                                    MessageBox.Show("Para Alterar um Contato é necessário buscá-lo primeiro !", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    dr.Close();
                                }

                            }
                            else
                            {
                                MessageBox.Show("Não é possível deixar o nome do contato em branco !", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                dr.Close();
                            }
                        }

                        else
                        {
                            MessageBox.Show("Para Alterar um Contato é necessário buscá-lo primeiro !", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dr.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Método para excluir um contato
        private void excluirContato()
        {
            try
            {
                if (txtCod.Text != String.Empty)
                {
                    if (MessageBox.Show("Deseja mesmo excluir esse contato? ", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {


                        codigo = "delete from contatos where nome=@nome and nomecriador=@criador";
                        MySqlCommand comando = new MySqlCommand(codigo, conect.conexao);
                        comando.Parameters.Add("@nome", MySqlDbType.VarChar).Value = txtPesq.Text.Trim();
                        comando.Parameters.Add("@criador", MySqlDbType.VarChar).Value = label3.Text;
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Contato Excluido Com Sucesso", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtPesq.Text = string.Empty;
                        txtNome.Text = string.Empty;
                        txtTel.Text = string.Empty;
                        txtEmail.Text = string.Empty;
                        txtEnd.Text = string.Empty;
                        txtCid.Text = string.Empty;
                        txtObs.Text = string.Empty;
                        txtCod.Text = string.Empty;
                        txtPesq.ReadOnly = false;
                    }

                }
                else
                {
                    MessageBox.Show("Para Excluir um Contato é necessário buscá-lo primeiro !", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
        private void PosContatos_Load(object sender, EventArgs e)
        {
            
        }

        //Abrindo o form PosLogin
        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            PosLogin a = new PosLogin(label3.Text);
            a.ShowDialog();
        }

        private void cadastarUsuario_Load(object sender, EventArgs e)
        {
            
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //abrindo o form TodosContatos
        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            TodosContatos a = new TodosContatos(label3.Text);
            a.ShowDialog();

        }

        //Chamando o método para Consultar um contato
        private void button5_Click(object sender, EventArgs e)
        {
            if (txtPesq.Text != String.Empty)
            {
                consultarContato();
                
            }
            else
            {
                MessageBox.Show("Para pesquisar é necessário digitar o nome de um contato !", "Campo em Branco !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPesq.ReadOnly = false;
            }
        }

        //botão para limpar todos os campos
        private void button7_Click(object sender, EventArgs e)
        {
            txtPesq.ReadOnly = false;
            txtPesq.Text = string.Empty;
            txtCod.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtTel.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtEnd.Text = string.Empty;
            txtCid.Text = string.Empty;
            txtObs.Text = string.Empty;
        }

        //Abrindo o form CadastraContato
        private void button6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CadastraContato a = new CadastraContato(label3.Text);
            a.ShowDialog();
        }

        //usando o método AlterarContato
        private void button2_Click(object sender, EventArgs e)
        {
            
            alterarContato();
        }

        //Usando o método ExcluirContato
        private void button3_Click(object sender, EventArgs e)
        {
            excluirContato();
        }

        private void txtPesq_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel24_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked_2(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        //Abrindo o form calculadora
        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Calculadora a = new Calculadora(label3.Text);
            a.ShowDialog();
        }

        private void configuraçõesDaContaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

      

        //Fechando o programa
        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        //Abrindo o form alterarSenha
        private void alterarSenhaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            AlterarSenha a = new AlterarSenha(label3.Text);
            a.ShowDialog();
        }

        //Abrindo o form ExcluirConta
        private void excluirContaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            ExcluirConta a = new ExcluirConta(label3.Text);
            a.ShowDialog();
        }

        //Botão para Limpar todos os campos
        private void button7_Click_1(object sender, EventArgs e)
        {
            txtCid.Text = string.Empty;
            txtPesq.Text = string.Empty;
            txtCod.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtEnd.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtObs.Text = string.Empty;
            txtTel.Text = string.Empty;
        }
    }
}

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
    public partial class CadastraContato : Form
    {
        public CadastraContato()
        {
            InitializeComponent();
        }

        //Recebendo parâmetro com o usuário logado ao iniciar o form
        public CadastraContato(string texto)
        {
            InitializeComponent();
            label3.Text = texto;
        }
        conexaocomMysql conect = new conexaocomMysql();
        
        //Abrindo o form PosContatos
        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            PosContatos a = new PosContatos(label3.Text);
            a.ShowDialog();
        }

        //Botão para Salvar no banco de dados o contato criado pelo usuário
        private void button6_Click(object sender, EventArgs e)
        {

            if (txtNome.Text != String.Empty)
            {
                MySqlCommand codigo = new MySqlCommand("select nome from contatos where nomecriador=@criador and nome=@nome", conect.conexao);
                codigo.Parameters.Add("@criador", MySqlDbType.VarChar).Value = label3.Text.Trim();
                codigo.Parameters.Add("@nome", MySqlDbType.VarChar).Value = txtNome.Text.Trim() ;
                codigo.ExecuteNonQuery();
                MySqlDataReader dr = codigo.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {


                    MessageBox.Show("Já Existe um contato com esse nome cadastrado !!!","Mensagem",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    dr.Close();

                }
                else
                {
                    try
                    {
                        dr.Close();
                        MySqlCommand comando = new MySqlCommand("insert into contatos (nome,tel,email,endereco,uf,obs,nomecriador) values (@nome,@tel,@email,@endereco,@uf,@obs,@criador)", conect.conexao);
                        comando.Parameters.AddWithValue("@criador", label3.Text.Trim());
                        comando.Parameters.AddWithValue("@nome", txtNome.Text.Trim());
                        comando.Parameters.AddWithValue("@tel", txtTel.Text.Trim());
                        comando.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        comando.Parameters.AddWithValue("@endereco", txtEnd.Text.Trim());
                        comando.Parameters.AddWithValue("@uf", txtCid.Text.Trim());
                        comando.Parameters.AddWithValue("@obs", txtObs.Text.Trim());

                        comando.ExecuteNonQuery();

                        this.Visible = false;
                        PosContatos a = new PosContatos(label3.Text);
                        a.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message.Contains("IX_Contato"))
                        {
                            MessageBox.Show("Já existe um contato com esse nome cadastrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dr.Close();
                        }
                        else
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Não é Possível Salvar um contato sem um nome ","Erro ao salvar",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        
        private void CadastraContato_Load(object sender, EventArgs e)
        {

        }
        //Abrindo o form calculadora
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

        }
        }
    

    


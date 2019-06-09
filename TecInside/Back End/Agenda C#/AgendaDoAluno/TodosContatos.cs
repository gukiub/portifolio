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
    public partial class TodosContatos : Form
    {

        conexaocomMysql conect = new conexaocomMysql();

        
        public TodosContatos()
        {
            InitializeComponent();
        }

        //Recebendo Parâmetro com o usuário que esta logado
        public TodosContatos(string texto)
        {
            InitializeComponent();
            label3.Text = texto;
        }

       
        //Método Para Mostrar os contatos do usuário que esta logado
        private void mostrarBD()
        {
            try
            {
                string codigo = String.Format("select nome,tel,email,endereco,uf from contatos where nomecriador=@criador");

                MySqlCommand comando = new MySqlCommand(codigo, conect.conexao);
                comando.Parameters.Add("@criador", MySqlDbType.VarChar).Value = label3.Text;
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                DataTable data = new DataTable();
                adaptador.Fill(data);
                dataGridView1.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        //Mostrar todos os contatos assim que o form carregar
        private void TodosContatos_Load(object sender, EventArgs e)
        {
            mostrarBD();
        }

        //Abrindo o Form PosContatos
        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            PosContatos a = new PosContatos(label3.Text);
            a.ShowDialog();
        }

        
      

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //abrindo o Form Calculadora
        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Calculadora a = new Calculadora(label3.Text);
            a.ShowDialog();
        }

        //abrindo o Form Alterar Senha
        private void alterarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AlterarSenha a = new AlterarSenha(label3.Text);
            a.ShowDialog();
        }

        //abrindo o Form ExcluirConta
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

        //Método para deletar todos os contatos
        private void deletarTodosContatos()
        {
            string codigo1 = "select * from contatos where nomecriador=@criador1";
            MySqlCommand comando1 = new MySqlCommand(codigo1, conect.conexao);
            comando1.Parameters.Add("criador1", MySqlDbType.VarChar).Value = label3.Text;
            MySqlDataReader dr = comando1.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                if (MessageBox.Show("Deseja Realmente Apagar todos os seus contatos ? ", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dr.Close();
                    string codigo = "delete from contatos where nomecriador=@criador";
                    MySqlCommand comando = new MySqlCommand(codigo, conect.conexao);
                    comando.Parameters.Add("@criador", MySqlDbType.VarChar).Value = label3.Text;
                    comando.ExecuteNonQuery();
                    this.Visible = false;
                    PosLogin a = new PosLogin(label3.Text);
                    a.ShowDialog();
                }
                else
                {
                    dr.Close();
                }
            }
            else
            {
                MessageBox.Show("Você ainda não possui nenhum contato");
                dr.Close();
            }
        }
        
        //usando o método para deletar todos os contatos
        private void button2_Click(object sender, EventArgs e)
        {
            deletarTodosContatos();
        }

        //Abrindo o form CadastraContato
        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CadastraContato a = new CadastraContato(label3.Text);
            a.ShowDialog();

        }

        //Abrindo o form PosContatos
        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            PosContatos a = new PosContatos(label3.Text);
            a.ShowDialog();
        }
    }
}

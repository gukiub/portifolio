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
    public partial class PosLembretes : Form
    {
        public PosLembretes()
        {
            InitializeComponent();
        }

        conexaocomMysql conect = new conexaocomMysql();

        //Recebendo parâmetro ao iniciar o form
        public PosLembretes(string texto)
        {
            InitializeComponent();
            label3.Text = texto;

        }
        
        //Método para mostrar os lembretes do usuário logado
        private void mostrarLembretes()
        {
            try
            {
                string codigo = String.Format("select id,assunto,data,lembrete from anotacoes where nomecriador=@criador");

                MySqlCommand comando = new MySqlCommand(codigo, conect.conexao);
                comando.Parameters.Add("@criador", MySqlDbType.VarChar).Value = label3.Text;
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                DataTable data = new DataTable();
                adaptador.Fill(data);
                dataGridView1.DataSource = data;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        //Chamando o método mostrarLembretes
        private void PosLembretes_Load(object sender, EventArgs e)
        {
            mostrarLembretes();
        }

        //Abrindo o form PosLogin
        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            PosLogin a = new PosLogin(label3.Text);
            a.ShowDialog();
        }

        //Abrindo o form PosCalendario
        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            PosCalendario a = new PosCalendario(label3.Text);
            a.ShowDialog();
        }

        //Abrindo o form ModificaLembrete
        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ModificaLembrete a = new ModificaLembrete(label3.Text);
            a.ShowDialog();
        }

       //Abrindo o form calculadora
        private void configToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Calculadora a = new Calculadora(label3.Text);
            a.ShowDialog();
            
        }

        private void configuraçõesDaContaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //abrindo o form AlterarSenha
        private void alterarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AlterarSenha a = new AlterarSenha(label3.Text);
            a.ShowDialog();
        }

        //abrindo o form ExcluirConta
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

        //método para deletar todos os lembretes do usuário
        private void deletarTodosLembretes()
        {
            string codigo1 = "select * from anotacoes where nomecriador=@criador1";
            MySqlCommand comando1 = new MySqlCommand(codigo1, conect.conexao);
            comando1.Parameters.Add("@criador1", MySqlDbType.VarChar).Value = label3.Text;
            MySqlDataReader dr = comando1.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                if (MessageBox.Show("Deseja Realmente Apagar todos os seus lembretes", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dr.Close();
                    string codigo = "delete from anotacoes where nomecriador=@criador";
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
                MessageBox.Show("Você ainda não possui nenhum Lembrete");
                dr.Close();
            }
        }

        //usando o método deletarTodosLembretes
        private void button4_Click(object sender, EventArgs e)
        {
            deletarTodosLembretes();
            
        }
    }
}

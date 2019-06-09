using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace AgendaDoAluno
{
    

    public partial class PosCalendario : Form
    {
        conexaocomMysql conect = new conexaocomMysql();
        
        public string reg,a;
        

        public PosCalendario()
        {
            
            InitializeComponent();
           
            btnSalvar.Visible = false;
           
            txtData.Visible = false;
            txtAssunto.Visible = false;
            

        }

        //Recebendo parâmetro com o usuário logado ao iniciar o form
        public PosCalendario(string texto)
        {
            InitializeComponent();
            label3.Text = texto;
            
            txtData.Visible = false;
            txtAssunto.Visible = false;
        }

       

        private void monthCalendar1_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        //Evento para pegar a Data Selecionada pelo usuário e Verificar se o mesmo deseja adicionar um lembrete
        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {

            reg = monthCalendar1.SelectionStart.Day.ToString()+monthCalendar1.SelectionRange.Start.Month.ToString()+monthCalendar1.SelectionRange.Start.Year.ToString();
            a = monthCalendar1.SelectionStart.Day.ToString()+"/" + monthCalendar1.SelectionRange.Start.Month.ToString()+"/" + monthCalendar1.SelectionRange.Start.Year.ToString();
            
              
           
              
                    if (MessageBox.Show("Deseja Adicionar um Lembrete?", "Adicionar Lembrete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                lblAssunto.Visible = true;
                txtData.Visible = true;
                    txtAgenda.Visible = true;
                    btnSalvar.Visible = true;
                    txtAssunto.Visible = true;
                    btnRetornar.Visible = true;
                    btnVoltar.Visible = false;
                    lblAssunto.Visible = true;
                    lblLembrete.Visible = true;
                    


                    txtData.Text = monthCalendar1.SelectionRange.Start.Day.ToString() + "/" + monthCalendar1.SelectionRange.Start.Month.ToString() + "/" + monthCalendar1.SelectionRange.Start.Year.ToString();
                    }
                }
               
            
        

      
        
        //Abrindo o form login
        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Login a = new Login();
            a.ShowDialog();
        }

        //Abrindo o form PosLogin
        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            PosLogin a = new PosLogin(label3.Text);
            a.ShowDialog();
        }

        private void PosCalendario_Load(object sender, EventArgs e)
        {
            
        }

        //Abrindo o form PosLogin
        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            PosLogin a = new PosLogin(label3.Text);
            a.Show();
        }

       //Salvando o lembrete no banco de dados
        private void button2_Click(object sender, EventArgs e)
        {



            try
            {
                if (txtAgenda.Text.Length > 0)
                {

                    if (conect.conexao.State == ConnectionState.Open)
                    {

                        MySqlCommand comando = new MySqlCommand("insert into anotacoes (assunto,data,lembrete,nomecriador) values (@assunto,@data,@lembrete,@criador)", conect.conexao);
                        comando.Parameters.AddWithValue("@assunto", txtAssunto.Text.Trim());
                        comando.Parameters.AddWithValue("@data", txtData.Text.Trim());

                        comando.Parameters.AddWithValue("@lembrete", txtAgenda.Text.Trim());
                        comando.Parameters.AddWithValue("@criador", label3.Text);

                        comando.ExecuteNonQuery();

                        MessageBox.Show("Agendamento para o dia " + a + " Registrado com sucesso !", "Agendado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtAssunto.Visible = false;
                        txtAgenda.Text = "";
                        txtData.Visible = false;
                        txtAgenda.Visible = false;
                        monthCalendar1.Visible = true;
                        lblAssunto.Visible = false;
                        btnSalvar.Visible = false;
                        btnRetornar.Visible = false;
                        btnVoltar.Visible = true;
                        lblAssunto.Visible = false;
                        lblLembrete.Visible = false;

                    }

                }
                else
                {

                    MessageBox.Show("Não é Possível Salvar um Lembrete em branco", "Erro ao salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        


            

       

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        //Tirando a visibilidade de uma label ao mudar o texto do campo "txtAssunto"
        private void txtAssunto_TextChanged(object sender, EventArgs e)
        {
            lblAssunto.Visible = false;
        }

        //Tirando a visibilidade de uma label ao mudar o texto do campo "txtAgenda"
        private void txtAgenda_TextChanged(object sender, EventArgs e)
        {
            lblLembrete.Visible = false;
        }

        //Botão Para Exibir o monthcalendar novamente após o usuário ter clicado em adicionar lembrete
        private void btnRetornar_Click(object sender, EventArgs e)
        {
            txtAssunto.Visible = false;
            txtData.Visible = false;
            monthCalendar1.Visible = true;
            txtAgenda.Visible = false;
            btnVoltar.Visible = true;
            btnSalvar.Visible = false;
            lblAssunto.Visible = false;
            lblLembrete.Visible = false;
           
            btnRetornar.Visible = false;
        }

        //Abrindo o form Calculadora
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
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        // Abrindo o form alterarSenha
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
    }
}

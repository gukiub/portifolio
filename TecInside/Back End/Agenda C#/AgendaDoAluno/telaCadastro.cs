using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace AgendaDoAluno
{
    public partial class telaCadastro : Form,ICadastro
    {
        conexaocomMysql conect = new conexaocomMysql();
        
        //Definindo propriedades de alguns campos
        public telaCadastro()
        {
            InitializeComponent();
            txtn2.PasswordChar = '*';
            txtn3.PasswordChar = '*';
            txtn2.MaxLength = 14;
            txtn1.MaxLength = 14;
            txtn3.MaxLength = 14;
        }
            
        
        //método para cadastrar alguém
        public void cadastrar()
        {
           
            
            lblerro1.Visible = false;
            lblerro2.Visible = false;

         


            if (txtn1.Text != String.Empty && txtn2.Text != String.Empty && txtn3.Text != String.Empty)
            {
                if (txtn2.Text.Equals(txtn3.Text))
                {
                    if (conect.conexao.State == ConnectionState.Open)
                    {


                        try { 
                        //Comando SQL(Query)
                        MySqlCommand comando = new MySqlCommand("INSERT INTO login (usuario,senha) VALUES (@usuario,@senha)", conect.conexao);
                        comando.Parameters.AddWithValue("@usuario", txtn1.Text.Trim());
                        comando.Parameters.AddWithValue("@senha", txtn2.Text.Trim());


                        //Executar o Comando SQL(Query)
                        comando.ExecuteNonQuery();

                        this.Visible = false;
                        Login a = new Login();
                        a.ShowDialog();
}
                       
                        
                            catch (Exception ex)
            {
                if (ex.Message.Contains("IX_Contato"))
                {
                    MessageBox.Show("Já existe um usuario com esse nome !", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Erro na conexão com Banco de Dados");
                    }



                }
                else
                {
                    lblerro2.Visible = false;
                    lblerro1.Visible = true;
                    txtn1.Text = String.Empty;
                    txtn2.Text = String.Empty;
                    txtn3.Text = String.Empty;

                }
            }
            else
            {
                lblerro1.Visible = false;
                lblerro2.Visible = true;
            }
        }

       //Usando método para cadastro
        private void button1_Click(object sender, EventArgs e)
        {
            cadastrar();
        }

        //Abrindo form Login
        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Login a = new Login();
            a.ShowDialog();

        }

        private void telaCadastro_Load(object sender, EventArgs e)
        {

        }


        //Fechando o programa
        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void panel24_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}


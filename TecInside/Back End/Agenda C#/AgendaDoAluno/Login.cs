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
    public partial class Login :Form,ILogin
    {

        conexaocomMysql conect = new conexaocomMysql();
        
        

        

        public Login()
        {

            InitializeComponent();
           
            // The password character is an asterisk.
            txtn2.PasswordChar = '*';
           // The control will allow no more than 14 characters.
            txtn2.MaxLength = 14;
            txtn1.MaxLength = 14;



        }

        //Método para Abrir o form PosLogin e passar o parâmetro com o usuário logado
        public void entrar()
        {
            this.Visible = false;
            this.Hide();
            PosLogin destino = new PosLogin(txtn1.Text);
            destino.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Método Para fazer o usuário logar
        public void logar()
        {

            try { 
            
            lblerro.Visible = false;


            //criando conexão com banco de dados
            
            //abrindo conexão
           

            //verificando se a conexão está aberta
            if (conect.conexao.State == ConnectionState.Open)
            {

                if (txtn1.Text != String.Empty && txtn2.Text != String.Empty)
                {
                    //Comando SQL(Query)
                    MySqlCommand comando = new MySqlCommand("SELECT * FROM login WHERE usuario=@usuario and senha=@senha", conect.conexao);
                    comando.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = txtn1.Text.Trim();
                    comando.Parameters.Add("@senha", MySqlDbType.VarChar).Value = txtn2.Text.Trim();

                    MySqlDataReader rdr = comando.ExecuteReader();
                    //comando para ler o que foi digitado pelo usuário
                    rdr.Read();
                    //comando para verificar se tem linhas
                    if (rdr.HasRows)
                    {
                        //comando para verificar se o usuario e senha digitados são iguais aos do banco
                        if (rdr["usuario"].ToString().Equals(txtn1.Text.Trim()) && rdr["senha"].ToString().Equals(txtn2.Text.Trim()))
                        {

                            entrar();
                            rdr.Close();


                        }

                    }
                    else
                    {
                        lblerro.Visible = true;

                        rdr.Close();

                    }

                }
                else
                {
                    lblerro.Visible = true;


                }
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //chamando o metodo logar
        private void button2_Click_1(object sender, EventArgs e)
        {
            
          
                logar();
            
                
        }

        //Abrindo o form telaCadastro
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            telaCadastro a = new telaCadastro();
            a.ShowDialog();

        }

        private void txtn1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void panel24_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel23_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel22_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel21_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel20_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel30_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel29_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel28_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel27_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel41_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel44_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel43_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel42_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel46_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel45_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel31_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel32_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel33_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel40_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel38_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel39_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel37_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel36_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel35_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel34_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel26_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel25_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}


        
    


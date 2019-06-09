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
    public partial class PosLogin : Form
    {
        public PosLogin()
        {
            InitializeComponent();
        }

        //Recebendo parâmetro com o usuário logado ao iniciar o form
        public PosLogin(string texto)
        {
            InitializeComponent();
            label3.Text = texto;
        }

        //Abrindo form PosContatos
        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            PosContatos a = new PosContatos(label3.Text);
            a.ShowDialog();
        }


        //Abrindo form PosCalendario
        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            PosCalendario a = new PosCalendario(label3.Text);
            a.ShowDialog();
        }

       
        //Abrindo form Login
        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Login a = new Login();
            a.ShowDialog();
        }

        private void PosLogin_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel21_Paint(object sender, PaintEventArgs e)
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

        private void panel24_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel23_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel22_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel20_Paint(object sender, PaintEventArgs e)
        {

        }

        //Abrindo o Form PosLembretes
        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            PosLembretes a = new PosLembretes(label3.Text);
            a.ShowDialog();

        }

        //Abrindo o Form Calculadora
        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Calculadora a = new Calculadora(label3.Text);
            a.ShowDialog();
            
        }

        //Abrindo o Form AlterarSenha
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

        //Fechando o programa
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}

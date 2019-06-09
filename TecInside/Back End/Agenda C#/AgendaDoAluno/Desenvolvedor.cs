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
    public partial class Desenvolvedor : Form
    {
        public Desenvolvedor()
        {
            InitializeComponent();
        }

        //Recebendo o parâmetro com o usuário logado ao iniciar o form
        public Desenvolvedor(string texto)
        {
            InitializeComponent();
            label3.Text = texto;
        }

        private void Desenvolvedor_Load(object sender, EventArgs e)
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

        //Abrindo o form ExcluirConta
        private void excluirContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ExcluirConta a = new ExcluirConta(label3.Text);
            a.ShowDialog();
        }

        //Abrindo o form Desenvolvedor
        private void desenvolvedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Desenvolvedor a = new Desenvolvedor(label3.Text);
            a.ShowDialog();
        }

        //FEchando o programa
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        //Abrindo o form PosLogin
        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            PosLogin a = new PosLogin(label3.Text);
            a.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tabuada
{
    public partial class CalculadoraTabuada : Form
    {
        public CalculadoraTabuada()
        {
            InitializeComponent();
        }

        //Definir metodo CalcularTaboada()
        private void CalcularTabuada() {
            //limpar lista
            tabuadaListBox.Items.Clear();
            //calcular a tabuada
            int tabuada = Convert.ToInt32(tabuadaTextBox.Text);
            for (int i = 0; i <= 10; i++) {
                tabuadaListBox.Items.Add(tabuada + " x " + i + " = " + (tabuada * i).ToString("#,##0"));
            }
            tabuadaTextBox.Focus();
        }


        //Definir Metodo LimparTela()
        private void LimparTela()
        {
            tabuadaTextBox.Clear();
            tabuadaTextBox.Focus();
            tabuadaListBox.Items.Clear();
        }


        private void CalculadoraTabuada_Load(object sender, EventArgs e)
        {

        }

        private void tabuadaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabuadaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Permitir apenas NÚMEROS, BACKSPACE e ENTER
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '\b' || e.KeyChar == '\r')
            {
                if (e.KeyChar == '\r')
                {
                    CalcularTabuada();
                }
            }
            else{
                e.KeyChar = '\0';
            }
        }

        private void CalculadoraTabuada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 27)
            {
                //chamar o metodo que limpa a tela
                LimparTela();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

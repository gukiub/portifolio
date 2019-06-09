using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            Decimal nota1, nota2, nota3, nota4, maiornota, menornota, media;

            nota1 = Convert.ToDecimal(txtNota1.Text);
            nota2 = Convert.ToDecimal(txtNota2.Text);
            nota3 = Convert.ToDecimal(txtNota3.Text);
            nota4 = Convert.ToDecimal(txtNota4.Text);

            if (nota1 > nota2 && nota2 > nota3 && nota3 > nota4)
            {
                maiornota = nota1;
            }

                else if (nota2 > nota1 && nota2 > nota3 && nota2 > nota4)
                {
                    maiornota = nota2;
                }

                    else if (nota3 > nota1 && nota3 > nota2 && nota3 > nota4)
                    {
                        maiornota = nota3;
                    }

                        else
                        {
                            maiornota = nota4;
                        }



            if (nota1 < nota2 && nota2 < nota3 && nota3 < nota4)
            {
                menornota = nota1;
            }

                else if (nota2 < nota1 && nota2 < nota3 && nota2 < nota4)
                {
                    menornota = nota2;
                }

                    else if (nota3 < nota1 && nota3 < nota2 && nota3 < nota4)
                    {
                        menornota = nota3;
                    }

                        else
                        {
                            menornota = nota4;
                        }

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            labelNotaMedia.Text = media.ToString();
            labelMaiorNota.Text = maiornota.ToString();
            labelMenorNota.Text = menornota.ToString();


        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            //Limpo as variaveis
            txtNota1.Text = "";
            txtNota2.Text = "";
            txtNota3.Text = "";
            txtNota4.Text = "";
            labelMaiorNota.Text = "0";
            labelMenorNota.Text = "0";
            labelNotaMedia.Text = "0";
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            DialogResult sair;

            sair = MessageBox.Show
                ("Deseja sair?",
                "Mensagem do Sistema",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            
            if (sair == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }

    
        }
    }
}

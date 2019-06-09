using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RKL.ResetText();
            CLK.ResetText();
            try
            {
                decimal km = ValidarDeciimal(txtKM);
                decimal litros = ValidarDeciimal(txtL);
                decimal rendimneto = km / litros;
                decimal consumo = litros / km;
                RKL.Text = rendimneto.ToString("N1");
                CLK.Text = consumo.ToString("N3");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message ,"Alerta de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtKM_TextChanged(object sender, EventArgs e)
        {

        }
        private decimal ValidarDeciimal(TextBox txt)
        {
            try
             {
                return Convert.ToDecimal(txt.Text);
            }

            
            catch (Exception)
            {

                txt.Focus();
                txt.SelectAll();
                throw new Exception("Preencha corrtamente o campo " + txt.Name.ToUpper().Replace("TEXTBOX", ""));
            }
           


        }
        
        private void LimparTela ()
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = String.Empty;
                }

                else if (ctl is Label && Convert.ToInt32(ctl.Tag).Equals(1))
                    {
                        ctl.Text = string.Empty;
                }
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                    if (e.KeyChar == 27)
                {
                    LimparTela();
                    txtKM.Focus();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Alerta de Erro ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
               
        }
    }
}

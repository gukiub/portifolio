using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DividirPorZero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutaErro_Click(object sender, EventArgs e)
        {
            try
            {
                int n1 = 10;
                int n2 = 0;

                //o objetivo é dividir dois numeros
                //mas o vaor n2 é zero
                int resultado = n1 / n2;

                //Exibir o resultado
                labelErro.Text = string.Format("{ 0} + { 1} = { 2}",
                n1.ToString(), n2.ToString(), resultado.ToString());
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message, "Alerta de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Seu animal.", "Alerta de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void labelErro_Click(object sender, EventArgs e)
        {

        }
    }
}

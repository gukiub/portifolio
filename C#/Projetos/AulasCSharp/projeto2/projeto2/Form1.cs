using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto2
{
    public partial class Corpo : Form
    {
        public Corpo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(Txt1.Text);
            int num2 = Convert.ToInt32(Txt2.Text);
            int soma = num1 + num2;

            MessageBox.Show("A soma é: " + (num1 + num2));
        }
    }
}

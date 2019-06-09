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
    public partial class TelaSplash : Form
    {
        public TelaSplash()
        {
            InitializeComponent();
            
        }

       
        
        private void panel5_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TelaSplash_Load(object sender, EventArgs e)
        {

        }

        //Preenchendo a progress bar
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pbcarrega.Value < 100)
            {
                pbcarrega.Value = pbcarrega.Value + 2;
            }
            else
            {
                timer1.Enabled = false;
                Login a = new Login();
                this.Visible = false;
                a.ShowDialog();
            }
        }

        private void pbcarrega_Click(object sender, EventArgs e)
        {

        }
    }
}

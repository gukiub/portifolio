using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaDoAluno
{
    public partial class teste : Form
    {
        public string reg;

        
        
        public teste()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
            reg =   monthCalendar1.SelectionRange.Start.Day.ToString() + monthCalendar1.SelectionRange.Start.Month.ToString() + monthCalendar1.SelectionRange.Start.Year.ToString();
            if (File.Exists(reg) == true)
            {
                AtivaControles();
                txtAgenda.Text = File.ReadAllText(reg);
            }
            else
            {
                if (MessageBox.Show("Deseja Adicionar um Lembrete?", "Registrar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    txtAgenda.Text = "";
                    AtivaControles();
                    
                    txtAgenda.Text = "Data "+monthCalendar1.SelectionRange.Start.Day.ToString()+"/"+monthCalendar1.SelectionRange.Start.Month.ToString()+"/"+monthCalendar1.SelectionRange.Start.Year.ToString();
                }
            }
        }


        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
           
            
        }
            
        
            
      
      

        private void AtivaControles()
        {

            monthCalendar1.Enabled = false;
            monthCalendar1.Hide();
            txtAgenda.Enabled = true;
            txtAgenda.Show();
            btnSalvar.Enabled = true;
            btnSalvar.Show();
            btnRetornar.Enabled = true;
            btnRetornar.Show();
        }

        

        private void teste_Load(object sender, EventArgs e)
        {
            reg = monthCalendar1.SelectionRange.Start.Day.ToString() + monthCalendar1.SelectionRange.Start.Month.ToString() + monthCalendar1.SelectionRange.Start.Year.ToString();
            if (DateTime.Today == monthCalendar1.TodayDate && File.Exists(reg) == true)
            {
                if(MessageBox.Show("Existem registros na agenda para essa data. Deseja ver ? ","Ver Agenda", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    AtivaControles();
                    txtAgenda.Text = File.ReadAllText(reg);
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
            if (File.Exists(reg))
                {
                    if(MessageBox.Show("Deseja deletar esse lembrete ?","Deletar",MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        File.Delete(reg);
                    }
                }
                
                
            else
            {
                if (txtAgenda.Text.Length > 0)
                {

                    
                    File.WriteAllText(reg, txtAgenda.Text);
                   
                   
                    MessageBox.Show("Agendamento Registrado com sucesso." + reg, "Agendado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
                txtAgenda.Enabled = false;
            txtAgenda.Hide();
            btnSalvar.Enabled = false;
            btnSalvar.Hide();
            btnRetornar.Enabled = false;
            btnRetornar.Hide();
            monthCalendar1.Enabled = true;
            monthCalendar1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(reg))
            {
                if (MessageBox.Show("Deseja deletar esse lembrete ?", "Deletar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    File.Delete(reg);
                }
            }
            else
            {
                MessageBox.Show("Não Há Lembretes para está data");
            }
        }
    }
}

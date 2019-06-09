using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumoRendimento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Validar Decimal metodo()
        private decimal ValidarDecimal(TextBox txt)
        {
            try
            {
                return Convert.ToDecimal(txt.Text);
            }
            catch
            {
                txt.Focus();
                txt.SelectAll();
                throw new Exception("Preencha corretamente o campo " + txt.Name.ToUpper().Replace("TEXTBOX", ""));
            }
        }

        //Definir o método LimparTela() aqui
        private void LimparTela()
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = string.Empty;
                }
                else if (ctl is Label && Convert.ToInt32(ctl.Tag).Equals(1))
                {
                    ctl.Text = string.Empty;
                }
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            rendimentoLabel.ResetText();
            consumoLabel.ResetText();

            try
            {
                decimal km = ValidarDecimal(KmTextBox);
                decimal litros = ValidarDecimal(LitrosTextBox);
            }
            catch (Exception)
            {

                throw;
            }
        } } }

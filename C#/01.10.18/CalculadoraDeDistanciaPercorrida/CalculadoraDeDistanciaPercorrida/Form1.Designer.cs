namespace CalculadoraDeDistanciaPercorrida
{
    partial class calcularKm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.listaSaida = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVelocidade = new System.Windows.Forms.TextBox();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.btnCalcula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listaSaida
            // 
            this.listaSaida.FormattingEnabled = true;
            this.listaSaida.Location = new System.Drawing.Point(12, 148);
            this.listaSaida.Name = "listaSaida";
            this.listaSaida.Size = new System.Drawing.Size(291, 134);
            this.listaSaida.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Velocidade do Veiculo (Km por Hora)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Horas Viajadas";
            // 
            // txtVelocidade
            // 
            this.txtVelocidade.Location = new System.Drawing.Point(199, 23);
            this.txtVelocidade.Name = "txtVelocidade";
            this.txtVelocidade.Size = new System.Drawing.Size(104, 20);
            this.txtVelocidade.TabIndex = 1;
            // 
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(199, 62);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(104, 20);
            this.txtHoras.TabIndex = 2;
            // 
            // btnCalcula
            // 
            this.btnCalcula.Location = new System.Drawing.Point(199, 102);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(104, 23);
            this.btnCalcula.TabIndex = 3;
            this.btnCalcula.Text = "Calcular";
            this.btnCalcula.UseVisualStyleBackColor = true;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // calcularKm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 294);
            this.Controls.Add(this.btnCalcula);
            this.Controls.Add(this.txtHoras);
            this.Controls.Add(this.txtVelocidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listaSaida);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "calcularKm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Distancia Percorrida";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.calcularKm_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listaSaida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVelocidade;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.Button btnCalcula;
    }
}


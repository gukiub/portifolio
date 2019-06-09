namespace LeitorNumerosAleatorios
{
    partial class LeitorNumerosAleatórios
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
            this.btnLerArquivo = new System.Windows.Forms.Button();
            this.listaSaida = new System.Windows.Forms.ListBox();
            this.ofdAbrirArquivo = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnLerArquivo
            // 
            this.btnLerArquivo.Location = new System.Drawing.Point(12, 12);
            this.btnLerArquivo.Name = "btnLerArquivo";
            this.btnLerArquivo.Size = new System.Drawing.Size(336, 36);
            this.btnLerArquivo.TabIndex = 0;
            this.btnLerArquivo.Text = "Ler arquivo de Texto";
            this.btnLerArquivo.UseVisualStyleBackColor = true;
            this.btnLerArquivo.Click += new System.EventHandler(this.BtnLerArquivo_Click);
            // 
            // listaSaida
            // 
            this.listaSaida.FormattingEnabled = true;
            this.listaSaida.Location = new System.Drawing.Point(12, 57);
            this.listaSaida.Name = "listaSaida";
            this.listaSaida.Size = new System.Drawing.Size(336, 225);
            this.listaSaida.TabIndex = 1;
            // 
            // ofdAbrirArquivo
            // 
            this.ofdAbrirArquivo.FileName = "openFileDialog1";
            // 
            // LeitorNumerosAleatórios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 297);
            this.Controls.Add(this.listaSaida);
            this.Controls.Add(this.btnLerArquivo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LeitorNumerosAleatórios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leitor de números aleatórios";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLerArquivo;
        private System.Windows.Forms.ListBox listaSaida;
        private System.Windows.Forms.OpenFileDialog ofdAbrirArquivo;
    }
}


namespace PrimeiroPrograma
{
    partial class janela
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
            this.Butao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Butao
            // 
            this.Butao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Butao.Location = new System.Drawing.Point(162, 130);
            this.Butao.Name = "Butao";
            this.Butao.Size = new System.Drawing.Size(126, 40);
            this.Butao.TabIndex = 0;
            this.Butao.Text = "Butão";
            this.Butao.UseVisualStyleBackColor = true;
            this.Butao.Click += new System.EventHandler(this.Butao_Click);
            // 
            // janela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.Butao);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "janela";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clique no butão";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Butao;
    }
}


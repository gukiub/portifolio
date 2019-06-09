namespace TotalVendas
{
    partial class frmTotalVendas
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.listaSaida = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(12, 12);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(203, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular Total";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // listaSaida
            // 
            this.listaSaida.FormattingEnabled = true;
            this.listaSaida.Location = new System.Drawing.Point(12, 52);
            this.listaSaida.Name = "listaSaida";
            this.listaSaida.Size = new System.Drawing.Size(203, 134);
            this.listaSaida.TabIndex = 1;
            // 
            // frmTotalVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 196);
            this.Controls.Add(this.listaSaida);
            this.Controls.Add(this.btnCalcular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTotalVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Total Vendas de Faturamento";
            this.Load += new System.EventHandler(this.frmTotalVendas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ListBox listaSaida;
    }
}


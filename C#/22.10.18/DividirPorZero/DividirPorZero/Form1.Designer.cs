namespace DividirPorZero
{
    partial class Form1
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
            this.btnExecutaErro = new System.Windows.Forms.Button();
            this.labelErro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExecutaErro
            // 
            this.btnExecutaErro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecutaErro.Location = new System.Drawing.Point(12, 30);
            this.btnExecutaErro.Name = "btnExecutaErro";
            this.btnExecutaErro.Size = new System.Drawing.Size(234, 34);
            this.btnExecutaErro.TabIndex = 0;
            this.btnExecutaErro.Text = "Executar";
            this.btnExecutaErro.UseVisualStyleBackColor = true;
            this.btnExecutaErro.Click += new System.EventHandler(this.btnExecutaErro_Click);
            // 
            // labelErro
            // 
            this.labelErro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelErro.Location = new System.Drawing.Point(12, 116);
            this.labelErro.Name = "labelErro";
            this.labelErro.Size = new System.Drawing.Size(234, 118);
            this.labelErro.TabIndex = 1;
            this.labelErro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelErro.Click += new System.EventHandler(this.labelErro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 271);
            this.Controls.Add(this.labelErro);
            this.Controls.Add(this.btnExecutaErro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dividir por Zero";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExecutaErro;
        private System.Windows.Forms.Label labelErro;
    }
}


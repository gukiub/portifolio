namespace tabuada
{
    partial class CalculadoraTabuada
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabuadaTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabuadaListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insira Aqui";
            // 
            // tabuadaTextBox
            // 
            this.tabuadaTextBox.Location = new System.Drawing.Point(12, 30);
            this.tabuadaTextBox.Name = "tabuadaTextBox";
            this.tabuadaTextBox.Size = new System.Drawing.Size(217, 20);
            this.tabuadaTextBox.TabIndex = 1;
            this.tabuadaTextBox.TextChanged += new System.EventHandler(this.tabuadaTextBox_TextChanged);
            this.tabuadaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabuadaTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Resultado";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tabuadaListBox
            // 
            this.tabuadaListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabuadaListBox.FormattingEnabled = true;
            this.tabuadaListBox.Location = new System.Drawing.Point(12, 78);
            this.tabuadaListBox.Name = "tabuadaListBox";
            this.tabuadaListBox.Size = new System.Drawing.Size(217, 197);
            this.tabuadaListBox.TabIndex = 3;
            // 
            // CalculadoraTabuada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 283);
            this.Controls.Add(this.tabuadaListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabuadaTextBox);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CalculadoraTabuada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Tabuada";
            this.Load += new System.EventHandler(this.CalculadoraTabuada_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CalculadoraTabuada_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tabuadaTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox tabuadaListBox;
    }
}


namespace MediaNotas
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.labelMaiorNota = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.txtNota4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelMenorNota = new System.Windows.Forms.Label();
            this.labelNotaMedia = new System.Windows.Forms.Label();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite a nota 1:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(251, 67);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(75, 23);
            this.BtnCalcular.TabIndex = 1;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(107, 10);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(100, 20);
            this.txtNota1.TabIndex = 2;
            // 
            // labelMaiorNota
            // 
            this.labelMaiorNota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMaiorNota.Location = new System.Drawing.Point(117, 149);
            this.labelMaiorNota.Name = "labelMaiorNota";
            this.labelMaiorNota.Size = new System.Drawing.Size(65, 22);
            this.labelMaiorNota.TabIndex = 3;
            this.labelMaiorNota.Text = "0";
            this.labelMaiorNota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMaiorNota.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Digite a nota 2:";
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(107, 39);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(100, 20);
            this.txtNota2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Digite a nota 3:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Digite a nota 4:";
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(107, 68);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(100, 20);
            this.txtNota3.TabIndex = 8;
            // 
            // txtNota4
            // 
            this.txtNota4.Location = new System.Drawing.Point(107, 97);
            this.txtNota4.Name = "txtNota4";
            this.txtNota4.Size = new System.Drawing.Size(100, 20);
            this.txtNota4.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sua maior nota é";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Sua menor nota é";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Sua média é";
            // 
            // labelMenorNota
            // 
            this.labelMenorNota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMenorNota.Location = new System.Drawing.Point(117, 179);
            this.labelMenorNota.Name = "labelMenorNota";
            this.labelMenorNota.Size = new System.Drawing.Size(65, 22);
            this.labelMenorNota.TabIndex = 13;
            this.labelMenorNota.Text = "0";
            this.labelMenorNota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNotaMedia
            // 
            this.labelNotaMedia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNotaMedia.Location = new System.Drawing.Point(117, 209);
            this.labelNotaMedia.Name = "labelNotaMedia";
            this.labelNotaMedia.Size = new System.Drawing.Size(65, 22);
            this.labelNotaMedia.TabIndex = 14;
            this.labelNotaMedia.Text = "0";
            this.labelNotaMedia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Location = new System.Drawing.Point(251, 108);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpar.TabIndex = 15;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(251, 149);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 23);
            this.BtnSair.TabIndex = 16;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(349, 252);
            this.ControlBox = false;
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.labelNotaMedia);
            this.Controls.Add(this.labelMenorNota);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNota4);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelMaiorNota);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Calcular a Maior nota";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.Label labelMaiorNota;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.TextBox txtNota4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelMenorNota;
        private System.Windows.Forms.Label labelNotaMedia;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnSair;
    }
}


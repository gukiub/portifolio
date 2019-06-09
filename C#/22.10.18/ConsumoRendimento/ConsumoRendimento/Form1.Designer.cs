using System;

namespace ConsumoRendimento
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.rendimentoLabel = new System.Windows.Forms.Label();
            this.consumoLabel = new System.Windows.Forms.Label();
            this.KmTextBox = new System.Windows.Forms.TextBox();
            this.LitrosTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(65, 128);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(338, 39);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            Form1 form1 = this;
            form1.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // rendimentoLabel
            // 
            this.rendimentoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rendimentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rendimentoLabel.Location = new System.Drawing.Point(243, 32);
            this.rendimentoLabel.Name = "rendimentoLabel";
            this.rendimentoLabel.Size = new System.Drawing.Size(160, 23);
            this.rendimentoLabel.TabIndex = 1;
            this.rendimentoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // consumoLabel
            // 
            this.consumoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.consumoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consumoLabel.Location = new System.Drawing.Point(243, 80);
            this.consumoLabel.Name = "consumoLabel";
            this.consumoLabel.Size = new System.Drawing.Size(160, 23);
            this.consumoLabel.TabIndex = 2;
            this.consumoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KmTextBox
            // 
            this.KmTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KmTextBox.Location = new System.Drawing.Point(65, 32);
            this.KmTextBox.Name = "KmTextBox";
            this.KmTextBox.Size = new System.Drawing.Size(151, 23);
            this.KmTextBox.TabIndex = 3;
            this.KmTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LitrosTextBox
            // 
            this.LitrosTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LitrosTextBox.Location = new System.Drawing.Point(65, 80);
            this.LitrosTextBox.Name = "LitrosTextBox";
            this.LitrosTextBox.Size = new System.Drawing.Size(151, 23);
            this.LitrosTextBox.TabIndex = 4;
            this.LitrosTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Litros:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Km:";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(243, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Rendimento - Km /Litros";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(243, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Consumo - Litros / Km";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 203);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LitrosTextBox);
            this.Controls.Add(this.KmTextBox);
            this.Controls.Add(this.consumoLabel);
            this.Controls.Add(this.rendimentoLabel);
            this.Controls.Add(this.btnCalcular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consumo e Rendimento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Label4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label rendimentoLabel;
        private System.Windows.Forms.Label consumoLabel;
        private System.Windows.Forms.TextBox KmTextBox;
        private System.Windows.Forms.TextBox LitrosTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}


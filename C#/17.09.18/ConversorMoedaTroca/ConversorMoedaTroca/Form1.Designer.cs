namespace ConversorMoedaTroca
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
            this.Lasbel = new System.Windows.Forms.Label();
            this.ahnsiudas = new System.Windows.Forms.Label();
            this.ValorDaCompra = new System.Windows.Forms.TextBox();
            this.ValorPagoEmDinheiro = new System.Windows.Forms.TextBox();
            this.Troco = new System.Windows.Forms.Label();
            this.TrocoFinal = new System.Windows.Forms.Label();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.troco1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.troco50 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.troco25 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.troco10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.troco05 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.troco01 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lasbel
            // 
            this.Lasbel.AutoSize = true;
            this.Lasbel.Location = new System.Drawing.Point(30, 30);
            this.Lasbel.Name = "Lasbel";
            this.Lasbel.Size = new System.Drawing.Size(88, 13);
            this.Lasbel.TabIndex = 0;
            this.Lasbel.Text = "Valor da Compra:";
            this.Lasbel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ahnsiudas
            // 
            this.ahnsiudas.AutoSize = true;
            this.ahnsiudas.Location = new System.Drawing.Point(15, 67);
            this.ahnsiudas.Name = "ahnsiudas";
            this.ahnsiudas.Size = new System.Drawing.Size(120, 13);
            this.ahnsiudas.TabIndex = 1;
            this.ahnsiudas.Text = "Valor pago em Dinheiro:";
            this.ahnsiudas.Click += new System.EventHandler(this.Val_Click);
            // 
            // ValorDaCompra
            // 
            this.ValorDaCompra.Location = new System.Drawing.Point(146, 25);
            this.ValorDaCompra.Name = "ValorDaCompra";
            this.ValorDaCompra.Size = new System.Drawing.Size(100, 20);
            this.ValorDaCompra.TabIndex = 2;
            // 
            // ValorPagoEmDinheiro
            // 
            this.ValorPagoEmDinheiro.Location = new System.Drawing.Point(146, 64);
            this.ValorPagoEmDinheiro.Name = "ValorPagoEmDinheiro";
            this.ValorPagoEmDinheiro.Size = new System.Drawing.Size(100, 20);
            this.ValorPagoEmDinheiro.TabIndex = 3;
            this.ValorPagoEmDinheiro.TextChanged += new System.EventHandler(this.Txt2_TextChanged);
            // 
            // Troco
            // 
            this.Troco.AutoSize = true;
            this.Troco.Location = new System.Drawing.Point(55, 109);
            this.Troco.Name = "Troco";
            this.Troco.Size = new System.Drawing.Size(38, 13);
            this.Troco.TabIndex = 4;
            this.Troco.Text = "Troco:";
            this.Troco.Click += new System.EventHandler(this.label3_Click);
            // 
            // TrocoFinal
            // 
            this.TrocoFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TrocoFinal.Location = new System.Drawing.Point(146, 104);
            this.TrocoFinal.Name = "TrocoFinal";
            this.TrocoFinal.Size = new System.Drawing.Size(100, 24);
            this.TrocoFinal.TabIndex = 5;
            this.TrocoFinal.Text = "0";
            this.TrocoFinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcular.Location = new System.Drawing.Point(37, 168);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(209, 46);
            this.BtnCalcular.TabIndex = 6;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Moedas de Troco:";
            // 
            // troco1
            // 
            this.troco1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.troco1.Location = new System.Drawing.Point(272, 42);
            this.troco1.Name = "troco1";
            this.troco1.Size = new System.Drawing.Size(32, 23);
            this.troco1.TabIndex = 8;
            this.troco1.Text = "00";
            this.troco1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(323, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Moedas de R$ 1,00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(323, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Moedas de R$ 0,50";
            // 
            // troco50
            // 
            this.troco50.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.troco50.Location = new System.Drawing.Point(272, 70);
            this.troco50.Name = "troco50";
            this.troco50.Size = new System.Drawing.Size(32, 23);
            this.troco50.TabIndex = 10;
            this.troco50.Text = "00";
            this.troco50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(323, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Moedas de R$ 0,25";
            // 
            // troco25
            // 
            this.troco25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.troco25.Location = new System.Drawing.Point(272, 99);
            this.troco25.Name = "troco25";
            this.troco25.Size = new System.Drawing.Size(32, 23);
            this.troco25.TabIndex = 12;
            this.troco25.Text = "00";
            this.troco25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(323, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Moedas de R$ 0,10";
            // 
            // troco10
            // 
            this.troco10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.troco10.Location = new System.Drawing.Point(272, 128);
            this.troco10.Name = "troco10";
            this.troco10.Size = new System.Drawing.Size(32, 23);
            this.troco10.TabIndex = 14;
            this.troco10.Text = "00";
            this.troco10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(323, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Moedas de R$ 0,05";
            // 
            // troco05
            // 
            this.troco05.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.troco05.Location = new System.Drawing.Point(272, 158);
            this.troco05.Name = "troco05";
            this.troco05.Size = new System.Drawing.Size(32, 23);
            this.troco05.TabIndex = 16;
            this.troco05.Text = "00";
            this.troco05.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(323, 196);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Moedas de R$ 0,01";
            // 
            // troco01
            // 
            this.troco01.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.troco01.Location = new System.Drawing.Point(272, 191);
            this.troco01.Name = "troco01";
            this.troco01.Size = new System.Drawing.Size(32, 23);
            this.troco01.TabIndex = 18;
            this.troco01.Text = "00";
            this.troco01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 236);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.troco01);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.troco05);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.troco10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.troco25);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.troco50);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.troco1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.TrocoFinal);
            this.Controls.Add(this.Troco);
            this.Controls.Add(this.ValorPagoEmDinheiro);
            this.Controls.Add(this.ValorDaCompra);
            this.Controls.Add(this.ahnsiudas);
            this.Controls.Add(this.Lasbel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Troco de Moedas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lasbel;
        private System.Windows.Forms.Label ahnsiudas;
        private System.Windows.Forms.TextBox ValorDaCompra;
        private System.Windows.Forms.TextBox ValorPagoEmDinheiro;
        private System.Windows.Forms.Label Troco;
        private System.Windows.Forms.Label TrocoFinal;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label troco1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label troco50;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label troco25;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label troco10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label troco05;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label troco01;
    }
}


namespace CalculoDeFrete
{
    partial class FormCalculaFrete
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
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.listaUF = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelFrete = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.totallabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(81, 18);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(314, 20);
            this.txtCliente.TabIndex = 1;
            // 
            // listaUF
            // 
            this.listaUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listaUF.FormattingEnabled = true;
            this.listaUF.Items.AddRange(new object[] {
            "SP",
            "MG",
            "RJ",
            "AM",
            "Outros"});
            this.listaUF.Location = new System.Drawing.Point(290, 65);
            this.listaUF.Name = "listaUF";
            this.listaUF.Size = new System.Drawing.Size(100, 21);
            this.listaUF.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Valor da compra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "UF";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(104, 66);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(133, 20);
            this.txtValor.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "% Frete";
            // 
            // labelFrete
            // 
            this.labelFrete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFrete.Location = new System.Drawing.Point(81, 109);
            this.labelFrete.Name = "labelFrete";
            this.labelFrete.Size = new System.Drawing.Size(314, 23);
            this.labelFrete.TabIndex = 4;
            this.labelFrete.Text = "0";
            this.labelFrete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(28, 156);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(367, 42);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular Frete";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // totallabel
            // 
            this.totallabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totallabel.Location = new System.Drawing.Point(28, 217);
            this.totallabel.Name = "totallabel";
            this.totallabel.Size = new System.Drawing.Size(367, 68);
            this.totallabel.TabIndex = 0;
            this.totallabel.Text = "0";
            this.totallabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormCalculaFrete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 304);
            this.Controls.Add(this.totallabel);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.labelFrete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listaUF);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalculaFrete";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculo de Frete";
            this.Load += new System.EventHandler(this.FormCalculaFrete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.ComboBox listaUF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelFrete;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label totallabel;
    }
}


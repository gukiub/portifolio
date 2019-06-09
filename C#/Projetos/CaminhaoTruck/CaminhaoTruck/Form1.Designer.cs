namespace CaminhaoTruck
{
    partial class Corpo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Corpo));
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDespesas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtToneladas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLucro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn_Calcular = new System.Windows.Forms.Button();
            this.dtView = new System.Windows.Forms.DataGridView();
            this.BtnLimparCampos = new System.Windows.Forms.Button();
            this.btnLimparDados = new System.Windows.Forms.Button();
            this.CargaToneladas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistanciaKm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lucro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.despesas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duração = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorDiaria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValeApena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTempo
            // 
            this.txtTempo.Location = new System.Drawing.Point(12, 196);
            this.txtTempo.MaxLength = 3;
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(157, 20);
            this.txtTempo.TabIndex = 4;
            this.txtTempo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTempo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Duração da viagem ( Dias )";
            // 
            // txtKm
            // 
            this.txtKm.Location = new System.Drawing.Point(12, 90);
            this.txtKm.MaxLength = 4;
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(157, 20);
            this.txtKm.TabIndex = 2;
            this.txtKm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKm_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Distância em Km";
            // 
            // txtDespesas
            // 
            this.txtDespesas.Location = new System.Drawing.Point(12, 143);
            this.txtDespesas.MaxLength = 6;
            this.txtDespesas.Name = "txtDespesas";
            this.txtDespesas.Size = new System.Drawing.Size(157, 20);
            this.txtDespesas.TabIndex = 3;
            this.txtDespesas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDespesas_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Despesas";
            // 
            // txtToneladas
            // 
            this.txtToneladas.Location = new System.Drawing.Point(12, 37);
            this.txtToneladas.MaxLength = 2;
            this.txtToneladas.Name = "txtToneladas";
            this.txtToneladas.Size = new System.Drawing.Size(157, 20);
            this.txtToneladas.TabIndex = 1;
            this.txtToneladas.TextChanged += new System.EventHandler(this.txtToneladas_TextChanged);
            this.txtToneladas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtToneladas_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Toneladas Transportadas na Viagem ";
            // 
            // txtLucro
            // 
            this.txtLucro.Location = new System.Drawing.Point(12, 249);
            this.txtLucro.MaxLength = 3;
            this.txtLucro.Name = "txtLucro";
            this.txtLucro.Size = new System.Drawing.Size(157, 20);
            this.txtLucro.TabIndex = 5;
            this.txtLucro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLucro_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Margem de Lucro Desejada";
            // 
            // Btn_Calcular
            // 
            this.Btn_Calcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.Btn_Calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Calcular.Location = new System.Drawing.Point(780, 249);
            this.Btn_Calcular.Name = "Btn_Calcular";
            this.Btn_Calcular.Size = new System.Drawing.Size(116, 35);
            this.Btn_Calcular.TabIndex = 6;
            this.Btn_Calcular.Text = "Calcular";
            this.Btn_Calcular.Click += new System.EventHandler(this.Btn_Calcular_Click);
            // 
            // dtView
            // 
            this.dtView.AllowUserToAddRows = false;
            this.dtView.AllowUserToResizeColumns = false;
            this.dtView.AllowUserToResizeRows = false;
            this.dtView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CargaToneladas,
            this.DistanciaKm,
            this.Lucro,
            this.despesas,
            this.Duração,
            this.ValorDiaria,
            this.ValeApena});
            this.dtView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dtView.Location = new System.Drawing.Point(191, 12);
            this.dtView.MultiSelect = false;
            this.dtView.Name = "dtView";
            this.dtView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtView.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dtView.Size = new System.Drawing.Size(705, 231);
            this.dtView.TabIndex = 0;
            // 
            // BtnLimparCampos
            // 
            this.BtnLimparCampos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.BtnLimparCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimparCampos.Location = new System.Drawing.Point(536, 249);
            this.BtnLimparCampos.Name = "BtnLimparCampos";
            this.BtnLimparCampos.Size = new System.Drawing.Size(116, 35);
            this.BtnLimparCampos.TabIndex = 8;
            this.BtnLimparCampos.Text = "Limpar";
            this.BtnLimparCampos.Click += new System.EventHandler(this.BtnLimparCampos_Click);
            // 
            // btnLimparDados
            // 
            this.btnLimparDados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnLimparDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparDados.Location = new System.Drawing.Point(658, 249);
            this.btnLimparDados.Name = "btnLimparDados";
            this.btnLimparDados.Size = new System.Drawing.Size(116, 35);
            this.btnLimparDados.TabIndex = 7;
            this.btnLimparDados.Text = "Deletar Linha";
            this.btnLimparDados.Click += new System.EventHandler(this.BtnLimparDados_Click);
            // 
            // CargaToneladas
            // 
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.CargaToneladas.DefaultCellStyle = dataGridViewCellStyle2;
            this.CargaToneladas.HeaderText = "Custo Da Viagem";
            this.CargaToneladas.Name = "CargaToneladas";
            this.CargaToneladas.ReadOnly = true;
            this.CargaToneladas.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // DistanciaKm
            // 
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.DistanciaKm.DefaultCellStyle = dataGridViewCellStyle3;
            this.DistanciaKm.HeaderText = "Valor do Frete";
            this.DistanciaKm.Name = "DistanciaKm";
            this.DistanciaKm.ReadOnly = true;
            this.DistanciaKm.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Lucro
            // 
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.Lucro.DefaultCellStyle = dataGridViewCellStyle4;
            this.Lucro.HeaderText = "Lucro";
            this.Lucro.Name = "Lucro";
            this.Lucro.ReadOnly = true;
            this.Lucro.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // despesas
            // 
            dataGridViewCellStyle5.NullValue = null;
            this.despesas.DefaultCellStyle = dataGridViewCellStyle5;
            this.despesas.HeaderText = "Margem do Lucro";
            this.despesas.Name = "despesas";
            this.despesas.ReadOnly = true;
            this.despesas.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Duração
            // 
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.Duração.DefaultCellStyle = dataGridViewCellStyle6;
            this.Duração.HeaderText = "Frete/Km";
            this.Duração.Name = "Duração";
            this.Duração.ReadOnly = true;
            this.Duração.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ValorDiaria
            // 
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            this.ValorDiaria.DefaultCellStyle = dataGridViewCellStyle7;
            this.ValorDiaria.HeaderText = "Valor da Diaria";
            this.ValorDiaria.Name = "ValorDiaria";
            this.ValorDiaria.ReadOnly = true;
            this.ValorDiaria.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ValeApena
            // 
            this.ValeApena.HeaderText = "Vale a pena?";
            this.ValeApena.Name = "ValeApena";
            this.ValeApena.ReadOnly = true;
            // 
            // Corpo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 293);
            this.Controls.Add(this.btnLimparDados);
            this.Controls.Add(this.BtnLimparCampos);
            this.Controls.Add(this.dtView);
            this.Controls.Add(this.Btn_Calcular);
            this.Controls.Add(this.txtLucro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtToneladas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDespesas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Corpo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculo Despesas Caminhão Truck";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Corpo_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dtView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDespesas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtToneladas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLucro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Btn_Calcular;
        private System.Windows.Forms.DataGridView dtView;
        private System.Windows.Forms.Button BtnLimparCampos;
        private System.Windows.Forms.Button btnLimparDados;
        private System.Windows.Forms.DataGridViewTextBoxColumn CargaToneladas;
        private System.Windows.Forms.DataGridViewTextBoxColumn DistanciaKm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lucro;
        private System.Windows.Forms.DataGridViewTextBoxColumn despesas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duração;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorDiaria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValeApena;
    }
}


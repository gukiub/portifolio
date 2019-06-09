namespace WindowsFormsApplication13
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtKM = new System.Windows.Forms.TextBox();
            this.txtL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnC = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RKL = new System.Windows.Forms.Label();
            this.CLK = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtKM
            // 
            this.txtKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKM.Location = new System.Drawing.Point(41, 48);
            this.txtKM.Name = "txtKM";
            this.txtKM.Size = new System.Drawing.Size(107, 22);
            this.txtKM.TabIndex = 0;
            this.txtKM.TextChanged += new System.EventHandler(this.txtKM_TextChanged);
            // 
            // txtL
            // 
            this.txtL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtL.Location = new System.Drawing.Point(41, 76);
            this.txtL.Name = "txtL";
            this.txtL.Size = new System.Drawing.Size(107, 22);
            this.txtL.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Consumo L/km";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(163, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rendimento KM/L";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(27, 164);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(236, 44);
            this.btnC.TabIndex = 4;
            this.btnC.Text = "calcular";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "KM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Litros";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // RKL
            // 
            this.RKL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RKL.Location = new System.Drawing.Point(157, 101);
            this.RKL.Name = "RKL";
            this.RKL.Size = new System.Drawing.Size(121, 32);
            this.RKL.TabIndex = 7;
            this.RKL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RKL.Click += new System.EventHandler(this.label5_Click);
            // 
            // CLK
            // 
            this.CLK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CLK.Location = new System.Drawing.Point(157, 43);
            this.CLK.Name = "CLK";
            this.CLK.Size = new System.Drawing.Size(121, 33);
            this.CLK.TabIndex = 8;
            this.CLK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CLK.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CLK);
            this.Controls.Add(this.RKL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtL);
            this.Controls.Add(this.txtKM);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consumo Rendimento";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKM;
        private System.Windows.Forms.TextBox txtL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label RKL;
        private System.Windows.Forms.Label CLK;
    }
}


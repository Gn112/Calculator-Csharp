namespace CalculadoraCsharp
{
    partial class Calculadora
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
            this.op1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCal = new System.Windows.Forms.TextBox();
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.bPonto = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.bLimpa = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.bMulti = new System.Windows.Forms.Button();
            this.bMais = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.bMenos = new System.Windows.Forms.Button();
            this.bDiv = new System.Windows.Forms.Button();
            this.bResul = new System.Windows.Forms.Button();
            this.op2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // op1
            // 
            this.op1.AutoSize = true;
            this.op1.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.op1.Location = new System.Drawing.Point(35, 17);
            this.op1.Name = "op1";
            this.op1.Size = new System.Drawing.Size(50, 20);
            this.op1.TabIndex = 0;
            this.op1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // txtCal
            // 
            this.txtCal.BackColor = System.Drawing.SystemColors.Control;
            this.txtCal.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCal.Location = new System.Drawing.Point(36, 40);
            this.txtCal.Name = "txtCal";
            this.txtCal.Size = new System.Drawing.Size(185, 46);
            this.txtCal.TabIndex = 2;
            this.txtCal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // b7
            // 
            this.b7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b7.Location = new System.Drawing.Point(36, 86);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(47, 47);
            this.b7.TabIndex = 4;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // b8
            // 
            this.b8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b8.Location = new System.Drawing.Point(82, 86);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(47, 47);
            this.b8.TabIndex = 5;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.b8_Click);
            // 
            // b9
            // 
            this.b9.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b9.Location = new System.Drawing.Point(128, 86);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(47, 47);
            this.b9.TabIndex = 6;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.b9_Click);
            // 
            // bPonto
            // 
            this.bPonto.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.bPonto.Location = new System.Drawing.Point(174, 86);
            this.bPonto.Name = "bPonto";
            this.bPonto.Size = new System.Drawing.Size(47, 47);
            this.bPonto.TabIndex = 7;
            this.bPonto.Text = ".";
            this.bPonto.UseVisualStyleBackColor = true;
            this.bPonto.Click += new System.EventHandler(this.bPonto_Click);
            // 
            // b4
            // 
            this.b4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b4.Location = new System.Drawing.Point(36, 132);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(47, 47);
            this.b4.TabIndex = 8;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b5
            // 
            this.b5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b5.Location = new System.Drawing.Point(82, 132);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(47, 47);
            this.b5.TabIndex = 9;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b6
            // 
            this.b6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b6.Location = new System.Drawing.Point(128, 132);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(47, 47);
            this.b6.TabIndex = 10;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // bLimpa
            // 
            this.bLimpa.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.bLimpa.Location = new System.Drawing.Point(174, 132);
            this.bLimpa.Name = "bLimpa";
            this.bLimpa.Size = new System.Drawing.Size(47, 47);
            this.bLimpa.TabIndex = 11;
            this.bLimpa.Text = "CE";
            this.bLimpa.UseVisualStyleBackColor = true;
            this.bLimpa.Click += new System.EventHandler(this.bLimpa_Click);
            // 
            // b1
            // 
            this.b1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(36, 178);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(47, 47);
            this.b1.TabIndex = 12;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // b2
            // 
            this.b2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.Location = new System.Drawing.Point(82, 178);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(47, 47);
            this.b2.TabIndex = 13;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b3
            // 
            this.b3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.Location = new System.Drawing.Point(128, 178);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(47, 47);
            this.b3.TabIndex = 14;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // bMulti
            // 
            this.bMulti.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.bMulti.Location = new System.Drawing.Point(174, 178);
            this.bMulti.Name = "bMulti";
            this.bMulti.Size = new System.Drawing.Size(47, 47);
            this.bMulti.TabIndex = 15;
            this.bMulti.Text = "*";
            this.bMulti.UseVisualStyleBackColor = true;
            this.bMulti.Click += new System.EventHandler(this.bMulti_Click);
            // 
            // bMais
            // 
            this.bMais.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.bMais.Location = new System.Drawing.Point(36, 224);
            this.bMais.Name = "bMais";
            this.bMais.Size = new System.Drawing.Size(47, 47);
            this.bMais.TabIndex = 16;
            this.bMais.Text = "+";
            this.bMais.UseVisualStyleBackColor = true;
            this.bMais.Click += new System.EventHandler(this.bMais_Click);
            // 
            // b0
            // 
            this.b0.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b0.Location = new System.Drawing.Point(82, 224);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(47, 47);
            this.b0.TabIndex = 17;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.b0_Click);
            // 
            // bMenos
            // 
            this.bMenos.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.bMenos.Location = new System.Drawing.Point(128, 224);
            this.bMenos.Name = "bMenos";
            this.bMenos.Size = new System.Drawing.Size(47, 47);
            this.bMenos.TabIndex = 18;
            this.bMenos.Text = "-";
            this.bMenos.UseVisualStyleBackColor = true;
            this.bMenos.Click += new System.EventHandler(this.bMenos_Click);
            // 
            // bDiv
            // 
            this.bDiv.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.bDiv.Location = new System.Drawing.Point(174, 224);
            this.bDiv.Name = "bDiv";
            this.bDiv.Size = new System.Drawing.Size(47, 47);
            this.bDiv.TabIndex = 19;
            this.bDiv.Text = "/";
            this.bDiv.UseVisualStyleBackColor = true;
            this.bDiv.Click += new System.EventHandler(this.bDiv_Click);
            // 
            // bResul
            // 
            this.bResul.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.bResul.Location = new System.Drawing.Point(36, 270);
            this.bResul.Name = "bResul";
            this.bResul.Size = new System.Drawing.Size(185, 47);
            this.bResul.TabIndex = 20;
            this.bResul.Text = "=";
            this.bResul.UseVisualStyleBackColor = true;
            this.bResul.Click += new System.EventHandler(this.bResul_Click);
            // 
            // op2
            // 
            this.op2.AutoSize = true;
            this.op2.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.op2.Location = new System.Drawing.Point(171, 17);
            this.op2.Name = "op2";
            this.op2.Size = new System.Drawing.Size(50, 20);
            this.op2.TabIndex = 21;
            this.op2.Text = "label3";
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 345);
            this.Controls.Add(this.op2);
            this.Controls.Add(this.bResul);
            this.Controls.Add(this.bDiv);
            this.Controls.Add(this.bMenos);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.bMais);
            this.Controls.Add(this.bMulti);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.bLimpa);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.bPonto);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.txtCal);
            this.Controls.Add(this.op1);
            this.Name = "Calculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label op1;
        private System.Windows.Forms.TextBox txtCal;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button bPonto;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button bLimpa;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button bMulti;
        private System.Windows.Forms.Button bMais;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button bMenos;
        private System.Windows.Forms.Button bDiv;
        private System.Windows.Forms.Button bResul;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label op2;
    }
}


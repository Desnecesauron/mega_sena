namespace MUV_calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbespacoi = new System.Windows.Forms.TextBox();
            this.txtbveloi = new System.Windows.Forms.TextBox();
            this.txtbtemp = new System.Windows.Forms.TextBox();
            this.txtbace = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Novo = new System.Windows.Forms.Button();
            this.Calc = new System.Windows.Forms.Button();
            this.Sair = new System.Windows.Forms.Button();
            this.novo_espacoi = new System.Windows.Forms.Button();
            this.novo_veloi = new System.Windows.Forms.Button();
            this.novo_temp = new System.Windows.Forms.Button();
            this.novo_ace = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(94, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(40, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quanto mais o tempo passa, mais veloz o objeto fica.";
            // 
            // txtbespacoi
            // 
            this.txtbespacoi.Location = new System.Drawing.Point(160, 164);
            this.txtbespacoi.Name = "txtbespacoi";
            this.txtbespacoi.Size = new System.Drawing.Size(100, 20);
            this.txtbespacoi.TabIndex = 2;
            this.txtbespacoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtbespacoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbespacoi_KeyPress);
            // 
            // txtbveloi
            // 
            this.txtbveloi.Location = new System.Drawing.Point(160, 217);
            this.txtbveloi.Name = "txtbveloi";
            this.txtbveloi.Size = new System.Drawing.Size(100, 20);
            this.txtbveloi.TabIndex = 3;
            this.txtbveloi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtbveloi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbveloi_KeyPress);
            // 
            // txtbtemp
            // 
            this.txtbtemp.Location = new System.Drawing.Point(160, 273);
            this.txtbtemp.Name = "txtbtemp";
            this.txtbtemp.Size = new System.Drawing.Size(100, 20);
            this.txtbtemp.TabIndex = 4;
            this.txtbtemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtbtemp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbtemp_KeyPress);
            // 
            // txtbace
            // 
            this.txtbace.Location = new System.Drawing.Point(160, 334);
            this.txtbace.Name = "txtbace";
            this.txtbace.Size = new System.Drawing.Size(100, 20);
            this.txtbace.TabIndex = 37;
            this.txtbace.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtbace.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbace_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Espaço inicial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Velocidade inicial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tempo decorrido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label5.Location = new System.Drawing.Point(387, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 39);
            this.label5.TabIndex = 8;
            this.label5.Text = "S=";
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblResult.Location = new System.Drawing.Point(453, 211);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(215, 78);
            this.lblResult.TabIndex = 35;
            this.lblResult.Text = "                                                                  ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Aceleração";
            // 
            // Novo
            // 
            this.Novo.Location = new System.Drawing.Point(94, 403);
            this.Novo.Name = "Novo";
            this.Novo.Size = new System.Drawing.Size(75, 23);
            this.Novo.TabIndex = 38;
            this.Novo.Text = "&Novo";
            this.Novo.UseVisualStyleBackColor = true;
            this.Novo.Click += new System.EventHandler(this.Novo_Click_1);
            // 
            // Calc
            // 
            this.Calc.Location = new System.Drawing.Point(332, 403);
            this.Calc.Name = "Calc";
            this.Calc.Size = new System.Drawing.Size(75, 23);
            this.Calc.TabIndex = 39;
            this.Calc.Text = "&Calcular";
            this.Calc.UseVisualStyleBackColor = true;
            this.Calc.Click += new System.EventHandler(this.Calc_Click);
            // 
            // Sair
            // 
            this.Sair.Location = new System.Drawing.Point(614, 403);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(75, 23);
            this.Sair.TabIndex = 40;
            this.Sair.Text = "&Sair";
            this.Sair.UseVisualStyleBackColor = true;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // novo_espacoi
            // 
            this.novo_espacoi.Location = new System.Drawing.Point(531, 64);
            this.novo_espacoi.Name = "novo_espacoi";
            this.novo_espacoi.Size = new System.Drawing.Size(77, 36);
            this.novo_espacoi.TabIndex = 41;
            this.novo_espacoi.Text = "&Espaço Inicial";
            this.novo_espacoi.UseVisualStyleBackColor = true;
            this.novo_espacoi.Click += new System.EventHandler(this.novo_espacoi_Click);
            // 
            // novo_veloi
            // 
            this.novo_veloi.Location = new System.Drawing.Point(614, 64);
            this.novo_veloi.Name = "novo_veloi";
            this.novo_veloi.Size = new System.Drawing.Size(75, 36);
            this.novo_veloi.TabIndex = 42;
            this.novo_veloi.Text = "&Velocidade Inicial";
            this.novo_veloi.UseVisualStyleBackColor = true;
            this.novo_veloi.Click += new System.EventHandler(this.novo_veloi_Click);
            // 
            // novo_temp
            // 
            this.novo_temp.Location = new System.Drawing.Point(531, 106);
            this.novo_temp.Name = "novo_temp";
            this.novo_temp.Size = new System.Drawing.Size(76, 35);
            this.novo_temp.TabIndex = 43;
            this.novo_temp.Text = "&Tempo decorrido";
            this.novo_temp.UseVisualStyleBackColor = true;
            this.novo_temp.Click += new System.EventHandler(this.novo_temp_Click);
            // 
            // novo_ace
            // 
            this.novo_ace.Location = new System.Drawing.Point(613, 106);
            this.novo_ace.Name = "novo_ace";
            this.novo_ace.Size = new System.Drawing.Size(76, 35);
            this.novo_ace.TabIndex = 44;
            this.novo_ace.Text = "&Aceleração";
            this.novo_ace.UseVisualStyleBackColor = true;
            this.novo_ace.Click += new System.EventHandler(this.novo_ace_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label7.Location = new System.Drawing.Point(453, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(335, 39);
            this.label7.TabIndex = 45;
            this.label7.Text = "Diferentes incógnitas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label8.Location = new System.Drawing.Point(267, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 20);
            this.label8.TabIndex = 83;
            this.label8.Text = "Incógnita: Espaço final";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(682, 254);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 92;
            this.label12.Text = "Metros";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(266, 337);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 13);
            this.label11.TabIndex = 91;
            this.label11.Text = "Metros/segundo²";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(266, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 90;
            this.label10.Text = "Segundos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(266, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 89;
            this.label9.Text = "Metros/segundo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(266, 167);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 88;
            this.label13.Text = "Metros";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.novo_ace);
            this.Controls.Add(this.novo_temp);
            this.Controls.Add(this.novo_veloi);
            this.Controls.Add(this.novo_espacoi);
            this.Controls.Add(this.Sair);
            this.Controls.Add(this.Calc);
            this.Controls.Add(this.Novo);
            this.Controls.Add(this.txtbace);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbtemp);
            this.Controls.Add(this.txtbveloi);
            this.Controls.Add(this.txtbespacoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Calculadora de Movimento Uniformemente Variado";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbespacoi;
        private System.Windows.Forms.TextBox txtbveloi;
        private System.Windows.Forms.TextBox txtbtemp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbace;
        private System.Windows.Forms.Button Novo;
        private System.Windows.Forms.Button Calc;
        private System.Windows.Forms.Button Sair;
        private System.Windows.Forms.Button novo_espacoi;
        private System.Windows.Forms.Button novo_veloi;
        private System.Windows.Forms.Button novo_temp;
        private System.Windows.Forms.Button novo_ace;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
    }
}


namespace MUV_calculator
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.Sair = new System.Windows.Forms.Button();
            this.Calc = new System.Windows.Forms.Button();
            this.Novo = new System.Windows.Forms.Button();
            this.txtbace = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbespacof = new System.Windows.Forms.TextBox();
            this.txtbveloi = new System.Windows.Forms.TextBox();
            this.txtbespacoi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Sair
            // 
            this.Sair.Location = new System.Drawing.Point(631, 409);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(75, 23);
            this.Sair.TabIndex = 80;
            this.Sair.Text = "&Sair";
            this.Sair.UseVisualStyleBackColor = true;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // Calc
            // 
            this.Calc.Location = new System.Drawing.Point(349, 409);
            this.Calc.Name = "Calc";
            this.Calc.Size = new System.Drawing.Size(75, 23);
            this.Calc.TabIndex = 79;
            this.Calc.Text = "&Calcular";
            this.Calc.UseVisualStyleBackColor = true;
            this.Calc.Click += new System.EventHandler(this.Calc_Click);
            // 
            // Novo
            // 
            this.Novo.Location = new System.Drawing.Point(111, 409);
            this.Novo.Name = "Novo";
            this.Novo.Size = new System.Drawing.Size(75, 23);
            this.Novo.TabIndex = 78;
            this.Novo.Text = "&Novo";
            this.Novo.UseVisualStyleBackColor = true;
            this.Novo.Click += new System.EventHandler(this.Novo_Click);
            // 
            // txtbace
            // 
            this.txtbace.Location = new System.Drawing.Point(177, 340);
            this.txtbace.Name = "txtbace";
            this.txtbace.Size = new System.Drawing.Size(100, 20);
            this.txtbace.TabIndex = 77;
            this.txtbace.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtbace.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbace_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 76;
            this.label6.Text = "Aceleração";
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblResult.Location = new System.Drawing.Point(470, 217);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(215, 78);
            this.lblResult.TabIndex = 75;
            this.lblResult.Text = "                                                                  ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label5.Location = new System.Drawing.Point(404, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 39);
            this.label5.TabIndex = 74;
            this.label5.Text = "T=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 73;
            this.label4.Text = "Espaço final";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 72;
            this.label3.Text = "Velocidade inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 71;
            this.label2.Text = "Espaço Inicial";
            // 
            // txtbespacof
            // 
            this.txtbespacof.Location = new System.Drawing.Point(177, 279);
            this.txtbespacof.Name = "txtbespacof";
            this.txtbespacof.Size = new System.Drawing.Size(100, 20);
            this.txtbespacof.TabIndex = 70;
            this.txtbespacof.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtbespacof.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbespacof_KeyPress);
            // 
            // txtbveloi
            // 
            this.txtbveloi.Location = new System.Drawing.Point(177, 223);
            this.txtbveloi.Name = "txtbveloi";
            this.txtbveloi.Size = new System.Drawing.Size(100, 20);
            this.txtbveloi.TabIndex = 69;
            this.txtbveloi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtbveloi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbveloi_KeyPress);
            // 
            // txtbespacoi
            // 
            this.txtbespacoi.Location = new System.Drawing.Point(177, 170);
            this.txtbespacoi.Name = "txtbespacoi";
            this.txtbespacoi.Size = new System.Drawing.Size(100, 20);
            this.txtbespacoi.TabIndex = 68;
            this.txtbespacoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtbespacoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbespacoi_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(84, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 24);
            this.label1.TabIndex = 67;
            this.label1.Text = "Quanto mais o tempo passa, mais veloz o objeto fica.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(138, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label7.Location = new System.Drawing.Point(294, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 20);
            this.label7.TabIndex = 82;
            this.label7.Text = "Incógnita: Tempo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(283, 282);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 92;
            this.label12.Text = "Metros";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(283, 343);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 13);
            this.label11.TabIndex = 91;
            this.label11.Text = "Metros/segundo²";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(691, 255);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 90;
            this.label10.Text = "Segundos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(283, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 89;
            this.label9.Text = "Metros/segundo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(283, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 88;
            this.label8.Text = "Metros";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
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
            this.Controls.Add(this.txtbespacof);
            this.Controls.Add(this.txtbveloi);
            this.Controls.Add(this.txtbespacoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form4";
            this.Text = "Calculadora de Movimento Uniformemente Variado";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Sair;
        private System.Windows.Forms.Button Calc;
        private System.Windows.Forms.Button Novo;
        private System.Windows.Forms.TextBox txtbace;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbespacof;
        private System.Windows.Forms.TextBox txtbveloi;
        private System.Windows.Forms.TextBox txtbespacoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tele_Sena_Sorteador
{
    public partial class Sorteador : Form
    {
        public Sorteador(System.Windows.Forms.FileDialog openFileDialog1)
        {
            InitializeComponent();
            Valor.FileName = openFileDialog1.FileName;
            Num_apostas.Text = "6";

            if(Num_apostas.Text == "6")
            {
                label7.Visible = false;
                textBox7.Visible = false;

                label8.Visible = false;
                textBox8.Visible = false;

                label9.Visible = false;
                textBox9.Visible = false;

                label10.Visible = false;
                textBox10.Visible = false;

                label11.Visible = false;
                textBox11.Visible = false;

                label12.Visible = false;
                textBox12.Visible = false;

                label13.Visible = false;
                textBox13.Visible = false;

                label14.Visible = false;
                textBox14.Visible = false;

                label15.Visible = false;
                textBox15.Visible = false;
            }

            label16.Visible = false;
            Numsort.Visible = false;
            label18.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Valor.FileName == " ")
            {
                DialogResult resposta;
                resposta = MessageBox.Show("Você não carregou nenhuma foto no menu!!!",
                    "Mega Sena",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                Fotinha.Load(Valor.FileName);
            }
        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            DialogFt.Title = "Escolha uma foto";
            if (DialogFt.ShowDialog() == DialogResult.OK)
            {
                Fotinha.Load(DialogFt.FileName);
            }
        }

        private void Sortei_Click(object sender, EventArgs e)
        {
            Random sorteio = new Random();
            Sorteio1.Text = Convert.ToString(sorteio.Next(1, 60));
            do
            {
                Sorteio2.Text = Convert.ToString(sorteio.Next(1, 60));
            } while (Sorteio2.Text == Sorteio1.Text);

            do
            {
                Sorteio3.Text = Convert.ToString(sorteio.Next(1, 60));
            } while (Sorteio3.Text == Sorteio1.Text || Sorteio3.Text == Sorteio2.Text);

            do
            {
                Sorteio4.Text = Convert.ToString(sorteio.Next(1, 60));
            } while (Sorteio4.Text == Sorteio1.Text || Sorteio4.Text == Sorteio2.Text || Sorteio4.Text == Sorteio3.Text);

            do
            {
                Sorteio5.Text = Convert.ToString(sorteio.Next(1, 60));
            } while (Sorteio5.Text == Sorteio1.Text || Sorteio5.Text == Sorteio2.Text || Sorteio5.Text == Sorteio3.Text || Sorteio5.Text == Sorteio4.Text);

            do
            {
                Sorteio6.Text = Convert.ToString(sorteio.Next(1, 60));
            } while (Sorteio6.Text == Sorteio1.Text || Sorteio6.Text == Sorteio2.Text || Sorteio6.Text == Sorteio3.Text || Sorteio6.Text == Sorteio4.Text || Sorteio6.Text == Sorteio5.Text);

            int x = 0;

            if(Sorteio1.Text == textBox1.Text || Sorteio1.Text == textBox2.Text || Sorteio1.Text == textBox3.Text || Sorteio1.Text == textBox4.Text || Sorteio1.Text == textBox5.Text || Sorteio1.Text == textBox6.Text || Sorteio1.Text == textBox7.Text || Sorteio1.Text == textBox8.Text || Sorteio1.Text ==textBox9.Text || Sorteio1.Text == textBox10.Text || Sorteio1.Text == textBox11.Text || Sorteio1.Text == textBox12.Text || Sorteio1.Text == textBox13.Text || Sorteio1.Text == textBox14.Text || Sorteio1.Text == textBox15.Text)
            {
                x++;
            }

            if (Sorteio2.Text == textBox1.Text || Sorteio2.Text == textBox2.Text || Sorteio2.Text == textBox3.Text || Sorteio2.Text == textBox4.Text || Sorteio2.Text == textBox5.Text || Sorteio2.Text == textBox6.Text || Sorteio2.Text == textBox7.Text || Sorteio2.Text == textBox8.Text || Sorteio2.Text == textBox9.Text || Sorteio2.Text == textBox10.Text || Sorteio2.Text == textBox11.Text || Sorteio2.Text == textBox12.Text || Sorteio2.Text == textBox13.Text || Sorteio2.Text == textBox14.Text || Sorteio2.Text == textBox15.Text)
            {
                x++;
            }
            
            if (Sorteio3.Text == textBox1.Text || Sorteio3.Text == textBox2.Text || Sorteio3.Text == textBox3.Text || Sorteio3.Text == textBox4.Text || Sorteio3.Text == textBox5.Text || Sorteio3.Text == textBox6.Text || Sorteio3.Text == textBox7.Text || Sorteio3.Text == textBox8.Text || Sorteio3.Text == textBox9.Text || Sorteio3.Text == textBox10.Text || Sorteio3.Text == textBox11.Text || Sorteio3.Text == textBox12.Text || Sorteio3.Text == textBox13.Text || Sorteio3.Text == textBox14.Text || Sorteio3.Text == textBox15.Text)
            {
                x++;
            }

            if (Sorteio4.Text == textBox1.Text || Sorteio4.Text == textBox2.Text || Sorteio4.Text == textBox3.Text || Sorteio4.Text == textBox4.Text || Sorteio4.Text == textBox5.Text || Sorteio4.Text == textBox6.Text || Sorteio4.Text == textBox7.Text || Sorteio4.Text == textBox8.Text || Sorteio4.Text == textBox9.Text || Sorteio4.Text == textBox10.Text || Sorteio4.Text == textBox11.Text || Sorteio4.Text == textBox12.Text || Sorteio4.Text == textBox13.Text || Sorteio4.Text == textBox14.Text || Sorteio4.Text == textBox15.Text)
            {
                x++;
            }

            if (Sorteio5.Text == textBox1.Text || Sorteio5.Text == textBox2.Text || Sorteio5.Text == textBox3.Text || Sorteio5.Text == textBox4.Text || Sorteio5.Text == textBox5.Text || Sorteio5.Text == textBox6.Text || Sorteio5.Text == textBox7.Text || Sorteio5.Text == textBox8.Text || Sorteio5.Text == textBox9.Text || Sorteio5.Text == textBox10.Text || Sorteio5.Text == textBox11.Text || Sorteio5.Text == textBox12.Text || Sorteio5.Text == textBox13.Text || Sorteio5.Text == textBox14.Text || Sorteio5.Text == textBox15.Text)
            {
                x++;
            }

            if(Sorteio6.Text == textBox1.Text || Sorteio6.Text == textBox2.Text || Sorteio6.Text == textBox3.Text || Sorteio6.Text == textBox4.Text || Sorteio6.Text == textBox5.Text || Sorteio6.Text == textBox6.Text || Sorteio6.Text == textBox7.Text || Sorteio6.Text == textBox8.Text || Sorteio6.Text == textBox9.Text || Sorteio6.Text == textBox10.Text || Sorteio6.Text == textBox11.Text || Sorteio6.Text == textBox12.Text || Sorteio6.Text == textBox13.Text || Sorteio6.Text == textBox14.Text || Sorteio6.Text == textBox15.Text)   
            {
                x++;
            }
            label16.Visible = true;
            Numsort.Visible = true;
            label18.Visible = true;
            Numsort.Text = Convert.ToString(x);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Num_apostas.Text = Convert.ToString(trackBar1.Value);
            if(Num_apostas.Text == "6")
            {
                label7.Visible = false;
                textBox7.Visible = false;
                textBox7.Text = null;
         
                label8.Visible = false;
                textBox8.Visible = false;
                textBox8.Text = null;

                label9.Visible = false;
                textBox9.Visible = false;
                textBox9.Text = null;

                label10.Visible = false;
                textBox10.Visible = false;
                textBox10.Text = null;

                label11.Visible = false;
                textBox11.Visible = false;
                textBox11.Text = null;

                label12.Visible = false;
                textBox12.Visible = false;
                textBox12.Text = null;

                label13.Visible = false;
                textBox13.Visible = false;
                textBox13.Text = null;

                label14.Visible = false;
                textBox14.Visible = false;
                textBox14.Text = null;

                label15.Visible = false;
                textBox15.Visible = false;
                textBox15.Text = null;
            }
            else if(Num_apostas.Text == "7")
            {
                label7.Visible = true;
                textBox7.Visible = true;
                //textBox7.Text = null;

                label8.Visible = false;
                textBox8.Visible = false;
                textBox8.Text = null;

                label9.Visible = false;
                textBox9.Visible = false;
                textBox9.Text = null;

                label10.Visible = false;
                textBox10.Visible = false;
                textBox10.Text = null;

                label11.Visible = false;
                textBox11.Visible = false;
                textBox11.Text = null;

                label12.Visible = false;
                textBox12.Visible = false;
                textBox12.Text = null;

                label13.Visible = false;
                textBox13.Visible = false;
                textBox13.Text = null;

                label14.Visible = false;
                textBox14.Visible = false;
                textBox14.Text = null;

                label15.Visible = false;
                textBox15.Visible = false;
                textBox15.Text = null;
            }
            else if(Num_apostas.Text == "8")
            {
                label7.Visible = true;
                textBox7.Visible = true;
                //textBox7.Text = null;

                label8.Visible = true;
                textBox8.Visible = true;
                //textBox8.Text = null;

                label9.Visible = false;
                textBox9.Visible = false;
                textBox9.Text = null;

                label10.Visible = false;
                textBox10.Visible = false;
                textBox10.Text = null;

                label11.Visible = false;
                textBox11.Visible = false;
                textBox11.Text = null;

                label12.Visible = false;
                textBox12.Visible = false;
                textBox12.Text = null;

                label13.Visible = false;
                textBox13.Visible = false;
                textBox13.Text = null;

                label14.Visible = false;
                textBox14.Visible = false;
                textBox14.Text = null;

                label15.Visible = false;
                textBox15.Visible = false;
                textBox15.Text = null;
            }
            else if(Num_apostas.Text == "9")
            {
                label7.Visible = true;
                textBox7.Visible = true;
                //textBox7.Text = null;

                label8.Visible = true;
                textBox8.Visible = true;
                //textBox8.Text = null;

                label9.Visible = true;
                textBox9.Visible = true;
                //textBox9.Text = null;

                label10.Visible = false;
                textBox10.Visible = false;
                textBox10.Text = null;

                label11.Visible = false;
                textBox11.Visible = false;
                textBox11.Text = null;

                label12.Visible = false;
                textBox12.Visible = false;
                textBox12.Text = null;

                label13.Visible = false;
                textBox13.Visible = false;
                textBox13.Text = null;

                label14.Visible = false;
                textBox14.Visible = false;
                textBox14.Text = null;

                label15.Visible = false;
                textBox15.Visible = false;
                textBox15.Text = null;
            }
            else if(Num_apostas.Text == "10")
            {
                label7.Visible = true;
                textBox7.Visible = true;
                //textBox7.Text = null;

                label8.Visible = true;
                textBox8.Visible = true;
                //textBox8.Text = null;

                label9.Visible = true;
                textBox9.Visible = true;
                //textBox9.Text = null;

                label10.Visible = true;
                textBox10.Visible = true;
                //textBox10.Text = null;

                label11.Visible = false;
                textBox11.Visible = false;
                textBox11.Text = null;

                label12.Visible = false;
                textBox12.Visible = false;
                textBox12.Text = null;

                label13.Visible = false;
                textBox13.Visible = false;
                textBox13.Text = null;

                label14.Visible = false;
                textBox14.Visible = false;
                textBox14.Text = null;

                label15.Visible = false;
                textBox15.Visible = false;
                textBox15.Text = null;
            }
            else if(Num_apostas.Text == "11")
            {
                label7.Visible = true;
                textBox7.Visible = true;
                //textBox7.Text = null;

                label8.Visible = true;
                textBox8.Visible = true;
                //textBox8.Text = null;

                label9.Visible = true;
                textBox9.Visible = true;
                //textBox9.Text = null;

                label10.Visible = true;
                textBox10.Visible = true;
                //textBox10.Text = null;

                label11.Visible = true;
                textBox11.Visible = true;
                //textBox11.Text = null;

                label12.Visible = false;
                textBox12.Visible = false;
                textBox12.Text = null;

                label13.Visible = false;
                textBox13.Visible = false;
                textBox13.Text = null;

                label14.Visible = false;
                textBox14.Visible = false;
                textBox14.Text = null;

                label15.Visible = false;
                textBox15.Visible = false;
                textBox15.Text = null;
            }
            else if(Num_apostas.Text == "12")
            {
                label7.Visible = true;
                textBox7.Visible = true;
                //textBox7.Text = null;

                label8.Visible = true;
                textBox8.Visible = true;
                //textBox8.Text = null;

                label9.Visible = true;
                textBox9.Visible = true;
                //textBox9.Text = null;

                label10.Visible = true;
                textBox10.Visible = true;
                //textBox10.Text = null;

                label11.Visible = true;
                textBox11.Visible = true;
                //textBox11.Text = null;

                label12.Visible = true;
                textBox12.Visible = true;
                //textBox12.Text = null;

                label13.Visible = false;
                textBox13.Visible = false;
                textBox13.Text = null;

                label14.Visible = false;
                textBox14.Visible = false;
                textBox14.Text = null;

                label15.Visible = false;
                textBox15.Visible = false;
                textBox15.Text = null;
            }
            else if(Num_apostas.Text == "13")
            {
                label7.Visible = true;
                textBox7.Visible = true;
                //textBox7.Text = null;

                label8.Visible = true;
                textBox8.Visible = true;
                //textBox8.Text = null;

                label9.Visible = true;
                textBox9.Visible = true;
                //textBox9.Text = null;

                label10.Visible = true;
                textBox10.Visible = true;
                //textBox10.Text = null;

                label11.Visible = true;
                textBox11.Visible = true;
                //textBox11.Text = null;

                label12.Visible = true;
                textBox12.Visible = true;
                //textBox12.Text = null;

                label13.Visible = true;
                textBox13.Visible = true;
                //textBox13.Text = null;

                label14.Visible = false;
                textBox14.Visible = false;
                textBox14.Text = null;

                label15.Visible = false;
                textBox15.Visible = false;
                textBox15.Text = null;
            }
            else if(Num_apostas.Text == "14")
            {
                label7.Visible = true;
                textBox7.Visible = true;
                //textBox7.Text = null;

                label8.Visible = true;
                textBox8.Visible = true;
                //textBox8.Text = null;

                label9.Visible = true;
                textBox9.Visible = true;
                //textBox9.Text = null;

                label10.Visible = true;
                textBox10.Visible = true;
                //textBox10.Text = null;

                label11.Visible = true;
                textBox11.Visible = true;
                //textBox11.Text = null;

                label12.Visible = true;
                textBox12.Visible = true;
                //textBox12.Text = null;

                label13.Visible = true;
                textBox13.Visible = true;
                //textBox13.Text = null;

                label14.Visible = true;
                textBox14.Visible = true;
                //textBox14.Text = null;

                label15.Visible = false;
                textBox15.Visible = false;
                textBox15.Text = null;
            }
            else if(Num_apostas.Text == "15")
            {
                label7.Visible = true;
                textBox7.Visible = true;
                //textBox7.Text = null;

                label8.Visible = true;
                textBox8.Visible = true;
                //textBox8.Text = null;

                label9.Visible = true;
                textBox9.Visible = true;
                //textBox9.Text = null;

                label10.Visible = true;
                textBox10.Visible = true;
                //textBox10.Text = null;

                label11.Visible = true;
                textBox11.Visible = true;
                //textBox11.Text = null;

                label12.Visible = true;
                textBox12.Visible = true;
                //textBox12.Text = null;

                label13.Visible = true;
                textBox13.Visible = true;
                //textBox13.Text = null;

                label14.Visible = true;
                textBox14.Visible = true;
                //textBox14.Text = null;

                label15.Visible = true;
                textBox15.Visible = true;
                //textBox15.Text = null;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13) //código do enter em ASCII
            {
                textBox2.Focus();
            }

            else if ((Char.IsDigit(e.KeyChar)) || (Char.IsControl(e.KeyChar)))
                e.Handled = false;

            else
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) //código do enter em ASCII
            {
                textBox3.Focus();
            }

            else if ((Char.IsDigit(e.KeyChar)) || (Char.IsControl(e.KeyChar)))
                e.Handled = false;

            else
                e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) //código do enter em ASCII
            {
                textBox4.Focus();
            }

            else if ((Char.IsDigit(e.KeyChar)) || (Char.IsControl(e.KeyChar)))
                e.Handled = false;

            else
                e.Handled = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) //código do enter em ASCII
            {
                textBox5.Focus();
            }

            else if ((Char.IsDigit(e.KeyChar)) || (Char.IsControl(e.KeyChar)))
                e.Handled = false;

            else
                e.Handled = true;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) //código do enter em ASCII
            {
                textBox6.Focus();
            }

            else if ((Char.IsDigit(e.KeyChar)) || (Char.IsControl(e.KeyChar)))
                e.Handled = false;

            else
                e.Handled = true;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) //código do enter em ASCII
            {
                if (textBox7.Visible == true)
                    textBox7.Focus();
                else
                    trackBar1.Focus();
            }

            else if ((Char.IsDigit(e.KeyChar)) || (Char.IsControl(e.KeyChar)))
                e.Handled = false;

            else
                e.Handled = true;
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) //código do enter em ASCII
            {
                if (textBox8.Visible == true)
                    textBox8.Focus();
                else
                    trackBar1.Focus();
            }

            else if ((Char.IsDigit(e.KeyChar)) || (Char.IsControl(e.KeyChar)))
                e.Handled = false;

            else
                e.Handled = true;
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) //código do enter em ASCII
            {
                if (textBox9.Visible == true)
                    textBox9.Focus();
                else
                    trackBar1.Focus();
            }

            else if ((Char.IsDigit(e.KeyChar)) || (Char.IsControl(e.KeyChar)))
                e.Handled = false;

            else
                e.Handled = true;
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) //código do enter em ASCII
            {
                if (textBox10.Visible == true)
                    textBox10.Focus();
                else
                    trackBar1.Focus();
            }

            else if ((Char.IsDigit(e.KeyChar)) || (Char.IsControl(e.KeyChar)))
                e.Handled = false;

            else
                e.Handled = true;
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) //código do enter em ASCII
            {
                if (textBox11.Visible == true)
                    textBox11.Focus();
                else
                    trackBar1.Focus();
            }

            else if ((Char.IsDigit(e.KeyChar)) || (Char.IsControl(e.KeyChar)))
                e.Handled = false;

            else
                e.Handled = true;
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) //código do enter em ASCII
            {
                if (textBox12.Visible == true)
                    textBox12.Focus();
                else
                    trackBar1.Focus();
            }

            else if ((Char.IsDigit(e.KeyChar)) || (Char.IsControl(e.KeyChar)))
                e.Handled = false;

            else
                e.Handled = true;
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) //código do enter em ASCII
            {
                if (textBox13.Visible == true)
                    textBox13.Focus();
                else
                    trackBar1.Focus();
            }

            else if ((Char.IsDigit(e.KeyChar)) || (Char.IsControl(e.KeyChar)))
                e.Handled = false;

            else
                e.Handled = true;
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) //código do enter em ASCII
            {
                if (textBox14.Visible == true)
                    textBox14.Focus();
                else
                    trackBar1.Focus();
            }

            else if ((Char.IsDigit(e.KeyChar)) || (Char.IsControl(e.KeyChar)))
                e.Handled = false;

            else
                e.Handled = true;
        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) //código do enter em ASCII
            {
                if (textBox15.Visible == true)
                    textBox15.Focus();
                else
                    trackBar1.Focus();
            }

            else if ((Char.IsDigit(e.KeyChar)) || (Char.IsControl(e.KeyChar)))
                e.Handled = false;

            else
                e.Handled = true;
        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) //código do enter em ASCII
            {
                trackBar1.Focus();
            }

            else if ((Char.IsDigit(e.KeyChar)) || (Char.IsControl(e.KeyChar)))
                e.Handled = false;

            else
                e.Handled = true;
        }

        private void ResultDem_Click(object sender, EventArgs e)
        {

            Concorrentes Other_form = new Concorrentes(Num_apostas.Text, Sorteio1.Text, Sorteio2.Text, Sorteio3.Text, Sorteio4.Text, Sorteio5.Text, Sorteio6.Text);
            Other_form.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Fotinha.Image = null;
            DialogFt.FileName = " ";
        }
    }
}

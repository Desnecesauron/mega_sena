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
using MUV_calculator;

namespace Tele_Sena_Sorteador
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            openFileDialog1.FileName = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Other_form = new Form1();
            Other_form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            resposta = MessageBox.Show("Você realmente quer sair do programa?",
                "Sorteador da Mega-Sena",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Escolha uma foto";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Fotinha.Load(openFileDialog1.FileName);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Fotinha.Image = null;
            openFileDialog1.FileName = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sorteador Other_form = new Sorteador(openFileDialog1);
            Other_form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sobre Other_form = new Sobre();
            Other_form.Show();
        }
    }
}

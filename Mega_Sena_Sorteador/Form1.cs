using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUV_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Novo_Click_1(object sender, EventArgs e)
        {
            txtbespacoi.Clear();
            txtbtemp.Clear();
            txtbveloi.Clear();
            txtbace.Clear();
            lblResult.Text = "                                ";
            txtbespacoi.Focus();
        }

        private void Calc_Click(object sender, EventArgs e)
        {
            float espacoFinal, espacoinicial, velocidade, tempo, aceleracao;



            //Testes de consistência

            if (String.IsNullOrWhiteSpace(txtbespacoi.Text) || String.IsNullOrWhiteSpace(txtbveloi.Text) || String.IsNullOrWhiteSpace(txtbtemp.Text) || String.IsNullOrWhiteSpace(txtbace.Text))
            {
               MessageBox.Show("Você deve informar os números de cada um!!!",
                    "Cálculo MUV",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                   return;
            }

            espacoinicial = Convert.ToSingle(txtbespacoi.Text);
            velocidade = Convert.ToSingle(txtbveloi.Text);
            tempo = Convert.ToSingle(txtbtemp.Text);
            aceleracao = Convert.ToSingle(txtbace.Text);

            espacoFinal = espacoinicial + (velocidade * tempo) + (aceleracao * (tempo * tempo)) / 2;
            lblResult.Text = espacoFinal.ToString();

            Novo.Focus();
        }

        private void novo_espacoi_Click(object sender, EventArgs e)
        {
            Form2 Other_form = new Form2();
            Other_form.Show();
        }

        private void novo_veloi_Click(object sender, EventArgs e)
        {
            Form3 Other_form = new Form3();
            Other_form.Show();
        }

        private void novo_temp_Click(object sender, EventArgs e)
        {
            Form4 Other_form = new Form4();
            Other_form.Show();
        }

        private void novo_ace_Click(object sender, EventArgs e)
        {
            Form5 Other_form = new Form5();
            Other_form.Show();
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtbespacoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsDigit(e.KeyChar)) || (e.KeyChar == ',') || (Char.IsControl(e.KeyChar)))
                e.Handled = false;

            else
                e.Handled = true;
        }

        private void txtbveloi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsDigit(e.KeyChar)) || (e.KeyChar == ',') || (Char.IsControl(e.KeyChar)))
                e.Handled = false;

            else
                e.Handled = true;
        }

        private void txtbtemp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsDigit(e.KeyChar)) || (e.KeyChar == ',') || (Char.IsControl(e.KeyChar)))
                e.Handled = false;

            else
                e.Handled = true;
        }

        private void txtbace_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsDigit(e.KeyChar)) || (e.KeyChar == ',') || (Char.IsControl(e.KeyChar)))
                e.Handled = false;

            else
                e.Handled = true;
        }
    }
}

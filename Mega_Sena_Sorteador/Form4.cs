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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Calc_Click(object sender, EventArgs e)
        {
            Double espacofinal, espacoinicial, velocidade, tempo, aceleracao, part1, part2, part3, part4, part5, part6, raiz, raizz;

            //Testes de consistência

            /*if (string.IsNullOrWhiteSpace)
            {
                MessageBox.Show("Cálculo MRU",
                            "Você deve informar o espaço inicial!!!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                return;
            }*/

            espacoinicial = Convert.ToDouble(txtbespacoi.Text);
            velocidade = Convert.ToDouble(txtbveloi.Text);
            espacofinal = Convert.ToDouble(txtbespacof.Text);
            aceleracao = Convert.ToDouble(txtbace.Text);

            part1 = aceleracao / 2;
            part2 = velocidade;
            part3 = (espacofinal - espacoinicial)*-1;

            //fazer a resolução pela equação de segundo grau:
            part4 = (velocidade * velocidade) + (- 4 * part1 * part3);
            part5 = part4;
            raiz = Math.Sqrt(part5);

            raizz = raiz;

            part6 = (-velocidade + raizz) / (2 * part1);

            //espacofinal = espacoinicial + (velocidade * tempo) + (aceleracao * (tempo * tempo)) / 2;

            tempo = part6;
            lblResult.Text = tempo.ToString();

            Novo.Focus();
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            txtbespacoi.Clear();
            txtbveloi.Clear();
            txtbespacof.Clear();
            txtbace.Clear();
            lblResult.Text = "                                ";
            txtbespacoi.Focus();
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

        private void txtbespacof_KeyPress(object sender, KeyPressEventArgs e)
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

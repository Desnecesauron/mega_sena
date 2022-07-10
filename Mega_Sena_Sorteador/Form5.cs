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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Calc_Click(object sender, EventArgs e)
        {
            float espacofinal, espacoinicial, velocidade, tempo, aceleracao, part1, part2, part3;

            //Testes de consistência

            /*if (string.IsNullOrWhiteSpace)
            {
                MessageBox.Show("Cálculo MRU",
                            "Você deve informar o espaço inicial!!!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                return;
            }*/

            espacoinicial = Convert.ToSingle(txtbespacoi.Text);
            velocidade = Convert.ToSingle(txtbveloi.Text);
            tempo = Convert.ToSingle(txtbtemp.Text);
            espacofinal = Convert.ToSingle(txtbespacof.Text);

            part1 = espacofinal - (espacoinicial + (velocidade * tempo));
            part2 = part1 * 2;
            part3 = part2 / (tempo * tempo);

            aceleracao = part3;

            lblResult.Text = aceleracao.ToString();

            Novo.Focus();
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            txtbespacoi.Clear();
            txtbtemp.Clear();
            txtbveloi.Clear();
            txtbespacof.Clear();
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

        private void txtbtemp_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}

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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Calc_Click(object sender, EventArgs e)
        {
            float espacoinicial, espacofinal, velocidade, tempo, aceleracao, part1;

            //Testes de consistência

            /*if (string.IsNullOrWhiteSpace)
            {
                MessageBox.Show("Cálculo MRU",
                            "Você deve informar o espaço inicial!!!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                return;
            }*/






            espacofinal = Convert.ToSingle(txtbespacof.Text);
            velocidade = Convert.ToSingle(txtbveloi.Text);
            tempo = Convert.ToSingle(txtbtemp.Text);
            aceleracao = Convert.ToSingle(txtbace.Text);
            part1= (velocidade * tempo) + (aceleracao * (tempo * tempo)) / 2;
            espacoinicial = espacofinal - part1;

            lblResult.Text = espacoinicial.ToString();

            Novo.Focus();
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            txtbespacof.Clear();
            txtbtemp.Clear();
            txtbveloi.Clear();
            txtbace.Clear();
            lblResult.Text = "                                ";
            txtbespacof.Focus();
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtbespacof_KeyPress(object sender, KeyPressEventArgs e)
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

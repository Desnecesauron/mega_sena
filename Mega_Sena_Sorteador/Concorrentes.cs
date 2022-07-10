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
    public partial class Concorrentes : Form
    {
        int Num1Sort1, Num2Sort1, Num3Sort1, Num4Sort1, Num5Sort1, Num6Sort1, Num7Sort1, Num8Sort1, Num9Sort1, Num10Sort1, Num11Sort1, Num12Sort1, Num13Sort1, Num14Sort1, Num15Sort1;

        int acertosp1;

        Random sorteio = new Random();

        public Concorrentes(string Num_apostas, string Sorteio1, string Sorteio2, string Sorteio3, string Sorteio4, string Sorteio5, string Sorteio6)
        {
            InitializeComponent();

            Sort1.Text = "0";
            Sort2.Text = "0";
            Sort3.Text = "0";
            Sort4.Text = "0";
            Sort5.Text = "0";
            Sort6.Text = "0";
            Sort7.Text = "0";
            Sort8.Text = "0";
            Sort9.Text = "0";
            Sort10.Text = "0";
            Sort11.Text = "0";
            Sort12.Text = "0";
            Sort13.Text = "0";
            Sort14.Text = "0";
            Sort15.Text = "0";

            if (Num_apostas == "6")
            {
                label7.Visible = false;
                Sort7.Visible = false;

                label8.Visible = false;
                Sort8.Visible = false;

                label9.Visible = false;
                Sort9.Visible = false;

                label10.Visible = false;
                Sort10.Visible = false;

                label11.Visible = false;
                Sort11.Visible = false;

                label12.Visible = false;
                Sort12.Visible = false;

                label13.Visible = false;
                Sort13.Visible = false;

                label14.Visible = false;
                Sort14.Visible = false;

                label15.Visible = false;
                Sort15.Visible = false;
            }
            else if (Num_apostas == "7")
            {
                label7.Visible = true;
                Sort7.Visible = true;

                label8.Visible = false;
                Sort8.Visible = false;

                label9.Visible = false;
                Sort9.Visible = false;

                label10.Visible = false;
                Sort10.Visible = false;

                label11.Visible = false;
                Sort11.Visible = false;

                label12.Visible = false;
                Sort12.Visible = false;

                label13.Visible = false;
                Sort13.Visible = false;

                label14.Visible = false;
                Sort14.Visible = false;

                label15.Visible = false;
                Sort15.Visible = false;
            }
            else if (Num_apostas == "8")
            {
                label7.Visible = true;
                Sort7.Visible = true;

                label8.Visible = true;
                Sort8.Visible = true;

                label9.Visible = false;
                Sort9.Visible = false;

                label10.Visible = false;
                Sort10.Visible = false;

                label11.Visible = false;
                Sort11.Visible = false;

                label12.Visible = false;
                Sort12.Visible = false;

                label13.Visible = false;
                Sort13.Visible = false;

                label14.Visible = false;
                Sort14.Visible = false;

                label15.Visible = false;
                Sort15.Visible = false;
            }
            else if (Num_apostas == "9")
            {
                label7.Visible = true;
                Sort7.Visible = true;

                label8.Visible = true;
                Sort8.Visible = true;

                label9.Visible = true;
                Sort9.Visible = true;

                label10.Visible = false;
                Sort10.Visible = false;

                label11.Visible = false;
                Sort11.Visible = false;

                label12.Visible = false;
                Sort12.Visible = false;

                label13.Visible = false;
                Sort13.Visible = false;

                label14.Visible = false;
                Sort14.Visible = false;

                label15.Visible = false;
                Sort15.Visible = false;
            }
            else if (Num_apostas == "10")
            {
                label7.Visible = true;
                Sort7.Visible = true;

                label8.Visible = true;
                Sort8.Visible = true;

                label9.Visible = true;
                Sort9.Visible = true;

                label10.Visible = true;
                Sort10.Visible = true;

                label11.Visible = false;
                Sort11.Visible = false;

                label12.Visible = false;
                Sort12.Visible = false;

                label13.Visible = false;
                Sort13.Visible = false;

                label14.Visible = false;
                Sort14.Visible = false;

                label15.Visible = false;
                Sort15.Visible = false;
            }
            else if (Num_apostas == "11")
            {
                label7.Visible = true;
                Sort7.Visible = true;

                label8.Visible = true;
                Sort8.Visible = true;

                label9.Visible = true;
                Sort9.Visible = true;

                label10.Visible = true;
                Sort10.Visible = true;

                label11.Visible = true;
                Sort11.Visible = true;

                label12.Visible = false;
                Sort12.Visible = false;

                label13.Visible = false;
                Sort13.Visible = false;

                label14.Visible = false;
                Sort14.Visible = false;

                label15.Visible = false;
                Sort15.Visible = false;
            }
            else if (Num_apostas == "12")
            {
                label7.Visible = true;
                Sort7.Visible = true;

                label8.Visible = true;
                Sort8.Visible = true;

                label9.Visible = true;
                Sort9.Visible = true;

                label10.Visible = true;
                Sort10.Visible = true;

                label11.Visible = true;
                Sort11.Visible = true;

                label12.Visible = true;
                Sort12.Visible = true;

                label13.Visible = false;
                Sort13.Visible = false;

                label14.Visible = false;
                Sort14.Visible = false;

                label15.Visible = false;
                Sort15.Visible = false;
            }
            else if (Num_apostas == "13")
            {
                label7.Visible = true;
                Sort7.Visible = true;

                label8.Visible = true;
                Sort8.Visible = true;

                label9.Visible = true;
                Sort9.Visible = true;

                label10.Visible = true;
                Sort10.Visible = true;

                label11.Visible = true;
                Sort11.Visible = true;

                label12.Visible = true;
                Sort12.Visible = true;

                label13.Visible = true;
                Sort13.Visible = true;

                label14.Visible = false;
                Sort14.Visible = false;

                label15.Visible = false;
                Sort15.Visible = false;
            }
            else if (Num_apostas == "14")
            {
                label7.Visible = true;
                Sort7.Visible = true;

                label8.Visible = true;
                Sort8.Visible = true;

                label9.Visible = true;
                Sort9.Visible = true;

                label10.Visible = true;
                Sort10.Visible = true;

                label11.Visible = true;
                Sort11.Visible = true;

                label12.Visible = true;
                Sort12.Visible = true;

                label13.Visible = true;
                Sort13.Visible = true;

                label14.Visible = true;
                Sort14.Visible = true;

                label15.Visible = false;
                Sort15.Visible = false;
            }
            else if (Num_apostas == "15")
            {
                label7.Visible = true;
                Sort7.Visible = true;

                label8.Visible = true;
                Sort8.Visible = true;

                label9.Visible = true;
                Sort9.Visible = true;

                label10.Visible = true;
                Sort10.Visible = true;

                label11.Visible = true;
                Sort11.Visible = true;

                label12.Visible = true;
                Sort12.Visible = true;

                label13.Visible = true;
                Sort13.Visible = true;

                label14.Visible = true;
                Sort14.Visible = true;

                label15.Visible = true;
                Sort15.Visible = true;
            }
            
                Sort1.Text = Convert.ToString(sorteio.Next(1, 60));
                do
                {
                    Sort2.Text = Convert.ToString(sorteio.Next(1, 60));
                } while (Sort2.Text == Sort1.Text);

                do
                {
                    Sort3.Text = Convert.ToString(sorteio.Next(1, 60));
                } while (Sort3.Text == Sort2.Text || Sort3.Text == Sort1.Text);

                do
                {
                    Sort4.Text = Convert.ToString(sorteio.Next(1, 60));
                } while (Sort4.Text == Sort3.Text || Sort4.Text == Sort2.Text || Sort4.Text == Sort1.Text);

                do
                {
                    Sort5.Text = Convert.ToString(sorteio.Next(1, 60));
                } while (Sort5.Text == Sort4.Text || Sort5.Text == Sort3.Text || Sort5.Text == Sort2.Text || Sort5.Text == Sort1.Text);

                do
                {
                    Sort6.Text = Convert.ToString(sorteio.Next(1, 60));
                } while (Sort6.Text == Sort5.Text || Sort6.Text == Sort4.Text || Sort6.Text == Sort3.Text || Sort6.Text == Sort2.Text || Sort6.Text == Sort1.Text);

                int x = Convert.ToInt32(Num_apostas);

                if(x >= 7)
                {
                    do
                    {
                        Sort7.Text = Convert.ToString(sorteio.Next(1, 60));
                    } while (Sort7.Text == Sort6.Text || Sort7.Text == Sort5.Text || Sort7.Text == Sort4.Text || Sort7.Text == Sort3.Text || Sort7.Text == Sort2.Text || Sort7.Text == Sort1.Text);

                    if (x >= 8)
                    {

                        do
                        {
                            Sort8.Text = Convert.ToString(sorteio.Next(1, 60));
                        } while (Sort8.Text == Sort7.Text || Sort8.Text == Sort6.Text || Sort8.Text == Sort5.Text || Sort8.Text == Sort4.Text || Sort8.Text == Sort3.Text || Sort8.Text == Sort2.Text || Sort8.Text == Sort1.Text);

                        if (x >= 9)
                        {
                            do
                            {
                                Sort9.Text = Convert.ToString(sorteio.Next(1, 60));
                            } while (Sort9.Text == Sort8.Text || Sort9.Text == Sort7.Text || Sort9.Text == Sort6.Text || Sort9.Text == Sort5.Text || Sort9.Text == Sort4.Text || Sort9.Text == Sort3.Text || Sort9.Text == Sort2.Text || Sort9.Text == Sort1.Text);

                            if (x >= 10)
                            {
                                do
                                {
                                    Sort10.Text = Convert.ToString(sorteio.Next(1, 60));
                                } while (Sort10.Text == Sort9.Text || Sort10.Text == Sort8.Text || Sort10.Text == Sort7.Text || Sort10.Text == Sort6.Text || Sort10.Text == Sort5.Text || Sort10.Text == Sort4.Text || Sort10.Text == Sort3.Text || Sort10.Text == Sort2.Text || Sort10.Text == Sort1.Text);

                                if (x >= 11)
                                {
                                    do
                                    {
                                        Sort11.Text = Convert.ToString(sorteio.Next(1, 60));
                                    } while (Sort11.Text == Sort10.Text || Sort11.Text == Sort9.Text || Sort11.Text == Sort8.Text || Sort11.Text == Sort7.Text || Sort11.Text == Sort6.Text || Sort11.Text == Sort5.Text || Sort11.Text == Sort4.Text || Sort11.Text == Sort3.Text || Sort11.Text == Sort2.Text || Sort11.Text == Sort1.Text);
                

                                    if (x >= 12)
                                    {
                                        do
                                        {
                                            Sort12.Text = Convert.ToString(sorteio.Next(1, 60));
                                        } while (Sort12.Text == Sort11.Text || Sort12.Text == Sort10.Text || Sort12.Text == Sort9.Text || Sort12.Text == Sort8.Text || Sort12.Text == Sort7.Text || Sort12.Text == Sort6.Text || Sort12.Text == Sort5.Text || Sort12.Text == Sort4.Text || Sort12.Text == Sort3.Text || Sort12.Text == Sort2.Text || Sort12.Text == Sort1.Text);
                

                                        if (x >= 13)
                                        {
                                            do
                                            {
                                                Sort13.Text = Convert.ToString(sorteio.Next(1, 60));
                                            } while (Sort13.Text == Sort12.Text || Sort13.Text == Sort11.Text || Sort13.Text == Sort10.Text || Sort13.Text == Sort9.Text || Sort13.Text == Sort8.Text || Sort13.Text == Sort7.Text || Sort13.Text == Sort6.Text || Sort13.Text == Sort5.Text || Sort13.Text == Sort4.Text || Sort13.Text == Sort3.Text || Sort13.Text == Sort2.Text || Sort13.Text == Sort1.Text);
                

                                            if (x >= 14)
                                            {
                                                do
                                                {
                                                    Sort14.Text = Convert.ToString(sorteio.Next(1, 60));
                                                } while (Sort14.Text == Sort13.Text || Sort14.Text == Sort12.Text || Sort14.Text == Sort11.Text || Sort14.Text == Sort10.Text || Sort14.Text == Sort9.Text || Sort14.Text == Sort8.Text || Sort14.Text == Sort7.Text || Sort14.Text == Sort6.Text || Sort14.Text == Sort5.Text || Sort14.Text == Sort4.Text || Sort14.Text == Sort3.Text || Sort14.Text == Sort2.Text || Sort14.Text == Sort1.Text);

                                                if (x == 15)
                                                {
                                                    do
                                                    {
                                                        Sort15.Text = Convert.ToString(sorteio.Next(1, 60));
                                                    } while (Sort15.Text == Sort14.Text || Sort15.Text == Sort13.Text || Sort15.Text == Sort12.Text || Sort15.Text == Sort11.Text || Sort15.Text == Sort10.Text || Sort15.Text == Sort9.Text || Sort15.Text == Sort8.Text || Sort15.Text == Sort7.Text || Sort15.Text == Sort6.Text || Sort15.Text == Sort5.Text || Sort15.Text == Sort4.Text || Sort15.Text == Sort3.Text || Sort15.Text == Sort2.Text || Sort15.Text == Sort1.Text);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                if (Sorteio1 == Sort1.Text || Sorteio1 == Sort2.Text || Sorteio1 == Sort3.Text || Sorteio1 == Sort4.Text || Sorteio1 == Sort5.Text || Sorteio1 == Sort6.Text || Sorteio1 == Sort7.Text || Sorteio1 == Sort8.Text || Sorteio1 == Sort9.Text || Sorteio1 == Sort10.Text || Sorteio1 == Sort11.Text || Sorteio1 == Sort12.Text || Sorteio1 == Sort13.Text || Sorteio1 == Sort14.Text || Sorteio1 == Sort15.Text)
                {
                    acertosp1++;
                }

                if (Sorteio2 == Sort1.Text || Sorteio2 == Sort2.Text || Sorteio2 == Sort3.Text || Sorteio2 == Sort4.Text || Sorteio2 == Sort5.Text || Sorteio2 == Sort6.Text || Sorteio2 == Sort7.Text || Sorteio2 == Sort8.Text || Sorteio2 == Sort9.Text || Sorteio2 == Sort10.Text || Sorteio2 == Sort11.Text || Sorteio2 == Sort12.Text || Sorteio2 == Sort13.Text || Sorteio2 == Sort14.Text || Sorteio2 == Sort15.Text)
                {
                    acertosp1++;
                }

                if (Sorteio3 == Sort1.Text || Sorteio3 == Sort2.Text || Sorteio3 == Sort3.Text || Sorteio3 == Sort4.Text || Sorteio3 == Sort5.Text || Sorteio3 == Sort6.Text || Sorteio3 == Sort7.Text || Sorteio3 == Sort8.Text || Sorteio3 == Sort9.Text || Sorteio3 == Sort10.Text || Sorteio3 == Sort11.Text || Sorteio3 == Sort12.Text || Sorteio3 == Sort13.Text || Sorteio3 == Sort14.Text || Sorteio3 == Sort15.Text)
                {
                    acertosp1++;
                }

                if (Sorteio4 == Sort1.Text || Sorteio4 == Sort2.Text || Sorteio4 == Sort3.Text || Sorteio4 == Sort4.Text || Sorteio4 == Sort5.Text || Sorteio4 == Sort6.Text || Sorteio4 == Sort7.Text || Sorteio4 == Sort8.Text || Sorteio4 == Sort9.Text || Sorteio4 == Sort10.Text || Sorteio4 == Sort11.Text || Sorteio4 == Sort12.Text || Sorteio4 == Sort13.Text || Sorteio4 == Sort14.Text || Sorteio4 == Sort15.Text)
                {
                    acertosp1++;
                }

                if (Sorteio5 == Sort1.Text || Sorteio5 == Sort2.Text || Sorteio5 == Sort3.Text || Sorteio5 == Sort4.Text || Sorteio5 == Sort5.Text || Sorteio5 == Sort6.Text || Sorteio5 == Sort7.Text || Sorteio5 == Sort8.Text || Sorteio5 == Sort9.Text || Sorteio5 == Sort10.Text || Sorteio5 == Sort11.Text || Sorteio5 == Sort12.Text || Sorteio5 == Sort13.Text || Sorteio5 == Sort14.Text || Sorteio5 == Sort15.Text)
                {
                    acertosp1++;
                }

                if (Sorteio6 == Sort1.Text || Sorteio6 == Sort2.Text || Sorteio6 == Sort3.Text || Sorteio6 == Sort4.Text || Sorteio6 == Sort5.Text || Sorteio6 == Sort6.Text || Sorteio6 == Sort7.Text || Sorteio6 == Sort8.Text || Sorteio6 == Sort9.Text || Sorteio6 == Sort10.Text || Sorteio6 == Sort11.Text || Sorteio6 == Sort12.Text || Sorteio6 == Sort13.Text || Sorteio6 == Sort14.Text || Sorteio6 == Sort15.Text)
                {
                    acertosp1++;
                }

                Numsort.Text = Convert.ToString(acertosp1);

                Num1Sort1 = Convert.ToInt32(Sort1.Text);
                Num2Sort1 = Convert.ToInt32(Sort2.Text);
                Num3Sort1 = Convert.ToInt32(Sort3.Text);
                Num4Sort1 = Convert.ToInt32(Sort4.Text);
                Num5Sort1 = Convert.ToInt32(Sort5.Text);
                Num6Sort1 = Convert.ToInt32(Sort6.Text);
                Num7Sort1 = Convert.ToInt32(Sort7.Text);
                Num8Sort1 = Convert.ToInt32(Sort8.Text);
                Num9Sort1 = Convert.ToInt32(Sort9.Text);
                Num10Sort1 = Convert.ToInt32(Sort10.Text);
                Num11Sort1 = Convert.ToInt32(Sort11.Text);
                Num12Sort1 = Convert.ToInt32(Sort12.Text);
                Num13Sort1 = Convert.ToInt32(Sort13.Text);
                Num14Sort1 = Convert.ToInt32(Sort14.Text);
                Num15Sort1 = Convert.ToInt32(Sort15.Text);

        }
        private void Closee_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

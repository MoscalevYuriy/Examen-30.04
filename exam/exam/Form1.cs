using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox2.Text.Length > 0 && textBox3.Text.Length > 0)
            {
                int n = Convert.ToInt32(textBox2.Text);
                int m = Convert.ToInt32(textBox2.Text);
                int minus = 0;
                Random rnd = new Random();
                int [,] array = new int[m, n];
                
                for (int i = 0; i < n; i++)
                {
                    for (int y = 0; y < m; y++)
                    {
                        array[i, y] = rnd.Next(-10,10);
                        if(array[i,y] < 0 && minus<2)
                        {
                            minus++;
                        }
                        if (minus == 2)
                        {
                            if(y + 1 >= m)
                            {
                                int tmp1 = array[i, y];
                                i++;
                                y = 0;
                                if(i<n)
                                {
                                    if (tmp1 > array[i, y])
                                    {
                                        array[i, y] = tmp1;
                                        array[i - 1, m - 1] = array[i, y];
                                    }
                                }
                                else
                                {
                                    break;
                                }

                            }
                            else
                            {
                                if(array[i,y]>array[i,y+1])
                                {
                                    int tmp = array[i,y];
                                    array[i, y] = array[i, y + 1];
                                    array[i, y + 1] = tmp;
                                }

                            }
                        }
                        textBox1.Text += Convert.ToString(array[i, y]);
                        textBox1.Text += " ";
                    }
                    textBox1.Text += Environment.NewLine;
                }


            }

            
        }
    }
}

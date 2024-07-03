using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Proposiciones : Form
    {
        public Proposiciones()
        {
            InitializeComponent();
        }

        //metodo en la cual nos permite llenar la tabla de verdad de la 2^n
        Int64 Potencia(Int64 x)
        {
            if (x == 0)
                return 1;
            else
                return 2 * Potencia(x - 1);
        }
       
       
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            {
                textBox2.Clear();

                Int64 x1, x2, c, i, j, n, exp;

                c = 0;
                x2 = 0;

                //introducimos el valor de n 
                n = Convert.ToInt64(textBox1.Text);

                //comprobamos que el valor de n sea mayor a 0 y llamamos al metodo potencia para llenar la tabla de verdad
                if (n > 0)
                {
                    exp = Potencia(n);
                    Int64[,] mat = new Int64[exp, n];
                    x1 = exp / 2;

                    for (j = 0; j < n; j++)
                    {
                        for (i = 0; i < exp; i++)
                        {
                            if (x2 == 0)
                            {
                                mat[i, j] = 0;
                                c++;
                            }
                            else if (x2 == 1)
                            {
                                mat[i, j] = 1;
                                c--;
                            }
                            if (c == x1)
                            {
                                x2 = 1;
                            }
                            if (c == 0)
                            {
                                x2 = 0;
                            }
                        }
                        x1 = x1 / 2;
                    }
                    //imprimimos la tabla de verdad
                    for (j = 0; j < n; j++)
                    {
                        textBox2.Text = textBox2.Text + "  x" + (j + 1).ToString();
                    }
                    textBox2.Text = textBox2.Text + "\r\n";
                    for (i = 0; i < exp; i++)
                    {
                        for (j = 0; j < n; j++)
                        {
                            textBox2.Text = textBox2.Text + "   " + Convert.ToString(mat[i, j]);
                        }
                        textBox2.Text = textBox2.Text + "\r\n";
                    }
                    textBox1.Clear();
                }
                else
                {
                    MessageBox.Show("ERROR, POR FAVOR INTRODUZCA UN VALOR MAYOR A 0");
                    textBox1.Clear();
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
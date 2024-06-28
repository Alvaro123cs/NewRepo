using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2doParcial
{
    public partial class coseno : Form
    {
        public coseno()
        {
            InitializeComponent();
        }

        private void coseno_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Double.Parse(textBox1.Text);
                double radians = x * (Math.PI / 180); // Convertir grados a radianes
                double cos = CosTaylorSeries(radians);
                textBox2.Text = cos.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un número válido en el primer cuadro de texto.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        double Factorial(int n)
        {
            double fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
        }

        double CosTaylorSeries(double x)
        {
            double sum = 0;
            for (int n = 0; n < 10; n++)
            {
                sum += Math.Pow(-1, n) * Math.Pow(x, 2 * n) / Factorial(2 * n);
            }
            return sum;
        }
    }


}


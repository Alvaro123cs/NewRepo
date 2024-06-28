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
    public partial class secante : Form
    {
        public secante()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double degrees))
            {
                double radians = degrees * (Math.PI / 180); // Convertir grados a radianes
                double cosine = Math.Cos(radians);
                if (cosine == 0)
                {
                    MessageBox.Show("Secante indefinida (coseno es cero).");
                }
                else
                {
                    double secant = 1 / cosine; // Secante
                    textBox2.Text = secant.ToString();
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ángulo válido.");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

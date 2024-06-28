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
    public partial class logartimo : Form
    {
        public logartimo()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double numero) && numero > 0)
            {
                double baseLog = 10; // Base del logaritmo (puedes cambiarla si necesitas)
                double logaritmo = Math.Log(numero, baseLog);
                textBox2.Text = logaritmo.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido mayor que 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

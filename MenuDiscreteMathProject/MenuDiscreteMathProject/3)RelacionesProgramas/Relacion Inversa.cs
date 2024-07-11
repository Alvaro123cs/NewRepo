using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Relacion_Inversa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conjunto = textBox1.Text.Trim();
            string[] relaciones = conjunto.Split(';')
                                          .Select(relacion => relacion.Trim())
                                          .ToArray();

            List<string> relacionesInversas = GenerarRelacionesInversas(relaciones);

            // Mostrar relaciones inversas en textBox2
            textBox2.Text = string.Join("; ", relacionesInversas);
        }

        private List<string> GenerarRelacionesInversas(string[] relaciones)
        {
            List<string> relacionesInversas = new List<string>();

            foreach (var relacion in relaciones)
            {
                string[] elementos = relacion.Trim('(', ')').Split(',').Select(e => e.Trim()).ToArray();
                if (elementos.Length == 2)
                {
                    relacionesInversas.Add("(" + elementos[1] + ", " + elementos[0] + ")");
                }
            }

            return relacionesInversas;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
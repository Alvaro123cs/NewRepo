using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Relacion_Asimetrica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private bool EsAsimetrica(string[] relaciones)
        {
            HashSet<Tuple<string, string>> conjuntoRelaciones = new HashSet<Tuple<string, string>>();

            foreach (var relacion in relaciones)
            {
                string[] elementos = relacion.Substring(1, relacion.Length - 2).Split(',')
                                            .Select(e => e.Trim()).ToArray();
                conjuntoRelaciones.Add(Tuple.Create(elementos[0], elementos[1]));
            }

            foreach (var relacion in conjuntoRelaciones)
            {
                var a = relacion.Item1;
                var b = relacion.Item2;
                if (a != b && conjuntoRelaciones.Contains(Tuple.Create(b, a)))
                {
                    return false;
                }
            }

            return true;
        }

        private List<string> GenerarRelacionesAsimetricas(string[] relaciones)
        {
            HashSet<Tuple<string, string>> conjuntoRelaciones = new HashSet<Tuple<string, string>>();

            foreach (var relacion in relaciones)
            {
                string[] elementos = relacion.Substring(1, relacion.Length - 2).Split(',')
                                            .Select(e => e.Trim()).ToArray();
                conjuntoRelaciones.Add(Tuple.Create(elementos[0], elementos[1]));
            }

            return conjuntoRelaciones.Select(r => "(" + r.Item1 + ", " + r.Item2 + ")").ToList();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string[] relaciones = textBox1.Text.Split(';')
                                                .Select(relacion => relacion.Trim())
                                                .ToArray();

            List<string> relacionesAsimetricas = GenerarRelacionesAsimetricas(relaciones);
            textBox2.Text = string.Join("; ", relacionesAsimetricas);

            bool esAsimetrica = EsAsimetrica(relaciones);
            labelResultado.Text = "La relación es asimétrica: " + esAsimetrica.ToString();
        }
    }
}
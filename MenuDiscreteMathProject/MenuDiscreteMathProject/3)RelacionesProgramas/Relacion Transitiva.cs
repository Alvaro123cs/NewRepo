using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Relacion_Transitiva
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Leer las relaciones del textbox
            string input = textBox1.Text.Trim();
            string[] relaciones = input.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
                                        .Select(rel => rel.Trim())
                                        .ToArray();

            // Generar y mostrar las relaciones
            List<string> relacionesGeneradas = GenerarRelaciones(relaciones);
            textBox2.Text = string.Join("; ", relacionesGeneradas);

            // Verificar si las relaciones son transitivas
            bool esTransitiva = EsTransitiva(relaciones);
            labelResultado.Text = "¿La relación es transitiva? = " + esTransitiva;
        }

        private List<string> GenerarRelaciones(string[] relaciones)
        {
            HashSet<string> conjuntoRelaciones = new HashSet<string>(relaciones);
            List<string> relacionesGeneradas = new List<string>();

            foreach (var relacion in conjuntoRelaciones)
            {
                var elementos = relacion.Trim('(', ')').Split(',').Select(e => e.Trim()).ToArray();
                if (elementos.Length == 2)
                {
                    // Agregar la relación original
                    relacionesGeneradas.Add(relacion);
                }
            }
            return relacionesGeneradas;
        }

        private bool EsTransitiva(string[] relaciones)
        {
            var relacionTuplas = new HashSet<Tuple<string, string>>();

            // Agregar todas las relaciones a un conjunto de tuplas
            foreach (var relacion in relaciones)
            {
                var elementos = relacion.Trim('(', ')').Split(',').Select(e => e.Trim()).ToArray();
                if (elementos.Length == 2)
                {
                    relacionTuplas.Add(Tuple.Create(elementos[0], elementos[1]));
                }
            }

            // Verificar transitividad
            foreach (var tupla1 in relacionTuplas)
            {
                foreach (var tupla2 in relacionTuplas)
                {
                    if (tupla1.Item2 == tupla2.Item1)
                    {
                        var tuplaEsperada = Tuple.Create(tupla1.Item1, tupla2.Item2);
                        if (!relacionTuplas.Contains(tuplaEsperada))
                        {
                            return false; // Falta la relación esperada
                        }
                    }
                }
            }
            return true; // Todas las condiciones se cumplen
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Relacion_Composicion
{
    public partial class Relacion_Composicion : Form
    {
        public Relacion_Composicion()
        {
            InitializeComponent();
        }

        private void labelResultado_Click(object sender, EventArgs e)
        {

        }

        private void Relacion_Composicion_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conjunto = textBox1.Text.Trim();
            string[] relaciones = conjunto.Split(';')
                                          .Select(relacion => relacion.Trim())
                                          .ToArray();

            List<string> relacionesComposicion = GenerarRelacionesComposicion(relaciones);
            textBox2.Text = string.Join("; ", relacionesComposicion);

            bool esComposicion = EsComposicion(relacionesComposicion);
            labelResultado.Text = "¿La relación es de composición? " + esComposicion;
        }

        private List<string> GenerarRelacionesComposicion(string[] relaciones)
        {
            HashSet<string> relacionesComposicion = new HashSet<string>();

            for (int i = 0; i < relaciones.Length; i++)
            {
                string[] elementos1 = relaciones[i].Trim('(', ')').Split(',').Select(e => e.Trim()).ToArray();

                // Verificar que tenga 2 elementos
                if (elementos1.Length != 2) continue;

                for (int j = 0; j < relaciones.Length; j++)
                {
                    string[] elementos2 = relaciones[j].Trim('(', ')').Split(',').Select(e => e.Trim()).ToArray();

                    // Verificar que tenga 2 elementos
                    if (elementos2.Length != 2) continue;

                    if (elementos1[1] == elementos2[0]) // Verifica si el segundo elemento de la primera relación es igual al primero de la segunda
                    {
                        relacionesComposicion.Add($"({elementos1[0]}, {elementos2[1]})");
                    }
                }
            }

            return relacionesComposicion.ToList();
        }

        private bool EsComposicion(List<string> relacionesComposicion)
        {
            HashSet<string> conjunto1 = new HashSet<string>();
            HashSet<string> conjunto2 = new HashSet<string>();

            foreach (var relacion in relacionesComposicion)
            {
                string[] elementos = relacion.Trim('(', ')').Split(',').Select(e => e.Trim()).ToArray();

                // Verificar que tenga 2 elementos
                if (elementos.Length == 2)
                {
                    conjunto1.Add(elementos[0]); // Primer conjunto
                    conjunto2.Add(elementos[1]); // Segundo conjunto
                }
            }

            // Verifica si hay elementos en común entre los conjuntos
            return !conjunto1.Any(conjunto2.Contains);
        }
    }
}

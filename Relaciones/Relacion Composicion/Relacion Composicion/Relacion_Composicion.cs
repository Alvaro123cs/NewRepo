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

        private void button1_Click(object sender, EventArgs e)
        {
            string conjunto = textBox1.Text.Trim();
            string[] relaciones = conjunto.Split(';')
                                          .Select(relacion => relacion.Trim())
                                          .ToArray();

            List<string> relacionesComposicion = GenerarRelacionesComposicion(relaciones);

            // Mostrar relaciones de composición en textBox2
            textBox2.Text = string.Join("; ", relacionesComposicion);

            bool esComposicion = EsComposicion(relacionesComposicion);
            labelResultado.Text = "¿La relación es de composición? " + esComposicion;
        }

        private List<string> GenerarRelacionesComposicion(string[] relaciones)
        {
            List<string> relacionesComposicion = new List<string>();

            foreach (var relacion in relaciones)
            {
                string[] elementos = relacion.Trim('(', ')').Split(',').Select(e => e.Trim()).ToArray();
                if (elementos.Length == 2)
                {
                    // Agregar relaciones de composición
                    relacionesComposicion.Add(relacion);
                }
            }

            return relacionesComposicion;
        }

        private bool EsComposicion(List<string> relaciones)
        {
            HashSet<string> conjunto1 = new HashSet<string>();
            HashSet<string> conjunto2 = new HashSet<string>();

            foreach (var relacion in relaciones)
            {
                string[] elementos = relacion.Trim('(', ')').Split(',').Select(e => e.Trim()).ToArray();
                conjunto1.Add(elementos[0]);
                conjunto2.Add(elementos[1]);
            }

            // Verificar si no hay elementos en común entre los dos conjuntos
            return !conjunto1.Any(conjunto2.Contains);
        }

        private void labelResultado_Click(object sender, EventArgs e)
        {

        }
    }
}

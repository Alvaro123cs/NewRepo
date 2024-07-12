using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MenuDiscreteMathProject._2_LenguajeMathProgramas
{
    public partial class Interseccion : Form
    {
        public Interseccion()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Leer los conjuntos de los TextBox
            var conjunto1 = ParseConjunto(textBox1.Text);
            var conjunto2 = ParseConjunto(textBox2.Text);

            // Obtener la intersección
            var interseccion = ObtenerInterseccion(conjunto1, conjunto2);

            // Mostrar el resultado en textBox3
            textBox3.Text = interseccion.Any() ? string.Join(", ", interseccion) : "No hay intersección";
        }

        private List<string> ParseConjunto(string conjunto)
        {
            // Eliminar los paréntesis y dividir por comas
            return conjunto.Trim('(', ')')
                           .Split(',')
                           .Select(elemento => elemento.Trim())
                           .ToList();
        }

        private List<string> ObtenerInterseccion(List<string> conjunto1, List<string> conjunto2)
        {
            // Crear conjuntos HashSet para realizar la intersección
            HashSet<string> set1 = new HashSet<string>(conjunto1);
            HashSet<string> set2 = new HashSet<string>(conjunto2);

            // Obtener la intersección
            set1.IntersectWith(set2);

            return set1.ToList();
        }
    }
}
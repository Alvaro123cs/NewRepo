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
            // Leer las relaciones de los TextBox
            var relaciones1 = textBox1.Text.Split(';')
                                           .Select(relacion => relacion.Trim())
                                           .ToArray();
            var relaciones2 = textBox2.Text.Split(';')
                                           .Select(relacion => relacion.Trim())
                                           .ToArray();

            // Obtener la intersección
            var interseccion = ObtenerInterseccion(relaciones1, relaciones2);

            // Mostrar el resultado en textBox3
            textBox3.Text = interseccion.Any() ? string.Join("; ", interseccion) : "No hay intersección";
        }

        private List<string> ObtenerInterseccion(string[] relaciones1, string[] relaciones2)
        {
            HashSet<string> conjuntoRelaciones1 = new HashSet<string>(relaciones1);
            HashSet<string> conjuntoRelaciones2 = new HashSet<string>(relaciones2);

            // Obtener la intersección
            conjuntoRelaciones1.IntersectWith(conjuntoRelaciones2);

            return conjuntoRelaciones1.ToList();
        }
    }
}
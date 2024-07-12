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
    public partial class Union : Form
    {
        public Union()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Leer los conjuntos de los TextBox
            var conjunto1 = ParseConjunto(textBox1.Text);
            var conjunto2 = ParseConjunto(textBox2.Text);

            // Obtener la unión
            var union = ObtenerUnion(conjunto1, conjunto2);

            // Mostrar el resultado en textBox3
            textBox3.Text = union.Any() ? string.Join(", ", union) : "No hay elementos en la unión";
        }

        private List<string> ParseConjunto(string conjunto)
        {
            // Eliminar los paréntesis y dividir por comas
            return conjunto.Trim('(', ')')
                           .Split(',')
                           .Select(elemento => elemento.Trim())
                           .ToList();
        }

        private List<string> ObtenerUnion(List<string> conjunto1, List<string> conjunto2)
        {
            // Crear conjuntos HashSet para realizar la unión
            HashSet<string> set1 = new HashSet<string>(conjunto1);
            HashSet<string> set2 = new HashSet<string>(conjunto2);

            // Obtener la unión
            set1.UnionWith(set2);

            return set1.ToList();
        }
    }
}
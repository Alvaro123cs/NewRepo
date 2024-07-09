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
            // Leer las relaciones de los TextBox
            var relaciones1 = textBox1.Text.Split(';')
                                           .Select(relacion => relacion.Trim())
                                           .ToArray();
            var relaciones2 = textBox2.Text.Split(';')
                                           .Select(relacion => relacion.Trim())
                                           .ToArray();

            // Obtener la unión
            var union = ObtenerUnion(relaciones1, relaciones2);

            // Mostrar el resultado en textBox3
            textBox3.Text = union.Any() ? string.Join("; ", union) : "No hay elementos en la unión";
        }

        private List<string> ObtenerUnion(string[] relaciones1, string[] relaciones2)
        {
            HashSet<string> conjuntoRelaciones1 = new HashSet<string>(relaciones1);
            HashSet<string> conjuntoRelaciones2 = new HashSet<string>(relaciones2);

            // Obtener la unión
            conjuntoRelaciones1.UnionWith(conjuntoRelaciones2);

            return conjuntoRelaciones1.ToList();
        }
    }
}

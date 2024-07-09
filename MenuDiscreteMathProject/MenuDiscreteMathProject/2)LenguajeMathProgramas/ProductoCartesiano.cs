using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApplication6
{
         public partial class ProductoCartesiano : Form
    {
        public ProductoCartesiano()
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

            // Obtener el producto cartesiano
            var productoCartesiano = ObtenerProductoCartesiano(relaciones1, relaciones2);

            // Mostrar el resultado en el TextBox3
            textBox3.Text = string.Join("; ", productoCartesiano);
        }

        private List<string> ObtenerProductoCartesiano(string[] relaciones1, string[] relaciones2)
        {
            List<string> productoCartesiano = new List<string>();

            foreach (var relacion1 in relaciones1)
            {
                foreach (var relacion2 in relaciones2)
                {
                    var elementos1 = relacion1.Substring(1, relacion1.Length - 2).Split(',').Select(e => e.Trim()).ToArray();
                    var elementos2 = relacion2.Substring(1, relacion2.Length - 2).Split(',').Select(e => e.Trim()).ToArray();

                    productoCartesiano.Add($"({elementos1[0]}, {elementos2[1]})");
                }
            }

            return productoCartesiano;
        }
    }
}
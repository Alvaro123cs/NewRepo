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
            var relaciones1 = ParseRelaciones(textBox1.Text);
            var relaciones2 = ParseRelaciones(textBox2.Text);

            // Obtener el producto cartesiano
            var productoCartesiano = ObtenerProductoCartesiano(relaciones1, relaciones2);

            // Mostrar el resultado en el textBox3
            textBox3.Text = string.Join("; ", productoCartesiano);
        }

        private List<string> ParseRelaciones(string input)
        {
            // Eliminar los paréntesis externos y dividir por punto y coma
            return input.Trim('(', ')')
                        .Split(',')
                        .Select(elemento => elemento.Trim())
                        .ToList();
        }

        private List<string> ObtenerProductoCartesiano(List<string> relaciones1, List<string> relaciones2)
        {
            List<string> productoCartesiano = new List<string>();

            foreach (var elemento1 in relaciones1)
            {
                foreach (var elemento2 in relaciones2)
                {
                    productoCartesiano.Add($"({elemento1}, {elemento2})");
                }
            }

            return productoCartesiano;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
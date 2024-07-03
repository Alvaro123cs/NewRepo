using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            // Leer los conjuntos desde los TextBox
            List<int> setA = ParseInput<int>(textBox1.Text);
            List<string> setB = ParseInput<string>(textBox2.Text);

            // Obtener el producto cartesiano
            List<Tuple<int, string>> cartesianProduct = CartesianProduct(setA, setB);

            // Construir el resultado en una cadena de texto
            StringBuilder result = new StringBuilder();
            foreach (var pair in cartesianProduct)
            {
                result.AppendLine("(" + pair.Item1 + ", " + pair.Item2 + ")");
            }

            // Mostrar el resultado en el label
            label1.Text = result.ToString();
        }

        private List<T> ParseInput<T>(string input)
        {
            // Dividir la entrada por comas y eliminar espacios en blanco
            string[] items = input.Split(',').Select(item => item.Trim()).ToArray();

            // Convertir los elementos a tipo T
            List<T> result = new List<T>();
            foreach (string item in items)
            {
                result.Add((T)Convert.ChangeType(item, typeof(T)));
            }

            return result;
        }

        private List<Tuple<T1, T2>> CartesianProduct<T1, T2>(List<T1> setA, List<T2> setB)
        {
            List<Tuple<T1, T2>> result = new List<Tuple<T1, T2>>();

            foreach (T1 itemA in setA)
            {
                foreach (T2 itemB in setB)
                {
                    result.Add(new Tuple<T1, T2>(itemA, itemB));
                }
            }

            return result;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // No es necesario implementar nada aquí para esta funcionalidad
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Este evento se activa cuando cambia el texto en textBox1
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Este evento se activa cuando cambia el texto en textBox2
        }
    }
}
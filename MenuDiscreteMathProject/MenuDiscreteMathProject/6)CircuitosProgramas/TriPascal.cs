using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrianguloDePascal
 {
    public partial class TriPascal : Form
    {
        public TriPascal()
        {
            InitializeComponent();
        }

        // Función para generar el Triángulo de Pascal hasta la fila n
        private long[,] GeneratePascalTriangle(int n)
        {
            long[,] triangle = new long[n + 1, n + 1];

            for (int i = 0; i <= n; i++)
            {
                triangle[i, 0] = 1;
                triangle[i, i] = 1;

                for (int j = 1; j < i; j++)
                {
                    triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j];
                }
            }

            return triangle;
        }

        // Función para calcular el coeficiente binomial "n choose k" usando el Triángulo de Pascal
        private long BinomialCoefficient(int n, int k)
        {
            long[,] triangle = GeneratePascalTriangle(n);
            return triangle[n, k];
        }

        // Función para generar la expansión binomial simplificada en texto formateado
        private string GenerateBinomialExpansion(int n)
        {
            string expansion = "(a + b)^" + n + " = ";

            for (int k = 0; k <= n; k++)
            {
                long coefficient = BinomialCoefficient(n, k);

                if (coefficient != 1 || (n - k == 0 && k == 0)) // Solo agregar el coeficiente si es distinto de 1 o si es el primer término
                {
                    expansion += coefficient;
                }

                if (n - k > 0) // Solo agregar 'a' si el exponente es mayor a 0
                {
                    expansion += "a";
                    if (n - k > 1) // Solo agregar el exponente si es mayor a 1
                    {
                        expansion += "^" + (n - k);
                    }
                }

                if (k > 0) // Solo agregar 'b' si el exponente es mayor a 0
                {
                    expansion += "b";
                    if (k > 1) // Solo agregar el exponente si es mayor a 1
                    {
                        expansion += "^" + k;
                    }
                }

                if (k < n)
                {
                    expansion += " + ";
                }
            }

            return expansion;
        }

        // Función para imprimir el Triángulo de Pascal y las expansiones binomiales
        private string TrianguloDePascal(int maxN)
        {
            string result = "";

            for (int n = 1; n <= maxN; n++)
            {
                result += GenerateBinomialExpansion(n) + "\n";
            }

            return result;
        }

        // Evento del botón para calcular y mostrar el Triángulo de Pascal y las expansiones binomiales
        private void calculateButton_Click(object sender, EventArgs e)
        {
            int maxN;
            if (int.TryParse(nTextBox.Text, out maxN) && maxN >= 0)
            {
                string triangle = TrianguloDePascal(maxN);
                resultLabel.Text = triangle; // Actualiza el Label con el resultado
            }
            else
            {
                resultLabel.Text = "Por favor, introduce un valor válido para n (n >= 0).";
            }
        }

        private void resultLabel_Click(object sender, EventArgs e)
        {

        }

        private void TriPascal_Load(object sender, EventArgs e)
        {

        }
    }
}
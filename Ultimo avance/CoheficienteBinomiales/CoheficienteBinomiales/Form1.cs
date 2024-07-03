using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CoheficienteBinomiales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Función para calcular el factorial de un número
        private long Factorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            long result = 1;
            for (int i = 2; i <= n; i++)
                result *= i;
            return result;
        }

        // Función para calcular el coeficiente binomial "n choose k"
        private long BinomialCoefficient(int n, int k)
        {
            long numerator = Factorial(n);
            long denominator = Factorial(k) * Factorial(n - k);
            return numerator / denominator;
        }

        // Función para generar la expansión binomial simplificada en texto formateado
        private string GenerateBinomialExpansion(int n)
        {
            string expansion = "(a + b)^" + n + " = ";

            for (int k = 0; k <= n; k++)
            {
                long coefficient = BinomialCoefficient(n, k);

                if (coefficient != 1) // Solo agregar el coeficiente si es distinto de 1
                {
                    expansion += coefficient;
                }

                if (n - k > 0) // Solo agregar a si el exponente es mayor a 0
                {
                    expansion += "a";
                    if (n - k > 1) // Solo agregar el exponente si es mayor a 1
                    {
                        expansion += "^" + (n - k);
                    }
                }

                if (k > 0) // Solo agregar b si el exponente es mayor a 0
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

        // Evento del botón para calcular y mostrar la expansión binomial
        private void calculateButton_Click(object sender, EventArgs e)
        {
            int n;

            if (int.TryParse(nTextBox.Text, out n) && n >= 0)
            {
                string binomialExpansion = GenerateBinomialExpansion(n);
                resultLabel.Text = binomialExpansion;
            }
            else
            {
                resultLabel.Text = "Por favor, introduce un valor válido para n (n >= 0).";
            }
        }
    }
}
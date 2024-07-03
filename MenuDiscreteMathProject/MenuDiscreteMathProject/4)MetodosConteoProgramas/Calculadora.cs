using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double numero = Convert.ToDouble(textBox1.Text);
            double porcentaje = numero / 100;
            textBox1.Text = porcentaje.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cuadrado;
            cuadrado = Convert.ToInt32(textBox1.Text);
            cuadrado = cuadrado * cuadrado;
            textBox1.Text += Environment.NewLine + " = " + Convert.ToString(cuadrado);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double number = double.Parse(textBox1.Text);
                double result = Math.Sqrt(number);
                textBox1.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "*";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "+";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                string expression = textBox1.Text;
                var result = new DataTable().Compute(expression, null);
                textBox1.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "-";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "/";
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private double CalcularSeno(double x, int n)
        {
            double seno = 0;

            for (int i = 0; i < n; i++)
            {
                double coeficiente = (i % 2 == 0) ? 1.0 : -1.0;
                double termino = coeficiente * Math.Pow(x, 2 * i + 1) / Factorial(2 * i + 1);
                seno += termino;
            }

            return seno;
        }

        private double Factorial(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }
        private void button27_Click(object sender, EventArgs e)
        {
            try
            {
                double xDegrees = Convert.ToDouble(textBox1.Text); // Obtener el valor de x en grados desde el TextBox
                double xRadians = xDegrees * Math.PI / 180.0; // Convertir de grados a radianes

                // Define un valor arbitrario para n, por ejemplo, 10
                int n = 10;

                double resultado = CalcularSeno(xRadians, n); // Calcular el seno usando el valor convertido a radianes

                textBox1.Text = resultado.ToString(); // Mostrar el resultado en el cuadro de texto de resultado
            }
            catch (FormatException)
            {
                MessageBox.Show("El valor de x no es un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private double CalcularCoseno(double x, int n)
        {
            double coseno = 1.0; // El primer término de la serie es siempre 1
            double potencia = 1.0; // Inicializamos la potencia de x como 1

            for (int i = 1; i <= n; i++)
            {
                potencia *= x * x; // Calculamos la potencia de x
                double factorial = Factorial(2 * i); // Calculamos el factorial del término actual
                double termino = potencia / factorial; // Calculamos el término actual
                if (i % 2 == 0)
                {
                    // Si i es par, sumamos el término al coseno
                    coseno += termino;
                }
                else
                {
                    // Si i es impar, restamos el término al coseno
                    coseno -= termino;
                }
            }

            return coseno;
        }
        private void button28_Click(object sender, EventArgs e)
        {
            try
            {
                double xDegrees;
                double n; // Definimos n como double para poder ingresar cualquier valor
                double.TryParse(textBox1.Text, out n); // Intentar obtener el valor de n desde el TextBox

               
                if (!double.TryParse(textBox1.Text, out xDegrees))
                {
                    MessageBox.Show("El valor de x no es un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

               
                double xRadians = xDegrees * Math.PI / 180.0;

               
                double resultado = CalcularCoseno(xRadians, (int)n);

               
                if (Math.Abs(resultado) < 1e-10) 
                {
                    resultado = 0;
                }

                
                textBox1.Text = resultado.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("El valor de x no es un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
            

       

        private void button33_Click(object sender, EventArgs e)
        {
            try
            {
                int decimalNumber = int.Parse(textBox1.Text);
                string hexadecimalNumber = DecimalToHexadecimal(decimalNumber);
                textBox1.Text = hexadecimalNumber;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private string DecimalToHexadecimal(int decimalNumber)
        {
            if (decimalNumber == 0)
                return "0";

            string hex = "";
            while (decimalNumber > 0)
            {
                int remainder = decimalNumber % 16;
                char hexDigit;

                if (remainder < 10)
                {
                    hexDigit = (char)('0' + remainder); 
                }
                else
                {
                    hexDigit = (char)('A' + remainder - 10); 
                }

                hex = hexDigit + hex;
                decimalNumber /= 16;
            }
            return hex;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            try
            {
                string hexadecimalNumber = textBox1.Text;
                int decimalNumber = HexadecimalToDecimal(hexadecimalNumber);
                textBox1.Text = decimalNumber.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private int HexadecimalToDecimal(string hexadecimalNumber)
        {
            int decimalNumber = 0;
            int length = hexadecimalNumber.Length;

            for (int i = 0; i < length; i++)
            {
                char digit = hexadecimalNumber[i];
                int value;

                if (Char.IsDigit(digit))
                {
                    value = digit - '0'; 
                }
                else
                {
                    value = Char.ToUpper(digit) - 'A' + 10; 
                }

                decimalNumber += value * (int)Math.Pow(16, length - i - 1);
            }

            return decimalNumber;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string binaryNumber = textBox1.Text;
                double realNumber = BinaryToReal(binaryNumber);
                textBox1.Text = realNumber.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private double CalcularLogaritmoNatural(double x)
        {
            if (x <= 0)
            {
                throw new ArgumentException("El argumento de logaritmo debe ser mayor que cero.", "x");
            }

            double result = Math.Log(x);
            return result;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            try
            {
                double number = double.Parse(textBox1.Text);
                double result = Math.Log(number);
                textBox1.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button25_Click_2(object sender, EventArgs e)
        {

        }

        private double CalcularTangente(double x)
        {
            
            double tangente = Math.Tan(x);

            if (Math.Abs(tangente) > 1e10)
            {
                tangente = double.PositiveInfinity;
            }

            
            if (Math.Abs(tangente) < 1e-10)
            {
                tangente = 0;
            }

            return tangente;
        }
        private void button29_Click(object sender, EventArgs e)
        {
            try
            {
                double xDegrees = Convert.ToDouble(textBox1.Text);
                double xRadians = xDegrees * Math.PI / 180.0; 
                double resultado = CalcularTangente(xRadians); 

                textBox1.Text = resultado.ToString(); 
            }
            catch (FormatException)
            {
                MessageBox.Show("El valor de x no es un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private double BinaryToReal(string binary)
        {
            double result = 0.0;
            int integerPart = 0;
            double fractionalPart = 0.0;

            int dotIndex = binary.IndexOf('.');

            if (dotIndex == -1)
            {
                integerPart = Convert.ToInt32(binary, 2);
            }
            else
            {
                integerPart = Convert.ToInt32(binary.Substring(0, dotIndex), 2);

                string fractionalBinary = binary.Substring(dotIndex + 1);
                for (int i = 0; i < fractionalBinary.Length; i++)
                {
                    fractionalPart += double.Parse(fractionalBinary[i].ToString()) * Math.Pow(2, -(i + 1));
                }
            }

            result = integerPart + fractionalPart;

            return result;
        }
        private void button25_Click(object sender, EventArgs e)
        {
            try
            {
                string binaryNumber = textBox1.Text;
                double realNumber = BinaryToReal(binaryNumber);
                textBox1.Text = realNumber.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private string DecimalToBinary(int decimalNumber)
        {
            if (decimalNumber == 0)
                return "0";

            string binary = "";
            while (decimalNumber > 0)
            {
                binary = (decimalNumber % 2) + binary;
                decimalNumber /= 2;
            }
            return binary;
        }
        private void button26_Click(object sender, EventArgs e)
        {
            try
            {
                int decimalNumber = int.Parse(textBox1.Text);
                string binaryNumber = DecimalToBinary(decimalNumber);
                textBox1.Text = binaryNumber;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {

        }
         
    }
}

            



       
        



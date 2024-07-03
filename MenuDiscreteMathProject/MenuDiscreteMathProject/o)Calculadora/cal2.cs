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

namespace CAlculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }
        private void agregarNumero(object sender, EventArgs e)
        {

            System.Windows.Forms.Button boton = (System.Windows.Forms.Button)sender;
            if (txtResultado.Text == "0")
                txtResultado.Text = "";
            txtResultado.Text += boton.Text;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "9";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "2";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "3";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + ",";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            int cuadrado;
            cuadrado = Convert.ToInt32(txtResultado.Text);
            cuadrado = cuadrado * cuadrado;
            txtResultado.Text = txtResultado.Text + " = " + Convert.ToString(cuadrado);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (txtResultado.TextLength == 1) txtResultado.Text = "0";
            txtResultado.Text = txtResultado.Text.Remove(txtResultado.Text.Length - 1);
        }
        string Operador = "";
        double num1 = 0;
        double num2 = 0;
        private void resultado_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(txtResultado.Text);

            switch (Operador)
            {
                case "+":
                    txtResultado.Text = $"{num1 + num2}";
                    break;
                case "-":
                    txtResultado.Text = $"{num1 - num2}";
                    break;
                case "*":
                    txtResultado.Text = $"{num1 * num2}";
                    break;
                case "/":
                    txtResultado.Text = $"{num1 / num2}";
                    break;
            }
        }

        private void suma_Click(object sender, EventArgs e)
        {
            Operador = "+";
            num1 = Convert.ToDouble(txtResultado.Text);
            txtResultado.Text = "0";
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "0";
            num1 = 0;
            num2 = 0;
            Operador = "";
        }

        private void resta_Click(object sender, EventArgs e)
        {
            Operador = "-";
            num1 = Convert.ToDouble(txtResultado.Text);
            txtResultado.Text = "0";
        }

        private void raizCuadrada_Click(object sender, EventArgs e)
        {
            int numero;
            numero = Convert.ToInt32(txtResultado.Text);
            double raizCuadrada = Math.Sqrt(numero);
            txtResultado.Text = "√(" + numero.ToString() + ") = " + raizCuadrada.ToString("N0");
        }

        private void borrarTodo_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "0";
            num1 = 0;
            num2 = 0;
            Operador = "";
        }

        private void multiplicar_Click(object sender, EventArgs e)
        {
            Operador = "*";
            num1 = Convert.ToDouble(txtResultado.Text);
            txtResultado.Text = "0";
        }

        private void dividir_Click(object sender, EventArgs e)
        {
            Operador = "/";
            num1 = Convert.ToDouble(txtResultado.Text);
            txtResultado.Text = "0";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            double numero = Convert.ToDouble(txtResultado.Text);
            if (numero != 0)
            {
                double inverso = 1 / numero;
                txtResultado.Text = inverso.ToString();
            }
            else
            {
                MessageBox.Show("No se puede calcular el inverso de cero.");
            }
        }

        private void porcentaje_Click(object sender, EventArgs e)
        {
            double numero = Convert.ToDouble(txtResultado.Text);
            double porcentaje = numero / 100;
            txtResultado.Text = porcentaje.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double numero = Convert.ToDouble(txtResultado.Text);
            numero = -numero;
            txtResultado.Text = numero.ToString();
        }



        static string DecimalABinary(int decimalNumber)
        {
            if (decimalNumber == 0)
            {
                return "0";
            }
            else
            {
                string binary = "";
                while (decimalNumber > 0)
                {
                    int remainder = decimalNumber % 2;
                    binary = remainder + binary;
                    decimalNumber /= 2;
                }
                return binary;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                bt0.Enabled = true;
                bt1.Enabled = true;
                bt2.Enabled = false;
                bt3.Enabled = false;
                bt4.Enabled = false;
                bt5.Enabled = false;
                bt6.Enabled = false;
                bt7.Enabled = false;
                bt8.Enabled = false;
                bt9.Enabled = false;


                {
                    // Asumiendo que txtResultado contiene un valor decimal
                    int numero = Convert.ToInt32(txtResultado.Text);
                    txtResultado.Text = DecimalToBinary(numero);
                }
            }
        }

        private void ConvertirADecimal()
        {
            // Asumiendo que txtResultado contiene un valor decimal
            int numero = Convert.ToInt32(txtResultado.Text);
            txtResultado.Text = numero.ToString();
        }





        // Función para convertir decimal a binario
        private string DecimalToBinary(int numero)
        {
            return Convert.ToString(numero, 2);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            bt0.Enabled = true;
            bt1.Enabled = true;
            bt2.Enabled = true;
            bt3.Enabled = true;
            bt4.Enabled = true;
            bt5.Enabled = true;
            bt6.Enabled = true;
            bt7.Enabled = true;
            bt8.Enabled = true;
            bt9.Enabled = true;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            {
                double x = Double.Parse(txtResultado.Text);
                double radians = x * (Math.PI / 180); // Convertir grados a radianes
                double cos = CosTaylorSeries(radians);
                txtResultado.Text = cos.ToString();
            }

            double Factorial(int n)
            {
                double fact = 1;
                for (int i = 1; i <= n; i++)
                {
                    fact *= i;
                }
                return fact;
            }


            double CosTaylorSeries(double x)
            {
                double sum = 0;
                for (int n = 0; n < 10; n++)
                {
                    sum += Math.Pow(-1, n) * Math.Pow(x, 2 * n) / Factorial(2 * n);
                }
                return sum;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            {
                if (double.TryParse(txtResultado.Text, out double x))
                {
                    double radians = x * (Math.PI / 180.0); // Convertir grados a radianes
                    double sin = SinTaylorSeries(radians);
                    txtResultado.Text = sin.ToString();
                }
                else
                {
                    MessageBox.Show("Ingrese un número válido.");
                }
            }
            double Factorial(int n)
            {
                double fact = 1;
                for (int i = 1; i <= n; i++)
                {
                    fact *= i;
                }
                return fact;
            }
            double SinTaylorSeries(double x)
            {
                double sum = 0;
                for (int n = 0; n < 10; n++)
                {
                    sum += Math.Pow(-1, n) * Math.Pow(x, 2 * n + 1) / Factorial(2 * n + 1);
                }
                return sum;
            }


        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (double.TryParse(txtResultado.Text, out double angle))
            {
                double radians = angle * (Math.PI / 180.0);
                double tangent = Math.Tan(angle); // Tangente
                txtResultado.Text = tangent.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ángulo válido.");
            }

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (double.TryParse(txtResultado.Text, out double degrees))
            {
                double radians = degrees * (Math.PI / 180);
                double cosine = Math.Cos(radians);
                if (cosine == 0)
                {
                    MessageBox.Show("Secante indefinida (coseno es cero).");
                }
                else
                {
                    double secant = 1 / cosine; // Secante
                    txtResultado.Text = secant.ToString();
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ángulo válido.");
            }

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (double.TryParse(txtResultado.Text, out double degrees))
            {
                double radians = degrees * (Math.PI / 180);
                double sine = Math.Sin(radians);
                if (sine == 0)
                {
                    MessageBox.Show("Cosecante indefinida (seno es cero).");
                }
                else
                {
                    double cosecant = 1 / sine; // Cosecante
                    txtResultado.Text = cosecant.ToString();
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ángulo válido.");
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (double.TryParse(txtResultado.Text, out double numero))
            {
                if (numero > 0)
                {
                    // Definir la base del logaritmo
                    double baseLog = 10; // Aquí puedes cambiar a otra base si lo deseas

                    // Calcular el logaritmo con la base especificada
                    double logaritmo = Math.Log(numero, baseLog);

                    // Mostrar el resultado
                    txtResultado.Text = logaritmo.ToString();
                }
            }
        }
    }
}

    
    


    



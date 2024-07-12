using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class BinarioDecimalVicever : Form
    {
        public BinarioDecimalVicever()
        {
            InitializeComponent();
        }

        private string DecimalToBinary(int decimalNumber)
        {
            if (decimalNumber == 0)
                return "0";

            string binary = string.Empty;
            while (decimalNumber > 0)
            {
                binary = (decimalNumber % 2) + binary;
                decimalNumber /= 2;
            }
            return binary;
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

        private void button1_Click(object sender, EventArgs e) // Binario a Real
        {
            try
            {
                string binaryNumber = textBox1.Text;
                double realNumber = BinaryToReal(binaryNumber);
                textBox2.Text = realNumber.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void BinarioDecimalVicever_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
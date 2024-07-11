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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string binaryNumber = textBox1.Text;
                double realNumber = BinaryToReal(binaryNumber);
                textBox2.Text = realNumber.ToString(); // Cambio textBox1.Text a textBox2.Text
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string binaryNumber = textBox1.Text;
                int decimalNumber = BinaryToDecimal(binaryNumber);
                textBox2.Text = decimalNumber.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private int BinaryToDecimal(string binary)
        {
            int decimalNumber = 0;


            for (int i = binary.Length - 1; i >= 0; i--)
            {

                int digit = int.Parse(binary[i].ToString());


                decimalNumber += digit * (int)Math.Pow(2, binary.Length - 1 - i);
            }

            return decimalNumber;
        }

        private void BinarioDecimalVicever_Load(object sender, EventArgs e)
        {

        }
    }


}


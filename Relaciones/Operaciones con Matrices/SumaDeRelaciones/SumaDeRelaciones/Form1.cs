using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumaDeRelaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer los elementos del textBox1
                string[] elementos = textBox1.Text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                int[] numeros = elementos.Select(int.Parse).ToArray();
                int n = numeros.Length;

                // Crear la matriz de suma
                int[,] matrizSuma = new int[n, n];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        matrizSuma[i, j] = numeros[i] + numeros[j];
                    }
                }

                // Mostrar la matriz en el dataGridView
                dataGridView1.ColumnCount = n;
                dataGridView1.RowCount = n;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = matrizSuma[i, j];
                    }
                }

                // Mostrar la matriz en el textBox2
                string matrizTexto = "";
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        matrizTexto += matrizSuma[i, j] + "\t";
                    }
                    matrizTexto += Environment.NewLine;
                }
                textBox2.Text = matrizTexto;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
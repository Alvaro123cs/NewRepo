using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MatricesDeRelaciones
{
    public partial class Form1 : Form
    {
        private int[,] matriz1 = new int[0, 0];
        private int[,] matriz2 = new int[0, 0];
        private List<string> elementos = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private int[,] ConvertirARelacion(string relacion, List<string> elementosX, List<string> elementosY)
        {
            int[,] matriz = new int[elementosX.Count, elementosY.Count];
            string[] pares = relacion.Split(' ');

            foreach (string par in pares)
            {
                string[] elementosPar = par.Trim('(', ')').Split(',');
                if (elementosPar.Length == 2)
                {
                    int fila = elementosX.IndexOf(elementosPar[0]);
                    int columna = elementosY.IndexOf(elementosPar[1]);
                    if (fila >= 0 && columna >= 0)
                    {
                        matriz[fila, columna] = 1;
                    }
                }
            }
            return matriz;
        }

        private void matrices1_Click(object sender, EventArgs e)
        {
            elementos = new List<string> { "1", "2", "3", "4" }; // Conjunto X

            string relacion1 = textBox1.Text;
            string relacion2 = textBox2.Text;

            matriz1 = ConvertirARelacion(relacion1, elementos, elementos);
            matriz2 = ConvertirARelacion(relacion2, elementos, elementos);

            string matriz1Str = MatrizToString(matriz1);
            string matriz2Str = MatrizToString(matriz2);

            resultado.Text = $"Matriz 1:\n{matriz1Str}\nMatriz 2:\n{matriz2Str}";
        }

        private void sumar_Click(object sender, EventArgs e)
        {
            if (matriz1.Length == 0 || matriz2.Length == 0)
            {
                resultadOperaciones.Text = "Primero debes generar las matrices.";
                return;
            }

            try
            {
                int[,] resultadoSuma = OperarMatrices(matriz1, matriz2, (a, b) => a + b);
                resultadOperaciones.Text = $"Resultado de Suma:\n{MatrizToString(resultadoSuma)}";
            }
            catch (Exception ex)
            {
                resultadOperaciones.Text = ex.Message;
            }
        }

        private void restar_Click(object sender, EventArgs e)
        {
            if (matriz1.Length == 0 || matriz2.Length == 0)
            {
                resultadOperaciones.Text = "Primero debes generar las matrices.";
                return;
            }

            try
            {
                int[,] resultadoResta = OperarMatrices(matriz1, matriz2, (a, b) => a - b);
                resultadOperaciones.Text = $"Resultado de Resta:\n{MatrizToString(resultadoResta)}";
            }
            catch (Exception ex)
            {
                resultadOperaciones.Text = ex.Message;
            }
        }

        private void multiplica_Click(object sender, EventArgs e)
        {
            if (matriz1.Length == 0 || matriz2.Length == 0)
            {
                resultadOperaciones.Text = "Primero debes generar las matrices.";
                return;
            }

            if (matriz1.GetLength(1) != matriz2.GetLength(0))
            {
                resultadOperaciones.Text = "Las matrices no son multiplicables.";
                return;
            }

            try
            {
                int[,] resultadoMultiplicacion = MultiplicarMatrices(matriz1, matriz2);
                resultadOperaciones.Text = $"Resultado de Multiplicación:\n{MatrizToString(resultadoMultiplicacion)}";
            }
            catch (Exception ex)
            {
                resultadOperaciones.Text = ex.Message;
            }
        }

        private int[,] OperarMatrices(int[,] matrizA, int[,] matrizB, Func<int, int, int> operacion)
        {
            int filas = matrizA.GetLength(0);
            int columnas = matrizA.GetLength(1);

            if (filas != matrizB.GetLength(0) || columnas != matrizB.GetLength(1))
            {
                throw new Exception("Las matrices deben tener las mismas dimensiones para esta operación.");
            }

            int[,] resultado = new int[filas, columnas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    resultado[i, j] = operacion(matrizA[i, j], matrizB[i, j]);
                }
            }

            return resultado;
        }

        private int[,] MultiplicarMatrices(int[,] matrizA, int[,] matrizB)
        {
            int filasA = matrizA.GetLength(0);
            int columnasA = matrizA.GetLength(1);
            int columnasB = matrizB.GetLength(1);

            int[,] resultado = new int[filasA, columnasB];

            for (int i = 0; i < filasA; i++)
            {
                for (int j = 0; j < columnasB; j++)
                {
                    resultado[i, j] = 0;
                    for (int k = 0; k < columnasA; k++)
                    {
                        resultado[i, j] += matrizA[i, k] * matrizB[k, j];
                    }
                }
            }

            return resultado;
        }

        private string MatrizToString(int[,] matriz)
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);
            string resultado = "";

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    resultado += matriz[i, j] + " ";
                }
                resultado = resultado.Trim() + "\n";
            }

            return resultado.Trim();
        }

        // Métodos vacíos que pueden ser implementados si es necesario
        private void Form1_Load(object sender, EventArgs e) { }
        private void relacion1_Click(object sender, EventArgs e) { }
        private void relacion2_Click(object sender, EventArgs e) { }
        private void resultado_Click(object sender, EventArgs e) { }
        private void resultadOperaciones_Click(object sender, EventArgs e) { }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Implementación opcional para manejo de eventos al cambiar texto en textBox1
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Implementación opcional para manejo de eventos al cambiar texto en textBox2
        }
    }
}

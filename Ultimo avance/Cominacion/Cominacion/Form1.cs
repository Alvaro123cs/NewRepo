using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combinacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string letrasInput = txtLetras.Text;
            char[] letras = letrasInput.ToCharArray();

            List<string> permutaciones = GenerarPermutaciones(letras);
            lstPermutaciones.Items.Clear();
            foreach (string permutacion in permutaciones)
            {
                lstPermutaciones.Items.Add(permutacion);
            }
            lblTotal.Text = String.Format("Total de Combinaciones: {0}", permutaciones.Count);
        }

        static List<string> GenerarPermutaciones(char[] letras)
        {
            List<string> resultado = new List<string>();
            Permutar(letras, 0, letras.Length - 1, resultado);
            return resultado;
        }

        static void Permutar(char[] letras, int izquierda, int derecha, List<string> resultado)
        {
            if (izquierda == derecha)
            {
                resultado.Add(new string(letras));
            }
            else
            {
                for (int i = izquierda; i <= derecha; i++)
                {
                    Intercambiar(ref letras[izquierda], ref letras[i]);
                    Permutar(letras, izquierda + 1, derecha, resultado);
                    Intercambiar(ref letras[izquierda], ref letras[i]); // backtrack
                }
            }
        }

        static void Intercambiar(ref char a, ref char b)
        {
            char temp = a;
            a = b;
            b = temp;
        }
    }
}

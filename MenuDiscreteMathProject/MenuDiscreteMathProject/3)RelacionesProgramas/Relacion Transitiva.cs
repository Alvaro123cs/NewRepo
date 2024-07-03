using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Relacion_Transitiva
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conjunto = textBox1.Text.Trim();
            string[] elementos = conjunto.Split(new char[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries)
                                          .Select(elemento => elemento.Trim())
                                          .Distinct()
                                          .ToArray();

            List<string> relaciones = GenerarRelaciones(elementos);

            // Mostrar relaciones en textBox2
            textBox2.Text = string.Join("; ", relaciones);

            bool esTransitiva = EsTransitiva(relaciones.ToArray());
            labelResultado.Text = "¿La relación es transitiva? = " + esTransitiva;

        }

       private List<string> GenerarRelaciones(string[] elementos)
       { 
           List<string> relaciones = new List<string>();

    for (int i = 0; i < elementos.Length; i++)
    {
        for (int j = 0; j < elementos.Length; j++)
        {
            if (i != j)
            {
                relaciones.Add("(" + elementos[i] + ", " + elementos[j] + ")");
            }
        }
    }

    return relaciones;
        
            
       
       
       }

        private bool EsTransitiva(string[] relaciones)
        {
            var relacionTuplas = new HashSet<Tuple<string, string>>();

            foreach (var relacion in relaciones)
            {
                var elementos = relacion.Trim('(', ')').Split(',').Select(e => e.Trim()).ToArray();
                if (elementos.Length == 2)
                {
                    relacionTuplas.Add(Tuple.Create(elementos[0], elementos[1]));
                }
            }

            foreach (var tupla1 in relacionTuplas)
            {
                foreach (var tupla2 in relacionTuplas)
                {
                    if (tupla1.Item2 == tupla2.Item1)
                    {
                        if (!relacionTuplas.Contains(Tuple.Create(tupla1.Item1, tupla2.Item2)))
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
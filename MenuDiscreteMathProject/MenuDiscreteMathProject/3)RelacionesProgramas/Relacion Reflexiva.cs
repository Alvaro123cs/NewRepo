using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Relaciones
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var conjunto = ObtenerConjunto();
            var relaciones = ObtenerRelaciones();
            MostrarRelaciones(relaciones);
            bool esReflexiva = EsReflexiva(conjunto, relaciones);
            labelResultado.Text = "La relación es reflexiva: " + esReflexiva.ToString();
        }

        private HashSet<string> ObtenerConjunto()
        {
            return new HashSet<string>(textBox1.Text.Split(',').Select(x => x.Trim()));
        }

        private List<Tuple<string, string>> ObtenerRelaciones()
        {
            var relaciones = new List<Tuple<string, string>>();
            var relacionesInput = textBox3.Text.Split(';').Select(r => r.Trim()).ToList();
            foreach (var relacion in relacionesInput)
            {
                var elementos = relacion.Split(',');
                if (elementos.Length == 2)
                {
                    relaciones.Add(new Tuple<string, string>(elementos[0].Trim(), elementos[1].Trim()));
                }
            }
            return relaciones;
        }

        private void MostrarRelaciones(List<Tuple<string, string>> relaciones)
        {
            textBox2.Text = string.Join("; ", relaciones.Select(r => $"({r.Item1}, {r.Item2})"));
        }

        private bool EsReflexiva(HashSet<string> conjunto, List<Tuple<string, string>> relaciones)
        {
            foreach (var elemento in conjunto)
            {
                bool encontrada = relaciones.Any(relacion => relacion.Item1 == elemento && relacion.Item2 == elemento);
                if (!encontrada)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Relacion_Simetrica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] relaciones = textBox1.Text.Split(';')
                                                .Select(relacion => relacion.Trim())
                                                .ToArray();

            List<string> relacionesSimetricas = ObtenerRelacionesSimetricas(relaciones);
            textBox2.Text = string.Join("; ", relacionesSimetricas);

            bool esSimetrica = EsSimetrica(relaciones);
            labelResultado.Text = "¿La relación es simétrica? " + esSimetrica;
        }

        private List<string> ObtenerRelacionesSimetricas(string[] relaciones)
        {
            List<string> relacionesSimetricas = new List<string>();

            foreach (var relacion in relaciones)
            {
                string[] elementos = relacion.Trim('(', ')').Split(',')
                                            .Select(elemento => elemento.Trim())
                                            .ToArray();
                relacionesSimetricas.Add("(" + elementos[1] + ", " + elementos[0] + ")");
            }

            return relacionesSimetricas;
        }

        private bool EsSimetrica(string[] relaciones)
        {
            HashSet<string> conjuntoRelaciones = new HashSet<string>(relaciones);

            foreach (var relacion in relaciones)
            {
                string[] elementos = relacion.Trim('(', ')').Split(',')
                                            .Select(elemento => elemento.Trim())
                                            .ToArray();
                string relacionInversa = "(" + elementos[1] + ", " + elementos[0] + ")";
                if (!conjuntoRelaciones.Contains(relacionInversa))
                {
                    return false;
                }
            }
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
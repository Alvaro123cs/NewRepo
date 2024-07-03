using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuDiscreteMathProject._6_CircuitosProgramas
{
    public partial class MenuCircuitos : Form
    {
        public MenuCircuitos()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void trianguloDePascalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario TriPascal
            TrianguloDePascal.TriPascal formTriPascal = new TrianguloDePascal.TriPascal();

            // Mostrar el formulario TriPascal
            formTriPascal.Show();
        }

        private void combinacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario Combinaciones
            Combinacion.Combinaciones formCombinaciones = new Combinacion.Combinaciones();

            // Mostrar el formulario Combinaciones
            formCombinaciones.Show();
        }

        private void coeficientesBinomialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CoheficienteBinomiales.CoeBinobiales formCoeBinobiales = new CoheficienteBinomiales.CoeBinobiales();

            // Mostrar el formulario CoeBinobiales
            formCoeBinobiales.Show();
        }
    }
}

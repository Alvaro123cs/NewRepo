using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Relacion_Asimetrica;
using Relacion_Inversa;

namespace MenuDiscreteMathProject._3_RelacionesProgramas
{
    public partial class MenuRelaciones : Form
    {
        public MenuRelaciones()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void asimétricaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relacion_Asimetrica.Form1 formAsimetrica = new Relacion_Asimetrica.Form1();
            formAsimetrica.StartPosition = FormStartPosition.CenterScreen; // Esto centra el formulario en la pantalla
            formAsimetrica.Show();
        }

        private void rToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relacion_Inversa.Form1 formInversa = new Relacion_Inversa.Form1();
            formInversa.StartPosition = FormStartPosition.CenterScreen; // Esto centra el formulario en la pantalla
            formInversa.Show();
        }

        private void relacionReflexivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relaciones.Form1 formReflexiva = new Relaciones.Form1();
            formReflexiva.StartPosition = FormStartPosition.CenterScreen; // Esto centra el formulario en la pantalla
            formReflexiva.Show();
        }

        private void relacionSimetricaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relacion_Simetrica.Form1 formSimetrica = new Relacion_Simetrica.Form1();
            formSimetrica.StartPosition = FormStartPosition.CenterScreen; // Esto centra el formulario en la pantalla
            formSimetrica.Show();
        }

        private void relacionTransitivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relacion_Transitiva.Form1 formTransitiva = new Relacion_Transitiva.Form1();
            formTransitiva.StartPosition = FormStartPosition.CenterScreen; // Esto centra el formulario en la pantalla
            formTransitiva.Show();
        }

        private void relacionComposiciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relacion_Composicion.Relacion_Composicion formComposicion = new Relacion_Composicion.Relacion_Composicion();
            formComposicion.StartPosition = FormStartPosition.CenterScreen; // Esto centra el formulario en la pantalla
            formComposicion.Show();

        }
    }
}

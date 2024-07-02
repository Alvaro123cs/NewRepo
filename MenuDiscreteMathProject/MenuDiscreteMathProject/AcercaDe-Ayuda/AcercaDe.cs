using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuDiscreteMathProject.AcercaDe_Ayuda
{
    public partial class AcercaDe : Form
    {
        public AcercaDe()
        {
            InitializeComponent();
            this.Resize += new EventHandler(AcercaDe_Resize);
        }

        private void AcercaDe_Resize(object sender, EventArgs e)
        {
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            // Ajustar el tamaño y la posición del título
            labelTitulo.Left = (formWidth - labelTitulo.Width) / 2;

            // Ajustar el tamaño y la posición de la descripción
            labelDescripcion.Width = formWidth - 100; // margen
            labelDescripcion.Left = (formWidth - labelDescripcion.Width) / 2;

            // Ajustar la posición del título de los integrantes
            labelIntegrantes.Left = (formWidth - labelIntegrantes.Width) / 2;

            // Calcular las nuevas posiciones de las imágenes y las etiquetas de los integrantes
            int pictureSpacing = 20; // espacio entre las imágenes
            int pictureBoxWidth = pictureBox1.Width;
            int pictureBoxHeight = pictureBox1.Height;
            int totalPictureWidth = 3 * pictureBoxWidth + 2 * pictureSpacing;

            int startX = (formWidth - totalPictureWidth) / 2;
            pictureBox1.Left = startX;
            pictureBox2.Left = startX + pictureBoxWidth + pictureSpacing;
            pictureBox3.Left = startX + 2 * (pictureBoxWidth + pictureSpacing);

            // Ajustar las posiciones de las etiquetas de los nombres
            label1.Left = pictureBox1.Left + (pictureBoxWidth - label1.Width) / 2;
            label2.Left = pictureBox2.Left + (pictureBoxWidth - label2.Width) / 2;
            label3.Left = pictureBox3.Left + (pictureBoxWidth - label3.Width) / 2;

            // Puedes ajustar otros controles de la misma manera
        }
        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void labelIntegrantes_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

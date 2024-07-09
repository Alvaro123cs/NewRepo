using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication6;

namespace MenuDiscreteMathProject._2_LenguajeMathProgramas
{
    public partial class MenuLenguaje : Form
    {
        public MenuLenguaje()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void productoCartesianoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductoCartesiano productoCartesianoForm = new ProductoCartesiano();
            productoCartesianoForm.Show();
        }

        private void unionDeConjutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Union UnionForm = new Union();
            UnionForm.Show();
        }

        private void interseccionDeConjutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Interseccion InterseccionForm = new Interseccion();
            InterseccionForm.Show();
        }
    }
}

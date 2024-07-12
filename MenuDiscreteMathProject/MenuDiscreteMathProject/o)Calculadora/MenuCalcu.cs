
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAlculadora; // Asegúrate de que el espacio de nombres es correcto.



namespace MenuDiscreteMathProject.o_Calculadora
{
    public partial class MenuCalcu : Form
    {
        public MenuCalcu()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculadora1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculadora calculadora = new Calculadora();
            calculadora.Show();
        }

       
    }
}

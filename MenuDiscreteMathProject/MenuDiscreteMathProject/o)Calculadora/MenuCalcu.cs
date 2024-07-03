using CalculadoraCientifica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
using CAlculadora;

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
            Cal1 calc1 = new Cal1();
            calc1.Show();
        }

        private void calculadora2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculadora calc2 = new Calculadora();
            calc2.Show();
        }
    }
}

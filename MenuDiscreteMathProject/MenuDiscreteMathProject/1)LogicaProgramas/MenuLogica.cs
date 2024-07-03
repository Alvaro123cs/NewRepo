using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication4;
using WindowsFormsApplication1; // Para el formulario Form1

namespace MenuDiscreteMathProject._1_LogicaProgramas
{
    public partial class MenuLogica : Form
    {
        public MenuLogica()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void proposicionesLógicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proposiciones proposicionesForm = new Proposiciones();
            proposicionesForm.Show();
        }

        private void negaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario Form1 y mostrarlo
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void proposiciónYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario ProposicionY y mostrarlo
            ProposicionY proposicionYForm = new ProposicionY();
            proposicionYForm.Show();
        }
    }
}

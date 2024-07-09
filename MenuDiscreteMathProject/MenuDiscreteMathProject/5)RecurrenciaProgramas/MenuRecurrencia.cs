using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuDiscreteMathProject._5_RecurrenciaProgramas
{
    public partial class MenuRecurrencia : Form
    {
        public MenuRecurrencia()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ecauionesDeOrden1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcuacionOrden1 ecuacionOrden1 = new EcuacionOrden1();   
            ecuacionOrden1.Show();
        }

        private void ecuacionesDeOrden2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcuacionOrden2 ecuacionOrden2 = new EcuacionOrden2();
            ecuacionOrden2.Show();
        }
    }
}

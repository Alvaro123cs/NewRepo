using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuDiscreteMathProject.o_ConversionesProgramas
{
    public partial class Menuconversiones : Form
    {
        public Menuconversiones()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menuconversiones_Load(object sender, EventArgs e)
        {

        }

        private void binarioToDecimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Instanciar y mostrar el formulario BinarioDecimalVicever
            WindowsFormsApplication5.BinarioDecimalVicever binarioDecimalForm = new WindowsFormsApplication5.BinarioDecimalVicever();
            binarioDecimalForm.Show();
        }

        private void decimalToBinarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Instanciar y mostrar el formulario DecimaltoBinario
            decimaltobinary.DecimaltoBinario decimalBinarioForm = new decimaltobinary.DecimaltoBinario();
            decimalBinarioForm.Show();
        }
    }
}

using System;
using System.Windows.Forms;

namespace LogicaMatematicaSistemasNumericos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccionado = comboBox1.SelectedItem.ToString();

            switch (seleccionado)
            {
                case "programa 1":
                    tabControl1.SelectedIndex = 0;
                    break;
                case "programa 2":
                    tabControl1.SelectedIndex = 1;
                    break;
                case "programa 3":
                    tabControl1.SelectedIndex = 2;
                    break;
                case "programa 4":
                    tabControl1.SelectedIndex = 3;
                    break;
            }
        }
    }
}

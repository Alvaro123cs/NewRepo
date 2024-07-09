using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MenuDiscreteMathProject._5_RecurrenciaProgramas
{
    public partial class EcuacionOrden1 : Form
    {
        public EcuacionOrden1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBoxN.Text);
            int c = int.Parse(textBoxCoef.Text);
            int d = int.Parse(textBoxD.Text);
            int a0 = int.Parse(textBoxA0.Text);

            var result = ResolverRecurrenciaOrden1(n, c, d, a0);
            textBoxResultado.Text = string.Join(", ", result);
        }

        private int[] ResolverRecurrenciaOrden1(int n, int c, int d, int a0)
        {
            int[] resultado = new int[n + 1];
            resultado[0] = a0;

            for (int i = 1; i <= n; i++)
            {
                resultado[i] = c * resultado[i - 1] + d;
            }

            return resultado;
        }
    }
}
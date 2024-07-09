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
    public partial class EcuacionOrden2 : Form
    {
        public EcuacionOrden2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBoxN.Text);
            int c1 = int.Parse(textBoxCoef1.Text);
            int c2 = int.Parse(textBoxCoef2.Text);
            int d = int.Parse(textBoxD.Text);
            int a0 = int.Parse(textBoxA0.Text);
            int a1 = int.Parse(textBoxA1.Text);

            var result = ResolverRecurrenciaOrden2(n, c1, c2, d, a0, a1);
            textBoxResultado.Text = string.Join(", ", result);
        }

        private int[] ResolverRecurrenciaOrden2(int n, int c1, int c2, int d, int a0, int a1)
        {
            int[] resultado = new int[n + 1];
            resultado[0] = a0;
            resultado[1] = a1;

            for (int i = 2; i <= n; i++)
            {
                resultado[i] = c1 * resultado[i - 1] + c2 * resultado[i - 2] + d;
            }

            return resultado;
        }
    }
}
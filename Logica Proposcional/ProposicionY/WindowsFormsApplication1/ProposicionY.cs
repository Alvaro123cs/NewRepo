using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ProposicionY : Form
    {
        public ProposicionY()
        {
            InitializeComponent();
        }

        int proposiciony (int x1, int x2)
        {
            if ((x1 == 1) &&  (x2 == 1))
                return 1;
            else
                return 0;
        }

        int proposiciono (int x1, int x2)
        {

            if ((x1 == 1) || (x2 == 1))
                return 1;
            else
                return 1;

        }

        



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        
              int x1, x2;
            x1 = Convert.ToInt32(textBox1.Text);
            x2 = Convert.ToInt32(textBox2.Text);
            textBox3.Text = Convert.ToString(proposiciony(x1, x2));
            textBox4.Text = Convert.ToString(proposiciony(x1, x2));



        }
    }
}

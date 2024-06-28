namespace Relaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Leer el conjunto A desde textBox1
            string conjuntoA = textBox1.Text;
            string[] elementosA = conjuntoA.Split(',');

            // Leer la relación R desde textBox2
            string relacionR = textBox2.Text;
            string[] paresR = relacionR.Split(' ');

            // Crear un hashset para la relación R para facilitar la búsqueda
            HashSet<string> paresRelacion = new HashSet<string>(paresR);

            // Verificar si la relación es simétrica y antisimétrica
            bool esSimetrica = true;
            bool esAntisimetrica = true;
            foreach (string par in paresR)
            {
                string[] elementosPar = par.Trim('(', ')').Split(',');
                if (elementosPar.Length == 2)
                {
                    string a = elementosPar[0];
                    string b = elementosPar[1];
                    string parInverso = $"({b},{a})";

                    if (a != b && paresRelacion.Contains(parInverso))
                    {
                        esAntisimetrica = false;
                    }
                    if (!paresRelacion.Contains(parInverso))
                    {
                        esSimetrica = false;
                    }
                }
            }

            // Mostrar el resultado en label2
            if (esSimetrica)
            {
                label2.Text = "La relación es simétrica.";
            }
            else if (esAntisimetrica)
            {
                label2.Text = "La relación es antisimétrica.";
            }
            else
            {
                label2.Text = "La relación no es ni simétrica ni antisimétrica.";
            }
        

    }

        private void label2_Click(object sender, EventArgs e)
        {
            // Código para el evento click de label2
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}



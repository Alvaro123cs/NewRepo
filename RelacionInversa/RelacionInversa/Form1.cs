namespace RelacionInversa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Leer el conjunto X desde textBox1
            string conjuntoX = textBox1.Text;

            // Leer la relación R desde textBox2
            string relacionR = textBox2.Text;
            string[] paresR = relacionR.Split(' ');

            // Calcular la relación inversa
            List<string> paresInversos = new List<string>();
            foreach (string par in paresR)
            {
                string[] elementosPar = par.Trim('(', ')').Split(',');
                if (elementosPar.Length == 2)
                {
                    string inverso = $"({elementosPar[1]},{elementosPar[0]})";
                    paresInversos.Add(inverso);
                }
            }

            // Mostrar el resultado en label3
            label3.Text = string.Join(" ", paresInversos);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

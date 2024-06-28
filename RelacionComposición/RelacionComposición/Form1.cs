namespace RelacionComposición
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Leer la relación R1 desde textBox1
            string relacionR1 = textBox1.Text;
            string[] paresR1 = relacionR1.Split(' ');

            // Leer la relación R2 desde textBox2
            string relacionR2 = textBox2.Text;
            string[] paresR2 = relacionR2.Split(' ');

            // Convertir las relaciones a listas de tuplas
            List<Tuple<string, string>> listaR1 = new List<Tuple<string, string>>();
            foreach (string par in paresR1)
            {
                string[] elementosPar = par.Trim('(', ')').Split(',');
                if (elementosPar.Length == 2)
                {
                    listaR1.Add(Tuple.Create(elementosPar[0], elementosPar[1]));
                }
            }

            List<Tuple<string, string>> listaR2 = new List<Tuple<string, string>>();
            foreach (string par in paresR2)
            {
                string[] elementosPar = par.Trim('(', ')').Split(',');
                if (elementosPar.Length == 2)
                {
                    listaR2.Add(Tuple.Create(elementosPar[0], elementosPar[1]));
                }
            }

            // Calcular la relación compuesta R2 ◦ R1
            List<string> composicion = new List<string>();
            foreach (var r1 in listaR1)
            {
                foreach (var r2 in listaR2)
                {
                    if (r1.Item2 == r2.Item1)
                    {
                        string compuesto = $"({r1.Item1},{r2.Item2})";
                        if (!composicion.Contains(compuesto))
                        {
                            composicion.Add(compuesto);
                        }
                    }
                }
            }

            // Mostrar el resultado en label4
            label4.Text = string.Join(" ", composicion);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

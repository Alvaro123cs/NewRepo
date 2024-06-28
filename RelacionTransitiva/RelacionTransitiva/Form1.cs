namespace RelacionTransitiva
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Leer la relación R desde textBox2
            string relacionR = textBox2.Text;
            string[] paresR = relacionR.Split(' ');

            // Convertir la relación a una lista de tuplas
            List<Tuple<string, string>> listaR = new List<Tuple<string, string>>();
            foreach (string par in paresR)
            {
                string[] elementosPar = par.Trim('(', ')').Split(',');
                if (elementosPar.Length == 2)
                {
                    listaR.Add(Tuple.Create(elementosPar[0], elementosPar[1]));
                }
            }

            // Verificar si la relación es transitiva
            bool esTransitiva = true;
            foreach (var r1 in listaR)
            {
                foreach (var r2 in listaR)
                {
                    if (r1.Item2 == r2.Item1)
                    {
                        var parTransitivo = Tuple.Create(r1.Item1, r2.Item2);
                        if (!listaR.Contains(parTransitivo))
                        {
                            esTransitiva = false;
                            break;
                        }
                    }
                }
                if (!esTransitiva) break;
            }

            // Mostrar el resultado en label3
            label3.Text = esTransitiva ? "La relación es transitiva." : "La relación no es transitiva.";
        
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

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

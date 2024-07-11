namespace Combinatoria
{
    public partial class Combi : Form
    {
        private string letras = "abcde";
        private List<string> combinaciones = new List<string>();

        public Combi()
        {
            InitializeComponent();
        }

        private void GenerarCombinaciones(int longitud, string combinacionActual)
        {
            if (longitud == 0)
            {
                combinaciones.Add(combinacionActual);
                return;
            }

            for (int i = 0; i < letras.Length; i++)
            {
                string nuevaCombinacion = combinacionActual + letras[i];
                GenerarCombinaciones(longitud - 1, nuevaCombinacion);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); // Limpiamos la lista de combinaciones anteriores
            combinaciones.Clear(); // Limpiamos la lista de combinaciones generadas anteriormente

            // Obtener la longitud deseada desde el textBox
            if (!int.TryParse(textBox1.Text, out int longitud) || longitud <= 0 || longitud >= 6)
            {
                MessageBox.Show("Por favor, ingrese un número válido (mayor que 0 y menor que 6) para la longitud de las combinaciones.");
                return;
            }

            // Generar las combinaciones
            GenerarCombinaciones(longitud, "");

            // Mostrar las combinaciones en el listBox
            foreach (var combinacion in combinaciones)
            {
                listBox1.Items.Add(combinacion);
            }


            // Generar las combinaciones
            GenerarCombinaciones(longitud, "");

            // Mostrar las combinaciones en el listBox
            foreach (var combinacion in combinaciones)
            {
                listBox1.Items.Add(combinacion);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Combi_Load(object sender, EventArgs e)
        {

        }
    }
}

namespace decimaltobinary
{
    public partial class DecimaltoBinario : Form
    {
        public DecimaltoBinario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int numeroDecimal = int.Parse(label1.Text);

                string numeroBinario = Convert.ToString(numeroDecimal, 2);

                label2.Text = numeroBinario;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DecimaltoBinario_Load(object sender, EventArgs e)
        {

        }
    }
}

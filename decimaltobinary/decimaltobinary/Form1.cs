namespace decimaltobinary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int numeroDecimal = int.Parse(txtDecimal.Text);

                string numeroBinario = Convert.ToString(numeroDecimal, 2);

                txtBinario.Text = numeroBinario;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

namespace decimaltobinary
{
    public partial class DecimaltoBinario : Form
    {
        public DecimaltoBinario()
        {
            InitializeComponent();
        }

        private string DecimalToBinary(int decimalNumber)
        {
            if (decimalNumber == 0)
                return "0";

            string binary = string.Empty;
            while (decimalNumber > 0)
            {
                binary = (decimalNumber % 2) + binary;
                decimalNumber /= 2;
            }
            return binary;
        }

        private void button1_Click(object sender, EventArgs e) // Binario a Real
        {
            try
            {
                int decimalNumber = int.Parse(textBox1.Text);
                string binaryNumber = DecimalToBinary(decimalNumber);
                textBox2.Text = binaryNumber;
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

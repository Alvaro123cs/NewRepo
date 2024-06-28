namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int BinaryToDecimal(string binary)
        {
            int decimalNumber = 0;

            
            for (int i = binary.Length - 1, j = 0; i >= 0; i--, j++)
            {
                
                int bit = binary[i] - '0';

                
                decimalNumber += bit * (int)Math.Pow(2, j);
            }
            return decimalNumber;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string binaryNumber = textBox1.Text;

            
            int decimalNumber = BinaryToDecimal(binaryNumber);

           
            textBox2.Text = decimalNumber.ToString();
        }
    }
}

namespace Menu
{
    public partial class Bienvenidaa : Form
    {
        public Bienvenidaa()
        {
            InitializeComponent();
        }

        private void iconocerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void iconoMaxMin_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal) this.WindowState = FormWindowState.Maximized;
            else this.WindowState = FormWindowState.Normal;
        }
    

        private void iconoMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

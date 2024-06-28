namespace _2doParcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cosenoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            coseno nuevoFormulario = new coseno();

            // Mostrar el nuevo formulario
            nuevoFormulario.Show();
        }

        private void secanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            secante nuevoFormulario = new secante();

            // Mostrar el nuevo formulario
            nuevoFormulario.Show();
        }

        private void logaritmoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logartimo nuevoFormulario = new logartimo();

            // Mostrar el nuevo formulario
            nuevoFormulario.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}

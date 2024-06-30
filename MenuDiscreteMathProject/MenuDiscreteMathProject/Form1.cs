using System;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;





namespace MenuDiscreteMathProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 50;
            }
            else
            {
                MenuVertical.Width = 250;
            }
        }

        private void ContenedorForms_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BarraTitulo_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void AbrirFormInPanel(object FormHijo)
        {
            if (FormHijo == null)
            {
                // Manejo de caso donde FormHijo es null, si es necesario
                return;
            }

            if (this.ContenedorForms.Controls.Count > 0)
                this.ContenedorForms.Controls.RemoveAt(0);

            if (FormHijo is Form fh)
            {
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.ContenedorForms.Controls.Add(fh);
                this.ContenedorForms.Tag = fh;
                fh.Show();
            }
            else
            {
                // Manejo de caso donde FormHijo no es un Form
            }
        }
        private void btnBi_Click(object sender, EventArgs e)
        {

            AbrirFormInPanel(new Form3());
        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Form2());
        }
    }
}

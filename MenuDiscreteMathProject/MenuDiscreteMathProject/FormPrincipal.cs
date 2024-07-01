using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D; // Asegúrate de incluir esta línea esta libreria sirve para ajustar el borde suave

namespace MenuDiscreteMathProject
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.White; // Cambia el color del fondo del padding
            this.Padding = new Padding(5); // Ajusta el padding los bordes del formulario
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Form1_Load(object sender, EventArgs e) { }

        private void pictureBox1_Click(object sender, EventArgs e) { }

        private void iconocerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconoMaxMin_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                this.Region = null; // Eliminar la región al maximizar
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                // Restaurar la región al volver a la ventana normal
                SetWindowRegion();
            }
        }

        private void iconoMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox2_Click(object sender, EventArgs e) { }

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

        private void ContenedorForms_Paint(object sender, PaintEventArgs e) { }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e) { }

        private void BarraTitulo_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox3_Click(object sender, EventArgs e) { }

        private void pictureBox5_Click(object sender, EventArgs e) { }

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario = ContenedorForms.Controls.OfType<MiForm>().FirstOrDefault() ?? new MiForm();
            if (!ContenedorForms.Controls.Contains(formulario))
            {
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                ContenedorForms.Controls.Add(formulario);
                ContenedorForms.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            formulario.BringToFront();
        }

        private void btnBi_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormBienvenida>();
        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormIntro>();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (this.WindowState != FormWindowState.Maximized) // Evitar redibujar la región si la ventana está maximizada
            {
                SetWindowRegion();
            }
        }

        private void SetWindowRegion()
        {
            Graphics g = this.CreateGraphics();
            g.SmoothingMode = SmoothingMode.AntiAlias;

            using (GraphicsPath path = new GraphicsPath())
            {
                int borderRadius = 20; // Radio del borde suave
                path.AddArc(new Rectangle(0, 0, borderRadius, borderRadius), 180, 90);
                path.AddArc(new Rectangle(this.Width - borderRadius - 1, 0, borderRadius, borderRadius), -90, 90);
                path.AddArc(new Rectangle(this.Width - borderRadius - 1, this.Height - borderRadius - 1, borderRadius, borderRadius), 0, 90);
                path.AddArc(new Rectangle(0, this.Height - borderRadius - 1, borderRadius, borderRadius), 90, 90);
                path.CloseFigure();

                this.Region = new Region(path);

                using (Pen pen = new Pen(Color.Black, 2)) // Cambia el color y el ancho del borde según tus necesidades
                {
                    g.DrawPath(pen, path);
                }
            }
        }

        private void btnPag_Click(object sender, EventArgs e)
        {
            AbrirFormulario<PagInicio>();
        }
    }
}

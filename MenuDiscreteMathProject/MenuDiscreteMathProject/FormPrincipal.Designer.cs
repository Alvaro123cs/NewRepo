namespace MenuDiscreteMathProject
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            iconoMinimizar = new PictureBox();
            iconoMaxMin = new PictureBox();
            iconocerrar = new PictureBox();
            MenuVertical = new Panel();
            pictureBox5 = new PictureBox();
            btnPag = new Button();
            pictureBox4 = new PictureBox();
            btnInt = new Button();
            pictureBox3 = new PictureBox();
            btnBi = new Button();
            pictureBox2 = new PictureBox();
            BarraTitulo = new Panel();
            btnMenu = new PictureBox();
            ContenedorForms = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconoMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconoMaxMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconocerrar).BeginInit();
            MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMenu).BeginInit();
            ContenedorForms.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(241, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(278, 10);
            label1.Name = "label1";
            label1.Size = new Size(261, 21);
            label1.TabIndex = 1;
            label1.Text = "Discrete Math Final Project";
            label1.Click += label1_Click;
            // 
            // iconoMinimizar
            // 
            iconoMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconoMinimizar.Image = (Image)resources.GetObject("iconoMinimizar.Image");
            iconoMinimizar.Location = new Point(725, 10);
            iconoMinimizar.Name = "iconoMinimizar";
            iconoMinimizar.Size = new Size(39, 27);
            iconoMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            iconoMinimizar.TabIndex = 5;
            iconoMinimizar.TabStop = false;
            iconoMinimizar.Click += iconoMinimizar_Click;
            // 
            // iconoMaxMin
            // 
            iconoMaxMin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconoMaxMin.Image = (Image)resources.GetObject("iconoMaxMin.Image");
            iconoMaxMin.Location = new Point(766, 10);
            iconoMaxMin.Name = "iconoMaxMin";
            iconoMaxMin.Size = new Size(39, 27);
            iconoMaxMin.SizeMode = PictureBoxSizeMode.Zoom;
            iconoMaxMin.TabIndex = 4;
            iconoMaxMin.TabStop = false;
            iconoMaxMin.Click += iconoMaxMin_Click;
            // 
            // iconocerrar
            // 
            iconocerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconocerrar.Image = (Image)resources.GetObject("iconocerrar.Image");
            iconocerrar.Location = new Point(807, 10);
            iconocerrar.Name = "iconocerrar";
            iconocerrar.Size = new Size(39, 27);
            iconocerrar.SizeMode = PictureBoxSizeMode.Zoom;
            iconocerrar.TabIndex = 3;
            iconocerrar.TabStop = false;
            iconocerrar.Click += iconocerrar_Click;
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = Color.LightBlue;
            MenuVertical.Controls.Add(pictureBox5);
            MenuVertical.Controls.Add(btnPag);
            MenuVertical.Controls.Add(pictureBox4);
            MenuVertical.Controls.Add(btnInt);
            MenuVertical.Controls.Add(pictureBox3);
            MenuVertical.Controls.Add(btnBi);
            MenuVertical.Controls.Add(pictureBox1);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.Location = new Point(0, 0);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(250, 609);
            MenuVertical.TabIndex = 7;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(12, 227);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(35, 35);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 6;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // btnPag
            // 
            btnPag.FlatAppearance.BorderSize = 0;
            btnPag.FlatStyle = FlatStyle.Flat;
            btnPag.Font = new Font("Bookman Old Style", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPag.ForeColor = SystemColors.ActiveCaptionText;
            btnPag.Location = new Point(1, 225);
            btnPag.Name = "btnPag";
            btnPag.Size = new Size(250, 40);
            btnPag.TabIndex = 5;
            btnPag.Text = "Página de Inicio";
            btnPag.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(11, 178);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(35, 35);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // btnInt
            // 
            btnInt.FlatAppearance.BorderSize = 0;
            btnInt.FlatStyle = FlatStyle.Flat;
            btnInt.Font = new Font("Bookman Old Style", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInt.ForeColor = SystemColors.ActiveCaptionText;
            btnInt.Location = new Point(-2, 177);
            btnInt.Name = "btnInt";
            btnInt.Size = new Size(250, 40);
            btnInt.TabIndex = 3;
            btnInt.Text = "Introduccion";
            btnInt.UseVisualStyleBackColor = true;
            btnInt.Click += btnInt_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(10, 127);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(35, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // btnBi
            // 
            btnBi.FlatAppearance.BorderSize = 0;
            btnBi.FlatStyle = FlatStyle.Flat;
            btnBi.Font = new Font("Bookman Old Style", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBi.ForeColor = SystemColors.ActiveCaptionText;
            btnBi.Location = new Point(1, 127);
            btnBi.Name = "btnBi";
            btnBi.Size = new Size(250, 40);
            btnBi.TabIndex = 1;
            btnBi.Text = "Bienvenida";
            btnBi.UseVisualStyleBackColor = true;
            btnBi.Click += btnBi_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(852, 481);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.SteelBlue;
            BarraTitulo.Controls.Add(label1);
            BarraTitulo.Controls.Add(iconoMaxMin);
            BarraTitulo.Controls.Add(btnMenu);
            BarraTitulo.Controls.Add(iconoMinimizar);
            BarraTitulo.Controls.Add(iconocerrar);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(250, 0);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(852, 50);
            BarraTitulo.TabIndex = 8;
            BarraTitulo.Paint += BarraTitulo_Paint;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown_1;
            // 
            // btnMenu
            // 
            btnMenu.Image = (Image)resources.GetObject("btnMenu.Image");
            btnMenu.Location = new Point(6, 6);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(39, 35);
            btnMenu.SizeMode = PictureBoxSizeMode.Zoom;
            btnMenu.TabIndex = 2;
            btnMenu.TabStop = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // ContenedorForms
            // 
            ContenedorForms.Controls.Add(label2);
            ContenedorForms.Controls.Add(pictureBox2);
            ContenedorForms.Dock = DockStyle.Fill;
            ContenedorForms.Location = new Point(250, 50);
            ContenedorForms.Name = "ContenedorForms";
            ContenedorForms.Size = new Size(852, 559);
            ContenedorForms.TabIndex = 9;
            ContenedorForms.Paint += ContenedorForms_Paint;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(561, 508);
            label2.Name = "label2";
            label2.Size = new Size(279, 21);
            label2.TabIndex = 2;
            label2.Text = "3er Semestre Periodo 1-2024";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 609);
            Controls.Add(ContenedorForms);
            Controls.Add(BarraTitulo);
            Controls.Add(MenuVertical);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconoMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconoMaxMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconocerrar).EndInit();
            MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            BarraTitulo.ResumeLayout(false);
            BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnMenu).EndInit();
            ContenedorForms.ResumeLayout(false);
            ContenedorForms.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox iconoMinimizar;
        private PictureBox iconoMaxMin;
        private PictureBox iconocerrar;
        private Panel MenuVertical;
        private PictureBox pictureBox2;
        private Panel BarraTitulo;
        private PictureBox btnMenu;
        private Panel ContenedorForms;
        private Button btnBi;
        private PictureBox pictureBox4;
        private Button btnInt;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private Button btnPag;
        private Label label2;
    }
}

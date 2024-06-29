namespace MenuDiscreteMathProject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            iconoMinimizar = new PictureBox();
            iconoMaxMin = new PictureBox();
            iconocerrar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconoMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconoMaxMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconocerrar).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(41, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(336, 41);
            label1.Name = "label1";
            label1.Size = new Size(223, 46);
            label1.TabIndex = 1;
            label1.Text = "Bienvenidos";
            label1.Click += label1_Click;
            // 
            // iconoMinimizar
            // 
            iconoMinimizar.Image = (Image)resources.GetObject("iconoMinimizar.Image");
            iconoMinimizar.Location = new Point(729, 12);
            iconoMinimizar.Name = "iconoMinimizar";
            iconoMinimizar.Size = new Size(39, 29);
            iconoMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            iconoMinimizar.TabIndex = 5;
            iconoMinimizar.TabStop = false;
            iconoMinimizar.Click += iconoMinimizar_Click;
            // 
            // iconoMaxMin
            // 
            iconoMaxMin.Image = (Image)resources.GetObject("iconoMaxMin.Image");
            iconoMaxMin.Location = new Point(774, 12);
            iconoMaxMin.Name = "iconoMaxMin";
            iconoMaxMin.Size = new Size(39, 29);
            iconoMaxMin.SizeMode = PictureBoxSizeMode.Zoom;
            iconoMaxMin.TabIndex = 4;
            iconoMaxMin.TabStop = false;
            iconoMaxMin.Click += iconoMaxMin_Click;
            // 
            // iconocerrar
            // 
            iconocerrar.Image = (Image)resources.GetObject("iconocerrar.Image");
            iconocerrar.Location = new Point(819, 12);
            iconocerrar.Name = "iconocerrar";
            iconocerrar.Size = new Size(39, 29);
            iconocerrar.SizeMode = PictureBoxSizeMode.Zoom;
            iconocerrar.TabIndex = 3;
            iconocerrar.TabStop = false;
            iconocerrar.Click += iconocerrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 526);
            Controls.Add(iconoMinimizar);
            Controls.Add(iconoMaxMin);
            Controls.Add(iconocerrar);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconoMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconoMaxMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconocerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox iconoMinimizar;
        private PictureBox iconoMaxMin;
        private PictureBox iconocerrar;
    }
}

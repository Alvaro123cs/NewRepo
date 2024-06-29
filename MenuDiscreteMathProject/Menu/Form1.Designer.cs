namespace Menu
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
            iconocerrar = new PictureBox();
            iconoMaxMin = new PictureBox();
            iconoMinimizar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)iconocerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconoMaxMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconoMinimizar).BeginInit();
            SuspendLayout();
            // 
            // iconocerrar
            // 
            iconocerrar.Image = (Image)resources.GetObject("iconocerrar.Image");
            iconocerrar.Location = new Point(753, 11);
            iconocerrar.Name = "iconocerrar";
            iconocerrar.Size = new Size(39, 29);
            iconocerrar.SizeMode = PictureBoxSizeMode.Zoom;
            iconocerrar.TabIndex = 0;
            iconocerrar.TabStop = false;
            iconocerrar.Click += iconocerrar_Click;
            // 
            // iconoMaxMin
            // 
            iconoMaxMin.Image = (Image)resources.GetObject("iconoMaxMin.Image");
            iconoMaxMin.Location = new Point(708, 11);
            iconoMaxMin.Name = "iconoMaxMin";
            iconoMaxMin.Size = new Size(39, 29);
            iconoMaxMin.SizeMode = PictureBoxSizeMode.Zoom;
            iconoMaxMin.TabIndex = 1;
            iconoMaxMin.TabStop = false;
            iconoMaxMin.Click += iconoMaxMin_Click;
            // 
            // iconoMinimizar
            // 
            iconoMinimizar.Image = (Image)resources.GetObject("iconoMinimizar.Image");
            iconoMinimizar.Location = new Point(663, 11);
            iconoMinimizar.Name = "iconoMinimizar";
            iconoMinimizar.Size = new Size(39, 29);
            iconoMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            iconoMinimizar.TabIndex = 2;
            iconoMinimizar.TabStop = false;
            iconoMinimizar.Click += iconoMinimizar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(iconoMinimizar);
            Controls.Add(iconoMaxMin);
            Controls.Add(iconocerrar);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)iconocerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconoMaxMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconoMinimizar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox iconocerrar;
        private PictureBox iconoMaxMin;
        private PictureBox iconoMinimizar;
    }
}

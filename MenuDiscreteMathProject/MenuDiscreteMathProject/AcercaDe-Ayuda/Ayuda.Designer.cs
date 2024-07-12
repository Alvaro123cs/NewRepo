namespace MenuDiscreteMathProject.AcercaDe_Ayuda
{
    partial class Ayuda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ayuda));
            label6 = new Label();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(769, 9);
            label6.Name = "label6";
            label6.Size = new Size(19, 20);
            label6.TabIndex = 24;
            label6.Text = "X";
            label6.Click += label6_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(190, 93);
            label1.Name = "label1";
            label1.Size = new Size(429, 62);
            label1.TabIndex = 25;
            label1.Text = "¿Necesitas Ayuda?";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(190, 189);
            label2.Name = "label2";
            label2.Size = new Size(401, 65);
            label2.TabIndex = 26;
            label2.Text = "Si tuviste algun inconveniente durante la sesion \r\npuedes comunicarte presionando las siguinetes opciones\r\n\r\n";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.UseCompatibleTextRendering = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(444, 274);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(108, 89);
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top;
            pictureBox2.BackColor = SystemColors.Control;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(225, 274);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(87, 89);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 28;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top;
            pictureBox3.BackColor = SystemColors.Control;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(336, 274);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(87, 89);
            pictureBox3.TabIndex = 29;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // Ayuda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label6);
            Name = "Ayuda";
            Text = "Ayuda";
            Load += Ayuda_Load;
            Resize += Ayuda_Resize;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Ayuda_Load(object sender, EventArgs e)
        {
            AdjustLayout();
        }

        private void Ayuda_Resize(object sender, EventArgs e)
        {
            AdjustLayout();
        }

        private void AdjustLayout()
        {
            label6.Location = new Point(ClientSize.Width - 30, 9);
            label1.Location = new Point((ClientSize.Width - 408) / 2, 100);
            label2.Location = new Point((ClientSize.Width - 401) / 2, 188);
            pictureBox1.Location = new Point(ClientSize.Width / 2 - 150, 285);
            pictureBox2.Location = new Point(ClientSize.Width / 2 - 50, 285);
            pictureBox3.Location = new Point(ClientSize.Width / 2 + 50, 285);
        }

        #endregion

        private Label label6;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}

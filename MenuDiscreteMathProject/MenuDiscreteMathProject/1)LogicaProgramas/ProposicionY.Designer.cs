namespace WindowsFormsApplication1
{
    partial class ProposicionY
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProposicionY));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.Location = new Point(39, 93);
            label1.Name = "label1";
            label1.Size = new Size(80, 25);
            label1.TabIndex = 0;
            label1.Text = "valor x1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.Location = new Point(39, 168);
            label2.Name = "label2";
            label2.Size = new Size(80, 25);
            label2.TabIndex = 0;
            label2.Text = "valor x2";
            label2.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(130, 168);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(130, 93);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.MenuHighlight;
            textBox3.Location = new Point(348, 301);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 98);
            textBox3.TabIndex = 1;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.MenuHighlight;
            textBox4.Location = new Point(580, 301);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 98);
            textBox4.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label3.Location = new Point(363, 265);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 0;
            label3.Text = "valor y";
            label3.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label4.Location = new Point(597, 263);
            label4.Name = "label4";
            label4.Size = new Size(71, 25);
            label4.TabIndex = 0;
            label4.Text = "valor o";
            label4.Click += label1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(81, 253);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(175, 146);
            button1.TabIndex = 2;
            button1.Text = "Push";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(332, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 184);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(551, 68);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(153, 184);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // ProposicionY
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(796, 515);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProposicionY";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Proposiciones";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}


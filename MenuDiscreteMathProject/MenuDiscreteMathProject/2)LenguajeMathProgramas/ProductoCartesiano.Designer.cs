namespace WindowsFormsApplication6
{
    partial class ProductoCartesiano
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductoCartesiano));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 29);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(260, 50);
            textBox1.TabIndex = 0;
            textBox1.Text = "(1,x)";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 101);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(260, 50);
            textBox2.TabIndex = 1;
            textBox2.Text = "(x, y, z)";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ControlLightLight;
            textBox3.Location = new Point(12, 180);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(260, 50);
            textBox3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 3;
            label1.Text = "Relaciones 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(12, 85);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 4;
            label2.Text = "Relaciones 2:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(12, 157);
            label3.Name = "label3";
            label3.Size = new Size(155, 20);
            label3.TabIndex = 5;
            label3.Text = "Producto Cartesiano:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(21, 253);
            button1.Name = "button1";
            button1.Size = new Size(240, 34);
            button1.TabIndex = 6;
            button1.Text = "Calcular Producto Cartesiano";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(32, 303);
            label4.Name = "label4";
            label4.Size = new Size(230, 60);
            label4.TabIndex = 8;
            label4.Text = "            IMPORTANTE!!\r\n        Introduzca relaciones \r\ncomo se muestra en el ejemplo:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(321, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(222, 214);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // ProductoCartesiano
            // 
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(622, 392);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ProductoCartesiano";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Producto Cartesiano de Relaciones";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private Label label4;
        private PictureBox pictureBox1;
    }
}


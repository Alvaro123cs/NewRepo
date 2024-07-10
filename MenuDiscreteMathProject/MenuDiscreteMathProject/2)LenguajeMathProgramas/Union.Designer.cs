namespace MenuDiscreteMathProject._2_LenguajeMathProgramas
{
    partial class Union
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 29);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(260, 60);
            textBox1.TabIndex = 0;
            textBox1.Text = "(a, b); (c, d); (e, f)";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 116);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(260, 60);
            textBox2.TabIndex = 1;
            textBox2.Text = "(g, h); (c, d); (i, j)";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 256);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(260, 60);
            textBox3.TabIndex = 2;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 191);
            button1.Name = "button1";
            button1.Size = new Size(260, 32);
            button1.TabIndex = 3;
            button1.Text = "Verificar Unión";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(153, 20);
            label1.TabIndex = 4;
            label1.Text = "Conjunto Relación 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(12, 96);
            label2.Name = "label2";
            label2.Size = new Size(153, 20);
            label2.TabIndex = 5;
            label2.Text = "Conjunto Relación 2:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(12, 236);
            label3.Name = "label3";
            label3.Size = new Size(139, 20);
            label3.TabIndex = 6;
            label3.Text = "Relaciones Unidas:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(32, 335);
            label4.Name = "label4";
            label4.Size = new Size(230, 60);
            label4.TabIndex = 8;
            label4.Text = "            IMPORTANTE!!\r\n        Introduzca relaciones \r\ncomo se muestra en el ejemplo:";
            // 
            // Union
            // 
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(284, 427);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Union";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Unión de Relaciones";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Label label4;
    }
}
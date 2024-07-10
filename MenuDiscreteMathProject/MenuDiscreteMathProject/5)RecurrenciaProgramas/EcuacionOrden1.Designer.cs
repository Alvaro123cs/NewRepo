namespace MenuDiscreteMathProject._5_RecurrenciaProgramas
{
    partial class EcuacionOrden1
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
            textBoxN = new TextBox();
            textBoxCoef = new TextBox();
            textBoxD = new TextBox();
            textBoxA0 = new TextBox();
            textBoxResultado = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // textBoxN
            // 
            textBoxN.Location = new Point(12, 29);
            textBoxN.Name = "textBoxN";
            textBoxN.Size = new Size(100, 27);
            textBoxN.TabIndex = 0;
            textBoxN.Text = "5";
            // 
            // textBoxCoef
            // 
            textBoxCoef.Location = new Point(12, 72);
            textBoxCoef.Name = "textBoxCoef";
            textBoxCoef.Size = new Size(100, 27);
            textBoxCoef.TabIndex = 1;
            textBoxCoef.Text = "3";
            // 
            // textBoxD
            // 
            textBoxD.Location = new Point(12, 115);
            textBoxD.Name = "textBoxD";
            textBoxD.Size = new Size(100, 27);
            textBoxD.TabIndex = 2;
            textBoxD.Text = "2";
            // 
            // textBoxA0
            // 
            textBoxA0.Location = new Point(12, 158);
            textBoxA0.Name = "textBoxA0";
            textBoxA0.Size = new Size(100, 27);
            textBoxA0.TabIndex = 3;
            textBoxA0.Text = "1";
            // 
            // textBoxResultado
            // 
            textBoxResultado.Location = new Point(12, 271);
            textBoxResultado.Multiline = true;
            textBoxResultado.Name = "textBoxResultado";
            textBoxResultado.Size = new Size(776, 167);
            textBoxResultado.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 186);
            button1.Name = "button1";
            button1.Size = new Size(100, 36);
            button1.TabIndex = 5;
            button1.Text = "Resolver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 6;
            label1.Text = "Número de n:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(12, 52);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 7;
            label2.Text = "Coef (c):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 95);
            label3.Name = "label3";
            label3.Size = new Size(21, 20);
            label3.TabIndex = 8;
            label3.Text = "d:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(12, 138);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 9;
            label4.Text = "a0: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(12, 248);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 10;
            label5.Text = "Resultado: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(178, 39);
            label7.Name = "label7";
            label7.Size = new Size(230, 60);
            label7.TabIndex = 15;
            label7.Text = "            IMPORTANTE!!\r\n        Introduzca los datos \r\ncomo se muestra en el ejemplo:";
            // 
            // EcuacionOrden1
            // 
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBoxResultado);
            Controls.Add(textBoxA0);
            Controls.Add(textBoxD);
            Controls.Add(textBoxCoef);
            Controls.Add(textBoxN);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "EcuacionOrden1";
            Text = "Recurrencia de Orden 1";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.TextBox textBoxCoef;
        private System.Windows.Forms.TextBox textBoxD;
        private System.Windows.Forms.TextBox textBoxA0;
        private System.Windows.Forms.TextBox textBoxResultado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Label label7;
    }
}
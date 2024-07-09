namespace MenuDiscreteMathProject._5_RecurrenciaProgramas
{
    partial class EcuacionOrden2
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
            textBoxCoef1 = new TextBox();
            textBoxCoef2 = new TextBox();
            textBoxD = new TextBox();
            textBoxA0 = new TextBox();
            textBoxA1 = new TextBox();
            textBoxResultado = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
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
            // textBoxCoef1
            // 
            textBoxCoef1.Location = new Point(12, 72);
            textBoxCoef1.Name = "textBoxCoef1";
            textBoxCoef1.Size = new Size(100, 27);
            textBoxCoef1.TabIndex = 1;
            textBoxCoef1.Text = "2";
            // 
            // textBoxCoef2
            // 
            textBoxCoef2.Location = new Point(12, 115);
            textBoxCoef2.Name = "textBoxCoef2";
            textBoxCoef2.Size = new Size(100, 27);
            textBoxCoef2.TabIndex = 2;
            textBoxCoef2.Text = "-1";
            // 
            // textBoxD
            // 
            textBoxD.Location = new Point(12, 158);
            textBoxD.Name = "textBoxD";
            textBoxD.Size = new Size(100, 27);
            textBoxD.TabIndex = 3;
            textBoxD.Text = "3";
            // 
            // textBoxA0
            // 
            textBoxA0.Location = new Point(12, 201);
            textBoxA0.Name = "textBoxA0";
            textBoxA0.Size = new Size(100, 27);
            textBoxA0.TabIndex = 4;
            textBoxA0.Text = "0";
            // 
            // textBoxA1
            // 
            textBoxA1.Location = new Point(12, 244);
            textBoxA1.Name = "textBoxA1";
            textBoxA1.Size = new Size(100, 27);
            textBoxA1.TabIndex = 5;
            textBoxA1.Text = "1";
            // 
            // textBoxResultado
            // 
            textBoxResultado.Location = new Point(12, 316);
            textBoxResultado.Multiline = true;
            textBoxResultado.Name = "textBoxResultado";
            textBoxResultado.Size = new Size(776, 122);
            textBoxResultado.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(12, 272);
            button1.Name = "button1";
            button1.Size = new Size(100, 36);
            button1.TabIndex = 7;
            button1.Text = "Resolver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 8;
            label1.Text = "Número de n:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 52);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 9;
            label2.Text = "Coef (c1):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 95);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 10;
            label3.Text = "Coef (c2):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 138);
            label4.Name = "label4";
            label4.Size = new Size(21, 20);
            label4.TabIndex = 11;
            label4.Text = "d:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 181);
            label5.Name = "label5";
            label5.Size = new Size(32, 20);
            label5.TabIndex = 12;
            label5.Text = "a0: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 224);
            label6.Name = "label6";
            label6.Size = new Size(32, 20);
            label6.TabIndex = 13;
            label6.Text = "a1: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(138, 12);
            label7.Name = "label7";
            label7.Size = new Size(220, 60);
            label7.TabIndex = 14;
            label7.Text = "            IMPORTANTE!!\r\n        Introduzca los datos \r\ncomo se muestra en el ejemplo:";
            // 
            // EcuacionOrden2
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBoxResultado);
            Controls.Add(textBoxA1);
            Controls.Add(textBoxA0);
            Controls.Add(textBoxD);
            Controls.Add(textBoxCoef2);
            Controls.Add(textBoxCoef1);
            Controls.Add(textBoxN);
            Name = "EcuacionOrden2";
            Text = "Recurrencia de Orden 2";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.TextBox textBoxCoef1;
        private System.Windows.Forms.TextBox textBoxCoef2;
        private System.Windows.Forms.TextBox textBoxD;
        private System.Windows.Forms.TextBox textBoxA0;
        private System.Windows.Forms.TextBox textBoxA1;
        private System.Windows.Forms.TextBox textBoxResultado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Label label7;
    }
}

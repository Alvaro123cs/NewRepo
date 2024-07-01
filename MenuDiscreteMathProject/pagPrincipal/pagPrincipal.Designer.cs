
namespace pagPrincipal
{
    partial class pagPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pagPrincipal));
            btnCerrar = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.AutoSize = true;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.Location = new Point(821, 9);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(19, 20);
            btnCerrar.TabIndex = 8;
            btnCerrar.Text = "X";
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 56);
            label1.Name = "label1";
            label1.Size = new Size(782, 42);
            label1.TabIndex = 9;
            label1.Text = "\"De los Números a los Algoritmos: Matemáticas Discreta en Computación con C#\"";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(6, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(65, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.Font = new Font("Bookman Old Style", 10.8F);
            label2.Location = new Point(47, 212);
            label2.Name = "label2";
            label2.Size = new Size(216, 29);
            label2.TabIndex = 11;
            label2.Text = "Lógica Proposicional\r\n\r\n";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += this.label2_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.Font = new Font("Bookman Old Style", 10.8F);
            label3.Location = new Point(38, 386);
            label3.Name = "label3";
            label3.Size = new Size(216, 29);
            label3.TabIndex = 12;
            label3.Text = "Conversiones";
            label3.TextAlign = ContentAlignment.TopCenter;
            label3.Click += this.label3_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.Font = new Font("Bookman Old Style", 10.8F);
            label4.Location = new Point(323, 212);
            label4.Name = "label4";
            label4.Size = new Size(216, 47);
            label4.TabIndex = 13;
            label4.Text = "Relaciones de Conjuntos";
            label4.TextAlign = ContentAlignment.TopCenter;
            label4.Click += this.label4_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.Font = new Font("Bookman Old Style", 10.8F);
            label5.Location = new Point(604, 212);
            label5.Name = "label5";
            label5.Size = new Size(216, 29);
            label5.TabIndex = 14;
            label5.Text = "Métodos de Conteo";
            label5.TextAlign = ContentAlignment.TopCenter;
            label5.Click += this.label5_Click;
            // 
            // pagPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 559);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(btnCerrar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "pagPrincipal";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

       

        #endregion

        private Label btnCerrar;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}

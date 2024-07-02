namespace MenuDiscreteMathProject.AcercaDe_Ayuda
{
    partial class AcercaDe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcercaDe));
            labelTitulo = new Label();
            labelDescripcion = new Label();
            labelIntegrantes = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(184, 52);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(458, 62);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Acerca de Nosotros";
            // 
            // labelDescripcion
            // 
            labelDescripcion.AutoSize = true;
            labelDescripcion.Location = new Point(184, 118);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(470, 160);
            labelDescripcion.TabIndex = 1;
            labelDescripcion.Text = resources.GetString("labelDescripcion.Text");
            labelDescripcion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelIntegrantes
            // 
            labelIntegrantes.AutoSize = true;
            labelIntegrantes.Font = new Font("Segoe UI", 14.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelIntegrantes.Location = new Point(330, 278);
            labelIntegrantes.Name = "labelIntegrantes";
            labelIntegrantes.Size = new Size(145, 32);
            labelIntegrantes.TabIndex = 2;
            labelIntegrantes.Text = "Integrantes";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlDark;
            pictureBox1.Location = new Point(165, 333);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 125);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ControlDark;
            pictureBox2.Location = new Point(353, 333);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 125);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ControlDark;
            pictureBox3.Location = new Point(542, 333);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 125);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(164, 473);
            label1.Name = "label1";
            label1.Size = new Size(101, 40);
            label1.TabIndex = 7;
            label1.Text = "Alvaro Cayalo\r\n   Subirana";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(337, 473);
            label2.Name = "label2";
            label2.Size = new Size(116, 40);
            label2.TabIndex = 8;
            label2.Text = "  Fabian Ernesto\r\n  Nuñez Heredia";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(527, 473);
            label3.Name = "label3";
            label3.Size = new Size(115, 40);
            label3.TabIndex = 9;
            label3.Text = " Fabiana Nicole \r\nPatiño Gutierrez";
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
            label6.TabIndex = 25;
            label6.Text = "X";
            label6.Click += label6_Click_1;
            // 
            // AcercaDe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(labelIntegrantes);
            Controls.Add(labelDescripcion);
            Controls.Add(labelTitulo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AcercaDe";
            Text = "Acerca de Nosotros";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private Label labelDescripcion;
        private Label labelIntegrantes;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label6;
    }
}
namespace MatricesDeRelaciones
{
    partial class MatricesDeRelaciones
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            relacion1 = new Label();
            relacion2 = new Label();
            resultado = new Label();
            label4 = new Label();
            matrices1 = new Button();
            sumar = new Button();
            restar = new Button();
            multiplica = new Button();
            label1 = new Label();
            resultadOperaciones = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(334, 60);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(228, 46);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(334, 132);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(228, 46);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // relacion1
            // 
            relacion1.AutoSize = true;
            relacion1.FlatStyle = FlatStyle.System;
            relacion1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            relacion1.Location = new Point(86, 69);
            relacion1.Name = "relacion1";
            relacion1.Size = new Size(241, 28);
            relacion1.TabIndex = 2;
            relacion1.Text = "Ingrese la Relacion (R1):";
            relacion1.Click += relacion1_Click;
            // 
            // relacion2
            // 
            relacion2.AutoSize = true;
            relacion2.FlatStyle = FlatStyle.System;
            relacion2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            relacion2.Location = new Point(76, 135);
            relacion2.Name = "relacion2";
            relacion2.Size = new Size(241, 28);
            relacion2.TabIndex = 3;
            relacion2.Text = "Ingrese la Relacion (R2):";
            relacion2.Click += relacion2_Click;
            // 
            // resultado
            // 
            resultado.AutoSize = true;
            resultado.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultado.Location = new Point(334, 189);
            resultado.Name = "resultado";
            resultado.Size = new Size(224, 23);
            resultado.TabIndex = 4;
            resultado.Text = "Resultado: .........................";
            resultado.Click += resultado_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.GradientActiveCaption;
            label4.FlatStyle = FlatStyle.System;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(334, 9);
            label4.Name = "label4";
            label4.Size = new Size(338, 41);
            label4.TabIndex = 5;
            label4.Text = "Matrices de Relaciones";
            // 
            // matrices1
            // 
            matrices1.BackColor = SystemColors.GradientActiveCaption;
            matrices1.FlatStyle = FlatStyle.Flat;
            matrices1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            matrices1.Location = new Point(623, 102);
            matrices1.Name = "matrices1";
            matrices1.Size = new Size(104, 61);
            matrices1.TabIndex = 6;
            matrices1.Text = "Mostrar Matrices";
            matrices1.UseVisualStyleBackColor = false;
            matrices1.Click += matrices1_Click;
            // 
            // sumar
            // 
            sumar.BackColor = SystemColors.GradientActiveCaption;
            sumar.FlatStyle = FlatStyle.Flat;
            sumar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sumar.Location = new Point(707, 269);
            sumar.Name = "sumar";
            sumar.Size = new Size(103, 46);
            sumar.TabIndex = 7;
            sumar.Text = "Sumar";
            sumar.UseVisualStyleBackColor = false;
            sumar.Click += sumar_Click;
            // 
            // restar
            // 
            restar.BackColor = SystemColors.GradientActiveCaption;
            restar.FlatStyle = FlatStyle.Flat;
            restar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            restar.Location = new Point(707, 341);
            restar.Name = "restar";
            restar.Size = new Size(104, 43);
            restar.TabIndex = 8;
            restar.Text = "Restar";
            restar.UseVisualStyleBackColor = false;
            restar.Click += restar_Click;
            // 
            // multiplica
            // 
            multiplica.BackColor = SystemColors.GradientActiveCaption;
            multiplica.FlatStyle = FlatStyle.Flat;
            multiplica.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            multiplica.Location = new Point(693, 413);
            multiplica.Name = "multiplica";
            multiplica.Size = new Size(118, 61);
            multiplica.TabIndex = 9;
            multiplica.Text = "Multiplicar";
            multiplica.UseVisualStyleBackColor = false;
            multiplica.Click += multiplica_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(654, 229);
            label1.Name = "label1";
            label1.Size = new Size(179, 23);
            label1.TabIndex = 10;
            label1.Text = "Calcular operaciones:";
            // 
            // resultadOperaciones
            // 
            resultadOperaciones.AutoSize = true;
            resultadOperaciones.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultadOperaciones.Location = new Point(294, 479);
            resultadOperaciones.Name = "resultadOperaciones";
            resultadOperaciones.Size = new Size(352, 23);
            resultadOperaciones.TabIndex = 11;
            resultadOperaciones.Text = "Resultado de Operaciones: .........................";
            resultadOperaciones.Click += resultadOperaciones_Click;
            // 
            // MatricesDeRelaciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(925, 707);
            Controls.Add(resultadOperaciones);
            Controls.Add(label1);
            Controls.Add(multiplica);
            Controls.Add(restar);
            Controls.Add(sumar);
            Controls.Add(matrices1);
            Controls.Add(label4);
            Controls.Add(resultado);
            Controls.Add(relacion2);
            Controls.Add(relacion1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MatricesDeRelaciones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MatricesDeRelaciones";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label relacion1;
        private Label relacion2;
        private Label resultado;
        private Label label4;
        private Button matrices1;
        private Button sumar;
        private Button restar;
        private Button multiplica;
        private Label label1;
        private Label resultadOperaciones;
    }
}

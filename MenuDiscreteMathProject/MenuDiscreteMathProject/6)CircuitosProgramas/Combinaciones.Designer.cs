namespace Combinacion
{
    partial class Combinaciones
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
            txtLetras = new TextBox();
            btnGenerar = new Button();
            lstPermutaciones = new ListBox();
            lblTotal = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtLetras
            // 
            txtLetras.Location = new Point(13, 61);
            txtLetras.Margin = new Padding(4, 5, 4, 5);
            txtLetras.Name = "txtLetras";
            txtLetras.Size = new Size(345, 27);
            txtLetras.TabIndex = 0;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(260, 101);
            btnGenerar.Margin = new Padding(4, 5, 4, 5);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(100, 35);
            btnGenerar.TabIndex = 1;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // lstPermutaciones
            // 
            lstPermutaciones.FormattingEnabled = true;
            lstPermutaciones.Location = new Point(13, 145);
            lstPermutaciones.Margin = new Padding(4, 5, 4, 5);
            lstPermutaciones.Name = "lstPermutaciones";
            lstPermutaciones.Size = new Size(345, 204);
            lstPermutaciones.TabIndex = 2;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(13, 362);
            lblTotal.Margin = new Padding(4, 0, 4, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(180, 20);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "Total de permutaciones: 0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(230, 20);
            label1.TabIndex = 4;
            label1.Text = "Ingrese los caracteres a combinar";
            // 
            // Combinaciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 409);
            Controls.Add(label1);
            Controls.Add(lblTotal);
            Controls.Add(lstPermutaciones);
            Controls.Add(btnGenerar);
            Controls.Add(txtLetras);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Combinaciones";
            Text = "Permutaciones de Letras";
            Load += Combinaciones_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtLetras;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.ListBox lstPermutaciones;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label1;
    }
}


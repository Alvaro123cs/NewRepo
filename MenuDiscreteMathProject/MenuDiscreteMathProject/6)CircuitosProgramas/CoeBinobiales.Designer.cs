namespace CoheficienteBinomiales
{
    partial class CoeBinobiales
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox nTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label resultLabel;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoeBinobiales));
            nTextBox = new TextBox();
            calculateButton = new Button();
            resultLabel = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // nTextBox
            // 
            nTextBox.BorderStyle = BorderStyle.FixedSingle;
            nTextBox.Location = new Point(40, 22);
            nTextBox.Margin = new Padding(4, 5, 4, 5);
            nTextBox.Name = "nTextBox";
            nTextBox.Size = new Size(132, 27);
            nTextBox.TabIndex = 0;
            // 
            // calculateButton
            // 
            calculateButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            calculateButton.Location = new Point(39, 59);
            calculateButton.Margin = new Padding(4, 5, 4, 5);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(133, 35);
            calculateButton.TabIndex = 1;
            calculateButton.Text = "Calcular";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultLabel.Location = new Point(39, 112);
            resultLabel.Margin = new Padding(4, 0, 4, 0);
            resultLabel.MaximumSize = new Size(533, 0);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(83, 20);
            resultLabel.TabIndex = 2;
            resultLabel.Text = "Resultado:";
            resultLabel.Click += resultLabel_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(296, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(325, 187);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // CoeBinobiales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(645, 220);
            Controls.Add(pictureBox1);
            Controls.Add(resultLabel);
            Controls.Add(calculateButton);
            Controls.Add(nTextBox);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 5, 4, 5);
            Name = "CoeBinobiales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Coeficiente Binomial";
            Load += CoeBinobiales_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private PictureBox pictureBox1;
    }
}

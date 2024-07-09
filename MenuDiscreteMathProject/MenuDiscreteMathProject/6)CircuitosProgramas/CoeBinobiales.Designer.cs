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
            nTextBox = new TextBox();
            calculateButton = new Button();
            resultLabel = new Label();
            SuspendLayout();
            // 
            // nTextBox
            // 
            nTextBox.Location = new Point(16, 19);
            nTextBox.Margin = new Padding(4, 5, 4, 5);
            nTextBox.Name = "nTextBox";
            nTextBox.Size = new Size(132, 27);
            nTextBox.TabIndex = 0;
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(16, 59);
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
            resultLabel.Location = new Point(16, 99);
            resultLabel.Margin = new Padding(4, 0, 4, 0);
            resultLabel.MaximumSize = new Size(533, 0);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(75, 20);
            resultLabel.TabIndex = 2;
            resultLabel.Text = "Resultado";
            // 
            // CoeBinobiales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(199, 186);
            Controls.Add(resultLabel);
            Controls.Add(calculateButton);
            Controls.Add(nTextBox);
            Margin = new Padding(4, 5, 4, 5);
            Name = "CoeBinobiales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Coeficiente Binomial";
            Load += CoeBinobiales_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

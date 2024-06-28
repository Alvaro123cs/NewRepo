namespace _2doParcial
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            seriesDeTaylorToolStripMenuItem = new ToolStripMenuItem();
            cosenoToolStripMenuItem = new ToolStripMenuItem();
            secanteToolStripMenuItem = new ToolStripMenuItem();
            logaritmoToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { seriesDeTaylorToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(986, 36);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // seriesDeTaylorToolStripMenuItem
            // 
            seriesDeTaylorToolStripMenuItem.BackColor = SystemColors.AppWorkspace;
            seriesDeTaylorToolStripMenuItem.BackgroundImageLayout = ImageLayout.Center;
            seriesDeTaylorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cosenoToolStripMenuItem, secanteToolStripMenuItem, logaritmoToolStripMenuItem });
            seriesDeTaylorToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            seriesDeTaylorToolStripMenuItem.Name = "seriesDeTaylorToolStripMenuItem";
            seriesDeTaylorToolStripMenuItem.Size = new Size(175, 32);
            seriesDeTaylorToolStripMenuItem.Text = "Series de Taylor";
            // 
            // cosenoToolStripMenuItem
            // 
            cosenoToolStripMenuItem.Name = "cosenoToolStripMenuItem";
            cosenoToolStripMenuItem.Size = new Size(195, 32);
            cosenoToolStripMenuItem.Text = "Coseno";
            cosenoToolStripMenuItem.Click += cosenoToolStripMenuItem_Click;
            // 
            // secanteToolStripMenuItem
            // 
            secanteToolStripMenuItem.Name = "secanteToolStripMenuItem";
            secanteToolStripMenuItem.Size = new Size(195, 32);
            secanteToolStripMenuItem.Text = "Secante";
            secanteToolStripMenuItem.Click += secanteToolStripMenuItem_Click;
            // 
            // logaritmoToolStripMenuItem
            // 
            logaritmoToolStripMenuItem.Name = "logaritmoToolStripMenuItem";
            logaritmoToolStripMenuItem.Size = new Size(195, 32);
            logaritmoToolStripMenuItem.Text = "Logaritmo";
            logaritmoToolStripMenuItem.Click += logaritmoToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(303, 113);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(0, 55);
            button1.Name = "button1";
            button1.Size = new Size(990, 810);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(986, 897);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Calcular Series de Taylor";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem seriesDeTaylorToolStripMenuItem;
        private ToolStripMenuItem cosenoToolStripMenuItem;
        private ToolStripMenuItem secanteToolStripMenuItem;
        private ToolStripMenuItem logaritmoToolStripMenuItem;
        private Label label1;
        private Button button1;
    }
}

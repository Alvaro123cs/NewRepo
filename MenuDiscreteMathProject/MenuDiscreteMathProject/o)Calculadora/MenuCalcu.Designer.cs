namespace MenuDiscreteMathProject.o_Calculadora
{
    partial class MenuCalcu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuCalcu));
            label6 = new Label();
            menuStrip1 = new MenuStrip();
            calculadora1ToolStripMenuItem = new ToolStripMenuItem();
            calculadora2ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
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
            label6.TabIndex = 23;
            label6.Text = "X";
            label6.Click += label6_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { calculadora1ToolStripMenuItem, calculadora2ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 31);
            menuStrip1.TabIndex = 24;
            menuStrip1.Text = "menuStrip1";
            // 
            // calculadora1ToolStripMenuItem
            // 
            calculadora1ToolStripMenuItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            calculadora1ToolStripMenuItem.Name = "calculadora1ToolStripMenuItem";
            calculadora1ToolStripMenuItem.Size = new Size(145, 27);
            calculadora1ToolStripMenuItem.Text = "Calculadora (1)";
            // 
            // calculadora2ToolStripMenuItem
            // 
            calculadora2ToolStripMenuItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            calculadora2ToolStripMenuItem.Name = "calculadora2ToolStripMenuItem";
            calculadora2ToolStripMenuItem.Size = new Size(145, 27);
            calculadora2ToolStripMenuItem.Text = "Calculadora (2)";
            // 
            // MenuCalcu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MenuCalcu";
            Text = "MenuCalcu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem calculadora1ToolStripMenuItem;
        private ToolStripMenuItem calculadora2ToolStripMenuItem;
    }
}
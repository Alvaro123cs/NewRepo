namespace MenuDiscreteMathProject.o_ConversionesProgramas
{
    partial class Menuconversiones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menuconversiones));
            label6 = new Label();
            menuStrip1 = new MenuStrip();
            conersionesToolStripMenuItem = new ToolStripMenuItem();
            binarioToDecimalToolStripMenuItem = new ToolStripMenuItem();
            decimalToBinarioToolStripMenuItem = new ToolStripMenuItem();
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { conersionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 31);
            menuStrip1.TabIndex = 24;
            menuStrip1.Text = "menuStrip1";
            // 
            // conersionesToolStripMenuItem
            // 
            conersionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { binarioToDecimalToolStripMenuItem, decimalToBinarioToolStripMenuItem });
            conersionesToolStripMenuItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            conersionesToolStripMenuItem.Name = "conersionesToolStripMenuItem";
            conersionesToolStripMenuItem.Size = new Size(133, 27);
            conersionesToolStripMenuItem.Text = "Conversiones:";
            // 
            // binarioToDecimalToolStripMenuItem
            // 
            binarioToDecimalToolStripMenuItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            binarioToDecimalToolStripMenuItem.Name = "binarioToDecimalToolStripMenuItem";
            binarioToDecimalToolStripMenuItem.Size = new Size(234, 28);
            binarioToDecimalToolStripMenuItem.Text = "BinarioToDecimal";
            binarioToDecimalToolStripMenuItem.Click += binarioToDecimalToolStripMenuItem_Click;
            // 
            // decimalToBinarioToolStripMenuItem
            // 
            decimalToBinarioToolStripMenuItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            decimalToBinarioToolStripMenuItem.Name = "decimalToBinarioToolStripMenuItem";
            decimalToBinarioToolStripMenuItem.Size = new Size(234, 28);
            decimalToBinarioToolStripMenuItem.Text = "DecimalToBinario";
            decimalToBinarioToolStripMenuItem.Click += decimalToBinarioToolStripMenuItem_Click;
            // 
            // Menuconversiones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Menuconversiones";
            Text = "Menuconversiones";
            Load += Menuconversiones_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem conersionesToolStripMenuItem;
        private ToolStripMenuItem binarioToDecimalToolStripMenuItem;
        private ToolStripMenuItem decimalToBinarioToolStripMenuItem;
    }
}
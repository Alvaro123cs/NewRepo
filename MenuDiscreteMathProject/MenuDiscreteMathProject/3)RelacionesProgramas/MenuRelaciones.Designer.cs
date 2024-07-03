namespace MenuDiscreteMathProject._3_RelacionesProgramas
{
    partial class MenuRelaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuRelaciones));
            label6 = new Label();
            menuStrip1 = new MenuStrip();
            relacionesToolStripMenuItem = new ToolStripMenuItem();
            asimétricaToolStripMenuItem = new ToolStripMenuItem();
            rToolStripMenuItem = new ToolStripMenuItem();
            relacionReflexivaToolStripMenuItem = new ToolStripMenuItem();
            relacionSimetricaToolStripMenuItem = new ToolStripMenuItem();
            relacionTransitivaToolStripMenuItem = new ToolStripMenuItem();
            relacionComposiciónToolStripMenuItem = new ToolStripMenuItem();
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { relacionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 31);
            menuStrip1.TabIndex = 24;
            menuStrip1.Text = "menuStrip1";
            // 
            // relacionesToolStripMenuItem
            // 
            relacionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { asimétricaToolStripMenuItem, rToolStripMenuItem, relacionReflexivaToolStripMenuItem, relacionSimetricaToolStripMenuItem, relacionTransitivaToolStripMenuItem, relacionComposiciónToolStripMenuItem });
            relacionesToolStripMenuItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            relacionesToolStripMenuItem.Name = "relacionesToolStripMenuItem";
            relacionesToolStripMenuItem.Size = new Size(112, 27);
            relacionesToolStripMenuItem.Text = "Relaciones:";
            // 
            // asimétricaToolStripMenuItem
            // 
            asimétricaToolStripMenuItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            asimétricaToolStripMenuItem.Name = "asimétricaToolStripMenuItem";
            asimétricaToolStripMenuItem.Size = new Size(269, 28);
            asimétricaToolStripMenuItem.Text = "Relacion Asimétrica";
            // 
            // rToolStripMenuItem
            // 
            rToolStripMenuItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            rToolStripMenuItem.Name = "rToolStripMenuItem";
            rToolStripMenuItem.Size = new Size(269, 28);
            rToolStripMenuItem.Text = "Relacion Inversa";
            // 
            // relacionReflexivaToolStripMenuItem
            // 
            relacionReflexivaToolStripMenuItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            relacionReflexivaToolStripMenuItem.Name = "relacionReflexivaToolStripMenuItem";
            relacionReflexivaToolStripMenuItem.Size = new Size(269, 28);
            relacionReflexivaToolStripMenuItem.Text = "Relacion Reflexiva";
            // 
            // relacionSimetricaToolStripMenuItem
            // 
            relacionSimetricaToolStripMenuItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            relacionSimetricaToolStripMenuItem.Name = "relacionSimetricaToolStripMenuItem";
            relacionSimetricaToolStripMenuItem.Size = new Size(269, 28);
            relacionSimetricaToolStripMenuItem.Text = "Relacion Simetrica";
            // 
            // relacionTransitivaToolStripMenuItem
            // 
            relacionTransitivaToolStripMenuItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            relacionTransitivaToolStripMenuItem.Name = "relacionTransitivaToolStripMenuItem";
            relacionTransitivaToolStripMenuItem.Size = new Size(269, 28);
            relacionTransitivaToolStripMenuItem.Text = "Relacion Transitiva";
            // 
            // relacionComposiciónToolStripMenuItem
            // 
            relacionComposiciónToolStripMenuItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            relacionComposiciónToolStripMenuItem.Name = "relacionComposiciónToolStripMenuItem";
            relacionComposiciónToolStripMenuItem.Size = new Size(269, 28);
            relacionComposiciónToolStripMenuItem.Text = "Relacion Composición";
            // 
            // MenuRelaciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            MainMenuStrip = menuStrip1;
            Name = "MenuRelaciones";
            Text = "MenuRelaciones";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem relacionesToolStripMenuItem;
        private ToolStripMenuItem asimétricaToolStripMenuItem;
        private ToolStripMenuItem rToolStripMenuItem;
        private ToolStripMenuItem relacionReflexivaToolStripMenuItem;
        private ToolStripMenuItem relacionSimetricaToolStripMenuItem;
        private ToolStripMenuItem relacionTransitivaToolStripMenuItem;
        private ToolStripMenuItem relacionComposiciónToolStripMenuItem;
    }
}
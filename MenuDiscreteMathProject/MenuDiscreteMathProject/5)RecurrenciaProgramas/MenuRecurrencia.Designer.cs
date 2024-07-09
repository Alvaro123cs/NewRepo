namespace MenuDiscreteMathProject._5_RecurrenciaProgramas
{
    partial class MenuRecurrencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuRecurrencia));
            label6 = new Label();
            menuStrip1 = new MenuStrip();
            relacionesDeRecurrenciaToolStripMenuItem = new ToolStripMenuItem();
            ecauionesDeOrden1ToolStripMenuItem = new ToolStripMenuItem();
            ecuacionesDeOrden2ToolStripMenuItem = new ToolStripMenuItem();
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { relacionesDeRecurrenciaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 31);
            menuStrip1.TabIndex = 24;
            menuStrip1.Text = "menuStrip1";
            // 
            // relacionesDeRecurrenciaToolStripMenuItem
            // 
            relacionesDeRecurrenciaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ecauionesDeOrden1ToolStripMenuItem, ecuacionesDeOrden2ToolStripMenuItem });
            relacionesDeRecurrenciaToolStripMenuItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            relacionesDeRecurrenciaToolStripMenuItem.Name = "relacionesDeRecurrenciaToolStripMenuItem";
            relacionesDeRecurrenciaToolStripMenuItem.Size = new Size(230, 27);
            relacionesDeRecurrenciaToolStripMenuItem.Text = "Relaciones de Recurrencia";
            // 
            // ecauionesDeOrden1ToolStripMenuItem
            // 
            ecauionesDeOrden1ToolStripMenuItem.Name = "ecauionesDeOrden1ToolStripMenuItem";
            ecauionesDeOrden1ToolStripMenuItem.Size = new Size(274, 28);
            ecauionesDeOrden1ToolStripMenuItem.Text = "Ecauiones de Orden 1";
            ecauionesDeOrden1ToolStripMenuItem.Click += ecauionesDeOrden1ToolStripMenuItem_Click;
            // 
            // ecuacionesDeOrden2ToolStripMenuItem
            // 
            ecuacionesDeOrden2ToolStripMenuItem.Name = "ecuacionesDeOrden2ToolStripMenuItem";
            ecuacionesDeOrden2ToolStripMenuItem.Size = new Size(274, 28);
            ecuacionesDeOrden2ToolStripMenuItem.Text = "Ecuaciones de Orden 2";
            ecuacionesDeOrden2ToolStripMenuItem.Click += ecuacionesDeOrden2ToolStripMenuItem_Click;
            // 
            // MenuRecurrencia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MenuRecurrencia";
            Text = "MenuRecurrencia";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem relacionesDeRecurrenciaToolStripMenuItem;
        private ToolStripMenuItem ecauionesDeOrden1ToolStripMenuItem;
        private ToolStripMenuItem ecuacionesDeOrden2ToolStripMenuItem;
    }
}
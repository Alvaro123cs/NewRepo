namespace ProyectMath
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
            menuStrip1 = new MenuStrip();
            preToolStripMenuItem = new ToolStripMenuItem();
            aNDYORToolStripMenuItem = new ToolStripMenuItem();
            negaciónToolStripMenuItem = new ToolStripMenuItem();
            potenciaToolStripMenuItem = new ToolStripMenuItem();
            lenguajeDeLasMátematicasToolStripMenuItem = new ToolStripMenuItem();
            conjuntosToolStripMenuItem = new ToolStripMenuItem();
            conjuntoUnionToolStripMenuItem = new ToolStripMenuItem();
            conjuntoIntersecciónToolStripMenuItem = new ToolStripMenuItem();
            conjuntoDiferenciaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { preToolStripMenuItem, lenguajeDeLasMátematicasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1164, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // preToolStripMenuItem
            // 
            preToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aNDYORToolStripMenuItem, negaciónToolStripMenuItem, potenciaToolStripMenuItem });
            preToolStripMenuItem.Name = "preToolStripMenuItem";
            preToolStripMenuItem.Size = new Size(193, 24);
            preToolStripMenuItem.Text = " Lógica y Demostraciones";
            // 
            // aNDYORToolStripMenuItem
            // 
            aNDYORToolStripMenuItem.Name = "aNDYORToolStripMenuItem";
            aNDYORToolStripMenuItem.Size = new Size(241, 26);
            aNDYORToolStripMenuItem.Text = "Proposicion AND y OR";
            // 
            // negaciónToolStripMenuItem
            // 
            negaciónToolStripMenuItem.Name = "negaciónToolStripMenuItem";
            negaciónToolStripMenuItem.Size = new Size(241, 26);
            negaciónToolStripMenuItem.Text = "Negación";
            // 
            // potenciaToolStripMenuItem
            // 
            potenciaToolStripMenuItem.Name = "potenciaToolStripMenuItem";
            potenciaToolStripMenuItem.Size = new Size(241, 26);
            potenciaToolStripMenuItem.Text = "Potencia";
            // 
            // lenguajeDeLasMátematicasToolStripMenuItem
            // 
            lenguajeDeLasMátematicasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { conjuntosToolStripMenuItem, conjuntoUnionToolStripMenuItem, conjuntoIntersecciónToolStripMenuItem, conjuntoDiferenciaToolStripMenuItem });
            lenguajeDeLasMátematicasToolStripMenuItem.Name = "lenguajeDeLasMátematicasToolStripMenuItem";
            lenguajeDeLasMátematicasToolStripMenuItem.Size = new Size(215, 24);
            lenguajeDeLasMátematicasToolStripMenuItem.Text = "Lenguaje de las Mátematicas";
            // 
            // conjuntosToolStripMenuItem
            // 
            conjuntosToolStripMenuItem.Name = "conjuntosToolStripMenuItem";
            conjuntosToolStripMenuItem.Size = new Size(235, 26);
            conjuntosToolStripMenuItem.Text = "Conjuntos:";
            conjuntosToolStripMenuItem.Click += conjuntosToolStripMenuItem_Click;
            // 
            // conjuntoUnionToolStripMenuItem
            // 
            conjuntoUnionToolStripMenuItem.Name = "conjuntoUnionToolStripMenuItem";
            conjuntoUnionToolStripMenuItem.Size = new Size(235, 26);
            conjuntoUnionToolStripMenuItem.Text = "Conjunto Union";
            // 
            // conjuntoIntersecciónToolStripMenuItem
            // 
            conjuntoIntersecciónToolStripMenuItem.Name = "conjuntoIntersecciónToolStripMenuItem";
            conjuntoIntersecciónToolStripMenuItem.Size = new Size(235, 26);
            conjuntoIntersecciónToolStripMenuItem.Text = "Conjunto Intersección";
            // 
            // conjuntoDiferenciaToolStripMenuItem
            // 
            conjuntoDiferenciaToolStripMenuItem.Name = "conjuntoDiferenciaToolStripMenuItem";
            conjuntoDiferenciaToolStripMenuItem.Size = new Size(235, 26);
            conjuntoDiferenciaToolStripMenuItem.Text = "Conjunto Diferencia";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 464);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem preToolStripMenuItem;
        private ToolStripMenuItem aNDYORToolStripMenuItem;
        private ToolStripMenuItem negaciónToolStripMenuItem;
        private ToolStripMenuItem potenciaToolStripMenuItem;
        private ToolStripMenuItem lenguajeDeLasMátematicasToolStripMenuItem;
        private ToolStripMenuItem conjuntosToolStripMenuItem;
        private ToolStripMenuItem conjuntoUnionToolStripMenuItem;
        private ToolStripMenuItem conjuntoIntersecciónToolStripMenuItem;
        private ToolStripMenuItem conjuntoDiferenciaToolStripMenuItem;
    }
}

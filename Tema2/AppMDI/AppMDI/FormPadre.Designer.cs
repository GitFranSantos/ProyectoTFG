namespace AppMDI
{
    partial class FormPadre
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
            MenuStrip = new MenuStrip();
            MenuItem_Nuevo = new ToolStripMenuItem();
            MenuItem_Ventana = new ToolStripMenuItem();
            MenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // MenuStrip
            // 
            MenuStrip.ImageScalingSize = new Size(20, 20);
            MenuStrip.Items.AddRange(new ToolStripItem[] { MenuItem_Nuevo, MenuItem_Ventana });
            MenuStrip.Location = new Point(0, 0);
            MenuStrip.MdiWindowListItem = MenuItem_Ventana;
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Size = new Size(800, 28);
            MenuStrip.TabIndex = 1;
            MenuStrip.Text = "menuStrip1";
            // 
            // MenuItem_Nuevo
            // 
            MenuItem_Nuevo.Name = "MenuItem_Nuevo";
            MenuItem_Nuevo.Size = new Size(66, 24);
            MenuItem_Nuevo.Text = "Nuevo";
            MenuItem_Nuevo.Click += MenuItem_Nuevo_Click;
            // 
            // MenuItem_Ventana
            // 
            MenuItem_Ventana.Name = "MenuItem_Ventana";
            MenuItem_Ventana.Size = new Size(76, 24);
            MenuItem_Ventana.Text = "Ventana";
            // 
            // FormPadre
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MenuStrip);
            IsMdiContainer = true;
            MainMenuStrip = MenuStrip;
            Name = "FormPadre";
            Text = "FormularioMDI(Formulario contenedor)";
            WindowState = FormWindowState.Maximized;
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MenuStrip;
        private ToolStripMenuItem MenuItem_Nuevo;
        private ToolStripMenuItem MenuItem_Ventana;
    }
}
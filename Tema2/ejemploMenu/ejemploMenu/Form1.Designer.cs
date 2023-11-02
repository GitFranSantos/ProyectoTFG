namespace ejemploMenu
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            MenuItemArchivo = new ToolStripMenuItem();
            MenuItemArchivo_Configuracion = new ToolStripMenuItem();
            MenuItemConfi_Color = new ToolStripMenuItem();
            MenuItemColor_Fondo = new ToolStripMenuItem();
            MenuItemColor_Fuente = new ToolStripMenuItem();
            MenuItemConfi_Fuente = new ToolStripMenuItem();
            MenuItemSalir = new ToolStripMenuItem();
            MenuItemOperaciones = new ToolStripMenuItem();
            MenuItemSumar = new ToolStripMenuItem();
            MenuItemRestar = new ToolStripMenuItem();
            MenuItemMultiplicacion = new ToolStripMenuItem();
            MenuItemDivision = new ToolStripMenuItem();
            MenuItemAcerca = new ToolStripMenuItem();
            txtA = new TextBox();
            MenuContextualTxtA = new ContextMenuStrip(components);
            MenuContextualTxtA_Resetear = new ToolStripMenuItem();
            MenuContextualTxtA_CalcularAleatorio = new ToolStripMenuItem();
            txtB = new TextBox();
            labelA = new Label();
            MenuContextualTxtB = new ContextMenuStrip(components);
            MenuContextualTxtB_Resetear = new ToolStripMenuItem();
            caulToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            MenuContextualTxtA.SuspendLayout();
            MenuContextualTxtB.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { MenuItemArchivo, MenuItemOperaciones, MenuItemAcerca });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(986, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // MenuItemArchivo
            // 
            MenuItemArchivo.DropDownItems.AddRange(new ToolStripItem[] { MenuItemArchivo_Configuracion, MenuItemSalir });
            MenuItemArchivo.Name = "MenuItemArchivo";
            MenuItemArchivo.Size = new Size(73, 24);
            MenuItemArchivo.Text = "Archivo";
            // 
            // MenuItemArchivo_Configuracion
            // 
            MenuItemArchivo_Configuracion.DropDownItems.AddRange(new ToolStripItem[] { MenuItemConfi_Color, MenuItemConfi_Fuente });
            MenuItemArchivo_Configuracion.Name = "MenuItemArchivo_Configuracion";
            MenuItemArchivo_Configuracion.Size = new Size(185, 26);
            MenuItemArchivo_Configuracion.Text = "Configuracion";
            // 
            // MenuItemConfi_Color
            // 
            MenuItemConfi_Color.DropDownItems.AddRange(new ToolStripItem[] { MenuItemColor_Fondo, MenuItemColor_Fuente });
            MenuItemConfi_Color.Name = "MenuItemConfi_Color";
            MenuItemConfi_Color.Size = new Size(136, 26);
            MenuItemConfi_Color.Text = "Color";
            // 
            // MenuItemColor_Fondo
            // 
            MenuItemColor_Fondo.Name = "MenuItemColor_Fondo";
            MenuItemColor_Fondo.Size = new Size(136, 26);
            MenuItemColor_Fondo.Text = "Fondo";
            MenuItemColor_Fondo.Click += MenuItemColor_Fondo_Click;
            // 
            // MenuItemColor_Fuente
            // 
            MenuItemColor_Fuente.Name = "MenuItemColor_Fuente";
            MenuItemColor_Fuente.Size = new Size(136, 26);
            MenuItemColor_Fuente.Text = "Fuente";
            MenuItemColor_Fuente.Click += MenuItemColor_Fuente_Click;
            // 
            // MenuItemConfi_Fuente
            // 
            MenuItemConfi_Fuente.Name = "MenuItemConfi_Fuente";
            MenuItemConfi_Fuente.Size = new Size(136, 26);
            MenuItemConfi_Fuente.Text = "Fuente";
            MenuItemConfi_Fuente.Click += MenuItemConfi_Fuente_Click;
            // 
            // MenuItemSalir
            // 
            MenuItemSalir.AutoToolTip = true;
            MenuItemSalir.Name = "MenuItemSalir";
            MenuItemSalir.ShortcutKeys = Keys.Control | Keys.S;
            MenuItemSalir.ShowShortcutKeys = false;
            MenuItemSalir.Size = new Size(185, 26);
            MenuItemSalir.Text = "Salir";
            MenuItemSalir.ToolTipText = "Ctrl+s";
            MenuItemSalir.Click += MenuItemSalir_Click;
            // 
            // MenuItemOperaciones
            // 
            MenuItemOperaciones.DropDownItems.AddRange(new ToolStripItem[] { MenuItemSumar, MenuItemRestar, MenuItemMultiplicacion, MenuItemDivision });
            MenuItemOperaciones.Name = "MenuItemOperaciones";
            MenuItemOperaciones.Size = new Size(106, 24);
            MenuItemOperaciones.Text = "Operaciones";
            // 
            // MenuItemSumar
            // 
            MenuItemSumar.AutoToolTip = true;
            MenuItemSumar.Name = "MenuItemSumar";
            MenuItemSumar.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            MenuItemSumar.ShowShortcutKeys = false;
            MenuItemSumar.Size = new Size(186, 26);
            MenuItemSumar.Text = "Sumar";
            MenuItemSumar.ToolTipText = "Ctrl+Shift+s";
            MenuItemSumar.Click += MenuItemSumar_Click;
            // 
            // MenuItemRestar
            // 
            MenuItemRestar.Name = "MenuItemRestar";
            MenuItemRestar.Size = new Size(186, 26);
            MenuItemRestar.Text = "Restar";
            MenuItemRestar.Click += MenuItemRestar_Click;
            // 
            // MenuItemMultiplicacion
            // 
            MenuItemMultiplicacion.Name = "MenuItemMultiplicacion";
            MenuItemMultiplicacion.Size = new Size(186, 26);
            MenuItemMultiplicacion.Text = "Multiplicacion";
            MenuItemMultiplicacion.Click += MenuItemMultiplicacion_Click;
            // 
            // MenuItemDivision
            // 
            MenuItemDivision.Name = "MenuItemDivision";
            MenuItemDivision.Size = new Size(186, 26);
            MenuItemDivision.Text = "Division";
            MenuItemDivision.Click += MenuItemDivision_Click;
            // 
            // MenuItemAcerca
            // 
            MenuItemAcerca.Name = "MenuItemAcerca";
            MenuItemAcerca.Size = new Size(89, 24);
            MenuItemAcerca.Text = "Acerca de";
            MenuItemAcerca.Click += MenuItemAcerca_Click;
            // 
            // txtA
            // 
            txtA.ContextMenuStrip = MenuContextualTxtA;
            txtA.Location = new Point(12, 31);
            txtA.Name = "txtA";
            txtA.Size = new Size(196, 27);
            txtA.TabIndex = 1;
            txtA.TextAlign = HorizontalAlignment.Right;
            // 
            // MenuContextualTxtA
            // 
            MenuContextualTxtA.ImageScalingSize = new Size(20, 20);
            MenuContextualTxtA.Items.AddRange(new ToolStripItem[] { MenuContextualTxtA_Resetear, MenuContextualTxtA_CalcularAleatorio });
            MenuContextualTxtA.Name = "MenuContextualTxtA";
            MenuContextualTxtA.Size = new Size(198, 52);
            // 
            // MenuContextualTxtA_Resetear
            // 
            MenuContextualTxtA_Resetear.Name = "MenuContextualTxtA_Resetear";
            MenuContextualTxtA_Resetear.Size = new Size(197, 24);
            MenuContextualTxtA_Resetear.Text = "Resetear";
            MenuContextualTxtA_Resetear.Click += MenuContextualTxtA_Resetear_Click;
            // 
            // MenuContextualTxtA_CalcularAleatorio
            // 
            MenuContextualTxtA_CalcularAleatorio.Name = "MenuContextualTxtA_CalcularAleatorio";
            MenuContextualTxtA_CalcularAleatorio.Size = new Size(197, 24);
            MenuContextualTxtA_CalcularAleatorio.Text = "Calcular Aleatorio";
            MenuContextualTxtA_CalcularAleatorio.Click += MenuContextualTxtA_CalcularAleatorio_Click;
            // 
            // txtB
            // 
            txtB.Location = new Point(12, 64);
            txtB.Name = "txtB";
            txtB.Size = new Size(196, 27);
            txtB.TabIndex = 2;
            txtB.TextAlign = HorizontalAlignment.Right;
            // 
            // labelA
            // 
            labelA.AutoSize = true;
            labelA.Location = new Point(240, 38);
            labelA.Name = "labelA";
            labelA.Size = new Size(0, 20);
            labelA.TabIndex = 3;
            // 
            // MenuContextualTxtB
            // 
            MenuContextualTxtB.ImageScalingSize = new Size(20, 20);
            MenuContextualTxtB.Items.AddRange(new ToolStripItem[] { MenuContextualTxtB_Resetear, caulToolStripMenuItem });
            MenuContextualTxtB.Name = "MenuContextualTxtB";
            MenuContextualTxtB.Size = new Size(211, 80);
            // 
            // MenuContextualTxtB_Resetear
            // 
            MenuContextualTxtB_Resetear.Name = "MenuContextualTxtB_Resetear";
            MenuContextualTxtB_Resetear.Size = new Size(210, 24);
            MenuContextualTxtB_Resetear.Text = "Resetear";
            MenuContextualTxtB_Resetear.Click += MenuContextualTxtB_Resetear_Click;
            // 
            // caulToolStripMenuItem
            // 
            caulToolStripMenuItem.Name = "caulToolStripMenuItem";
            caulToolStripMenuItem.Size = new Size(210, 24);
            caulToolStripMenuItem.Text = "Calcular Aleatorio";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 516);
            Controls.Add(labelA);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            MenuContextualTxtA.ResumeLayout(false);
            MenuContextualTxtB.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem MenuItemArchivo;
        private ToolStripMenuItem MenuItemSalir;
        private ToolStripMenuItem MenuItemOperaciones;
        private ToolStripMenuItem MenuItemAcerca;
        private ToolStripMenuItem MenuItemSumar;
        private ToolStripMenuItem MenuItemRestar;
        private ToolStripMenuItem MenuItemMultiplicacion;
        private ToolStripMenuItem MenuItemDivision;
        private TextBox txtA;
        private TextBox txtB;
        private Label labelA;
        private ContextMenuStrip MenuContextualTxtA;
        private ToolStripMenuItem MenuContextualTxtA_Resetear;
        private ToolStripMenuItem MenuContextualTxtA_CalcularAleatorio;
        private ToolStripMenuItem MenuItemArchivo_Configuracion;
        private ToolStripMenuItem MenuItemConfi_Color;
        private ToolStripMenuItem MenuItemColor_Fondo;
        private ToolStripMenuItem MenuItemColor_Fuente;
        private ToolStripMenuItem MenuItemConfi_Fuente;
        private ContextMenuStrip MenuContextualTxtB;
        private ToolStripMenuItem MenuContextualTxtB_Resetear;
        private ToolStripMenuItem caulToolStripMenuItem;
    }
}
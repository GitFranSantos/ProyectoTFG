namespace InterfazResponvive
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
            btnBoton1 = new Button();
            btnBoton2 = new Button();
            contenedor = new Panel();
            txtEntrada1 = new TextBox();
            contenedor.SuspendLayout();
            SuspendLayout();
            // 
            // btnBoton1
            // 
            btnBoton1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnBoton1.BackColor = Color.FromArgb(255, 255, 128);
            btnBoton1.Location = new Point(30, 32);
            btnBoton1.Name = "btnBoton1";
            btnBoton1.Size = new Size(138, 139);
            btnBoton1.TabIndex = 0;
            btnBoton1.Text = "button1";
            btnBoton1.UseVisualStyleBackColor = false;
            // 
            // btnBoton2
            // 
            btnBoton2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnBoton2.BackColor = Color.FromArgb(255, 255, 128);
            btnBoton2.Location = new Point(398, 32);
            btnBoton2.Name = "btnBoton2";
            btnBoton2.Size = new Size(139, 139);
            btnBoton2.TabIndex = 1;
            btnBoton2.Text = "button2";
            btnBoton2.UseVisualStyleBackColor = false;
            // 
            // contenedor
            // 
            contenedor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            contenedor.BackColor = Color.FromArgb(255, 192, 192);
            contenedor.Controls.Add(txtEntrada1);
            contenedor.Location = new Point(185, 32);
            contenedor.Name = "contenedor";
            contenedor.Size = new Size(207, 333);
            contenedor.TabIndex = 2;
            // 
            // txtEntrada1
            // 
            txtEntrada1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEntrada1.Location = new Point(17, 24);
            txtEntrada1.Multiline = true;
            txtEntrada1.Name = "txtEntrada1";
            txtEntrada1.Size = new Size(178, 115);
            txtEntrada1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(contenedor);
            Controls.Add(btnBoton2);
            Controls.Add(btnBoton1);
            Name = "Form1";
            Text = "Form1";
            contenedor.ResumeLayout(false);
            contenedor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBoton1;
        private Button btnBoton2;
        private Panel contenedor;
        private TextBox txtEntrada1;
    }
}
namespace Ejemplo1
{
    partial class PaginaPrincipal
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
            miEtiqueta = new Label();
            botonModal = new Button();
            SuspendLayout();
            // 
            // miEtiqueta
            // 
            miEtiqueta.AutoSize = true;
            miEtiqueta.Location = new Point(12, 32);
            miEtiqueta.Name = "miEtiqueta";
            miEtiqueta.Size = new Size(50, 20);
            miEtiqueta.TabIndex = 0;
            miEtiqueta.Text = "label1";
            // 
            // botonModal
            // 
            botonModal.Location = new Point(12, 90);
            botonModal.Name = "botonModal";
            botonModal.Size = new Size(94, 29);
            botonModal.TabIndex = 1;
            botonModal.Text = "button1";
            botonModal.UseVisualStyleBackColor = true;
            botonModal.Click += botonModal_Click;
            // 
            // PaginaPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(botonModal);
            Controls.Add(miEtiqueta);
            Name = "PaginaPrincipal";
            Text = "Mi Primer Formulario";
            MouseEnter += Form1_MouseEnter;
            MouseLeave += Form1_MouseLeave;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label miEtiqueta;
        private Button botonModal;
    }
}
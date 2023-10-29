namespace Ejercicio6ControlesForm
{
    partial class Form3
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
            btnBoton2F3 = new Button();
            cajaTextoTelF3 = new TextBox();
            cajaTextoApe2F3 = new TextBox();
            cajaTextoApe1F3 = new TextBox();
            cajaTextoNombreF3 = new TextBox();
            etiqueta4 = new Label();
            etiqueta3 = new Label();
            etiqueta2 = new Label();
            etiqueta1 = new Label();
            SuspendLayout();
            // 
            // btnBoton2F3
            // 
            btnBoton2F3.Location = new Point(562, 232);
            btnBoton2F3.Name = "btnBoton2F3";
            btnBoton2F3.Size = new Size(94, 29);
            btnBoton2F3.TabIndex = 19;
            btnBoton2F3.Text = "Cerrar";
            btnBoton2F3.UseVisualStyleBackColor = true;
            btnBoton2F3.Click += btnBoton2F3_Click;
            // 
            // cajaTextoTelF3
            // 
            cajaTextoTelF3.Enabled = false;
            cajaTextoTelF3.Location = new Point(286, 272);
            cajaTextoTelF3.Name = "cajaTextoTelF3";
            cajaTextoTelF3.ReadOnly = true;
            cajaTextoTelF3.Size = new Size(125, 27);
            cajaTextoTelF3.TabIndex = 17;
            // 
            // cajaTextoApe2F3
            // 
            cajaTextoApe2F3.Enabled = false;
            cajaTextoApe2F3.Location = new Point(286, 232);
            cajaTextoApe2F3.Name = "cajaTextoApe2F3";
            cajaTextoApe2F3.ReadOnly = true;
            cajaTextoApe2F3.Size = new Size(125, 27);
            cajaTextoApe2F3.TabIndex = 16;
            // 
            // cajaTextoApe1F3
            // 
            cajaTextoApe1F3.Enabled = false;
            cajaTextoApe1F3.Location = new Point(286, 193);
            cajaTextoApe1F3.Name = "cajaTextoApe1F3";
            cajaTextoApe1F3.ReadOnly = true;
            cajaTextoApe1F3.Size = new Size(125, 27);
            cajaTextoApe1F3.TabIndex = 15;
            // 
            // cajaTextoNombreF3
            // 
            cajaTextoNombreF3.Enabled = false;
            cajaTextoNombreF3.Location = new Point(286, 151);
            cajaTextoNombreF3.Name = "cajaTextoNombreF3";
            cajaTextoNombreF3.ReadOnly = true;
            cajaTextoNombreF3.Size = new Size(125, 27);
            cajaTextoNombreF3.TabIndex = 14;
            // 
            // etiqueta4
            // 
            etiqueta4.AutoSize = true;
            etiqueta4.Location = new Point(144, 279);
            etiqueta4.Name = "etiqueta4";
            etiqueta4.Size = new Size(67, 20);
            etiqueta4.TabIndex = 13;
            etiqueta4.Text = "Telefono";
            // 
            // etiqueta3
            // 
            etiqueta3.AutoSize = true;
            etiqueta3.Location = new Point(144, 239);
            etiqueta3.Name = "etiqueta3";
            etiqueta3.Size = new Size(74, 20);
            etiqueta3.TabIndex = 12;
            etiqueta3.Text = "Apellido2";
            // 
            // etiqueta2
            // 
            etiqueta2.AutoSize = true;
            etiqueta2.Location = new Point(144, 200);
            etiqueta2.Name = "etiqueta2";
            etiqueta2.Size = new Size(74, 20);
            etiqueta2.TabIndex = 11;
            etiqueta2.Text = "Apelldio1";
            // 
            // etiqueta1
            // 
            etiqueta1.AutoSize = true;
            etiqueta1.Location = new Point(144, 158);
            etiqueta1.Name = "etiqueta1";
            etiqueta1.Size = new Size(64, 20);
            etiqueta1.TabIndex = 10;
            etiqueta1.Text = "Nombre";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBoton2F3);
            Controls.Add(cajaTextoTelF3);
            Controls.Add(cajaTextoApe2F3);
            Controls.Add(cajaTextoApe1F3);
            Controls.Add(cajaTextoNombreF3);
            Controls.Add(etiqueta4);
            Controls.Add(etiqueta3);
            Controls.Add(etiqueta2);
            Controls.Add(etiqueta1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBoton2F3;
        private TextBox cajaTextoTelF3;
        private TextBox cajaTextoApe2F3;
        private TextBox cajaTextoApe1F3;
        private TextBox cajaTextoNombreF3;
        private Label etiqueta4;
        private Label etiqueta3;
        private Label etiqueta2;
        private Label etiqueta1;
    }
}
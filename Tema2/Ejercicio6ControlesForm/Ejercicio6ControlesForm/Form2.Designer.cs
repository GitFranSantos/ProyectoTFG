namespace Ejercicio6ControlesForm
{
    partial class Form2
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
            etiqueta1 = new Label();
            etiqueta2 = new Label();
            etiqueta3 = new Label();
            etiqueta4 = new Label();
            cajaTextoNombre = new TextBox();
            cajaTextoApe1 = new TextBox();
            cajaTextoApe2 = new TextBox();
            cajaTextoTel = new TextBox();
            btnBoton1 = new Button();
            btnBoton2 = new Button();
            SuspendLayout();
            // 
            // etiqueta1
            // 
            etiqueta1.AutoSize = true;
            etiqueta1.Location = new Point(62, 47);
            etiqueta1.Name = "etiqueta1";
            etiqueta1.Size = new Size(64, 20);
            etiqueta1.TabIndex = 0;
            etiqueta1.Text = "Nombre";
            // 
            // etiqueta2
            // 
            etiqueta2.AutoSize = true;
            etiqueta2.Location = new Point(62, 89);
            etiqueta2.Name = "etiqueta2";
            etiqueta2.Size = new Size(74, 20);
            etiqueta2.TabIndex = 1;
            etiqueta2.Text = "Apelldio1";
            // 
            // etiqueta3
            // 
            etiqueta3.AutoSize = true;
            etiqueta3.Location = new Point(62, 128);
            etiqueta3.Name = "etiqueta3";
            etiqueta3.Size = new Size(74, 20);
            etiqueta3.TabIndex = 2;
            etiqueta3.Text = "Apellido2";
            // 
            // etiqueta4
            // 
            etiqueta4.AutoSize = true;
            etiqueta4.Location = new Point(62, 168);
            etiqueta4.Name = "etiqueta4";
            etiqueta4.Size = new Size(67, 20);
            etiqueta4.TabIndex = 3;
            etiqueta4.Text = "Telefono";
            // 
            // cajaTextoNombre
            // 
            cajaTextoNombre.Location = new Point(204, 40);
            cajaTextoNombre.Name = "cajaTextoNombre";
            cajaTextoNombre.Size = new Size(125, 27);
            cajaTextoNombre.TabIndex = 4;
            // 
            // cajaTextoApe1
            // 
            cajaTextoApe1.Location = new Point(204, 82);
            cajaTextoApe1.Name = "cajaTextoApe1";
            cajaTextoApe1.Size = new Size(125, 27);
            cajaTextoApe1.TabIndex = 5;
            // 
            // cajaTextoApe2
            // 
            cajaTextoApe2.Location = new Point(204, 121);
            cajaTextoApe2.Name = "cajaTextoApe2";
            cajaTextoApe2.Size = new Size(125, 27);
            cajaTextoApe2.TabIndex = 6;
            // 
            // cajaTextoTel
            // 
            cajaTextoTel.Location = new Point(204, 161);
            cajaTextoTel.Name = "cajaTextoTel";
            cajaTextoTel.Size = new Size(125, 27);
            cajaTextoTel.TabIndex = 7;
            // 
            // btnBoton1
            // 
            btnBoton1.Location = new Point(480, 80);
            btnBoton1.Name = "btnBoton1";
            btnBoton1.Size = new Size(94, 29);
            btnBoton1.TabIndex = 8;
            btnBoton1.Text = "Agregar";
            btnBoton1.UseVisualStyleBackColor = true;
            btnBoton1.Click += btnBoton1_Click;
            // 
            // btnBoton2
            // 
            btnBoton2.Location = new Point(480, 121);
            btnBoton2.Name = "btnBoton2";
            btnBoton2.Size = new Size(94, 29);
            btnBoton2.TabIndex = 9;
            btnBoton2.Text = "Cancelar";
            btnBoton2.UseVisualStyleBackColor = true;
            btnBoton2.Click += btnBoton2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBoton2);
            Controls.Add(btnBoton1);
            Controls.Add(cajaTextoTel);
            Controls.Add(cajaTextoApe2);
            Controls.Add(cajaTextoApe1);
            Controls.Add(cajaTextoNombre);
            Controls.Add(etiqueta4);
            Controls.Add(etiqueta3);
            Controls.Add(etiqueta2);
            Controls.Add(etiqueta1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label etiqueta1;
        private Label etiqueta2;
        private Label etiqueta3;
        private Label etiqueta4;
        private TextBox cajaTextoNombre;
        private TextBox cajaTextoApe1;
        private TextBox cajaTextoApe2;
        private TextBox cajaTextoTel;
        private Button btnBoton1;
        private Button btnBoton2;
    }
}
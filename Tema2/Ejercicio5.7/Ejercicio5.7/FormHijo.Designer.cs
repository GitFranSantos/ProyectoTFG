namespace Ejercicio5._7
{
    partial class FormHijo
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
            textBoxDNI = new TextBox();
            textBoxNombre = new TextBox();
            textBoxApellidos = new TextBox();
            textBoxTelefono = new TextBox();
            textBoxEmail = new TextBox();
            labelDNI = new Label();
            labelNombre = new Label();
            labelApellidos = new Label();
            labelTelefono = new Label();
            labelEmail = new Label();
            buttonPrincipio = new Button();
            buttonAtras = new Button();
            buttonAvanzar = new Button();
            buttonFinal = new Button();
            SuspendLayout();
            // 
            // textBoxDNI
            // 
            textBoxDNI.Location = new Point(93, 58);
            textBoxDNI.Name = "textBoxDNI";
            textBoxDNI.Size = new Size(229, 27);
            textBoxDNI.TabIndex = 0;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(93, 109);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(229, 27);
            textBoxNombre.TabIndex = 1;
            // 
            // textBoxApellidos
            // 
            textBoxApellidos.Location = new Point(93, 158);
            textBoxApellidos.Name = "textBoxApellidos";
            textBoxApellidos.Size = new Size(229, 27);
            textBoxApellidos.TabIndex = 2;
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Location = new Point(93, 216);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.Size = new Size(229, 27);
            textBoxTelefono.TabIndex = 3;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(93, 272);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(229, 27);
            textBoxEmail.TabIndex = 4;
            // 
            // labelDNI
            // 
            labelDNI.AutoSize = true;
            labelDNI.Location = new Point(424, 65);
            labelDNI.Name = "labelDNI";
            labelDNI.Size = new Size(35, 20);
            labelDNI.TabIndex = 5;
            labelDNI.Text = "DNI";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(424, 116);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(64, 20);
            labelNombre.TabIndex = 6;
            labelNombre.Text = "Nombre";
            // 
            // labelApellidos
            // 
            labelApellidos.AutoSize = true;
            labelApellidos.Location = new Point(424, 165);
            labelApellidos.Name = "labelApellidos";
            labelApellidos.Size = new Size(72, 20);
            labelApellidos.TabIndex = 7;
            labelApellidos.Text = "Apellidos";
            // 
            // labelTelefono
            // 
            labelTelefono.AutoSize = true;
            labelTelefono.Location = new Point(424, 223);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(67, 20);
            labelTelefono.TabIndex = 8;
            labelTelefono.Text = "Telefono";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(424, 279);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(52, 20);
            labelEmail.TabIndex = 9;
            labelEmail.Text = "E-mail";
            // 
            // buttonPrincipio
            // 
            buttonPrincipio.Location = new Point(93, 380);
            buttonPrincipio.Name = "buttonPrincipio";
            buttonPrincipio.Size = new Size(94, 29);
            buttonPrincipio.TabIndex = 10;
            buttonPrincipio.Text = "<<";
            buttonPrincipio.UseVisualStyleBackColor = true;
            buttonPrincipio.Click += buttonPrincipio_Click;
            // 
            // buttonAtras
            // 
            buttonAtras.Location = new Point(294, 380);
            buttonAtras.Name = "buttonAtras";
            buttonAtras.Size = new Size(94, 29);
            buttonAtras.TabIndex = 11;
            buttonAtras.Text = "<";
            buttonAtras.UseVisualStyleBackColor = true;
            buttonAtras.Click += buttonAtras_Click;
            // 
            // buttonAvanzar
            // 
            buttonAvanzar.Location = new Point(460, 380);
            buttonAvanzar.Name = "buttonAvanzar";
            buttonAvanzar.Size = new Size(94, 29);
            buttonAvanzar.TabIndex = 12;
            buttonAvanzar.Text = ">";
            buttonAvanzar.UseVisualStyleBackColor = true;
            buttonAvanzar.Click += buttonAvanzar_Click;
            // 
            // buttonFinal
            // 
            buttonFinal.Location = new Point(612, 380);
            buttonFinal.Name = "buttonFinal";
            buttonFinal.Size = new Size(94, 29);
            buttonFinal.TabIndex = 13;
            buttonFinal.Text = ">>";
            buttonFinal.UseVisualStyleBackColor = true;
            buttonFinal.Click += buttonFinal_Click;
            // 
            // FormHijo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonFinal);
            Controls.Add(buttonAvanzar);
            Controls.Add(buttonAtras);
            Controls.Add(buttonPrincipio);
            Controls.Add(labelEmail);
            Controls.Add(labelTelefono);
            Controls.Add(labelApellidos);
            Controls.Add(labelNombre);
            Controls.Add(labelDNI);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxTelefono);
            Controls.Add(textBoxApellidos);
            Controls.Add(textBoxNombre);
            Controls.Add(textBoxDNI);
            Name = "FormHijo";
            Text = "FormHijo";
            FormClosed += FormHijo_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxDNI;
        private TextBox textBoxNombre;
        private TextBox textBoxApellidos;
        private TextBox textBoxTelefono;
        private TextBox textBoxEmail;
        private Label labelDNI;
        private Label labelNombre;
        private Label labelApellidos;
        private Label labelTelefono;
        private Label labelEmail;
        private Button buttonPrincipio;
        private Button buttonAtras;
        private Button buttonAvanzar;
        private Button buttonFinal;
    }
}
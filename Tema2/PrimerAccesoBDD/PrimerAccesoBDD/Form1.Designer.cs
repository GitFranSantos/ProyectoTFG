namespace PrimerAccesoBDD
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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            labelUser = new Label();
            labelPass = new Label();
            labelServer = new Label();
            labelPuerto = new Label();
            textBoxUser = new TextBox();
            textBoxPass = new TextBox();
            textBoxServer = new TextBox();
            textBoxPuerto = new TextBox();
            panel1 = new Panel();
            panelInsert = new Panel();
            btnInsert = new Button();
            textBoxInsertEmail = new TextBox();
            textBoxInsertTel = new TextBox();
            textBoxInsertApe = new TextBox();
            textBoxInsertNombre = new TextBox();
            textBoxInsertDNI = new TextBox();
            lblInsertEmail = new Label();
            lblInsertTelefono = new Label();
            lblInsertApellidos = new Label();
            label2 = new Label();
            lblInsertDNI = new Label();
            btnMostrarBDD = new Button();
            btnActualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panelInsert.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(0, 236);
            button1.Name = "button1";
            button1.Size = new Size(307, 29);
            button1.TabIndex = 0;
            button1.Text = "Conectar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 272);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(648, 251);
            dataGridView1.TabIndex = 1;
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Location = new Point(16, 23);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(59, 20);
            labelUser.TabIndex = 2;
            labelUser.Text = "Usuario";
            // 
            // labelPass
            // 
            labelPass.AutoSize = true;
            labelPass.Location = new Point(16, 72);
            labelPass.Name = "labelPass";
            labelPass.Size = new Size(83, 20);
            labelPass.TabIndex = 3;
            labelPass.Text = "Contraseña";
            // 
            // labelServer
            // 
            labelServer.AutoSize = true;
            labelServer.Location = new Point(16, 128);
            labelServer.Name = "labelServer";
            labelServer.Size = new Size(50, 20);
            labelServer.TabIndex = 4;
            labelServer.Text = "Server";
            // 
            // labelPuerto
            // 
            labelPuerto.AutoSize = true;
            labelPuerto.Location = new Point(16, 182);
            labelPuerto.Name = "labelPuerto";
            labelPuerto.Size = new Size(52, 20);
            labelPuerto.TabIndex = 5;
            labelPuerto.Text = "Puerto";
            // 
            // textBoxUser
            // 
            textBoxUser.Location = new Point(99, 20);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(125, 27);
            textBoxUser.TabIndex = 6;
            // 
            // textBoxPass
            // 
            textBoxPass.Location = new Point(99, 69);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.Size = new Size(125, 27);
            textBoxPass.TabIndex = 7;
            textBoxPass.UseSystemPasswordChar = true;
            // 
            // textBoxServer
            // 
            textBoxServer.Location = new Point(99, 125);
            textBoxServer.Name = "textBoxServer";
            textBoxServer.Size = new Size(125, 27);
            textBoxServer.TabIndex = 8;
            // 
            // textBoxPuerto
            // 
            textBoxPuerto.Location = new Point(99, 182);
            textBoxPuerto.Name = "textBoxPuerto";
            textBoxPuerto.Size = new Size(125, 27);
            textBoxPuerto.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.Controls.Add(labelUser);
            panel1.Controls.Add(textBoxPuerto);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBoxUser);
            panel1.Controls.Add(labelPuerto);
            panel1.Controls.Add(textBoxServer);
            panel1.Controls.Add(labelPass);
            panel1.Controls.Add(textBoxPass);
            panel1.Controls.Add(labelServer);
            panel1.Location = new Point(12, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(307, 265);
            panel1.TabIndex = 10;
            // 
            // panelInsert
            // 
            panelInsert.Controls.Add(btnInsert);
            panelInsert.Controls.Add(textBoxInsertEmail);
            panelInsert.Controls.Add(textBoxInsertTel);
            panelInsert.Controls.Add(textBoxInsertApe);
            panelInsert.Controls.Add(textBoxInsertNombre);
            panelInsert.Controls.Add(textBoxInsertDNI);
            panelInsert.Controls.Add(lblInsertEmail);
            panelInsert.Controls.Add(lblInsertTelefono);
            panelInsert.Controls.Add(lblInsertApellidos);
            panelInsert.Controls.Add(label2);
            panelInsert.Controls.Add(lblInsertDNI);
            panelInsert.Location = new Point(349, 1);
            panelInsert.Name = "panelInsert";
            panelInsert.Size = new Size(526, 265);
            panelInsert.TabIndex = 11;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(338, 112);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(135, 59);
            btnInsert.TabIndex = 10;
            btnInsert.Text = "Insertar";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // textBoxInsertEmail
            // 
            textBoxInsertEmail.Location = new Point(90, 213);
            textBoxInsertEmail.Name = "textBoxInsertEmail";
            textBoxInsertEmail.Size = new Size(125, 27);
            textBoxInsertEmail.TabIndex = 9;
            // 
            // textBoxInsertTel
            // 
            textBoxInsertTel.Location = new Point(90, 162);
            textBoxInsertTel.Name = "textBoxInsertTel";
            textBoxInsertTel.Size = new Size(125, 27);
            textBoxInsertTel.TabIndex = 8;
            // 
            // textBoxInsertApe
            // 
            textBoxInsertApe.Location = new Point(90, 118);
            textBoxInsertApe.Name = "textBoxInsertApe";
            textBoxInsertApe.Size = new Size(125, 27);
            textBoxInsertApe.TabIndex = 7;
            // 
            // textBoxInsertNombre
            // 
            textBoxInsertNombre.Location = new Point(90, 65);
            textBoxInsertNombre.Name = "textBoxInsertNombre";
            textBoxInsertNombre.Size = new Size(125, 27);
            textBoxInsertNombre.TabIndex = 6;
            // 
            // textBoxInsertDNI
            // 
            textBoxInsertDNI.Location = new Point(90, 17);
            textBoxInsertDNI.Name = "textBoxInsertDNI";
            textBoxInsertDNI.Size = new Size(125, 27);
            textBoxInsertDNI.TabIndex = 5;
            // 
            // lblInsertEmail
            // 
            lblInsertEmail.AutoSize = true;
            lblInsertEmail.Location = new Point(18, 213);
            lblInsertEmail.Name = "lblInsertEmail";
            lblInsertEmail.Size = new Size(46, 20);
            lblInsertEmail.TabIndex = 4;
            lblInsertEmail.Text = "Email";
            // 
            // lblInsertTelefono
            // 
            lblInsertTelefono.AutoSize = true;
            lblInsertTelefono.Location = new Point(18, 165);
            lblInsertTelefono.Name = "lblInsertTelefono";
            lblInsertTelefono.Size = new Size(67, 20);
            lblInsertTelefono.TabIndex = 3;
            lblInsertTelefono.Text = "Telefono";
            // 
            // lblInsertApellidos
            // 
            lblInsertApellidos.AutoSize = true;
            lblInsertApellidos.Location = new Point(18, 121);
            lblInsertApellidos.Name = "lblInsertApellidos";
            lblInsertApellidos.Size = new Size(72, 20);
            lblInsertApellidos.TabIndex = 2;
            lblInsertApellidos.Text = "Apellidos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 69);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // lblInsertDNI
            // 
            lblInsertDNI.AutoSize = true;
            lblInsertDNI.Location = new Point(18, 20);
            lblInsertDNI.Name = "lblInsertDNI";
            lblInsertDNI.Size = new Size(35, 20);
            lblInsertDNI.TabIndex = 0;
            lblInsertDNI.Text = "DNI";
            // 
            // btnMostrarBDD
            // 
            btnMostrarBDD.Location = new Point(666, 283);
            btnMostrarBDD.Name = "btnMostrarBDD";
            btnMostrarBDD.Size = new Size(209, 74);
            btnMostrarBDD.TabIndex = 12;
            btnMostrarBDD.Text = "Mostrar BDD";
            btnMostrarBDD.UseVisualStyleBackColor = true;
            btnMostrarBDD.Click += btnMostrarBDD_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(666, 363);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(209, 70);
            btnActualizar.TabIndex = 13;
            btnActualizar.Text = "Actualizar Tabla";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 535);
            Controls.Add(btnActualizar);
            Controls.Add(btnMostrarBDD);
            Controls.Add(panelInsert);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelInsert.ResumeLayout(false);
            panelInsert.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Label labelUser;
        private Label labelPass;
        private Label labelServer;
        private Label labelPuerto;
        private TextBox textBoxUser;
        private TextBox textBoxPass;
        private TextBox textBoxServer;
        private TextBox textBoxPuerto;
        private Panel panel1;
        private Panel panelInsert;
        private TextBox textBoxInsertEmail;
        private TextBox textBoxInsertTel;
        private TextBox textBoxInsertApe;
        private TextBox textBoxInsertNombre;
        private TextBox textBoxInsertDNI;
        private Label lblInsertEmail;
        private Label lblInsertTelefono;
        private Label lblInsertApellidos;
        private Label label2;
        private Label lblInsertDNI;
        private Button btnInsert;
        private Button btnMostrarBDD;
        private Button btnActualizar;
    }
}
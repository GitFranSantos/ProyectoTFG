namespace Ejercicio5._7
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
            lblUser = new Label();
            lblPass = new Label();
            lblServer = new Label();
            lblPort = new Label();
            btnConectar = new Button();
            textBoxUser = new TextBox();
            textBoxPass = new TextBox();
            textBoxServer = new TextBox();
            textBoxPort = new TextBox();
            SuspendLayout();
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(226, 57);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(59, 20);
            lblUser.TabIndex = 0;
            lblUser.Text = "Usuario";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(226, 112);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(70, 20);
            lblPass.TabIndex = 1;
            lblPass.Text = "Password";
            // 
            // lblServer
            // 
            lblServer.AutoSize = true;
            lblServer.Location = new Point(226, 165);
            lblServer.Name = "lblServer";
            lblServer.Size = new Size(50, 20);
            lblServer.TabIndex = 2;
            lblServer.Text = "Server";
            // 
            // lblPort
            // 
            lblPort.AutoSize = true;
            lblPort.Location = new Point(226, 214);
            lblPort.Name = "lblPort";
            lblPort.Size = new Size(52, 20);
            lblPort.TabIndex = 3;
            lblPort.Text = "Puerto";
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(305, 302);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(267, 86);
            btnConectar.TabIndex = 4;
            btnConectar.Text = "Conectar BDD";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // textBoxUser
            // 
            textBoxUser.Location = new Point(380, 50);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(238, 27);
            textBoxUser.TabIndex = 5;
            // 
            // textBoxPass
            // 
            textBoxPass.Location = new Point(380, 105);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.Size = new Size(238, 27);
            textBoxPass.TabIndex = 6;
            textBoxPass.UseSystemPasswordChar = true;
            // 
            // textBoxServer
            // 
            textBoxServer.Location = new Point(380, 158);
            textBoxServer.Name = "textBoxServer";
            textBoxServer.Size = new Size(238, 27);
            textBoxServer.TabIndex = 7;
            // 
            // textBoxPort
            // 
            textBoxPort.Location = new Point(380, 207);
            textBoxPort.Name = "textBoxPort";
            textBoxPort.Size = new Size(238, 27);
            textBoxPort.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxPort);
            Controls.Add(textBoxServer);
            Controls.Add(textBoxPass);
            Controls.Add(textBoxUser);
            Controls.Add(btnConectar);
            Controls.Add(lblPort);
            Controls.Add(lblServer);
            Controls.Add(lblPass);
            Controls.Add(lblUser);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUser;
        private Label lblPass;
        private Label lblServer;
        private Label lblPort;
        private Button btnConectar;
        private TextBox textBoxUser;
        private TextBox textBoxPass;
        private TextBox textBoxServer;
        private TextBox textBoxPort;
    }
}
namespace Ejercicio6._1DataReader2
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
            listBoxForm1 = new ListBox();
            dataGridViewForm1 = new DataGridView();
            textBoxServer = new TextBox();
            textBoxUser = new TextBox();
            textBoxPass = new TextBox();
            textBoxPuerto = new TextBox();
            btnConectar = new Button();
            labelServer = new Label();
            labelUser = new Label();
            labelPass = new Label();
            labelPuerto = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewForm1).BeginInit();
            SuspendLayout();
            // 
            // listBoxForm1
            // 
            listBoxForm1.FormattingEnabled = true;
            listBoxForm1.ItemHeight = 20;
            listBoxForm1.Location = new Point(581, 12);
            listBoxForm1.Name = "listBoxForm1";
            listBoxForm1.Size = new Size(641, 284);
            listBoxForm1.TabIndex = 0;
            listBoxForm1.DoubleClick += listBoxForm1_DoubleClick;
            // 
            // dataGridViewForm1
            // 
            dataGridViewForm1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewForm1.Location = new Point(12, 302);
            dataGridViewForm1.Name = "dataGridViewForm1";
            dataGridViewForm1.RowHeadersWidth = 51;
            dataGridViewForm1.RowTemplate.Height = 29;
            dataGridViewForm1.Size = new Size(1210, 248);
            dataGridViewForm1.TabIndex = 1;
            // 
            // textBoxServer
            // 
            textBoxServer.Location = new Point(25, 26);
            textBoxServer.Name = "textBoxServer";
            textBoxServer.Size = new Size(227, 27);
            textBoxServer.TabIndex = 2;
            textBoxServer.Text = "127.0.0.1";
            // 
            // textBoxUser
            // 
            textBoxUser.Location = new Point(25, 75);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(227, 27);
            textBoxUser.TabIndex = 3;
            textBoxUser.Text = "root";
            // 
            // textBoxPass
            // 
            textBoxPass.Location = new Point(25, 135);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.Size = new Size(227, 27);
            textBoxPass.TabIndex = 4;
            textBoxPass.Text = "2DAM";
            textBoxPass.UseSystemPasswordChar = true;
            // 
            // textBoxPuerto
            // 
            textBoxPuerto.Location = new Point(25, 187);
            textBoxPuerto.Name = "textBoxPuerto";
            textBoxPuerto.Size = new Size(227, 27);
            textBoxPuerto.TabIndex = 5;
            textBoxPuerto.Text = "3306";
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(25, 241);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(550, 55);
            btnConectar.TabIndex = 6;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // labelServer
            // 
            labelServer.AutoSize = true;
            labelServer.Location = new Point(296, 33);
            labelServer.Name = "labelServer";
            labelServer.Size = new Size(50, 20);
            labelServer.TabIndex = 7;
            labelServer.Text = "Server";
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Location = new Point(296, 82);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(38, 20);
            labelUser.TabIndex = 8;
            labelUser.Text = "User";
            // 
            // labelPass
            // 
            labelPass.AutoSize = true;
            labelPass.Location = new Point(296, 142);
            labelPass.Name = "labelPass";
            labelPass.Size = new Size(70, 20);
            labelPass.TabIndex = 9;
            labelPass.Text = "Password";
            // 
            // labelPuerto
            // 
            labelPuerto.AutoSize = true;
            labelPuerto.Location = new Point(296, 194);
            labelPuerto.Name = "labelPuerto";
            labelPuerto.Size = new Size(52, 20);
            labelPuerto.TabIndex = 10;
            labelPuerto.Text = "Puerto";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1234, 562);
            Controls.Add(labelPuerto);
            Controls.Add(labelPass);
            Controls.Add(labelUser);
            Controls.Add(labelServer);
            Controls.Add(btnConectar);
            Controls.Add(textBoxPuerto);
            Controls.Add(textBoxPass);
            Controls.Add(textBoxUser);
            Controls.Add(textBoxServer);
            Controls.Add(dataGridViewForm1);
            Controls.Add(listBoxForm1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewForm1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxForm1;
        private DataGridView dataGridViewForm1;
        private TextBox textBoxServer;
        private TextBox textBoxUser;
        private TextBox textBoxPass;
        private TextBox textBoxPuerto;
        private Button btnConectar;
        private Label labelServer;
        private Label labelUser;
        private Label labelPass;
        private Label labelPuerto;
    }
}
namespace Ejercicio6._1
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
            textBoxServer = new TextBox();
            labelServer = new Label();
            labelUser = new Label();
            textBoxUser = new TextBox();
            labelPass = new Label();
            textBoxPass = new TextBox();
            label4 = new Label();
            textBoxPuerto = new TextBox();
            buttonConectar = new Button();
            dataGridViewForm1 = new DataGridView();
            listBoxForm1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewForm1).BeginInit();
            SuspendLayout();
            // 
            // textBoxServer
            // 
            textBoxServer.Location = new Point(34, 36);
            textBoxServer.Name = "textBoxServer";
            textBoxServer.Size = new Size(125, 27);
            textBoxServer.TabIndex = 0;
            textBoxServer.Text = "127.0.0.1";
            // 
            // labelServer
            // 
            labelServer.AutoSize = true;
            labelServer.Location = new Point(181, 43);
            labelServer.Name = "labelServer";
            labelServer.Size = new Size(93, 20);
            labelServer.TabIndex = 1;
            labelServer.Text = "IP Del Server";
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Location = new Point(181, 85);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(59, 20);
            labelUser.TabIndex = 3;
            labelUser.Text = "Usuario";
            // 
            // textBoxUser
            // 
            textBoxUser.Location = new Point(34, 82);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(125, 27);
            textBoxUser.TabIndex = 2;
            textBoxUser.Text = "root";
            // 
            // labelPass
            // 
            labelPass.AutoSize = true;
            labelPass.Location = new Point(181, 133);
            labelPass.Name = "labelPass";
            labelPass.Size = new Size(70, 20);
            labelPass.TabIndex = 5;
            labelPass.Text = "Password";
            // 
            // textBoxPass
            // 
            textBoxPass.Location = new Point(34, 126);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.Size = new Size(125, 27);
            textBoxPass.TabIndex = 4;
            textBoxPass.Text = "2DAM";
            textBoxPass.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(181, 186);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 7;
            label4.Text = "Puerto";
            // 
            // textBoxPuerto
            // 
            textBoxPuerto.Location = new Point(34, 179);
            textBoxPuerto.Name = "textBoxPuerto";
            textBoxPuerto.Size = new Size(125, 27);
            textBoxPuerto.TabIndex = 6;
            textBoxPuerto.Text = "3306";
            // 
            // buttonConectar
            // 
            buttonConectar.Location = new Point(34, 241);
            buttonConectar.Name = "buttonConectar";
            buttonConectar.Size = new Size(240, 37);
            buttonConectar.TabIndex = 8;
            buttonConectar.Text = "Conectar";
            buttonConectar.UseVisualStyleBackColor = true;
            buttonConectar.Click += buttonConectar_Click;
            // 
            // dataGridViewForm1
            // 
            dataGridViewForm1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewForm1.Location = new Point(34, 293);
            dataGridViewForm1.Name = "dataGridViewForm1";
            dataGridViewForm1.RowHeadersWidth = 51;
            dataGridViewForm1.RowTemplate.Height = 29;
            dataGridViewForm1.Size = new Size(885, 249);
            dataGridViewForm1.TabIndex = 9;
            // 
            // listBoxForm1
            // 
            listBoxForm1.FormattingEnabled = true;
            listBoxForm1.ItemHeight = 20;
            listBoxForm1.Location = new Point(339, 37);
            listBoxForm1.Name = "listBoxForm1";
            listBoxForm1.Size = new Size(580, 244);
            listBoxForm1.TabIndex = 10;
            listBoxForm1.DoubleClick += listBoxForm1_DoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 565);
            Controls.Add(listBoxForm1);
            Controls.Add(dataGridViewForm1);
            Controls.Add(buttonConectar);
            Controls.Add(label4);
            Controls.Add(textBoxPuerto);
            Controls.Add(labelPass);
            Controls.Add(textBoxPass);
            Controls.Add(labelUser);
            Controls.Add(textBoxUser);
            Controls.Add(labelServer);
            Controls.Add(textBoxServer);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewForm1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxServer;
        private Label labelServer;
        private Label labelUser;
        private TextBox textBoxUser;
        private Label labelPass;
        private TextBox textBoxPass;
        private Label label4;
        private TextBox textBoxPuerto;
        private Button buttonConectar;
        private DataGridView dataGridViewForm1;
        private ListBox listBoxForm1;
    }
}
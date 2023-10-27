namespace Ejercicio6ControlesForm
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
            label1 = new Label();
            listBox1 = new ListBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(205, 52);
            label1.Name = "label1";
            label1.Size = new Size(415, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingenieros forestales acreditados para trabajar en la empresa";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(320, 110);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 104);
            listBox1.TabIndex = 1;
            // 
            // btn1
            // 
            btn1.Location = new Point(274, 263);
            btn1.Name = "btn1";
            btn1.Size = new Size(94, 29);
            btn1.TabIndex = 2;
            btn1.Text = "Agregar";
            btn1.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            btn2.Location = new Point(420, 263);
            btn2.Name = "btn2";
            btn2.Size = new Size(94, 29);
            btn2.TabIndex = 3;
            btn2.Text = "Eliminar";
            btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            btn3.Location = new Point(274, 340);
            btn3.Name = "btn3";
            btn3.Size = new Size(94, 29);
            btn3.TabIndex = 4;
            btn3.Text = "Contar";
            btn3.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            btn4.Location = new Point(420, 340);
            btn4.Name = "btn4";
            btn4.Size = new Size(94, 29);
            btn4.TabIndex = 5;
            btn4.Text = "Ver nombre";
            btn4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Ejemplo de Listas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBox1;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
    }
}
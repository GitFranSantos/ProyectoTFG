namespace Ejemplo1
{
    partial class TercerForm
    {

        private System.ComponentModel.IContainer components = null;


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
            rdBtn1 = new RadioButton();
            rdBtn2 = new RadioButton();
            rdBtn3 = new RadioButton();
            label1 = new Label();
            panel1 = new Panel();
            rdBtnMaximizar = new RadioButton();
            rdBtnNormal = new RadioButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // rdBtn1
            // 
            rdBtn1.AutoSize = true;
            rdBtn1.Location = new Point(50, 40);
            rdBtn1.Name = "rdBtn1";
            rdBtn1.Size = new Size(84, 24);
            rdBtn1.TabIndex = 0;
            rdBtn1.TabStop = true;
            rdBtn1.Text = "640*480";
            rdBtn1.UseVisualStyleBackColor = true;
            rdBtn1.Click += rdBtn1_Click;
            // 
            // rdBtn2
            // 
            rdBtn2.AutoSize = true;
            rdBtn2.Location = new Point(50, 106);
            rdBtn2.Name = "rdBtn2";
            rdBtn2.Size = new Size(84, 24);
            rdBtn2.TabIndex = 1;
            rdBtn2.TabStop = true;
            rdBtn2.Text = "800*600";
            rdBtn2.UseVisualStyleBackColor = true;
            rdBtn2.Click += rdBtn2_Click;
            // 
            // rdBtn3
            // 
            rdBtn3.AutoSize = true;
            rdBtn3.Location = new Point(50, 172);
            rdBtn3.Name = "rdBtn3";
            rdBtn3.Size = new Size(92, 24);
            rdBtn3.TabIndex = 2;
            rdBtn3.TabStop = true;
            rdBtn3.Text = "1024*768";
            rdBtn3.UseVisualStyleBackColor = true;
            rdBtn3.Click += rdBtn3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 14);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 3;
            label1.Text = "Ventana";
            // 
            // panel1
            // 
            panel1.Controls.Add(rdBtnMaximizar);
            panel1.Controls.Add(rdBtnNormal);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(322, 92);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 208);
            panel1.TabIndex = 4;
            // 
            // rdBtnMaximizar
            // 
            rdBtnMaximizar.AutoSize = true;
            rdBtnMaximizar.Location = new Point(45, 130);
            rdBtnMaximizar.Name = "rdBtnMaximizar";
            rdBtnMaximizar.Size = new Size(99, 24);
            rdBtnMaximizar.TabIndex = 5;
            rdBtnMaximizar.TabStop = true;
            rdBtnMaximizar.Text = "Maximizar";
            rdBtnMaximizar.UseVisualStyleBackColor = true;
            rdBtnMaximizar.Click += rdBtnMaximizar_Click;
            // 
            // rdBtnNormal
            // 
            rdBtnNormal.AutoSize = true;
            rdBtnNormal.Location = new Point(45, 80);
            rdBtnNormal.Name = "rdBtnNormal";
            rdBtnNormal.Size = new Size(80, 24);
            rdBtnNormal.TabIndex = 4;
            rdBtnNormal.TabStop = true;
            rdBtnNormal.Text = "Normal";
            rdBtnNormal.UseVisualStyleBackColor = true;
            rdBtnNormal.Click += rdBtnNormal_Click;
            // 
            // TercerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 433);
            Controls.Add(panel1);
            Controls.Add(rdBtn3);
            Controls.Add(rdBtn2);
            Controls.Add(rdBtn1);
            Name = "TercerForm";
            Text = "TercerForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rdBtn1;
        private RadioButton rdBtn2;
        private RadioButton rdBtn3;
        private Label label1;
        private Panel panel1;
        private RadioButton rdBtnNormal;
        private RadioButton rdBtnMaximizar;
    }
}
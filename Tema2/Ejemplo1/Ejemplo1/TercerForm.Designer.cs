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
            rdBtn1.MouseClick += rdBtn1_MouseClick;
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
            rdBtn2.MouseClick += rdBtn2_MouseClick_1;
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
            rdBtn3.MouseClick += rdBtn3_MouseClick;
            // 
            // TercerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 433);
            Controls.Add(rdBtn3);
            Controls.Add(rdBtn2);
            Controls.Add(rdBtn1);
            Name = "TercerForm";
            Text = "TercerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rdBtn1;
        private RadioButton rdBtn2;
        private RadioButton rdBtn3;
    }
}
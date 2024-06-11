namespace AppMDI
{
    partial class FormHijo1
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
            CajaTxt = new RichTextBox();
            SuspendLayout();
            // 
            // CajaTxt
            // 
            CajaTxt.Dock = DockStyle.Fill;
            CajaTxt.Location = new Point(0, 0);
            CajaTxt.Name = "CajaTxt";
            CajaTxt.Size = new Size(800, 450);
            CajaTxt.TabIndex = 0;
            CajaTxt.Text = "";
            // 
            // FormHijo1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CajaTxt);
            Name = "FormHijo1";
            Text = "FormHijo1";
            FormClosing += FormHijo1_FormClosing;
            FormClosed += FormHijo1_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox CajaTxt;
    }
}
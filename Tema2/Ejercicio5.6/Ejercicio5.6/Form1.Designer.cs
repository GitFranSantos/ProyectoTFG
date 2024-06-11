namespace Ejercicio5._6
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
            listBoxNomCol = new ListBox();
            lblNumCol = new Label();
            lblNumColB = new Label();
            lblNumFilas = new Label();
            lblNumFilasB = new Label();
            lblCampo1 = new Label();
            txtBoxCampo1 = new TextBox();
            lblCampo2 = new Label();
            txtBoxCampo2 = new TextBox();
            SuspendLayout();
            // 
            // listBoxNomCol
            // 
            listBoxNomCol.FormattingEnabled = true;
            listBoxNomCol.ItemHeight = 20;
            listBoxNomCol.Location = new Point(45, 35);
            listBoxNomCol.Name = "listBoxNomCol";
            listBoxNomCol.Size = new Size(315, 284);
            listBoxNomCol.TabIndex = 0;
            // 
            // lblNumCol
            // 
            lblNumCol.AutoSize = true;
            lblNumCol.Location = new Point(454, 35);
            lblNumCol.Name = "lblNumCol";
            lblNumCol.Size = new Size(132, 20);
            lblNumCol.TabIndex = 1;
            lblNumCol.Text = "Numero Columnas";
            // 
            // lblNumColB
            // 
            lblNumColB.AutoSize = true;
            lblNumColB.Location = new Point(454, 68);
            lblNumColB.Name = "lblNumColB";
            lblNumColB.Size = new Size(0, 20);
            lblNumColB.TabIndex = 2;
            // 
            // lblNumFilas
            // 
            lblNumFilas.AutoSize = true;
            lblNumFilas.Location = new Point(454, 113);
            lblNumFilas.Name = "lblNumFilas";
            lblNumFilas.Size = new Size(96, 20);
            lblNumFilas.TabIndex = 3;
            lblNumFilas.Text = "Numero Filas";
            // 
            // lblNumFilasB
            // 
            lblNumFilasB.AutoSize = true;
            lblNumFilasB.Location = new Point(454, 143);
            lblNumFilasB.Name = "lblNumFilasB";
            lblNumFilasB.Size = new Size(0, 20);
            lblNumFilasB.TabIndex = 4;
            // 
            // lblCampo1
            // 
            lblCampo1.AutoSize = true;
            lblCampo1.Location = new Point(460, 202);
            lblCampo1.Name = "lblCampo1";
            lblCampo1.Size = new Size(126, 20);
            lblCampo1.TabIndex = 5;
            lblCampo1.Text = "Ejemplo campo 1";
            // 
            // txtBoxCampo1
            // 
            txtBoxCampo1.Location = new Point(461, 238);
            txtBoxCampo1.Name = "txtBoxCampo1";
            txtBoxCampo1.Size = new Size(125, 27);
            txtBoxCampo1.TabIndex = 6;
            // 
            // lblCampo2
            // 
            lblCampo2.AutoSize = true;
            lblCampo2.Location = new Point(464, 281);
            lblCampo2.Name = "lblCampo2";
            lblCampo2.Size = new Size(126, 20);
            lblCampo2.TabIndex = 7;
            lblCampo2.Text = "Ejemplo campo 2";
            // 
            // txtBoxCampo2
            // 
            txtBoxCampo2.Location = new Point(464, 313);
            txtBoxCampo2.Name = "txtBoxCampo2";
            txtBoxCampo2.Size = new Size(125, 27);
            txtBoxCampo2.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBoxCampo2);
            Controls.Add(lblCampo2);
            Controls.Add(txtBoxCampo1);
            Controls.Add(lblCampo1);
            Controls.Add(lblNumFilasB);
            Controls.Add(lblNumFilas);
            Controls.Add(lblNumColB);
            Controls.Add(lblNumCol);
            Controls.Add(listBoxNomCol);
            Name = "Form1";
            Text = "Numero Filas";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxNomCol;
        private Label lblNumCol;
        private Label lblNumColB;
        private Label lblNumFilas;
        private Label lblNumFilasB;
        private Label lblCampo1;
        private TextBox txtBoxCampo1;
        private Label lblCampo2;
        private TextBox txtBoxCampo2;
    }
}
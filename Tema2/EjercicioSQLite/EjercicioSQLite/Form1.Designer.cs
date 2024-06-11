namespace EjercicioSQLite
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
            lblNombre = new Label();
            lblApellido = new Label();
            textBoxNombre = new TextBox();
            textBoxApellido = new TextBox();
            btnConectar = new Button();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            dataGridViewForm1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewForm1).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(40, 34);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(40, 119);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 20);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(40, 70);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(125, 27);
            textBoxNombre.TabIndex = 2;
            // 
            // textBoxApellido
            // 
            textBoxApellido.Location = new Point(40, 160);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(125, 27);
            textBoxApellido.TabIndex = 3;
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(634, 34);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(94, 29);
            btnConectar.TabIndex = 4;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(634, 82);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(634, 131);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(94, 29);
            btnActualizar.TabIndex = 6;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(634, 177);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 39);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dataGridViewForm1
            // 
            dataGridViewForm1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewForm1.Location = new Point(40, 234);
            dataGridViewForm1.Name = "dataGridViewForm1";
            dataGridViewForm1.RowHeadersWidth = 51;
            dataGridViewForm1.RowTemplate.Height = 29;
            dataGridViewForm1.Size = new Size(722, 204);
            dataGridViewForm1.TabIndex = 8;
            dataGridViewForm1.CellDoubleClick += dataGridViewForm1_CellDoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewForm1);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(btnConectar);
            Controls.Add(textBoxApellido);
            Controls.Add(textBoxNombre);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewForm1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblApellido;
        private TextBox textBoxNombre;
        private TextBox textBoxApellido;
        private Button btnConectar;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnEliminar;
        private DataGridView dataGridViewForm1;
    }
}
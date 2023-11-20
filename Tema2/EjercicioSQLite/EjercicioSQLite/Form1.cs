namespace EjercicioSQLite
{
    public partial class Form1 : Form
    {
        ConexionBdd miConexion = new ConexionBdd();
        public Form1()
        {
            InitializeComponent();
            btnActualizar.Enabled = false;
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            miConexion.CrearConexion();
            dataGridViewForm1.DataSource = miConexion.ObtenerContenidoTabla();
            btnActualizar.Enabled = true;
            btnAgregar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            miConexion.AgregarDatos(textBoxNombre.Text, textBoxApellido.Text);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dataGridViewForm1.DataSource = null;
            dataGridViewForm1.DataSource = miConexion.ObtenerContenidoTabla();
            if (dataGridViewForm1.SelectedRows.Count > 0)
            {
                DataGridViewRow dgvr = dataGridViewForm1.SelectedRows[0];
                miConexion.ActualizarDatos(Int32.Parse(dgvr.Cells[0].Value.ToString()), textBoxNombre.Text, textBoxApellido.Text);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            //int indiceFila = dr.Index;
            if(dataGridViewForm1.SelectedRows.Count > 0)
            {
                DataGridViewRow dgvr = dataGridViewForm1.SelectedRows[0];
                miConexion.EliminarDatos(Int32.Parse(dgvr.Cells[0].Value.ToString()));
            }
        }

        private void dataGridViewForm1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0 && dataGridViewForm1.SelectedRows.Count > 0)
            {
                DataGridViewRow dgvr = dataGridViewForm1.SelectedRows[0];
                textBoxNombre.Text = dgvr.Cells[1].Value.ToString();
                textBoxApellido.Text = dgvr.Cells[2].Value.ToString();
            }
        }
    }
}
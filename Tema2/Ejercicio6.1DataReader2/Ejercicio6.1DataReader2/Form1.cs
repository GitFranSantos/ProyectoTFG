namespace Ejercicio6._1DataReader2
{
    public partial class Form1 : Form
    {
        DataReaderBdd dataReader;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            dataReader = new DataReaderBdd(textBoxServer.Text, textBoxUser.Text, textBoxPass.Text, textBoxPuerto.Text);

            dataReader.Conectar();

            foreach (Pais p in dataReader.ObtenerPaises())
            {
                string nuevoPais = $"{p.Nombre}";
                listBoxForm1.Items.Add(nuevoPais);
            }
            dataReader.Desconectar();
        }

        private void listBoxForm1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewForm1.Rows.Count > 0)
            {
                dataGridViewForm1.Rows.Clear();
            }

            dataReader.Conectar();

            int elementoSeleccionado = listBoxForm1.SelectedIndex;

            string codCiudad = dataReader.ObtenerPaises()[elementoSeleccionado].CodigoPais;

            if(dataGridViewForm1.Columns.Count == 0)
            {
                dataGridViewForm1.Columns.Add("Name", "Nombre");
            }
            
            foreach (Ciudad c in dataReader.TodasCiudades(codCiudad))
            {
                dataGridViewForm1.Rows.Add(c.Nombre);
            }
            dataReader.Desconectar();
        }
    }
}
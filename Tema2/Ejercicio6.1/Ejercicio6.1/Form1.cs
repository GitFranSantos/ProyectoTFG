namespace Ejercicio6._1
{
    public partial class Form1 : Form
    {
        DataReaderBdd dataReader;


        public Form1()
        {
            InitializeComponent();
            dataGridViewForm1.Columns.Add("Code", "Code");
            dataGridViewForm1.Columns.Add("Name", "Nombre País");
            dataGridViewForm1.Columns.Add("Continent", "Continente");
            dataGridViewForm1.Columns.Add("SurfaceArea", "Area");
            dataGridViewForm1.Columns.Add("Population", "Poblacion");
            dataGridViewForm1.Columns.Add("LifeExpectancy", "Esperanza Vida");

        }

        private void buttonConectar_Click(object sender, EventArgs e)
        {
            dataReader = new DataReaderBdd(textBoxServer.Text, textBoxUser.Text, textBoxPass.Text, textBoxPuerto.Text);
            dataReader.Conectar();
            //Sacar todas las ciudades y poblacion en el listBox
            //List<Ciudad>listaCiudades = new List<Ciudad>();
            //listaCiudades = dataReader.ObtenerCiudades();

            foreach (Ciudad c in dataReader.ObtenerCiudades())
            {
                string nomYpob = "Ciudad: " + c.Nombre + " --- Numero de habitantes: " + c.Poblacion;
                listBoxForm1.Items.Add(nomYpob);
            }
            dataReader.Desconectar();
        }

        private void listBoxForm1_DoubleClick(object sender, EventArgs e)
        {
            dataReader.Conectar();

            int elementoSeleccionado = listBoxForm1.SelectedIndex;

            string codPais = dataReader.ObtenerCiudades()[elementoSeleccionado].CountryCode;

            Pais paisSeleccionado = dataReader.ObtenerPais(codPais);

            dataGridViewForm1.Rows.Add(paisSeleccionado.CodigoPais, paisSeleccionado.Nombre, paisSeleccionado.Continente, paisSeleccionado.SurfaceArea, paisSeleccionado.Poblacion, paisSeleccionado.LifeExpecting);

            dataReader.Desconectar();
        }
    }
}
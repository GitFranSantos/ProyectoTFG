namespace Ejercicio5._6
{
    public partial class Form1 : Form
    {
        ConexionBdd miConexion = new ConexionBdd("root", "2DAM", "localhost", "3306");
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            miConexion.Conectar();

            listBoxNomCol.DataSource = miConexion.GetNombreColumnas();

            //miConexion.GetNomColumnas(listBoxNomCol);

            lblNumColB.Text = miConexion.GetNumCol().ToString();

            lblNumFilasB.Text = miConexion.GetNumFilas().ToString();

            //miConexion.GetCampo(txtBoxCampo1, txtBoxCampo2);

            txtBoxCampo1.Text = miConexion.GetCampo1().ToString();

            //txtBoxCampo2.Text = miConexion.GetCampo2().ToString();
        }
    }
}
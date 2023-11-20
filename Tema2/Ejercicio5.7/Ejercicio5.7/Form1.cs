namespace Ejercicio5._7
{
    public partial class Form1 : Form
    {
        public ConexionBdd miConexion;
        public string user = "root";
        public string pass = "2DAM";
        public string puerto = "3306";
        public string server = "localhost";
        public Form1()
        {
            InitializeComponent();
            textBoxUser.Text = user;
            textBoxPass.Text = pass;
            textBoxServer.Text = server;
            textBoxPort.Text = puerto;
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            //miConexion = new ConexionBdd(textBoxUser.Text,textBoxPass.Text,textBoxServer.Text,textBoxPuerto.Text)
            //Si queremos que los textbox se rellenen manualmente y use lo que pongas en los campos para crear la conexion

            miConexion = new ConexionBdd(user, pass, server, puerto);
            miConexion.CrearConexion();
            miConexion.Consulta("SELECT * FROM forestales");

            FormHijo formHijo = new FormHijo(miConexion);
            this.Hide();
            formHijo.Show();
        }
    }

}
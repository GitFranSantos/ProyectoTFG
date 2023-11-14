using MySql.Data.MySqlClient;
using System.Data;

namespace PrimerAccesoBDD
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
            textBoxPuerto.Text = puerto;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //miConexion = new ConexionBdd(textBoxUser.Text,textBoxPass.Text,textBoxServer.Text,textBoxPuerto.Text)
            //Si queremos que los textbox se rellenen manualmente y use lo que pongas en los campos para crear la conexion

            miConexion = new ConexionBdd(user, pass, server, puerto);
            miConexion.CrearConexion();
            miConexion.Consulta("SELECT * FROM forestales");


            miConexion.Desconectar();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            miConexion.CrearConexion();
            miConexion.Insertar(textBoxInsertDNI.Text, textBoxInsertNombre.Text, textBoxInsertApe.Text,
                textBoxInsertTel.Text, textBoxInsertEmail.Text);
        }

        private void btnMostrarBDD_Click(object sender, EventArgs e)
        {
            DataView dv = miConexion.GetDataView();
            //Mostramos la consulta por el dataGridView1
            dataGridView1.DataSource = dv;

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DataView dv = miConexion.GetDataView();
            //Mostramos la consulta por el dataGridView1
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dv;

        }
    }
}
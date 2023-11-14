using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerAccesoBDD
{
    public class ConexionBdd
    {
        private MySqlConnection miConexion;
        private MySqlCommand miComando;
        private MySqlDataAdapter miAdaptador;
        private DataSet aplicationDataSet;

        public string Server {  get; set; }
        public string Puerto {  get; set; }
        public string User {  get; set; }
        public string Password { get; set; }
        
        public ConexionBdd(string user, string password, string server, string puerto)
        {
            this.Server = server;
            this.Puerto = puerto;
            this.User = user;
            this.Password = password;
        }
        
        public void CrearConexion()
        {
            if (miConexion != null)
            {
                miConexion.Close();
            }
            try
            {   //Crear la conexion
                miConexion = new MySqlConnection("server = "+Server+"; port="+Puerto+"; userid="+User+"; password="+Password+"; database=Ingenieros; Allow Zero Datetime=true;CHARSET=latin1");
                miConexion.Open();
                MessageBox.Show("Conexion con exito");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al conectar al servidor MySQL: " + ex.Message, "Error al conectar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Consulta(string consulta)
        {

            //Crear el comando
            //Primero se elige el schema en el que se encuentran las tablas si fuese necesario
            //miConexion.ChangeDatabase("Ingenieros");
            //Otra forma es pasarle la conexion como segundo parametro para no tener que hacer miComando.Connection = miConexion;
            //miComando = new MySqlCommand(consulta, miConexion);
            miComando = new MySqlCommand(consulta);
            //Realizar la conexion con el comando
            miComando.Connection = miConexion;
            //Crear el DataAdapter
            miAdaptador = new MySqlDataAdapter(miComando);

            //Crear el DataSet
            aplicationDataSet = new DataSet();

            //Rellenar el daset coon el DataAdapter
            miAdaptador.Fill(aplicationDataSet);
            //dataGridView1.DataSource = aplicationDataSet.Tables[0].DefaultView;
        }

        public DataSet GetDataSet()
        {
            return aplicationDataSet;
        }
        
        public DataView GetDataView()
        {
            return aplicationDataSet.Tables[0].DefaultView;
        }
        
        public void Desconectar()
        {
            miConexion.Close();
        }
        public void Insertar(string dni, string nombre, string apellido, string telefono, string email)
        {
            try
            {
                string insert = "INSERT INTO forestales VALUES " +
                "('" + dni + "', '" + nombre + "', '" + apellido + "', '" + telefono + "', '" + email +"');";
                miComando = new MySqlCommand(insert, miConexion);
                miComando.ExecuteNonQuery();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Error al conectar al servidor MySQL: " + ex.Message, 
                    "Error al conectar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

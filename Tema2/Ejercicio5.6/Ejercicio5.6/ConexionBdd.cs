using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Ejercicio5._6
{
    public class ConexionBdd
    {
        //constructor
        //Metodo conectar
        //Metodo obtener nombre columnas que devuelve una lista de string   
        //Metodo obtener numero de filas que devuelve un int
        //Obtener campo(numero fila, numero columna) devuelve un string
        private MySqlConnection miConexion;
        private MySqlCommand miComando;
        private MySqlDataAdapter miAdaptador;
        private DataSet ds;

        public string User {  get; set; }
        public string Pass { get; set; }
        public string Server { get; set; }
        public string Puerto {  get; set; }
        

        public ConexionBdd(string user, string pass, string server, string puerto)
        {
            this.User = user;
            this.Pass = pass;
            this.Server = server;
            this.Puerto = puerto;
        }

        public void Conectar()
        {
            if (miConexion != null)
            {
                miConexion.Close();
            }
            try
            {   //Crear la conexion
                miConexion = new MySqlConnection("server = " + Server + "; port=" + Puerto + "; userid=" + User + "; password=" + Pass + "; database=Ingenieros; Allow Zero Datetime=true;CHARSET=latin1");
                miComando = new MySqlCommand("SELECT * FROM forestales", miConexion);
                miAdaptador = new MySqlDataAdapter(miComando);
                miConexion.Open();
                ds = new DataSet();
                miAdaptador.Fill(ds);
                miConexion.Close();
                MessageBox.Show("Conexion con exito");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al conectar al servidor MySQL: " + ex.Message, "Error al conectar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public List<string> GetNombreColumnas()
        {
            List<string> result = new List<string>();

            foreach(DataColumn col in ds.Tables[0].Columns)
            {
                result.Add(col.ColumnName);
            }

            return result;
        }
        public void GetNomColumnas(ListBox listaNombre)
        {
            foreach (DataColumn col in ds.Tables[0].Columns)
            {
                listaNombre.Items.Add(col.ColumnName);
            }
        }

        public int GetNumFilas()
        {
            return ds.Tables[0].Rows.Count;
        }

        public int GetNumCol()
        {
            return ds.Tables[0].Columns.Count;
        }

        /*
        public void GetCampo(TextBox txtBoxCampo1, TextBox txtCampo2)
        {
            DataRow fila = ds.Tables[0].Rows[0];
            txtBoxCampo1.Text = fila[0].ToString();
            txtCampo2.Text = ds.Tables[0].Rows[0][1].ToString();
        }
        */

        public string GetCampo1()
        {
            DataRow fila = ds.Tables[0].Rows[0];
            return fila[0].ToString();
            
        }
        /*
        public string GetCampo2()
        {
            return ds.Tables[0].Rows[0][1].ToString();
        }
        */
    }
}

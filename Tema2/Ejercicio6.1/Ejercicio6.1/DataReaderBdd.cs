using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;

namespace Ejercicio6._1
{


    public class DataReaderBdd
    {

        MySqlConnection miConexion;
        MySqlCommand miComando;
        MySqlDataReader dataReader;

        string server;
        string puerto;
        string user;
        string pass;

        public DataReaderBdd(string server, string user, string pass, string puerto)
        {
            this.server = server;
            this.user = user;
            this.pass = pass;   
            this.puerto = puerto;   
        }
        public void Conectar()
        {
            if(miConexion != null) miConexion.Close();
           
            try
            {
                miConexion = new MySqlConnection("server = " + server + "; port=" + puerto + "; userid=" + user + "; password=" + pass + "; database=world; Allow Zero Datetime=true;CHARSET=latin1");
                miConexion.Open();
                MessageBox.Show("Conexion con exito");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al conectar al servidor MySQL: " + ex.Message, "Error al conectar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Desconectar()
        {
            dataReader.Close();
            miConexion.Close();
        }

        //Metodo que devuelva una lista de ciudades
        public List<Ciudad> ObtenerCiudades()
        {
            List<Ciudad> listaCiudades = new List<Ciudad>();
            Conectar();
            miComando = new MySqlCommand("SELECT * FROM city", miConexion);
            dataReader = miComando.ExecuteReader();

            while(dataReader.Read())
            {
                Ciudad city = new Ciudad((Int32)dataReader["ID"], dataReader["Name"].ToString(), dataReader["CountryCode"].ToString() , (Int32)dataReader["Population"]);
                listaCiudades.Add(city);
            }
            return listaCiudades;

            Desconectar();
        }

        public Pais ObtenerPais(string codigo)
        {
            Conectar();

            Pais paisSeleccionado;

            miComando = new MySqlCommand("SELECT * FROM country WHERE Code = '" + codigo +"'", miConexion);

            dataReader = miComando.ExecuteReader();

            dataReader.Read();

            paisSeleccionado = new Pais(dataReader["Code"].ToString(), dataReader["Name"].ToString(), dataReader["Continent"].ToString(), (Decimal)dataReader["SurfaceArea"], (Int32)dataReader["Population"], (Decimal)dataReader["LifeExpectancy"]);

            Desconectar();

            return paisSeleccionado;
        }
    }
}

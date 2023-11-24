using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;

namespace Ejercicio6._1DataReader2
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
            if (miConexion != null) miConexion.Close();

            try
            {
                miConexion = new MySqlConnection("server = " + server + "; port=" + puerto + "; userid=" + user + "; password=" + pass + "; database=world; Allow Zero Datetime=true;CHARSET=latin1");
                miConexion.Open();
                //MessageBox.Show("Conexion con exito");
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
        public List<Pais> ObtenerPaises()
        {
            List<Pais> listaPaises = new List<Pais>();
            Conectar();
            miComando = new MySqlCommand("SELECT * FROM country", miConexion);
            dataReader = miComando.ExecuteReader();

            while (dataReader.Read())
            {
                decimal esperanzaVida;
                esperanzaVida = 0;
                Pais nuevoPais = new Pais(dataReader["Code"].ToString(), dataReader["Name"].ToString(), dataReader["Continent"].ToString(), (Decimal)dataReader["SurfaceArea"], (Int32)dataReader["Population"], esperanzaVida);
                listaPaises.Add(nuevoPais);
            }
            return listaPaises;

            Desconectar();
        }
        
        public List<Ciudad> TodasCiudades(string codigo)
        {
            Conectar();

            List<Ciudad> listaTodasCiudades = new List<Ciudad>();
            
            miComando = new MySqlCommand("SELECT * FROM city WHERE CountryCode = '"+codigo+"'", miConexion);

            dataReader = miComando.ExecuteReader();

            while(dataReader.Read())
            {
                Ciudad city = new Ciudad((Int32)dataReader["ID"], dataReader["Name"].ToString(), dataReader["CountryCode"].ToString(), (Int32)dataReader["Population"]);
                listaTodasCiudades.Add(city);
            }

            Desconectar();

            return listaTodasCiudades;
        }
    }
}

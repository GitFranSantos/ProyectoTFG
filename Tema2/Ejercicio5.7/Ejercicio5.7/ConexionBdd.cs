﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5._7
{
    public class ConexionBdd
    {
        private MySqlConnection miConexion;
        private MySqlCommand miComando;
        private MySqlDataAdapter miAdaptador;
        private DataSet aplicationDataSet;

        public string Server { get; set; }
        public string Puerto { get; set; }
        public string User { get; set; }
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
                miConexion = new MySqlConnection("server = " + Server + "; port=" + Puerto + "; userid=" + User + "; password=" + Password + "; database=Ingenieros; Allow Zero Datetime=true;CHARSET=latin1");
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

        public DataRow GetPrimeraFila()
        {
            DataRow drow = aplicationDataSet.Tables[0].Rows[0];
            return drow;
        }

        public DataRow GetSiguiente(int indice)
        {
            DataRow drow = aplicationDataSet.Tables[0].Rows[indice];
            return drow;
        }

        public DataRow GetAnterior(int indice)
        {
            DataRow drow = aplicationDataSet.Tables[0].Rows[indice];
            return drow;
        }

        public DataRow GetUltimaFila()
        {
            DataRow drow = aplicationDataSet.Tables[0].Rows[aplicationDataSet.Tables[0].Rows.Count - 1];
            return drow;
        }

        public void Desconectar()
        {
            miConexion.Close();
        }
        
        public int GetLongitudTabla()
        {
            int longitud = aplicationDataSet.Tables[0].Rows.Count-1;
            return longitud;
        }
    }
}

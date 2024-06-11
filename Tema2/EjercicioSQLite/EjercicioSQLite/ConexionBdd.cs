using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SQLite;
using System.Data;

namespace EjercicioSQLite
{
    public class ConexionBdd
    {
        SQLiteConnection conexion;
        SQLiteCommand comando;
        SQLiteDataAdapter adaptador;
        DataSet ds;

        //conexion = new SQLiteConecction("DataSource = RUTA del .db; Version = 3; New = False; Compress = True");
        public ConexionBdd()
        {

        }

        public void CrearConexion()
        {
            if (conexion != null) conexion.Close();
            try
            {
                conexion = new SQLiteConnection("Data Source = C:\\Users\\franp\\Desktop\\2DAM\\Desarrollo de interfaces\\GitHubDI\\DI\\Tema2\\EjercicioSQLite\\BddSQLite.db; Version = 3; New = False; Compress = True");
                conexion.Open();
                MessageBox.Show("Conexion establecida");
            }
            catch(SQLiteException ex)
            {
                MessageBox.Show("Error al conectar al servidor de SQL: " +
                ex.Message, "Error al conectar",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        public DataView ObtenerContenidoTabla()
        {
            try
            {
                comando = new SQLiteCommand("SELECT * FROM persona", conexion);
                adaptador = new SQLiteDataAdapter(comando);
                ds = new DataSet();
                //conexion.Open();
                adaptador.Fill(ds);
            }
            catch(SQLiteException ex)
            {
                MessageBox.Show("Error al conectar al servidor de MySQL: " +
                ex.Message, "Error al conectar",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ds.Tables[0].DefaultView;
        }

        public void AgregarDatos(string nombre, string ape)
        {
            
             comando = new SQLiteCommand("INSERT INTO persona (nombre, apellidos) VALUES ('" + nombre + "', '" + ape + "')", conexion);
             comando.ExecuteNonQuery();
        }

        public void EliminarDatos(int id)
        {
            comando = new SQLiteCommand("DELETE FROM persona WHERE ID = "+id, conexion);
            comando.ExecuteNonQuery();
        }

        public void ActualizarDatos(int id, string nombre, string apellidos)
        {
            comando = new SQLiteCommand("UPDATE persona SET ID = '" + id + "', nombre = '" + nombre + "', apellidos = '" + apellidos + "' WHERE ID = "+id, conexion);
            comando.ExecuteNonQuery();
        }

    }
}

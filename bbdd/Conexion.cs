using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace ControlCesharp.bbdd
{
    internal class Conexion
    {
        private static readonly string url = "Server=145.14.151.1;" +
            "Database=u812167471_agendadam;" +
            "User ID=u812167471_agendadam;" +
            "Port=3306;" +
            "Password=2025-Agenda;" +
            "Convert Zero Datetime=True;";

        public static bool Acceder(string user, string pass)
        {
            string consulta = "SELECT * FROM usuarios WHERE usuario = ?user AND pass = ?pass";
            MySqlConnection conn = new MySqlConnection(url);
            conn.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(consulta, conn);
                comando.Parameters.AddWithValue("?user", user);
                comando.Parameters.AddWithValue("?pass", pass);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public static bool UsuarioExiste(string user)
        {
            string consulta = "SELECT * FROM usuarios WHERE usuario = ?user";
            MySqlConnection conn = new MySqlConnection(url);
            conn.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(consulta, conn);
                comando.Parameters.AddWithValue("?user", user);
                MySqlDataReader reader = comando.ExecuteReader();
                return reader.HasRows;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable getAlumnos()
        {
            //aqui pondremos el codigo para obtener los alumnos
            return null;
        }

        public static DataTable getProfesores()
        {
            //aqui pondremos el codigo para obtener los profesores
            return null;
        }


    }
}

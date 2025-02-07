using System.Data;
using System.Windows.Forms;
using ControlCesharp.modelo;
using MySqlConnector;

namespace ControlCesharp.bbdd
{
    internal class Conexion
    {
        private static readonly string url = "Server=145.14.151.1;" +
            "Database=u812167471_alumnosyprofes;" +
            "User ID=u812167471_alumnosyprofes;" +
            "Port=3306;" +
            "Password=2025-Alumnosyprofes;" +
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
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM alumnos";

            MySqlConnection conn = new MySqlConnection(url);

            try
            {
                conn.Open();
                MySqlCommand comando = new MySqlCommand(consulta, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                adapter.Fill(dt);
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.Message);

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public static DataTable getProfesores()
        {
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM profesores";

            MySqlConnection conn = new MySqlConnection(url);

            try
            {
                conn.Open();
                MySqlCommand comando = new MySqlCommand(consulta, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                adapter.Fill(dt);
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.Message);

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        public static bool RegistrarA(string text, Alumno a)
        {
            string consulta = "INSERT INTO alumnos (nombre, apellidos, edad, ciudad, ciclo) VALUES (?nom, ?ape, ?edad, ?ciu, ?ciclo)";
            MySqlConnection conn = new MySqlConnection(url);
            conn.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(consulta, conn);
                comando.Parameters.AddWithValue("?nom", a.Nombre);
                comando.Parameters.AddWithValue("?ape", a.Apellidos);
                comando.Parameters.AddWithValue("?edad", a.Edad);
                comando.Parameters.AddWithValue("?ciu", a.Ciudad);
                comando.Parameters.AddWithValue("?ciclo", a.Ciclo);
                comando.ExecuteNonQuery();
                return true;
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

        public static bool RegistrarP(string text, Profesor p)
        {
            string consulta = "INSERT INTO profesores (dni, nombre, apellidos, ciclo, salario, turno) VALUES (?dni, ?nom, ?ape, ?ciclo, ?salario, ?turno)";
            MySqlConnection conn = new MySqlConnection(url);
            conn.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(consulta, conn);
                comando.Parameters.AddWithValue("?dni", p.Dni);
                comando.Parameters.AddWithValue("?nom", p.Nombre);
                comando.Parameters.AddWithValue("?ape", p.Apellidos);
                comando.Parameters.AddWithValue("?ciclo", p.Ciclo);
                comando.Parameters.AddWithValue("?salario", p.Salario);
                comando.Parameters.AddWithValue("?turno", p.Turno);
                comando.ExecuteNonQuery();
                return true;
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
    }
}

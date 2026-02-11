using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class CDHabitaciones
    {
        public DataTable ObtenerHabitaciones()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Habitaciones", con))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
                con.Close();
            }
            return dt;
        }

        public bool AgregarHabitaciones(int numero, string descripcion, int cantidad)
        {
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Habitaciones (Numero, Descripcion, Cant_huespedes) VALUES (@numero, @descripcion, @cantidad)", con))
                {
                    cmd.Parameters.AddWithValue("@numero", numero);
                    cmd.Parameters.AddWithValue("@descripcion", descripcion);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    con.Close();
                    return rowsAffected > 0;
                }
            }
        }

        public bool ModificarHabitaciones(int id, int numero, string descripcion, int cantidad)
        {
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE Habitaciones SET Numero = @numero, Descripcion = @descripcion, Cant_huespedes = @cantidad WHERE Id_habitaciones = @id", con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@numero", numero);
                    cmd.Parameters.AddWithValue("@descripcion", descripcion);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    con.Close();
                    return rowsAffected > 0;
                }
            }
        }

        public bool EliminarHabitaciones(int id)
        {
            using(SqlConnection con = Conexion.obtenerConexion())
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("DELETE FROM Habitaciones WHERE Id_habitaciones = @id", con))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    con.Close();
                    return rowsAffected > 0;
                }
            }
        }
    }
}

using CalculadoraWebFinal.Datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CalculadoraWebFinal.Logica
{
    public class UsuarioBLL
    {

        public static int Agregar(string nombre)
        {
            int retorno = 0;
            Usuario_Dal.nombre = nombre;

            string query = "INSERT INTO Roles (nombre) VALUES (@nombre)";
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBconexion.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand(query, Conn);
                    cmd.Parameters.Add(new SqlParameter("@nombre", nombre));
                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                retorno = -1;
            }
            finally
            {
                Conn.Close();
            }

            return retorno;
        }
    }
}
using CalculadoraWebFinal.Datos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CalculadoraWebFinal.Logica
{
    namespace CalculadoraWebFinal.Logica
    {
        public class OperacionBLL
        {
            public static int Agregar(Operacion_Dal operacion)
            {
                int resultado = 0;
                string constr = ConfigurationManager.ConnectionStrings["CalculadoraconnectionString"].ConnectionString;
                using (SqlConnection con = new SqlConnection(constr))
                {
                    string query = "INSERT INTO Operaciones (usuario_id, operacion, resultado, fecha_operacion) VALUES (@usuario_id, @operacion, @resultado, @fecha_operacion)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@usuario_id", operacion.usuario_id);
                        cmd.Parameters.AddWithValue("@operacion", operacion.operacion);
                        cmd.Parameters.AddWithValue("@resultado", operacion.resultado);
                        cmd.Parameters.AddWithValue("@fecha_operacion", operacion.fecha_operacion);

                        con.Open();
                        resultado = cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                return resultado;
            }
            public static int Eliminar(int id)
            {
                int resultado = 0;
                string constr = ConfigurationManager.ConnectionStrings["CalculadoraconnectionString"].ConnectionString;
                using (SqlConnection con = new SqlConnection(constr))
                {
                    string query = "DELETE FROM Operaciones WHERE id = @id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        con.Open();
                        resultado = cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                return resultado;
            }
        }
    }
  }

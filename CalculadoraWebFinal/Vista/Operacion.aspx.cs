using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CalculadoraWebFinal.Logica;
using CalculadoraWebFinal.Datos;
using CalculadoraWebFinal.Logica.CalculadoraWebFinal.Logica;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace CalculadoraWebFinal.Vista
{
    public partial class Operacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LlenarGrid();
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Operacion_Dal operacion = new Operacion_Dal
            {
                usuario_id = int.Parse(TextCodigo.Text),
                operacion = TextOperacion.Text,
                resultado = decimal.Parse(TextResultado.Text),
                fecha_operacion = DateTime.Now
            };

            if (OperacionBLL.Agregar(operacion) > 0)
            {
                LlenarGrid();
            }
        }

        protected void LlenarGrid()
        {
            DataTable dt = new DataTable();
            string constr = ConfigurationManager.ConnectionStrings["CalculadoraconnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Operaciones", con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        sda.Fill(dt);
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                    }
                }
            }
        }

        protected void btnEliminarOperacion_Click(object sender, EventArgs e)
        {
            {
                int id;
                if (int.TryParse(TextIdEliminar.Text, out id))
                {
                    if (OperacionBLL.Eliminar(id) > 0)
                    {
                        LlenarGrid(); // Recargar el GridView después de eliminar
                    }
                    else
                    {
                        // Manejar el caso donde no se eliminó ningún registro, por ejemplo, mostrar un mensaje de error.
                        Response.Write("<script>alert('No se pudo eliminar el registro. Por favor, verifique el ID.');</script>");
                    }
                }
                else
                {
                    // Manejar el caso donde el ID no es válido, por ejemplo, mostrar un mensaje de error.
                    Response.Write("<script>alert('Por favor, ingrese un ID válido.');</script>");
                }
            }
        }
    }
}
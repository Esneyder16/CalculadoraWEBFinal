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
    }
}
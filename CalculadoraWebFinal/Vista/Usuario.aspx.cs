using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CalculadoraWebFinal.Datos;
using CalculadoraWebFinal.Logica;

namespace CalculadoraWebFinal.Vista
{
    public partial class Usuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        protected void Agregar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            if(UsuarioBLL.Agregar(TextCodigo.Text)> 0) LlenarGrid();
        }
        protected void LlenarGrid()
        {
            string nombre = "";
            DataTable dt = new DataTable();
            string constr = ConfigurationManager.ConnectionStrings["CalculadoraconnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT *  FROM Usuarios"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (dt)
                        {
                            sda.Fill(dt);
                            GridView1.DataSource = dt;
                            GridView1.DataBind();
                        }
                    }
                }

            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
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
            if (!IsPostBack)
            {
                LlenarGrid();
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            if (UsuarioBLL.Agregar(TextCodigo.Text) > 0)
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
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Usuarios"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(dt);
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                    }
                }
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Eliminar")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                if (UsuarioBLL.Eliminar(id) > 0)
                {
                    LlenarGrid();
                }
            }
        }
    }
}

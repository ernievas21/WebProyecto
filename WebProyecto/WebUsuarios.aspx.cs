using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTarea6
{
    public partial class WebUsuarios : System.Web.UI.Page
    {
        List<Usuario> misUsuarios = new List<Usuario>();
        List<Usuario> listaUsuarios = new List<Usuario>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Usuario objeUsuario = new Usuario();
                misUsuarios = objeUsuario.ConsultarUsuario();

                gvUsuarios.DataSource = misUsuarios;

                gvUsuarios.DataBind();

            }



        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuControlAcceso.aspx");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTarea6
{
    public partial class Empleados : System.Web.UI.Page
    {
        List<emplados> misEmpleados = new List<emplados>();
        List<emplados> listaEstudiantes = new List<emplados>();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                emplados objeEmpleado = new emplados();
                misEmpleados = objeEmpleado.ConsultarEmpleados();

                gvEmpleados.DataSource = misEmpleados;
                gvEmpleados.DataBind();

            }



        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuControlAcceso.aspx");
        }
    }
}
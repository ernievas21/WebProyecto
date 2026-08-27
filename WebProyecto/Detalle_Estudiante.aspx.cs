using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTarea6
{
    public partial class Detalle_Estudiante : System.Web.UI.Page
    {
        List<Estudiante> misEstudiantes = new List<Estudiante>();
        List<Estudiante> listaEstudiantes = new List<Estudiante>();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                Estudiante objeEstudiante = new Estudiante();
                misEstudiantes = objeEstudiante.ConsultarEstudiantes();

                //agregar los clientes en Grid
                // gvEstudiante.DataSource = misEstudiantes;
                // gvEstudiante.DataBind();
                gvEstu.DataSource = misEstudiantes;
                gvEstu.DataBind();

            }



        }

        protected void BtnModificarEstudiante_Click(object sender, EventArgs e)
        {
            string id_estudiante_modificar = txtModificar.Text;
            Response.Redirect("ModificarAlumno.aspx?ID=" + id_estudiante_modificar);
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Ingreso_Estudiante.aspx");
        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            string id_estudiante_eliminar = txtModificar.Text;
            Response.Redirect("EliminarAlumno.aspx?ID=" + id_estudiante_eliminar);
        }
    
    }
}
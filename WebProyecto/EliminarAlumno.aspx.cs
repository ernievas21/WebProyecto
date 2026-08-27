using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTarea6
{
    public partial class EliminarAlumno : System.Web.UI.Page
    {
        //creo la lista de clientes
        List<Estudiante> miEstudiante = new List<Estudiante>();
        protected void Page_Load(object sender, EventArgs e)
        {


            if (!IsPostBack)
            {

                Estudiante objestudiante = new Estudiante();
                objestudiante.idtEstudiante = Convert.ToInt32(Request.QueryString["ID"]);

                miEstudiante = objestudiante.ConsultarEstudiante();

                txtNombre.Text = miEstudiante[0].nombre;
                txtApellido.Text = miEstudiante[0].apellido;
                txtAltura.Text = miEstudiante[0].altura.ToString();
                txtPeso.Text = miEstudiante[0].peso.ToString();
                txtEdad.Text = miEstudiante[0].edad.ToString();
                txtGenero.Text = miEstudiante[0].genero.ToString();



            }



        }

        private void Limpiar()
        {
            txtApellido.Text = "";
            txtAltura.Text = "";
            txtNombre.Text = "";
            txtPeso.Text = "";
            txtEdad.Text = "";
            txtGenero.Text = "";

            // lblEdad.Text = "";
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Estudiante objestudianteEliminar = new Estudiante();
                objestudianteEliminar.idtEstudiante = Convert.ToInt32(Request.QueryString["ID"]);

                //tratar de modificarlo en la base de datos.
                objestudianteEliminar.EliminarEstudiante();
            }
            catch (Exception ex)
            {
                //esta sección siempre se ejecuta cuando existe un error en el try
                Session["Error"] = "Ha ocurrido un error " + ex.Message.ToString();
                Response.Redirect("ManejoErrores.aspx");
            }
            finally
            {
                //siempre se ejecuta después de que se ejecute ya sea el try o el catch
                Limpiar();
            }
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Detalle_Estudiante.aspx");
        }
    }
}
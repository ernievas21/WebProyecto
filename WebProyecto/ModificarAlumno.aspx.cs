using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTarea6
{
    public partial class ModificarAlumno : System.Web.UI.Page
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

        protected void BtnModificar_Click(object sender, EventArgs e)
        {


            try
            {
                //siempre se va tratar de ejecutar el codigo en esta seccion 

                Estudiante objEstudianteModificar = new Estudiante();

                objEstudianteModificar.idtEstudiante = Convert.ToInt32(Request.QueryString["ID"]);
                objEstudianteModificar.nombre = txtNombre.Text;
                objEstudianteModificar.apellido = txtApellido.Text;
                objEstudianteModificar.altura = Int32.Parse( txtAltura.Text);
                objEstudianteModificar.peso = Int32.Parse(txtPeso.Text);
                objEstudianteModificar.edad = Int32.Parse(txtEdad.Text);
                objEstudianteModificar.genero = txtGenero.Text;


                int resultado = objEstudianteModificar.SobrePeso();

                 lblSobrepeso.Text = resultado.ToString();
                objEstudianteModificar.sobrepeso = resultado;

              




                //tratar de insertar
                objEstudianteModificar.ModificarEstudiante();


                //objCliente.ObtenerUltimoIdInsertado();





            }
            catch (Exception ex)
            {

                //esta sección siempre se ejecuta cuando existe un error en el try
                Session["Error"] = "Ha ocurrido un error " + ex.Message.ToString();
                Response.Redirect("ManejoErrores.aspx");


            }
            finally
            {
                //siempre se ejecuta despues de que se ejecute ya sea el try o el cath

                //Limpiar campos 
                //Limpiar();
                Limpiar();
            }



        }

        protected void BtnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Detalle_Estudiante.aspx");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.ML;
using Microsoft.ML.Data;




namespace WebTarea6
{
    public partial class Ingreso_Estudiante : System.Web.UI.Page
    {

        List<Estudiante> misEstudiantes = new List<Estudiante>();
        protected void Page_Load(object sender, EventArgs e)
        {


            if (!IsPostBack)
            {



                Estudiante objeEstudiante = new Estudiante();
                misEstudiantes = objeEstudiante.ConsultarEstudiantes();

                //agregar los clientes en Grid
              //  gvEstudiante.DataSource = misEstudiantes;
             //   gvEstudiante.DataBind();


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

        protected void btnAgrearEstudiante_Click(object sender, EventArgs e)
        {
            Estudiante objestudiante = new Estudiante();

            //objCliente.idCliente =  2;
            objestudiante.nombre = txtNombre.Text;
            objestudiante.apellido = txtApellido.Text;
            objestudiante.altura = Int32.Parse(txtAltura.Text);
            objestudiante.peso = Int32.Parse(txtPeso.Text);
            objestudiante.edad = Int32.Parse(txtEdad.Text);
            objestudiante.genero = txtGenero.Text;
        


           

            ////usando el metodo de persona que fue asociado a ala clase Cliente
            lblEdad.Text = objestudiante.DeterminarComplexion();
           
            int resultado = objestudiante.SobrePeso();

            lblSobrepeso.Text = resultado.ToString();
            objestudiante.sobrepeso = resultado;

            objestudiante.CrearEstudiante();

            //Limpiar();

        }

        protected void btnDetalleDatos_Click(object sender, EventArgs e)
        {
            Response.Redirect("Detalle_Estudiante.aspx");
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("PaginaPrincipal.aspx");
        }
    }
}

//nuevo 

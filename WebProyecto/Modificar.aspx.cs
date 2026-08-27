using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTarea6
{
    public partial class Modificar : System.Web.UI.Page
    {
       //creo la lista de clientes
        List<Cliente> miCliente = new List<Cliente>();
        
        protected void Page_Load(object sender, EventArgs e)
        {


            if(!IsPostBack)
            {

                Cliente objcliente = new Cliente();
                objcliente.idcliente = Convert.ToInt32(Request.QueryString["ID"]);

                miCliente = objcliente.ConsultarCliente();

                txtNombre.Text = miCliente[0].nombre;
                txtApellido.Text = miCliente[0].apellido;
                txtDireccion.Text = miCliente[0].direccion;
                txtTelefono.Text = miCliente[0].telefono.ToString();
                txtEdad.Text = miCliente[0].edad.ToString();

            }
            





        }

       

        protected void btnDetalle_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("Detalle.aspx");



        }

        private void Limpiar()
        {
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtEdad.Text = "";
           // lblEdad.Text = "";
        }

        protected void BtnCrear_Click(object sender, EventArgs e)
        {
            
            // sirve para crear los objetos 
            try
            { 
            
            // instanciar los objetos creados en el proyecto 
            Persona miPersona = new Persona();
            miPersona.altura = 1.75;
            miPersona.color_tez = "Blanca";
            miPersona.edad = 33;

            //clase Empleado 
            //Empleado miEmpleado = new Empleado();
            //miEmpleado.idEmpleado = 1;
            //miEmpleado.nombre = "Juan Pablo";
            //miEmpleado.apellido = "Sosa Garcia";
            //miEmpleado.puesto = "Contador";
            //miEmpleado.direccion = "zona 3";

            Usuario miUsuario = new Usuario();
            miUsuario.idUsuario = 1;
          //  miUsuario.estatusUsuario = 'A';
            
            // metodos para determinar  

            Cliente micliente  = new Cliente();
           string resulato= micliente.quejaCLiente('S');
            string encuesta = resulato;
            }
            catch (Exception)
            {
                // Va manejar la sesion para obtimizar recursos
                Session["Error"] = "Ha ocurrido un error";
                Response.Redirect("ManejoErrores.aspx");
                //esta seccion siempre se ejecuta cuando exite cuando exite un error en el try 
                string error = "Tengo un error incorrecto";

            }
            finally
            {
                // limpiar campos
                Limpiar();
            }



        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {

            try
            {
                //siempre se va tratar de ejecutar el codigo en esta seccion 

                Cliente objClienteModificar = new Cliente();

                objClienteModificar.idcliente = Convert.ToInt32(Request.QueryString["ID"]);
                objClienteModificar.nombre = txtNombre.Text;
                objClienteModificar.apellido = txtApellido.Text;
                objClienteModificar.direccion = txtDireccion.Text;
                objClienteModificar.telefono = Int32.Parse(txtTelefono.Text);
                objClienteModificar.edad = Int32.Parse(txtEdad.Text);

                //tratar de insertar
                objClienteModificar.ModificarCliente();
                
                
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
                Limpiar();

            }







        }
    }
}
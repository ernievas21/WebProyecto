using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTarea6
{
    public partial class Maestro : System.Web.UI.Page
    {
       //creo la lista de clientes
        //List<Cliente> listaClientes = new List<Cliente>();
        protected void Page_Load(object sender, EventArgs e)
        {


            if(!IsPostBack)
            {
             string bienvenido = "Bienvenidos";

            }
            else
            {
                if (Session["Clientes"]!=null)
                {
                //listaClientes = Session["Clientes"] as List<Cliente>;
                }
            }
            
            Cliente Objetocliente = new Cliente();
            Objetocliente.ConsultarClientes();


            ////Manejo de interfaces 
            //Usuario miUsuario = new Usuario();
            //miUsuario.idUsuario = 1;
            //miUsuario.estado_Usuario('A');

            //lblUsuario.Text = miUsuario.estado_Usuario('A');





        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {

            try
            {
                //siempre se va tratar de ejecutar el codigo en esta seccion 

                Cliente objCliente = new Cliente();

                //objCliente.idCliente =  2;
                objCliente.nombre = txtNombre.Text;
                objCliente.apellido = txtApellido.Text;
                objCliente.direccion = txtDireccion.Text;
                objCliente.telefono = Int32.Parse(txtTelefono.Text);
                objCliente.numero_cuenta = Int32.Parse(txtnumero_cuenta.Text);

                //tratar de insertar
                objCliente.CrearCliente();
                //objCliente.ObtenerUltimoIdInsertado();



                ////usando el metodo de persona que fue asociado a ala clase Cliente
                //lblEdad.Text = nuevo_cliente.DeterminarEdad();

                ////agrego los objetos del cliente a la lista
                //listaClientes.Add(nuevo_cliente);
                ////agrego la varible de session para guardar los dartos de los objetos
                //Session["Clientes"] = listaClientes;


            }
            catch (Exception)
            {

                //Session["Error"] = "Ha ocurrido un error";
                //Response.Redirect("ManejoErrores.aspx");
                ////esta seccion siempre se ejecuta cuando exite cuando exite un error en el try 
                //string error = "Tengo un error incorrecto";
            }
            finally
            {
                //siempre se ejecuta despues de que se ejecute ya sea el try o el cath

                //Limpiar campos 
                Limpiar();

            }
            
            
         
  


        }

        protected void btnDetalle_Click(object sender, EventArgs e)
        {
            //Opcion 1 : hacer redirect con variables de sesion 
           // Session["Clientes"] = listaClientes;

            //ir a la pagina Detalle 
            Response.Redirect("Detalle.aspx");



        }

        private void Limpiar()
        {
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtnumero_cuenta.Text = "";
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
          // string resulato= micliente.quejaCLiente('S');
           // string encuesta = resulato;
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

        protected void btnProducto_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProductoCrear.aspx");
        }

        protected void btnPrincipal_Click(object sender, EventArgs e)
        {
            Response.Redirect("PaginaPrincipal.aspx");
        }
    }
}
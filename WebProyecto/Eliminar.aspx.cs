using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTarea6
{
    public partial class Eliminar : System.Web.UI.Page
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

      

      

        protected void btnEliminar_Click(object sender, EventArgs e)
        {

            try
            {
                Cliente objclienteEliminar = new Cliente();
                objclienteEliminar.idcliente = Convert.ToInt32(Request.QueryString["ID"]);

                //tratar de modificarlo en la base de datos.
                objclienteEliminar.EliminarCliente();
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
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTarea6
{
    public partial class CrearCliente : System.Web.UI.Page
    {

        List<Cliente> misClientes = new List<Cliente>();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {



                Cliente objeCliente = new Cliente();
                misClientes = objeCliente.ConsultarClientes();

                //agregar los clientes en Grid
                //  gvEstudiante.DataSource = misEstudiantes;
                //   gvEstudiante.DataBind();


            }



        }

        private void Limpiar()
        {
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtNombre.Text = "";
            txttelefono.Text = "";
            txtEdad.Text = "";
          
            // lblEdad.Text = "";
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
           // parametros para registrar al cliente 
            Cliente objCliente = new Cliente();
            objCliente.nombre = txtNombre.Text;
            objCliente.apellido = txtApellido.Text;
            objCliente.direccion = txtDireccion.Text;
            objCliente.telefono = Int32.Parse(txttelefono.Text);
            objCliente.edad = Int32.Parse(txtEdad.Text);
           
            //inserto el cliente 
            objCliente.CrearCliente();
            Limpiar();

        }

        protected void btnListar_Click(object sender, EventArgs e)
        {
            Response.Redirect("DetalleCliente.aspx");
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("PaginaPrincipal.aspx");
        }
    }
}
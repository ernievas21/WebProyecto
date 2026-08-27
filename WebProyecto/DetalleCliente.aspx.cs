using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTarea6
{
    
    public partial class DetalleCliente : System.Web.UI.Page
    {
        List<Cliente> misClientes = new List<Cliente>();
        List<Cliente> listaClientes = new List<Cliente>();
        protected void Page_Load(object sender, EventArgs e)
        {

            Cliente objeCliente = new Cliente();
            misClientes = objeCliente.ConsultarClientes();

            //agregar los clientes en Grid
            // gvEstudiante.DataSource = misEstudiantes;
            // gvEstudiante.DataBind();
            gvClientes.DataSource = misClientes;
            gvClientes.DataBind();




        }

        protected void BtnModificarEstudiante_Click(object sender, EventArgs e)
        {
            string id_cliente_modificar = txtModificar.Text;
            Response.Redirect("ModificarCliente.aspx?ID=" + id_cliente_modificar);
        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            string id_cliente_eliminar = txtModificar.Text;
            Response.Redirect("EliminarCliente.aspx?ID=" + id_cliente_eliminar);
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("CrearCliente.aspx");
        }
    }
}
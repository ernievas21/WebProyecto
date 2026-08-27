using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTarea6
{
    public partial class Detalle : System.Web.UI.Page
    {
        
        List<Cliente> misCLientes = new List<Cliente>();
        List<Cliente> listaClientes = new List<Cliente>();
        protected void Page_Load(object sender, EventArgs e)
        {
            //Session de lista de CLientes 
          // listaClientes = Session["Clientes"] as List<Cliente>;
           
            //llevar los datos que estoy ingresando en los textos 
            //gvClientes.DataSource = listaClientes;
            //gvClientes.DataBind();
            if (!IsPostBack)
            {
                Cliente objeCliente = new Cliente();
                misCLientes = objeCliente.ConsultarClientes();

                //agregar los clientes en Grid
                gvClientes.DataSource = misCLientes;
                gvClientes.DataBind();
            }
           
           

        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Maestro.aspx");
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            ////muscar en la lista 

            ////Session de lista de CLientes 
            //listaClientes = Session["Clientes"] as List<Cliente>;

            ////expresion landap es una variable que extrae el objeto buscado para gusarar en una lista
            //Cliente resulBusqueda = listaClientes.Find(x => x.nombre.Contains(txtBuscar.Text.Trim()));

            //bool encontrado = listaClientes.Exists(x => x.nombre.Contains(txtBuscar.Text.Trim()));

            //if (encontrado)
            //{
            //    btnEliminar.Visible = true;
            //}
            //else
            //{
            //    btnEliminar.Visible = false;
            //}

            ////Variable de sesion para ver el resultado 
            //Session["RESULTADO"] = resulBusqueda;



        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {

            string id_cliente_modificar = txtModificar.Text;
            Response.Redirect("Eliminar.aspx?ID=" + id_cliente_modificar);
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            string id_cliente_modificar = txtModificar.Text;
            Response.Redirect("Modificar.aspx?ID="+ id_cliente_modificar);


        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTarea6
{
    public partial class DetalleProducto : System.Web.UI.Page
    {
        List<Producto> misProductos = new List<Producto>();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                Producto objeProducto = new Producto();
                misProductos = objeProducto.ConsultarProductos();

                //agregar los clientes en Grid
                gvProductos.DataSource = misProductos;
                gvProductos.DataBind();
            }





        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProductoCrear.aspx");
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {

            string id_producto_modificar = txtModificar.Text;
            Response.Redirect("ModificarProducto.aspx?ID=" + id_producto_modificar);


        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            string id_producto_modificar = txtModificar.Text;
            Response.Redirect("EliminarProducto.aspx?ID=" + id_producto_modificar);



        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTarea6
{
    public partial class EliminarProducto : System.Web.UI.Page
    {
        //creo la lista de clientes
        List<Producto> miProducto = new List<Producto>();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                Producto objProducto = new Producto();
            objProducto.idproducto = Convert.ToInt32(Request.QueryString["ID"]);

            miProducto = objProducto.ConsultarProducto();

            txtDescripcion.Text = miProducto[0].descripcion;
            txtPrecio.Text = miProducto[0].precio.ToString();
            txtMarca.Text = miProducto[0].marca;
            txtLote.Text = miProducto[0].lote;
            txtCodigoBarra.Text = miProducto[0].codigoBarra;
            txtFechaVencimiento.Text = miProducto[0].fechaVencimento;

            }

        }

        private void Limpiar()
        {
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtMarca.Text = "";
            txtLote.Text = "";
            txtCodigoBarra.Text = "";
            txtFechaVencimiento.Text =  "";

        }


        protected void btnEliminar_Click(object sender, EventArgs e)
        {


            try
            {
                Producto objproductoEliminar = new Producto();
                objproductoEliminar.idproducto = Convert.ToInt32(Request.QueryString["ID"]);

                //tratar de modificarlo en la base de datos.
                objproductoEliminar.EliminarProducto();
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

        protected void btnDetalle_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProductoCrear.aspx");
        }
    }
}
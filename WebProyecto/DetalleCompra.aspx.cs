using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTarea6
{
    public partial class DetalleCompra : System.Web.UI.Page
    {
        List<compraDetalle> ldCompra = new List<compraDetalle>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            int idcompra = int.Parse(txtCodigoCompra.Text);
            compraDetalle objedecompra = new compraDetalle();
            ldCompra = objedecompra.ConsultarDetalleCompra(idcompra);
            gvDetalleCompra.DataSource = ldCompra;
            gvDetalleCompra.DataBind();

          
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Compra.aspx");
        }
    }
}
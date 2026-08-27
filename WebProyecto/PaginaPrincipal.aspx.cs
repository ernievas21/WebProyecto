using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTarea6
{
    public partial class PaginaPrincipal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCliente_Click(object sender, EventArgs e)
        {
            Response.Redirect("CrearCLiente.aspx");
        }

        protected void btnProduto_Click(object sender, EventArgs e)
        {
            Response.Redirect("WSobrePeso.aspx");
            
        }

        protected void btnFactura_Click(object sender, EventArgs e)
        {
            Response.Redirect("Factura.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProductoCrear.aspx"); 
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Compra.aspx");
        }

        protected void btnControlAcceso_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuControlAcceso.aspx");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTarea6
{
    public partial class DetalleFactura : System.Web.UI.Page
    {
        List<detalle_factura> ldfactura = new List<detalle_factura>();
        protected void Page_Load(object sender, EventArgs e)
        {
            


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Factura.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            int idfactura =int.Parse(txtIdFactura.Text);
            detalle_factura objedefac = new detalle_factura();
            ldfactura = objedefac.ConsultarDetalleFactura(idfactura);

               
            gvDetalleFactura.DataSource = ldfactura;
            gvDetalleFactura.DataBind();
        }
    }
}
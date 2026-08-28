using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTarea6
{
    public partial class Factura : System.Web.UI.Page
    {
       //lista para buscar cliente y productos
        List<Cliente> miCliente = new List<Cliente>();
        List<Producto> miproductos = new List<Producto>();
        List<detalle_factura> ldfactura = new List<detalle_factura>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {


            Cliente objcliente = new Cliente();
            objcliente.idtcliente =int.Parse(txtidCliente.Text);

            miCliente = objcliente.ConsultarCliente();

            txtNombre.Text = miCliente[0].nombre;
            txtApellido.Text = miCliente[0].apellido;




       
        }

        protected void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            Producto objProducto = new Producto();
            objProducto.idproducto = int.Parse(txtidProducto.Text);
            miproductos = objProducto.ConsultarProducto();

            txtDescripcion.Text = miproductos[0].descripcion;
            txtPrecio.Text = miproductos[0].precio.ToString();


        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            int resultado;

            int precio = int.Parse( txtPrecio.Text);
            int cantidad = int.Parse( txtCantidad.Text);
            resultado = precio * cantidad;

            txtTotal.Text = resultado.ToString();
        }

        protected void tbnAgregar_Click(object sender, EventArgs e)
        {

            //declaro las clases 
            // encabezado 
            factura objfactura = new factura();
            objfactura.idfactura = int.Parse(txtcodigoFactura.Text);
            objfactura.fecha_factura = txtFecha.Text;
            objfactura.idcliente = int.Parse(txtidCliente.Text);
            objfactura.serie = txtSerie.Text;
            objfactura.tipo = txtTipo.Text;
            objfactura.id_tienda = int.Parse(txtid_tienda.Text);

            // tratar de insertar factura
            objfactura.CrearFactura();

          
            //detalle 

            //declaro las clases 
            // encabezado 
            detalle_factura objDetalleFactura = new detalle_factura();
            objDetalleFactura.idfactura =int.Parse( txtcodigoFactura.Text);
            objDetalleFactura.total =int.Parse( txtTotal.Text);
            objDetalleFactura.idproducto = int.Parse(txtidProducto.Text);
            objDetalleFactura.cantidad = int.Parse(txtCantidad.Text);

            //lista de facturar 

            ldfactura.Add(objDetalleFactura);
            gvEncabezado.DataSource = ldfactura;
            gvEncabezado.DataBind();
           


            //tratar de insertar factura detalle 
            objDetalleFactura.CrearFacturaDetalle();

            //reducir inventario 
            int idtienda = int.Parse(txtid_tienda.Text);
            int idproducto =int.Parse((string)txtidProducto.Text);
            int cantidadReducir = int.Parse((string)txtCantidad.Text);

            inventario objInventario = new inventario();
            string resultadoReduccion = objInventario.ReducirInventario(idtienda, idproducto, cantidadReducir);

            limpiar();
           
           

        }

        protected void tbnDetalle_Click(object sender, EventArgs e)
        {
            string idfactura  = txtcodigoFactura.Text;
            Response.Redirect("DetalleFactura.aspx");
           // Response.Redirect("DetalleFactura.aspx?ID=" + idfactura);




        }

        protected void btnPrincipal_Click(object sender, EventArgs e)
        {
            Response.Redirect("PaginaPrincipal.aspx");
        }


        public void limpiar ()
        {

            txtcodigoFactura.Text = " ";
            txtTotal.Text = "";
            txtidProducto.Text = "";
            txtCantidad.Text = "";
            txtidProducto.Text = "";

        }

    }
}
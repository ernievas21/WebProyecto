using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTarea6
{
    public partial class Compra : System.Web.UI.Page
    {
        //lista para buscar cliente y productos
        List<Proveedor> miProveedor = new List<Proveedor>();
        List<Producto> miproductos = new List<Producto>();
        List<compraDetalle> ldcompra = new List<compraDetalle>();
      
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {

          
            
            //declaro las clases 
            // encabezado 
            compra objcompra = new compra();
            objcompra.idcompra = int.Parse(txtIdCompra.Text);
            objcompra.idproveedor = int.Parse(txtCodigoProveedor.Text);
            objcompra.idcaja = int.Parse(txtCaja.Text);
            objcompra.descripcion = txtDescripcion.Text;
            objcompra.fecha_compra = txtfecha_compra.Text;
            // tratar de insertar factura
            objcompra.CrearCompra();

         

            compraDetalle objDetalleCompra = new compraDetalle();
            objDetalleCompra.idcompra = int.Parse(txtIdCompra.Text); 
            objDetalleCompra.idproducto = int.Parse(txtidProducto.Text);
            objDetalleCompra.descripcion = txtDescripcion.Text;
            objDetalleCompra.cantidad = int.Parse(txtCantidad.Text);
            objDetalleCompra.total = int.Parse(txtTotal.Text);

            //lista de facturar 

            ldcompra.Add(objDetalleCompra);
            gvEncabezado.DataSource = ldcompra;
            gvEncabezado.DataBind();



            //tratar de insertar factura detalle 
            objDetalleCompra.CrearCompraDetalle();


            //inventario 
            int idcompra = int.Parse(txtIdCompra.Text);
            int idproducto = int.Parse((string)txtidProducto.Text);
            int cantidadReducir = int.Parse((string)txtCantidad.Text);

            inventario objInventario = new inventario();
            string resultadoReduccion = objInventario.AumentarInventario(idcompra, idproducto, cantidadReducir);



        }

        protected void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            Producto objProducto = new Producto();
            objProducto.idproducto = int.Parse(txtidProducto.Text);
            miproductos = objProducto.ConsultarProducto();

            txtDescripcion.Text = miproductos[0].descripcion;
            txtPrecio.Text = miproductos[0].precio.ToString();


        }

        protected void btnBuscarProveedor_Click(object sender, EventArgs e)
        {

            Proveedor objcliente = new Proveedor();
            objcliente.idproveedor = int.Parse(txtCodigoProveedor.Text);

            miProveedor = objcliente.ConsultarProveedor();

            txtNombre.Text = miProveedor[0].nombre;
           


        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            int resultado;

            int precio = int.Parse(txtPrecio.Text);
            int cantidad = int.Parse(txtCantidad.Text);
            resultado = precio * cantidad;

            txtTotal.Text = resultado.ToString();


        }

        protected void Detalle_Click(object sender, EventArgs e)
        {
            Response.Redirect("DetalleCompra.aspx");
        }

        protected void btnMenu_Click(object sender, EventArgs e)
        {
            Response.Redirect("PaginaPrincipal.aspx");
        }
    }
}
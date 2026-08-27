using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTarea6
{
    public partial class ProductoCrear : System.Web.UI.Page
    {
        List<Producto> misProductos = new List<Producto>();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                Producto objeProducto = new Producto();
                misProductos = objeProducto.ConsultarProductos();

                //agregar los clientes en Grid
                //gvProductos.DataSource = misProductos;
                //gvProductos.DataBind();
            }



        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {

            try
            {
                //siempre se va tratar de ejecutar el codigo en esta seccion 

                Producto objproducto = new Producto();

                //objCliente.idCliente =  2;
                objproducto.descripcion = txtDescripcion.Text;
                objproducto.precio = Int32.Parse(txtPrecio.Text);
                objproducto.marca = txtMarca.Text;
                objproducto.lote = txtLote.Text;
                objproducto.codigoBarra = txtCodigoBarras.Text;
                objproducto.fechaVencimento = txtFechaVencimiento.Text;


                //tratar de insertar
                objproducto.CrearProducto();
                //objCliente.ObtenerUltimoIdInsertado();

                cargar();


            }
            catch (Exception)
            {

                
            }
            finally
            {
                //siempre se ejecuta despues de que se ejecute ya sea el try o el cath

                //Limpiar campos 
                Limpiar();

            }



        }

        private void Limpiar()
        {
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtMarca.Text = "";
            txtLote.Text= "";
            txtCodigoBarras.Text=" ";
            txtFechaVencimiento.Text="";

        }

        private void cargar()
        {
            Producto objeProducto = new Producto();
            misProductos = objeProducto.ConsultarProductos();

            //agregar los clientes en Grid
            //gvProductos.DataSource = misProductos;
            //gvProductos.DataBind();

        }

        protected void btnDetalle_Click(object sender, EventArgs e)
        {
            Response.Redirect("DetalleProducto.aspx");
        }

        protected void btnPrincipal_Click(object sender, EventArgs e)
        {
            Response.Redirect("PaginaPrincipal.aspx");
        }
    }
}
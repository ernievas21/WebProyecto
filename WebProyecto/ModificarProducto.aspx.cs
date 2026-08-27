using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTarea6
{
    public partial class ModificarProducto : System.Web.UI.Page
    {
       //creo la lista de clientes
        List<Producto> miProducto = new List<Producto>();
        
        protected void Page_Load(object sender, EventArgs e)
        {


            if(!IsPostBack)
            {

                Producto objProducto = new Producto();
                objProducto.idproducto = Convert.ToInt32(Request.QueryString["ID"]);

                miProducto = objProducto.ConsultarProducto();

                txtDescripcion.Text = miProducto[0].descripcion;
                txtPrecio.Text = miProducto[0].precio.ToString();
                txtMarca.Text = miProducto[0].marca;
                txtLote.Text = miProducto[0].lote;
                txtCodigoBarras.Text = miProducto[0].codigoBarra;
                txtFechaVencimiento.Text = miProducto[0].fechaVencimento;


            }
            





        }

       

       

        private void Limpiar()
        {
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtMarca.Text = "";
            txtLote.Text = "";
            txtCodigoBarras.Text = "";
            txtFechaVencimiento.Text =  "";

        }

       

        

        protected void btnModificar_Click1(object sender, EventArgs e)
        {
            try
            {
                //siempre se va tratar de ejecutar el codigo en esta seccion 

                Producto objProductoModificar = new Producto();

                objProductoModificar.idproducto = Convert.ToInt32(Request.QueryString["ID"]);
                objProductoModificar.descripcion= txtDescripcion.Text;

                objProductoModificar.precio = Int32.Parse(txtPrecio.Text);
                objProductoModificar.marca = txtMarca.Text;
                objProductoModificar.lote = txtLote.Text;
                objProductoModificar.codigoBarra = txtCodigoBarras.Text;
                objProductoModificar.fechaVencimento = txtFechaVencimiento.Text;


                //tratar de insertar
                objProductoModificar.ModificarProducto();


                //objCliente.ObtenerUltimoIdInsertado();





            }
            catch (Exception ex)
            {

                //esta sección siempre se ejecuta cuando existe un error en el try
                Session["Error"] = "Ha ocurrido un error " + ex.Message.ToString();
                Response.Redirect("ManejoErrores.aspx");


            }
            finally
            {
                //siempre se ejecuta despues de que se ejecute ya sea el try o el cath

                //Limpiar campos 
                Limpiar();

            }
        }

        protected void btnDetalle_Click(object sender, EventArgs e)
        {
            Response.Redirect("DetalleProducto.aspx");
        }
    }
}
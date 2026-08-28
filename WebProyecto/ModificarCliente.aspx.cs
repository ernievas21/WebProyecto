using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTarea6
{
    public partial class ModificarCliente : System.Web.UI.Page
    {
        //creo la lista de clientes
        List<Cliente> miCliente = new List<Cliente>();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                Cliente objcliente = new Cliente();
            objcliente.idtcliente = Convert.ToInt32(Request.QueryString["ID"]);

            miCliente = objcliente.ConsultarCliente();

            txtNombre.Text = miCliente[0].nombre;
            txtApellido.Text = miCliente[0].apellido;
            //txtDireccion.Text = miCliente[0].direccion.ToString();
            txttelefono.Text = miCliente[0].telefono.ToString();
            txtEdad.Text = miCliente[0].numero_cuenta.ToString();
           
            }

        }


        private void Limpiar()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txttelefono.Text = "";
            txtEdad.Text = "";
           
        }


        protected void BtnModificar_Click(object sender, EventArgs e)
        {


            try
            {
                //siempre se va tratar de ejecutar el codigo en esta seccion 

                Cliente  objClienteModificar = new Cliente();

                objClienteModificar.idtcliente = Convert.ToInt32(Request.QueryString["ID"]);
                objClienteModificar.nombre = txtNombre.Text;
                objClienteModificar.apellido = txtApellido.Text;
                objClienteModificar.direccion = txtDireccion.Text;
                objClienteModificar.telefono = Int32.Parse(txttelefono.Text);


                //tratar de insertar
                objClienteModificar.ModificarCliente();


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
                //Limpiar();
                Limpiar();
            }


        }

        protected void BtnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("DetalleCliente.aspx");
        }
    }
}
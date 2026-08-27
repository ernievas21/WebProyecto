using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace WebTarea6
{
    public class inventario
    {

        public int idinventario { get; set; }
        public int idfactura { get; set; }

        public int idproducto { get; set; }

        public int idbodega     { get; set; }

        public int cantidad { get; set; }
        public int idcompra { get; set; }
        
        //instanciando clases externas 
        private ConexionBBD conexion = new ConexionBBD();
        private Utilitario objUtiliario = new Utilitario();

        //  private Utilitarios objUtilitarios = new Utilitarios();

        //variables para la clase 
        string SrtSQL = String.Empty;

        // variable resultado 
        string srtResul = String.Empty;

        string strResultado = String.Empty;

        public inventario()
        {

        }


        // Obtener datos de la base de datos 
        public List<inventario> ConsultarInventario()
        {
            DataTable dtDatos = new DataTable();
            SrtSQL = "SELECT * FROM inventario";

            //EJECUTAR LA CONSULTA 
            dtDatos = conexion.SeleccionarRegistrosDT(SrtSQL);
            List<inventario> ListaInventario = new List<inventario>();
            ListaInventario = objUtiliario.ConvertirDataTable<inventario>(dtDatos);

            return ListaInventario;
        }

        public string ReducirInventario(int idfactura, int idProducto, int cantidadReducir)
        {
            // Validar si la cantidad a reducir es válida
            SrtSQL = $"SELECT cantidad FROM inventario WHERE idfactura = {idfactura} AND idproducto = {idProducto}";
            DataTable dtDatos = conexion.SeleccionarRegistrosDT(SrtSQL);

            if (dtDatos.Rows.Count == 0)
            {
                return "Producto no encontrado en el inventario de la tienda especificada.";
            }

            int cantidadActual = Convert.ToInt32(dtDatos.Rows[0]["cantidad"]);

            if (cantidadActual < cantidadReducir)
            {
                return "Cantidad insuficiente en el inventario.";
            }

            // Reducir la cantidad en el inventario
            int nuevaCantidad = cantidadActual - cantidadReducir;
            SrtSQL = $"UPDATE inventario SET cantidad = {nuevaCantidad} WHERE idfactura = {idfactura} AND idproducto = {idProducto}";

            try
            {
                conexion.EjecutarComando(SrtSQL);
                return "Inventario actualizado exitosamente.";
            }
            catch (Exception ex)
            {
                return "Error al actualizar el inventario: " + ex.Message;
            }
        }

        //metodo para aumentar inventario de compras 
        
        //inicio 
        public string AumentarInventario(int idcompra, int idProducto, int cantidadReducir)
        {
            // Validar si la cantidad a reducir es válida
            SrtSQL = $"SELECT cantidad FROM inventario WHERE idcompra = {idcompra} AND idproducto = {idProducto}";
            DataTable dtDatos = conexion.SeleccionarRegistrosDT(SrtSQL);

            if (dtDatos.Rows.Count == 0)
            {
                return "Producto no encontrado en el inventario de la caja especificada.";
            }

            int cantidadActual = Convert.ToInt32(dtDatos.Rows[0]["cantidad"]);

            if (cantidadActual < cantidadReducir)
            {
                return "Cantidad insuficiente en el inventario.";
            }

            // Aumentar la cantidad en el inventario
            int nuevaCantidad = cantidadActual + cantidadReducir;
            SrtSQL = $"UPDATE inventario SET cantidad = {nuevaCantidad} WHERE idcompra = {idcompra} AND idproducto = {idProducto}";

            try
            {
                conexion.EjecutarComando(SrtSQL);
                return "Inventario actualizado exitosamente.";
            }
            catch (Exception ex)
            {
                return "Error al actualizar el inventario: " + ex.Message;
            }
        }



        //fin 


    }
}
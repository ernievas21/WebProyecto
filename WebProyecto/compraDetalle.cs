using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace WebTarea6
{
    public class compraDetalle
    {
        public int iddetalle_compra { get; set; }
        public int idcompra { get; set; }
        public int idproducto { get; set; }
        public string descripcion { get; set; }
        public int cantidad { get; set; }

        public int total { get; set; }

        public compraDetalle ()
         {

         }

        //instanciando clases externas 
        private ConexionBBD conexion = new ConexionBBD();
        private Utilitario objUtiliario = new Utilitario();
        //variables para la clase 
        string SrtSQL = String.Empty;

        // variable resultado 
        string srtResul = String.Empty;

        string strResultado = String.Empty;


        //metodo de insretar campos 
        public string CrearCompraDetalle()
        {
            string srtSecuencia = string.Empty;

            SrtSQL = "INSERT INTO detalle_compra";
            SrtSQL += " (idcompra, idproducto,descripcion, cantidad, total)";
            SrtSQL += "VALUES (@Pidcompra, @Pidproducto, @Pdescripcion, @Pcantidad,@Ptotal)";

            //insertar datos del objeto 
            SrtSQL = SrtSQL.Replace("@Pidcompra", "'" + idcompra + "'");
            SrtSQL = SrtSQL.Replace("@Pidproducto", "'" + idproducto + "'");
            SrtSQL = SrtSQL.Replace("@Pdescripcion", "'" + descripcion + "'");
            SrtSQL = SrtSQL.Replace("@Pcantidad", "'" + cantidad + "'");
            SrtSQL = SrtSQL.Replace("@Ptotal", "'" + total + "'");

            //Ejecutar consulta 
            strResultado = conexion.EjecutarComando(SrtSQL);


            if (strResultado == "OK")
            {
                srtSecuencia = conexion.ObtenerUltimoIdInsertado();
                return srtSecuencia;
            }
            else
                return strResultado;

        }


        public List<compraDetalle> ConsultarDetalleCompra(int idcompra)
        {
            DataTable dtDatos = new DataTable();
            SrtSQL = "SELECT * FROM detalle_compra where idcompra =@Pidcompra";
            SrtSQL = SrtSQL.Replace("@Pidcompra", "'" + idcompra + "'");

            //EJECUTAR LA CONSULTA 
            dtDatos = conexion.SeleccionarRegistrosDT(SrtSQL);
            List<compraDetalle> ListaCompra = new List<compraDetalle>();
            ListaCompra = objUtiliario.ConvertirDataTable<compraDetalle>(dtDatos);

            return ListaCompra;
        }








    }
}
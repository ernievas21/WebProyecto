using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace WebTarea6
{
    public class detalle_factura
    {

        //variables 
        public int iddetalle_factura { get; set; }
        public int total { get; set; }
        public int idproducto { get; set; }
        public int cantidad { get; set; }   
        public int idfactura { get; set; }

        //instanciando clases externas 
        private ConexionBBD conexion = new ConexionBBD();
        private Utilitario objUtiliario = new Utilitario();
        //variables para la clase 
        string SrtSQL = String.Empty;

        // variable resultado 
        string srtResul = String.Empty;

        string strResultado = String.Empty;


        //metodo de insretar campos 
        public string CrearFacturaDetalle()
        {
            string srtSecuencia = string.Empty;

            SrtSQL = "INSERT INTO tdetalle_factura";
            SrtSQL += " (total, idproducto, cantidad, idfactura)";
            SrtSQL += "VALUES (@Ptotal, @Pidproducto, @Pcantidad, @Pidfactura)";

            //insertar datos del objeto 
            SrtSQL = SrtSQL.Replace("@Ptotal", "'" + total + "'");
            SrtSQL = SrtSQL.Replace("@Pidproducto", "'" + idproducto + "'");
            SrtSQL = SrtSQL.Replace("@Pcantidad", "'" + cantidad + "'");
            SrtSQL = SrtSQL.Replace("@Pidfactura", "'" + idfactura + "'");

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

        public List<detalle_factura> ConsultarDetalleFactura(int idfactura)
        {
            DataTable dtDatos = new DataTable();
            SrtSQL = "SELECT * FROM tdetalle_factura where idfactura =@Pidfactura";
            SrtSQL = SrtSQL.Replace("@Pidfactura", "'" + idfactura + "'");

            //EJECUTAR LA CONSULTA 
            dtDatos = conexion.SeleccionarRegistrosDT(SrtSQL);
            List<detalle_factura> Listafactura = new List<detalle_factura>();
            Listafactura = objUtiliario.ConvertirDataTable<detalle_factura>(dtDatos);

            return Listafactura;
        }






    }
}
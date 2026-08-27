using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace WebTarea6
{
    public class factura
    {
        //atributos 
        public int idfactura { get; set; }
        public string fecha_factura { get; set; }
        public int idcliente { get; set; }

        public string serie { get; set; }
        public string tipo { get; set; }
        public int id_tienda { get; set; }

        //instanciando clases externas 
        private ConexionBBD conexion = new ConexionBBD();
        private Utilitario objUtiliario = new Utilitario();
        //variables para la clase 
        string SrtSQL = String.Empty;

        // variable resultado 
        string srtResul = String.Empty;

        string strResultado = String.Empty;


        public factura()
        {

        }


        //consultar facuras

        public List<factura> ConsultarFacturas()
        {
            DataTable dtDatos = new DataTable();
            SrtSQL = "SELECT * FROM tfactura";

            //EJECUTAR LA CONSULTA 
            dtDatos = conexion.SeleccionarRegistrosDT(SrtSQL);
            List<factura> ListaFacturas = new List<factura>();
            ListaFacturas = objUtiliario.ConvertirDataTable<factura>(dtDatos);

            return ListaFacturas;
        }
        // consultar una factura 

        public List<factura> ConsultarFactura()
        {
            DataTable dtDatos = new DataTable();
            SrtSQL = "SELECT * FROM tfactura where idfactura =@Pidfactura";
            SrtSQL = SrtSQL.Replace("@Pidfactura", "'" + idfactura + "'");

            //EJECUTAR LA CONSULTA 
            dtDatos = conexion.SeleccionarRegistrosDT(SrtSQL);
            List<factura> Listafactura = new List<factura>();
            Listafactura = objUtiliario.ConvertirDataTable<factura>(dtDatos);

            return Listafactura;
        }


        public string CrearFactura()
        {
            string srtSecuencia = string.Empty;

            SrtSQL = "INSERT INTO tfactura";
            SrtSQL += " (idfactura,fecha_factura, idcliente, serie, tipo,id_tienda)";
            SrtSQL += "VALUES (@idfactura,@Pfecha_factura, @Pidcliente, @Pserie, @Ptipo,@Pid_tienda)";

            //insertar datos del objeto 
            SrtSQL = SrtSQL.Replace("@idfactura", "'" + idfactura + "'");
            SrtSQL = SrtSQL.Replace("@Pfecha_factura", "'" + fecha_factura + "'");
            SrtSQL = SrtSQL.Replace("@Pidcliente", "'" + idcliente + "'");
            SrtSQL = SrtSQL.Replace("@Pserie", "'" + serie + "'");
            SrtSQL = SrtSQL.Replace("@Ptipo", "'" + tipo + "'");
            SrtSQL = SrtSQL.Replace("@Pid_tienda", "'" + id_tienda + "'");

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

        public List<Cliente> extraerNombre( int idcliente)
        {
            DataTable dtDatos = new DataTable();
            SrtSQL = "SELECT nombre FROM tcliente where idcliente =@Pidcliente";
            SrtSQL = SrtSQL.Replace("@Pidcliente", "'" + idcliente + "'");

            //EJECUTAR LA CONSULTA 
            dtDatos = conexion.SeleccionarRegistrosDT(SrtSQL);
            //  return dtDatos.ToString();

            List<Cliente> Listafactura = new List<Cliente>();
            Listafactura = objUtiliario.ConvertirDataTable<Cliente>(dtDatos);


            //strResultado = Convert.ToString(dtDatos);

            return Listafactura;
            //return strResultado = conexion.EjecutarComando(SrtSQL);

        }

        public List<Cliente> ConsultarNombrecli( int idcliente)
        {
            DataTable dtDatos = new DataTable();
            SrtSQL = "SELECT nombre FROM tcliente where idcliente =@Pidcliente";
            SrtSQL = SrtSQL.Replace("@Pidcliente", "'" + idcliente + "'");

            //EJECUTAR LA CONSULTA 
            dtDatos = conexion.SeleccionarRegistrosDT(SrtSQL);
            List<Cliente> Listafactura = new List<Cliente>();
            Listafactura = objUtiliario.ConvertirDataTable<Cliente>(dtDatos);

            return Listafactura;
        }



    }





}
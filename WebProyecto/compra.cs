using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace WebTarea6
{
    public class compra
    {
        //atributos 
        public int idcompra { get; set; }
        public int idproveedor { get; set; }
        public int idcaja { get; set; }
        public string descripcion { get; set; }
        public string fecha_compra { get; set; }

        //instanciando clases externas 
        private ConexionBBD conexion = new ConexionBBD();
        private Utilitario objUtiliario = new Utilitario();
        //variables para la clase 
        string SrtSQL = String.Empty;

        // variable resultado 
        string srtResul = String.Empty;

        string strResultado = String.Empty;

        public compra()
        {

        }

        public List<compra> ConsultarCompras()
        {
            DataTable dtDatos = new DataTable();
            SrtSQL = "SELECT * FROM compra";

            //EJECUTAR LA CONSULTA 
            dtDatos = conexion.SeleccionarRegistrosDT(SrtSQL);
            List<compra> ListaCompras = new List<compra>();
            ListaCompras = objUtiliario.ConvertirDataTable<compra>(dtDatos);

            return ListaCompras;
        }

        // consultar una compra

        public List<compra> ConsultarCompra()
        {
            DataTable dtDatos = new DataTable();
            SrtSQL = "SELECT * FROM compra where idcompra =@Pidcompra";
            SrtSQL = SrtSQL.Replace("@Pidcompra", "'" + idcompra + "'");

            //EJECUTAR LA CONSULTA 
            dtDatos = conexion.SeleccionarRegistrosDT(SrtSQL);
            List<compra> Listacompra = new List<compra>();
            Listacompra = objUtiliario.ConvertirDataTable<compra>(dtDatos);

            return Listacompra;
        }

        //crear compra 

        public string CrearCompra()
        {
            string srtSecuencia = string.Empty;

            SrtSQL = "INSERT INTO compra";
            SrtSQL += " (idcompra,idproveedor,idcaja,descripcion,fecha_compra)";
            SrtSQL += "VALUES (@Pidcompra,@Pidproveedor, @Pidcaja, @Pdescripcion,@Pfecha_compra)";

            //insertar datos del objeto 
            SrtSQL = SrtSQL.Replace("@Pidcompra", "'" + idcompra + "'");
            SrtSQL = SrtSQL.Replace("@Pidproveedor", "'" + idproveedor + "'");
            SrtSQL = SrtSQL.Replace("@Pidcaja", "'" + idcaja + "'");
            SrtSQL = SrtSQL.Replace("@Pdescripcion", "'" + descripcion + "'");
            SrtSQL = SrtSQL.Replace("@Pfecha_compra", "'" + fecha_compra + "'");

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
        // extrar nombre proveedor 
        public List<Proveedor> extraerNombre(int idproveedor)
        {
            DataTable dtDatos = new DataTable();
            SrtSQL = "SELECT nombre FROM proveedor where idproveedor =@Pidproveedor";
            SrtSQL = SrtSQL.Replace("@Pidproveedor", "'" + idproveedor + "'");

            //EJECUTAR LA CONSULTA 
            dtDatos = conexion.SeleccionarRegistrosDT(SrtSQL);
            //  return dtDatos.ToString();

            List<Proveedor> Listacompra = new List<Proveedor>();
            Listacompra = objUtiliario.ConvertirDataTable<Proveedor>(dtDatos);

            //strResultado = Convert.ToString(dtDatos);}
            return Listacompra;
            //return strResultado = conexion.EjecutarComando(SrtSQL);

        }








    }
}
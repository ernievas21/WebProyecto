using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace WebTarea6
{
    public class Proveedor
    {

        public int idproveedor { get; set; }

        public string nombre { get; set; }
        public string direccion { get; set; }
        public int telefono { get; set; }
        public DateTime fecha_fundacion { get; set; }
        public int anos { get; set; }


        //instanciando clases externas 
        private ConexionBBD conexion = new ConexionBBD();
        private Utilitario objUtiliario = new Utilitario();

        //  private Utilitarios objUtilitarios = new Utilitarios();

        //variables para la clase 
        string SrtSQL = String.Empty;

        // variable resultado 
        string srtResul = String.Empty;

        string strResultado = String.Empty;



        // Obtener solo un dato de la base de datos 

        public List<Proveedor> ConsultarProveedor()
        {
            DataTable dtDatos = new DataTable();
            SrtSQL = "SELECT * FROM proveedor where idproveedor =@Pidproveedor";
            SrtSQL = SrtSQL.Replace("@Pidproveedor", "'" + idproveedor + "'");


            //EJECUTAR LA CONSULTA 
            dtDatos = conexion.SeleccionarRegistrosDT(SrtSQL);
            List<Proveedor> Listaproveedores = new List<Proveedor>();
            Listaproveedores = objUtiliario.ConvertirDataTable<Proveedor>(dtDatos);

            return Listaproveedores;
        }

    }
}
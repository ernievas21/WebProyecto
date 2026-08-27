using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace WebTarea6
{
    public class emplados
    {
        public int idempleado { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }

        public string direccion { get; set; }

        public int edad { get; set; }

        public DateTime fechaNacimiento { get; set; }

        public int sueldo { get; set; }


        //instanciando clases externas 
        private ConexionBBD conexion = new ConexionBBD();
        private Utilitario objUtiliario = new Utilitario();
        //  private Utilitarios objUtilitarios = new Utilitarios();

        //variables para la clase 
        string SrtSQL = String.Empty;

        // variable resultado 
        string srtResul = String.Empty;

        string strResultado = String.Empty;

        public emplados()
         {

         }


        // Obtener datos de la base de datos 
        public List<emplados> ConsultarEmpleados()
        {
            DataTable dtDatos = new DataTable();
            SrtSQL = "SELECT * FROM empleado";

            //EJECUTAR LA CONSULTA 
            dtDatos = conexion.SeleccionarRegistrosDT(SrtSQL);
            List<emplados> ListaEmpleados = new List<emplados>();
            ListaEmpleados = objUtiliario.ConvertirDataTable<emplados>(dtDatos);

            return ListaEmpleados;
        }




    }
}
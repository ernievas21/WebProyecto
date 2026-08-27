using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace WebTarea6
{


    //Interfaz de Usuario 
    //metodo para validar el empleado.
    public interface IUsuario
    {
        string estado_Usuario(char estado);
    }

    //Muestre los atributos de la Interfaz
    public class Usuario:IUsuario
    {

        public int idUsuario { get; set; }
        public string fechaAlta { get; set; }
        public string fechaBaja { get; set; }
        public string estado { get; set; }
        public int idempleado { get; set; }

        //instanciando clases externas 
        private ConexionBBD conexion = new ConexionBBD();
        private Utilitario objUtiliario = new Utilitario();
        //  private Utilitarios objUtilitarios = new Utilitarios();

        //variables para la clase 
        string SrtSQL = String.Empty;

        // variable resultado 
        string srtResul = String.Empty;

        string strResultado = String.Empty;

        public Usuario()
        {
                
        }

        public string estado_Usuario(char estado)
        {
            if (estado == 'A')
            {
                return "Usuario Activo";
            }
            else
            {
                return "Usuario Inactivo";
            }


        }


        // Obtener datos de la base de datos 
        public List<Usuario> ConsultarUsuario()
        {
            DataTable dtDatos = new DataTable();
            SrtSQL = "SELECT * FROM usuario";

            //EJECUTAR LA CONSULTA 
            dtDatos = conexion.SeleccionarRegistrosDT(SrtSQL);
            List<Usuario> ListaUsuarios = new List<Usuario>();
            ListaUsuarios = objUtiliario.ConvertirDataTable<Usuario>(dtDatos);

            return ListaUsuarios;
        }





    }
}
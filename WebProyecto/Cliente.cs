using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace WebTarea6
{
    public class Cliente
    {


        //Atributos 

        //Si queremos usar los atriutos para el usuario hay que usar GET Y SET

        public int idtcliente { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string direccion { get; set; }
        public int telefono { get; set; }
        public int numero_cuenta { get; set; }

        //instanciando clases externas 
        private ConexionBBD conexion = new ConexionBBD();
        private Utilitario objUtiliario = new Utilitario();

      //  private Utilitarios objUtilitarios = new Utilitarios();

        //variables para la clase 
        string SrtSQL = String.Empty;

        // variable resultado 
        string srtResul = String.Empty;

        string strResultado = String.Empty;



        //contructor en blanco 
        public Cliente()
        {

        }


        //CRUD 

        // insertar datos de la base de datos 
        public string CrearCliente()
        {
            string srtSecuencia = string.Empty;
            
            SrtSQL = "INSERT INTO tcliente";
            SrtSQL += " (nombre, apellido, direccion, telefono, numero_cuenta)";
            SrtSQL += "VALUES (@Pnombre, @Papellido, @Pdireccion, @Ptelefono, @Pnumero_cuenta)";

            //insertar datos del objeto 
            SrtSQL = SrtSQL.Replace("@Pnombre","'"+ nombre +"'");
            SrtSQL = SrtSQL.Replace("@Papellido", "'" + apellido + "'");
            SrtSQL = SrtSQL.Replace("@Pdireccion", "'" + direccion + "'");
            SrtSQL = SrtSQL.Replace("@Ptelefono", "'" + telefono + "'");
            SrtSQL = SrtSQL.Replace("@Pnumero_cuenta", "'" + numero_cuenta + "'");
            
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


        // Obtener datos de la base de datos 
        public List<Cliente> ConsultarClientes()
        {
            DataTable dtDatos = new DataTable();
            SrtSQL = "SELECT * FROM mydb.tcliente";

            //EJECUTAR LA CONSULTA 
            dtDatos =  conexion.SeleccionarRegistrosDT(SrtSQL);
            List<Cliente> Listaclientes = new List<Cliente>();
            Listaclientes = objUtiliario.ConvertirDataTable<Cliente>(dtDatos);

            return Listaclientes;
        }




        // Obtener solo un dato de la base de datos 

        public List<Cliente> ConsultarCliente()
        {
            DataTable dtDatos = new DataTable();
            SrtSQL = "SELECT * FROM mydb.tcliente where idtcliente =@Pidtcliente";
            SrtSQL = SrtSQL.Replace("@Pidtcliente", "'" + idtcliente + "'");



            //EJECUTAR LA CONSULTA 
            dtDatos = conexion.SeleccionarRegistrosDT(SrtSQL);
            List<Cliente> Listaclientes = new List<Cliente>();
            Listaclientes = objUtiliario.ConvertirDataTable<Cliente>(dtDatos);

            return Listaclientes;
        }


        //Actulizar datos de la base de datos 

        public string ModificarCliente()
        {
            SrtSQL = " UPDATE tcliente";
            SrtSQL += " SET nombre = @Pnombre, ";
            SrtSQL += "     apellido = @Papellido, ";
            SrtSQL += "     direccion = @Pdireccion, ";
            SrtSQL += "     telefono = @Ptelefono, ";
            SrtSQL += "     numero_cuenta = @Pnumero_cuenta ";
            SrtSQL += " WHERE idtcliente = @Pidtcliente";

            SrtSQL = SrtSQL.Replace("@Pidtcliente", "" + idtcliente + "");
            SrtSQL = SrtSQL.Replace("@Pnombre", "'" + nombre + "'");
            SrtSQL = SrtSQL.Replace("@Papellido", "'" + apellido + "'");
            SrtSQL = SrtSQL.Replace("@Pdireccion", "'" + direccion + "'");
            SrtSQL = SrtSQL.Replace("@Ptelefono", "'" + telefono + "'");
            SrtSQL = SrtSQL.Replace("@Pnumero_cuenta", "" + numero_cuenta + "");

            strResultado = conexion.EjecutarComando(SrtSQL);
            return strResultado;

           
        }



        //Eliminar datos de la base de datos 
        public string EliminarCliente()
        {
            SrtSQL = " DELETE FROM tcliente";
            SrtSQL += " WHERE idtcliente = @Pidtcliente ";

            SrtSQL = SrtSQL.Replace("@Pidtcliente", "'" + idtcliente + "'");

            //Ejecutar consulta
            strResultado = conexion.EjecutarComando(SrtSQL);
            return strResultado;

            
        }







        //----------------------------//
        //clase persona 
        Persona nueva_Persona = new Persona();
        
       
       

        //Metodos 
        public bool agregarLCiente(int id_cliente)
        {
            return true;


        }
        public string quejaCLiente(char queja)
        {
            if (queja == 'S')
                return "El cliente se quejo";
            else
                return "Buen Servicio";
        }






    }
}
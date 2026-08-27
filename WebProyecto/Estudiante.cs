using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace WebTarea6
{
    public class Estudiante
    {


        //Atributos 
        //public int idCliente;
        //public string nombre;
        //public string apellido;
        //public string direccion;
        //public int telefono;

        //Si queremos usar los atriutos para el usuario hay que usar GET Y SET

        public int idtEstudiante { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int  altura { get; set; }
        public int peso { get; set; }
        public int edad { get; set; }

        public string genero { get; set; }

        public int sobrepeso { get; set; }

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
        public Estudiante()
        {

        }


        //CRUD 

        // insertar datos de la base de datos 
        public string CrearEstudiante()
        {
            string srtSecuencia = string.Empty;
            
            SrtSQL = "INSERT INTO testudiante";
            SrtSQL += " (nombre, apellido, altura, peso,edad, genero,sobrepeso)";
            SrtSQL += "VALUES (@Pnombre, @Papellido, @altura, @peso,@Pedad,@Pgenero,@Psobrepeso)";

            //insertar datos del objeto 
            SrtSQL = SrtSQL.Replace("@Pnombre","'"+ nombre +"'");
            SrtSQL = SrtSQL.Replace("@Papellido", "'" + apellido + "'");
            SrtSQL = SrtSQL.Replace("@altura", "'" + altura + "'");
            SrtSQL = SrtSQL.Replace("@peso", "'" + peso + "'");
            SrtSQL = SrtSQL.Replace("@Pedad", "'" + edad + "'");
            SrtSQL = SrtSQL.Replace("@Pgenero", "'" + genero + "'");
            SrtSQL = SrtSQL.Replace("@Psobrepeso", "'" + sobrepeso + "'");

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
        public List<Estudiante> ConsultarEstudiantes()
        {
            DataTable dtDatos = new DataTable();
            SrtSQL = "SELECT * FROM testudiante";

            //EJECUTAR LA CONSULTA 
            dtDatos =  conexion.SeleccionarRegistrosDT(SrtSQL);
            List<Estudiante> Listaestudiantes = new List<Estudiante>();
            Listaestudiantes = objUtiliario.ConvertirDataTable<Estudiante>(dtDatos);

            return Listaestudiantes;
        }




        // Obtener solo un dato de la base de datos 

        public List<Estudiante> ConsultarEstudiante()
        {
            DataTable dtDatos = new DataTable();
            SrtSQL = "SELECT * FROM testudiante where idtEstudiante =@PidtEstudiante";
            SrtSQL = SrtSQL.Replace("@PidtEstudiante", "'" + idtEstudiante + "'");



            //EJECUTAR LA CONSULTA 
            dtDatos = conexion.SeleccionarRegistrosDT(SrtSQL);
            List<Estudiante> Listaestudiantes = new List<Estudiante>();
            Listaestudiantes = objUtiliario.ConvertirDataTable<Estudiante>(dtDatos);

            return Listaestudiantes;
        }


        //Actulizar datos de la base de datos 

        public string ModificarEstudiante()
        {
            SrtSQL = " UPDATE testudiante";
            SrtSQL += " SET nombre = @Pnombre, ";
            SrtSQL += "     apellido = @Papellido, ";
            SrtSQL += "     altura = @Paltura, ";
            SrtSQL += "     peso = @Ppeso, ";
            SrtSQL += "     edad = @Pedad, ";
            SrtSQL += "     genero = @Pgenero,";
            SrtSQL += "     sobrepeso = @Psobrepeso";
            SrtSQL += " WHERE idtEstudiante = @PidtEstudiante ";

            SrtSQL = SrtSQL.Replace("@PidtEstudiante", "'" + idtEstudiante + "'");
            SrtSQL = SrtSQL.Replace("@Pnombre", "'" + nombre + "'");
            SrtSQL = SrtSQL.Replace("@Papellido", "'" + apellido + "'");
            SrtSQL = SrtSQL.Replace("@Paltura", "'" + altura + "'");
            SrtSQL = SrtSQL.Replace("@Ppeso", "'" + peso + "'");
            SrtSQL = SrtSQL.Replace("@Pedad", "'" + edad + "'");
            SrtSQL = SrtSQL.Replace("@Pgenero", "'" + genero + "'");
            SrtSQL = SrtSQL.Replace("@Psobrepeso", "'" + sobrepeso + "'");

            strResultado = conexion.EjecutarComando(SrtSQL);
            return strResultado;

           
        }





        //Eliminar datos de la base de datos 
        public string EliminarEstudiante()
        {
            SrtSQL = " DELETE FROM testudiante";
            SrtSQL += " WHERE idtEstudiante = @PidtEstudiante ";

            SrtSQL = SrtSQL.Replace("@PidtEstudiante", "'" + idtEstudiante + "'");

            //Ejecutar consulta
            strResultado = conexion.EjecutarComando(SrtSQL);
            return strResultado;

            
        }







        //----------------------------//
        //clase persona 
        Persona nueva_Persona = new Persona();
        
        //mando a llamar los metodos de otra clase
        public string DeterminarEdad ()
        {
            return nueva_Persona.estatusEdad(edad);
        }
        public string DeterminarComplexion ()
        {
            return nueva_Persona.ObtenerComplexion(peso);
        }

        public int  SobrePeso()
        {
            return nueva_Persona.sobrePeso(peso);
        }



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
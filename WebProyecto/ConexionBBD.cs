using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//libreria de base de datos 
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace WebTarea6
{

    // CONEXION DE BASE DE DATOS DESDE UN PUNTO UNICO ENCUENTRO
    public class ConexionBBD
    {

        private string gSrtConn;
        private MySqlConnection Conn;
        private MySqlDataAdapter daDatos;


        public ConexionBBD()
        {
            Conn = new MySqlConnection();
            try
            {
                Conn.ConnectionString = ConfigurationManager.ConnectionStrings["CadenaConexion"].ConnectionString;
                gSrtConn = Conn.ConnectionString;

                //trate de abriri la base de datos 
                Conn.Open();
                // Cierre de conexion de base de datos 
                Conn.Close();

            }
            catch (MySqlException error)
            {
                throw error;
            }

        }


        public DataTable SeleccionarRegistrosDT(string strSQL)
        {
            DataTable dtDatos = new DataTable();

            try
            {
                //obtener los datos 
                dtDatos.Reset();//dataLimpia

                Conn = new MySqlConnection();
                Conn.ConnectionString = gSrtConn;
                Conn.Open();

                daDatos = new MySqlDataAdapter(strSQL, Conn);
                daDatos.Fill(dtDatos);



            }
            catch (MySqlException ex)
            {
                dtDatos.Reset();
                //se va agregar una columna de error 
                dtDatos.TableName = "Error";
                dtDatos.Columns.Add("ERROR_DESC");
                dtDatos.Rows.Add();
                dtDatos.Rows[0]["ERROR_DESC"] = "Error " + ex.Message;
                
            }
            finally
            {
                //seguridad 
                Conn.Close();
            }
            return dtDatos.Copy();


        }

        public string EjecutarComando(string strSQL)
        {
            string strRespuesta = string.Empty;

            try
            {
                //ejecutar comando 
                Conn = new MySqlConnection();
                Conn.ConnectionString = gSrtConn;

                //Abrir la conexion 
                Conn.Open();
                //comando para instancia de sql 
                MySqlCommand comando = new MySqlCommand(strSQL, Conn);
                comando.ExecuteNonQuery();
               
                Conn.Close();
                // si funciona bien 
                strRespuesta = "OK";
            }
            catch(MySqlException ex )
            {
                //cerramos la base de datos
                Conn.Close();
                strRespuesta = "Error:" + ex.Message;
            }

            return strRespuesta;
        }

        public string ObtenerUltimoIdInsertado()
        {

            string strResultado = string.Empty;
            string strSQL = string.Empty;
            DataTable dtDatos = new DataTable();

            strSQL = "SELECT LAST_INSERT_ID(); ";

            //METODO EJECUTA LA CONSULTA 
            dtDatos = SeleccionarRegistrosDT(strSQL);

            strResultado = dtDatos.Rows[0]["LAST_INSERT_ID()"].ToString();

            return strResultado;
        }
    }
}
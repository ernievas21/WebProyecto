using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace WebTarea6
{
    public class Producto
    {

        //variables 
        public int idproducto { get; set; }
        public string descripcion { get; set; }
        public int precio { get; set; }

        public string marca { get; set; }

        public string lote { get; set; }

        public string codigoBarra { get; set; }

        public string fechaVencimento { get; set; }

        //instanciando clases externas 
        private ConexionBBD conexion = new ConexionBBD();
        private Utilitario objUtiliario = new Utilitario();

        //  private Utilitarios objUtilitarios = new Utilitarios();

        //variables para la clase 
        string SrtSQL = String.Empty;

        // variable resultado 
        string srtResul = String.Empty;

        string strResultado = String.Empty;

        //metodos para realizar el crud 

        //contructor en blanco 
        public Producto()
        {

        }

        // insertar datos de la base de datos 
        public string CrearProducto()
        {
            string srtSecuencia = string.Empty;

            SrtSQL = "INSERT INTO tproducto";
            SrtSQL += " (descripcion, precio, marca,lote,codigoBarra,fechaVencimento)";
            SrtSQL += "VALUES (@Pdescripcion, @Pprecio, @Pmarca,@Plote,@PcodigoBarra,@PfechaVencimento)";

            //insertar datos del objeto 
            SrtSQL = SrtSQL.Replace("@Pdescripcion", "'" + descripcion + "'");
            SrtSQL = SrtSQL.Replace("@Pprecio", "'" + precio + "'");
            SrtSQL = SrtSQL.Replace("@Pmarca", "'" + marca + "'");
            SrtSQL = SrtSQL.Replace("@Plote", "'" + lote + "'");
            SrtSQL = SrtSQL.Replace("@PcodigoBarra", "'" + codigoBarra + "'");
            SrtSQL = SrtSQL.Replace("@PfechaVencimento", "'" + fechaVencimento + "'");
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
        public List<Producto> ConsultarProductos()
        {
            DataTable dtDatos = new DataTable();
            SrtSQL = "SELECT * FROM tproducto";

            //EJECUTAR LA CONSULTA 
            dtDatos = conexion.SeleccionarRegistrosDT(SrtSQL);
            List<Producto> ListacProductos = new List<Producto>();
            ListacProductos = objUtiliario.ConvertirDataTable<Producto>(dtDatos);

            return ListacProductos;
        }

        // Obtener solo un dato de la base de datos 

        public List<Producto> ConsultarProducto()
        {
            DataTable dtDatos = new DataTable();
            SrtSQL = "SELECT * FROM tproducto where idproducto =@Pidproducto";
            SrtSQL = SrtSQL.Replace("@Pidproducto", "'" + idproducto + "'");



            //EJECUTAR LA CONSULTA 
            dtDatos = conexion.SeleccionarRegistrosDT(SrtSQL);
            List<Producto> Listaproductos = new List<Producto>();
            Listaproductos = objUtiliario.ConvertirDataTable<Producto>(dtDatos);

            return Listaproductos;
        }


        //Actulizar datos de la base de datos 

        public string ModificarProducto()
        {
            SrtSQL = " UPDATE tproducto";
            SrtSQL += " SET descripcion = @Pdescripcion, ";
            SrtSQL += "     precio = @Pprecio, ";
            SrtSQL += "     marca = @Pmarca, ";
            SrtSQL += "     lote = @Plote, ";
            SrtSQL += "     codigoBarra = @PcodigoBarra, ";
            SrtSQL += "     fechaVencimento = @PfechaVencimento ";
            SrtSQL += " WHERE idproducto = @Pidproducto ";
            SrtSQL = SrtSQL.Replace("@Pidproducto", "'" + idproducto + "'");
            SrtSQL = SrtSQL.Replace("@Pdescripcion", "'" + descripcion + "'");
            SrtSQL = SrtSQL.Replace("@Pprecio", "'" + precio + "'");
            SrtSQL = SrtSQL.Replace("@Pmarca", "'" + marca + "'");
            SrtSQL = SrtSQL.Replace("@Plote", "'" + lote + "'");
            SrtSQL = SrtSQL.Replace("@PcodigoBarra", "'" + codigoBarra + "'");
            SrtSQL = SrtSQL.Replace("@PfechaVencimento", "'" + fechaVencimento + "'");

            strResultado = conexion.EjecutarComando(SrtSQL);
            return strResultado;




        }


        //Eliminar datos de la base de datos 
        public string EliminarProducto()
        {
            SrtSQL = " DELETE FROM tproducto";
            SrtSQL += " WHERE idproducto = @Pidproducto ";

            SrtSQL = SrtSQL.Replace("@Pidproducto", "'" + idproducto + "'");

            //Ejecutar consulta
            strResultado = conexion.EjecutarComando(SrtSQL);
            return strResultado;


        }
    }
}
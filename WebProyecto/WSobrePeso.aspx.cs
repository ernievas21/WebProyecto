using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Microsoft.ML;

namespace WebTarea6
{
    public partial class WSobrePeso : System.Web.UI.Page
    {

        private List<Estudiante> CargarEstudiantesDesdeCSV(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                return csv.GetRecords<Estudiante>().ToList();
            }
        }
        //clase 

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Estudiante> estudiantes = CargarEstudiantesDesdeCSV("C:\\Users\\ernie\\source\\repos\\WebTarea6\\WebTarea6\\App_Data\\datos.csv"); // Reemplaza con la ruta correcta al archivo CSV
                gvEstudiante.DataSource = estudiantes;
                gvEstudiante.DataBind();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnClasificar_Click(object sender, EventArgs e)
        {
            List<Estudiante> estudiantes = CargarEstudiantesDesdeCSV("C:\\Users\\ernie\\source\\repos\\WebTarea6\\WebTarea6\\App_Data\\datos.csv"); // Reemplaza con la ruta correcta al archivo CSV

            List<Estudiante> sobrepeso = estudiantes.Where(estudiante => estudiante.sobrepeso == 1).ToList();
            List<Estudiante> noSobrepeso = estudiantes.Where(estudiante => estudiante.sobrepeso == 0).ToList();

            gvSobrepeso.DataSource = sobrepeso;
            gvnoSobrepeso.DataSource = noSobrepeso;

            gvSobrepeso.DataBind();
            gvnoSobrepeso.DataBind();
        }
    }
}
using System.Web.Http;

namespace WebTarea6
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Habilitar rutas por atributos en controladores
            config.MapHttpAttributeRoutes();

            // Configuración de la ruta por defecto
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // 1. Forzar que la API responda siempre en JSON límpio
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new System.Net.Http.Headers.MediaTypeHeaderValue("text/html"));

            // 2. Permitir que Angular se conecte sin bloqueos de seguridad (CORS)
            config.EnableCors(new System.Web.Http.Cors.EnableCorsAttribute("http://localhost:4200", "*", "*"));

        }

    }

}
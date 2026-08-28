using System;
using System.Text;
using RabbitMQ.Client;

namespace WebTarea6
{
    public static class RabbitMQService
    {
        // IP/Host estándar de RabbitMQ local
        private static readonly string HostName = "localhost";
         

        public static void EnviarEvento(string tipoAccion, string datosJson)
        {
            try
            {
                // 1. Crear la fábrica de conexiones
                var factory = new ConnectionFactory() { HostName = HostName };

                // 2. Abrir la conexión y el canal de comunicación
                using (var connection = factory.CreateConnection())
                using (var channel = connection.CreateModel())
                {
                    // 3. Declarar la cola (buzón) de forma segura si no existe
                    channel.QueueDeclare(
                        queue: "cola_clientes",
                        durable: true,     // Sobrevive a reinicios del servidor
                        exclusive: false,
                        autoDelete: false,
                        arguments: null
                    );

                    // Empaquetar el mensaje indicando qué pasó (Insertar, Modificar, etc.)
                    string mensajeCompleto = $"{tipoAccion}|{datosJson}";
                    var body = Encoding.UTF8.GetBytes(mensajeCompleto);

                    // 4. Publicar la "carta" en el buzón
                    channel.BasicPublish(
                        exchange: "",
                        routingKey: "cola_clientes",
                        basicProperties: null,
                        body: body
                    );
                }
            }
            catch (Exception)
            {
                // En un entorno real se registra en log, en tu prueba puedes dejarlo pasar
                // para que no rompa el flujo principal si el servidor RabbitMQ está apagado.
            }
        }
    }
}
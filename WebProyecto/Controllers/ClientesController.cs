using System;
using System.Web.Http;

namespace WebTarea6
{
    [RoutePrefix("api/clientes")]
    public class ClientesController : ApiController
    {
        // 1. CONSULTAR CLIENTES (GET) -> https://localhost:44338/api/clientes
        [HttpGet]
        [Route("")]
        public IHttpActionResult ObtenerTodos()
        {
            try
            {
                Cliente objeCliente = new Cliente();
                var listaClientes = objeCliente.ConsultarClientes();
                return Ok(listaClientes);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        // 2. INSERTAR CLIENTE (POST) -> https://localhost:44338/api/clientes
        [HttpPost]
        [Route("")]
        public IHttpActionResult Insertar([FromBody] Cliente nuevoCliente)
        {
            if (nuevoCliente == null) return BadRequest("Datos del cliente inválidos.");

            try
            {
                // 1. Guardar en la base de datos usando tu lógica existente
                // (Llamamos al método CrearCliente pasándole el objeto que viene desde Angular)
                nuevoCliente.CrearCliente();

                // 2. Serializar el objeto a texto JSON para enviarlo a RabbitMQ
                var serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
                string jsonCliente = serializer.Serialize(nuevoCliente);

                // 3. Disparar el evento hacia RabbitMQ
                RabbitMQService.EnviarEvento("CLIENTE_CREADO", jsonCliente);

                return Ok(new { mensaje = "Cliente insertado correctamente" });


            }

            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        // 3. MODIFICAR CLIENTE (PUT) -> https://localhost:44338/api/clientes
        [HttpPut]
        [Route("")]
        public IHttpActionResult Modificar([FromBody] Cliente clienteData)
        {
            if (clienteData == null) return BadRequest("Datos inválidos.");

            try
            {
                // Instanciamos tu clase de lógica tradicional
                Cliente objeCliente = new Cliente();

                // Le inyectamos TODOS los campos que nos mandó Angular
              
                objeCliente.idtcliente = clienteData.idtcliente; 
                objeCliente.nombre = clienteData.nombre;
                objeCliente.apellido = clienteData.apellido;
                objeCliente.direccion = clienteData.direccion; 
                objeCliente.telefono = Convert.ToInt32(clienteData.telefono);   
                objeCliente.numero_cuenta = Convert.ToInt32(clienteData.numero_cuenta);          

                // Ejecutamos el método que ya tienes programado en Cliente.cs
                objeCliente.ModificarCliente();

                //Reportamos el evento correspondiente a RabbitMQ
                var serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
                string jsonCliente = serializer.Serialize(clienteData);
                
                RabbitMQService.EnviarEvento("CLIENTE_MODIFICADO", jsonCliente);

                return Ok(new { mensaje = "Cliente modificado correctamente" });
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        // ELIMINAR CLIENTE (DELETE) -> https://localhost:44338/api/clientes/5
        [HttpDelete]
        [Route("{id}")]
        public IHttpActionResult Eliminar(int id)
        {
            try
            {
                // Instanciamos la clase de lógica
                Cliente objeCliente = new Cliente();

                // Le inyectamos el ID que viene desde la URL de Angular
                objeCliente.idtcliente = id;

                // Ejecutamos el método que acabamos de ver en tu pantalla
                objeCliente.EliminarCliente();

                // Reportamos el evento a RabbitMQ
                RabbitMQService.EnviarEvento("CLIENTE_ELIMINADO", "ID:" + id);

                return Ok(new { mensaje = "Cliente eliminado correctamente" });
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
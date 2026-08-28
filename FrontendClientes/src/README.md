Pasos para el uso de la herramienta 

1. Base de Datos (Capa de Persistencia)
Motor: MySQL.Archivo: script_base_datos.sql (ubicado en la raíz del repositorio).Cómo usarlo:Abre MySQL Workbench y conéctate a tu servidor local.Ve a File ➔ Open SQL Script y selecciona el archivo script_base_datos.sql.Presiona el icono del rayo (Execute) para crear la base de datos mydb, fundar las tablas (tcliente, t_producto) e insertar los registros iniciales de prueba.

2. Backend (Capa de Servicios y API)Tecnología: .NET / C# (Web API con soporte CORS habilitado).Carpeta: WebProyecto.Cómo usarlo:Abre el archivo de solución WebProyecto.sln en tu Visual Studio clásico.Compila el proyecto presionando Ctrl + Shift + B para restaurar paquetes.Haz clic en el botón verde Iniciar (IIS Express). Esto levantará la API localmente (típicamente en el puerto 44338). Déjala corriendo en segundo plano; ella se encargará de persistir los datos en MySQL y publicar mensajes asíncronos en las colas de RabbitMQ.

3. Frontend (Interfaz de Usuario)Tecnología: Angular (Estructura Standalone moderna).Carpeta: FrontendClientes.Cómo usarlo:Abre una terminal de comandos (en tu sistema o dentro de Visual Studio Code).Entra a la subcarpeta del proyecto web ejecutando "cd FrontendClientes"

4. Para ejecutar el comando oficial del servicio es 
ng serve -o
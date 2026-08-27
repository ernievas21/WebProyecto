FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

# Establece el directorio de trabajo
WORKDIR /app

# Copia los archivos de la aplicación al contenedor
COPY . .

# Restaura las dependencias
RUN dotnet restore

# Compila la aplicación
RUN dotnet build --configuration Release

# Publica la aplicación
RUN dotnet publish --configuration Release --output /app/out

# Define la imagen final
FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY --from=build /app/out .
# Expone el puerto de la aplicación
EXPOSE 80

# Define el comando de inicio
ENTRYPOINT ["dotnet", "WebTarea6.dll"]






# Etapa 1: build del proyecto .NET
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copiar proyectos necesarios
COPY ["Eventos360.Frontend/Eventos360.Frontend.csproj", "Eventos360.Frontend/"]
COPY ["Eventos360.Shared/Eventos360.Shared.csproj", "Eventos360.Shared/"]

# Restaurar dependencias
RUN dotnet restore "Eventos360.Frontend/Eventos360.Frontend.csproj"

# Copiar todo el código
COPY . .

# Publicar en modo Release
WORKDIR "/src/Eventos360.Frontend"
RUN dotnet publish "Eventos360.Frontend.csproj" -c Release -o /app/publish

# Etapa 2: imagen final con Nginx
FROM nginx:alpine

# Establecer directorio de trabajo
WORKDIR /usr/share/nginx/html

# Copiar la aplicación publicada desde la etapa de build
COPY --from=build /app/publish/wwwroot .

# Copiar la configuración personalizada de Nginx
# (ruta relativa desde la raíz del proyecto)
COPY config/nginx.conf /etc/nginx/nginx.conf

# Exponer el puerto 80
EXPOSE 80

# Comando de inicio
ENTRYPOINT ["nginx", "-g", "daemon off;"]

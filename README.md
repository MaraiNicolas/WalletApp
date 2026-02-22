🚀 Cómo levantar el proyecto localmente
Sigue estos 5 pasos para compilar y ejecutar WalletApp en tu entorno local.

1. Requisitos previos obligatorios
Antes de empezar, asegúrate de tener instalado:
.NET 10 SDK
Docker Desktop (debe estar en ejecución)
Visual Studio 2022 (versión Preview para soportar .NET 10), JetBrains Rider o VS Code.

2. Clonar la solución
Abre tu terminal y clona el repositorio:

git clone https://github.com/TU_USUARIO/WalletApp.git
cd WalletApp

4. Levantar el SQL Server (Docker)
El proyecto usa SQL Server. Levanta un contenedor rápidamente ejecutando este comando en tu terminal:

docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=TuPasswordSeguro123!" -p 1433:1433 --name sql_walletapp -d mcr.microsoft.com/mssql/server:2022-latest
(Importante: Si cambias la contraseña en este comando, deberás actualizar la cadena de conexión en el archivo appsettings.Development.json del proyecto WalletApp.Api).

4. Aplicar las Migraciones (Crear la Base de Datos)
Para que Entity Framework cree las tablas en el contenedor que acabas de levantar:
Si usas Visual Studio: Abre la Consola del Administrador de Paquetes, asegúrate de que el "Proyecto predeterminado" sea WalletApp.Infrastructure y ejecuta:

Update-Database
dotnet ef database update --project src/WalletApp.Infrastructure --startup-project src/WalletApp.Api

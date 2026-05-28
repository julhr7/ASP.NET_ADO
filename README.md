# 🌐 ASP.NET Data Access con ADO.NET

Este repositorio contiene un proyecto desarrollado en **ASP.NET** cuyo objetivo principal es demostrar la implementación de un acceso a datos directo, seguro y eficiente utilizando **ADO.NET** nativo, prescindiendo de ORMs (como Entity Framework). 

Es un ejemplo práctico de cómo gestionar conexiones a la base de datos a bajo nivel, ejecutar consultas SQL y mapear resultados a objetos de dominio (C#).

---

## 🎯 Objetivos del Proyecto y Buenas Prácticas

Este proyecto está diseñado para resaltar los siguientes fundamentos técnicos:

* **Gestión de Conexiones:** Uso correcto de la clase `SqlConnection` implementando bloques `using` para garantizar la liberación de recursos (Garbage Collection) y evitar fugas de memoria.
* **Seguridad (Anti SQL Injection):** Implementación de consultas parametrizadas (`SqlParameter`) y/o el uso de **Procedimientos Almacenados (Stored Procedures)** para prevenir ataques de inyección SQL.
* **Rendimiento Optimo:** Uso de `SqlDataReader` para una lectura de datos rápida y de solo avance (forward-only), ideal para leer grandes volúmenes de información con un impacto mínimo en la memoria.
* **Mapeo Manual:** Transformación explícita de las filas de la base de datos a modelos/entidades de C# (Data Transfer Objects).
* **Operaciones CRUD:** Implementación completa de Crear, Leer, Actualizar y Eliminar (Create, Read, Update, Delete) de forma transaccional.

---

## 🚀 Instrucciones de Ejecución Local

Para levantar este proyecto en tu entorno local, sigue los pasos a continuación:

### 📋 Requisitos previos
* Visual Studio (Recomendado 2022) o VS Code.
* .NET SDK *(Ajustar según la versión exacta: .NET 6, 7 u 8 / o .NET Framework si es un proyecto clásico)*.
* **SQL Server** (LocalDB, Express o Developer Edition).

### 🗄️ Configuración de la Base de Datos

1. En la carpeta raíz del proyecto (o en una carpeta `Scripts`), encontrarás un archivo `.sql` (por ejemplo, `database_schema.sql`).
2. Abre SQL Server Management Studio (SSMS) o Azure Data Studio y ejecuta ese script para crear las tablas necesarias y poblar los datos de prueba.
3. Abre el archivo `appsettings.json` (o `web.config` si es .NET Framework clásico) y actualiza la cadena de conexión (`ConnectionString`) para que apunte a tu servidor de SQL Server local.

### 💻 Pasos para ejecutar

1. **Clonar el repositorio:**
   ```bash
   git clone [https://github.com/julhr7/ASP.NET_ADO.git](https://github.com/julhr7/ASP.NET_ADO.git)
   ```

2. **Navegar a la carpeta del proyecto:**
   ```bash
   cd ASP.NET_ADO
   ```

3. **Restaurar paquetes y compilar:**
   ```bash
   dotnet build
   ```

4. **Ejecutar la aplicación:**
   ```bash
   dotnet run
   ```
   *(Alternativamente, simplemente abre el archivo `.sln` en Visual Studio y presiona `F5` para iniciar en modo depuración).*

---

## 🛠️ Stack Tecnológico

* **Framework Web:** ASP.NET Core MVC / Web API *(Ajustar según aplique)*
* **Lenguaje:** C#
* **Acceso a Datos:** ADO.NET nativo (`System.Data.SqlClient` / `Microsoft.Data.SqlClient`)
* **Base de Datos:** Microsoft SQL Server
* **Arquitectura:** *(Opcional: Mencionar si utilizaste Arquitectura en 3 capas (Presentación, Negocio, Datos) o Patrón Repositorio)*

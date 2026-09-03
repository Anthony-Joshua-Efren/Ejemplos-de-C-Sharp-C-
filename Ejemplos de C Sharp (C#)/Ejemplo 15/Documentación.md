# Documentación del proyecto

**Nombre del proyecto:** **Ejemplo 15 - CRUD con SQLite**

**Elaborado por:** **Anthony Silva**

**Fecha de elaboración:** **01 / 09 / 2026**

**Lenguaje:** **C# .NET 10.0**

**Base de datos:** **SQLite**

**Proveedor:** **Microsoft.Data.Sqlite**

---

# Objetivo del proyecto

Desarrollar una aplicación de consola en C# que permita establecer una conexión con una base de datos SQLite y realizar las operaciones fundamentales de un sistema de información:

- Crear
- Consultar
- Actualizar
- Eliminar

Estas operaciones reciben el nombre de **CRUD**.

El proyecto tiene como finalidad introducir al estudiante en el manejo de bases de datos desde C#, utilizando SQL y el paquete `Microsoft.Data.Sqlite`.

---

# Objetivos del proyecto

- Comprender qué es una base de datos.
- Comprender qué es una base de datos relacional.
- Comprender qué es SQLite.
- Identificar la diferencia entre una base de datos con servidor y una base de datos basada en archivos.
- Conocer los conceptos básicos de SQL.
- Instalar y utilizar `Microsoft.Data.Sqlite`.
- Crear una conexión entre C# y SQLite.
- Crear una base de datos desde C#.
- Crear tablas mediante SQL.
- Insertar registros.
- Consultar registros.
- Actualizar registros.
- Eliminar registros.
- Aplicar validaciones.
- Utilizar `try-catch`.
- Utilizar parámetros SQL.
- Aplicar Programación Orientada a Objetos.
- Separar responsabilidades mediante diferentes clases.

---

# ¿Qué es una base de datos?

Una **base de datos** es un conjunto organizado de información que puede ser almacenada, consultada, modificada y administrada de manera estructurada.

## ¿Para qué sirve?

Una base de datos sirve para manejar grandes cantidades de información sin perder el control o la seguridad. En la vida real permite:
- **Guardar datos de forma segura:** Almacena perfiles de usuarios, contraseñas, compras o inventarios.
- **Buscar al instante:** Encuentra un dato específico en segundos mediante programas especiales.
- **Actualizar información:** Permite cambiar, borrar o añadir nuevos elementos sin dañar el resto de los registros.
- **Evitar duplicados:** Mantiene el orden para que no existan datos repetidos o confusos.
- **Dar acceso a varios usuarios:** Permite que muchas personas o aplicaciones consulten la misma información al mismo tiempo.

## ¿Qué es una base de datos relacional?

Una **base de datos relacional** es un tipo de base de datos que organiza la información en **tablas** que se relacionan entre sí mediante **claves primarias** y **claves foráneas**. Cada tabla contiene filas (registros) y columnas (campos), y las relaciones permiten mantener la integridad de los datos y facilitar consultas complejas.

- Más información: https://azure.microsoft.com/es-es/resources/cloud-computing-dictionary/what-are-databases

---

# SQLite

**SQLite** es un sistema de gestión de bases de datos relacional (RDBMS) que se caracteriza por ser **ligero, rápido y fácil de usar**. A diferencia de otros sistemas de bases de datos, SQLite no requiere un servidor separado para funcionar, ya que almacena toda la información en un solo archivo en el disco.

A diferencia de sistemas como **SQL Server** o **MySQL**, para este proyecto no se requiere ejecutar un servidor independiente.

La aplicación utiliza un archivo:

```
Tienda.db
```

como base de datos.

- Más información: https://sqlite.org/ | https://sqlitebrowser.org/

---

# Microsoft.Data.Sqlite

**Microsoft.Data.Sqlite** es un proveedor de datos para SQLite desarrollado por Microsoft. Permite a las aplicaciones .NET interactuar con bases de datos SQLite de manera eficiente y sencilla.

Para instalarlo, se utiliza el siguiente comando en la consola del Administrador de paquetes de NuGet:

```
dotnet add package Microsoft.Data.Sqlite
```
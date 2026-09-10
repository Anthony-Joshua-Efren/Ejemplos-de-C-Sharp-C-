# Documentación del proyecto

**Nombre del proyecto:** **Ejemplo 16 - CRUD con Excel**  
**Elaborado por:** **Anthony Silva**  
**Fecha de elaboración:** **05 / 09 / 2026**
**Biblioteca utilizada:** **ClosedXML**  
**Archivo de persistencia:** **Productos.xlsx**

---

# Objetivo del proyecto

Desarrollar una aplicación de consola en C# capaz de utilizar un archivo de Excel como medio de persistencia de información.

La aplicación implementa las operaciones fundamentales de un CRUD:

```text
C → Create
R → Read
U → Update
D → Delete
```

El sistema permitirá registrar, consultar, actualizar y eliminar productos almacenados en un archivo `.xlsx`.

Además, el proyecto permitirá comprender cómo C# puede manipular un archivo de Excel sin depender de que Microsoft Excel esté instalado.

---

# Objetivos del proyecto

- Comprender qué es la persistencia de datos.
- Comprender qué es una hoja de cálculo.
- Comprender las diferencias entre Excel y una base de datos.
- Conocer la biblioteca `ClosedXML`.
- Crear un archivo `.xlsx` desde C#.
- Crear una hoja de trabajo desde C#.
- Insertar información.
- Consultar información.
- Actualizar información.
- Eliminar información.
- Aplicar Programación Orientada a Objetos.
- Aplicar encapsulación.
- Implementar validaciones.
- Implementar `try-catch`.
- Trabajar con archivos desde C#.
- Separar responsabilidades entre diferentes clases.

---

# ¿Qué es la persistencia de datos?

La **persistencia de datos** es la capacidad de conservar información para que siga disponible después de que un programa termine su ejecución.

Por ejemplo, si registramos:

```text
Producto: Teclado
Precio: $850
Cantidad: 10
```

y cerramos el programa, los datos deben conservarse.

La información puede persistirse mediante:

```text
Base de datos
Archivo de texto
Archivo JSON
Archivo XML
Archivo Excel
```

En este proyecto utilizaremos:

```text
Productos.xlsx
```

---

# ¿Qué es Excel?

Excel es una aplicación de hojas de cálculo utilizada para organizar, analizar y presentar información.

Un archivo de Excel está formado por un libro que puede contener diferentes hojas.

```text
Productos.xlsx
│
└── Productos
```

En una hoja encontramos:

```text
Columnas
Filas
Celdas
```

---

# ¿Excel es una base de datos?

No.

Excel es una **hoja de cálculo**, no un sistema gestor de bases de datos.

Sin embargo, puede utilizarse como un mecanismo sencillo de persistencia cuando la cantidad y complejidad de los datos son pequeñas.

En este proyecto utilizaremos una hoja de Excel de forma similar a una tabla:

```text
+----+-------------------+---------+----------+
| Id | Nombre            | Precio  | Cantidad |
+----+-------------------+---------+----------+
| 1  | Teclado           | 850.00  | 10       |
| 2  | Mouse             | 350.00  | 20       |
+----+-------------------+---------+----------+
```

---

# ¿Qué es una base de datos?

Una **base de datos** es un sistema organizado para almacenar, consultar, modificar y administrar información.

En una base de datos relacional, la información se organiza principalmente mediante tablas.

Ejemplo:

```text
Productos
├── Id
├── Nombre
├── Precio
└── Cantidad
```

Un SGBD está diseñado específicamente para trabajar con datos, consultas, integridad y relaciones.

Excel puede almacenar información estructurada, pero no ofrece el mismo modelo que un sistema gestor de bases de datos.

---

# Excel vs. SQLite

En el proyecto anterior se utilizó SQLite.

La diferencia conceptual es:

```text
SQLite
   ↓
Tienda.db
   ↓
Motor de base de datos
   ↓
SQL
```

Mientras que en este proyecto:

```text
Excel
   ↓
Productos.xlsx
   ↓
Hoja de cálculo
   ↓
ClosedXML
```

Comparación:

| Característica | SQLite | Excel |
|---|---|---|
| Tipo | Base de datos relacional | Hoja de cálculo |
| Archivo | `.db` | `.xlsx` |
| SQL | Sí | No |
| Tablas | Sí | Hojas/filas/columnas |
| Relaciones | Sí | No como un SGBD |
| Consultas avanzadas | Sí | Limitadas |
| Edición manual | Limitada | Excelente |
| Reportes | Secundario | Excelente |
| Servidor independiente | No | No |

---

# SQLite, Excel y servidores

También podemos diferenciar tres escenarios:

```text
Aplicación + Excel
        ↓
Productos.xlsx
```

```text
Aplicación + SQLite
        ↓
Tienda.db
```

```text
Aplicación
     ↓
Servidor de BD
     ↓
SQL Server / MySQL / PostgreSQL
```

SQLite y Excel pueden funcionar sin un servidor independiente. Un sistema como SQL Server, MySQL o PostgreSQL normalmente utiliza un servicio de base de datos que administra el almacenamiento y las consultas.

---

# ¿Por qué utilizar Excel en este proyecto?

Excel resulta conveniente como ejercicio de persistencia porque:

- El formato es fácil de visualizar.
- Los datos pueden modificarse manualmente.
- Los archivos `.xlsx` son ampliamente utilizados.
- Puede abrirse con Microsoft Excel, LibreOffice Calc, WPS y aplicaciones compatibles.
- Permite visualizar directamente lo que el programa está almacenando.

---

# ¿Necesitamos instalar Microsoft Excel?

No.

El programa utiliza:

```text
C#
 ↓
ClosedXML
 ↓
Productos.xlsx
```

ClosedXML permite crear y modificar archivos Excel sin requerir que Microsoft Excel esté instalado.

Por ello:

```text
Alumno con Excel
→ Puede abrir el archivo.

Alumno con LibreOffice
→ Puede abrir el archivo.

Alumno con WPS Office
→ Puede abrir el archivo.

Alumno sin suite de oficina
→ El programa todavía puede crear y modificar el archivo.
```

---

# ¿Qué es ClosedXML?

**ClosedXML** es una biblioteca para .NET que facilita la creación, lectura y modificación de archivos de Excel basados en OpenXML.

Permite trabajar con:

```text
Libros
Hojas
Filas
Columnas
Celdas
Formato
```

En este proyecto se utilizará para manipular:

```text
Productos.xlsx
```

---

# Instalación de ClosedXML

Desde la terminal:

```bash
dotnet add package ClosedXML
```

También puede instalarse desde la Consola del Administrador de paquetes:

```powershell
Install-Package ClosedXML
```

---

# Estructura del proyecto

```text
Ejemplo_Excel_CRUD
│
├── Program.cs
├── Producto.cs
├── ExcelBD.cs
├── ProductoExcel.cs
│
└── Productos.xlsx
```

---

# Responsabilidad de cada clase

| Clase | Responsabilidad |
|---|---|
| `Program` | Controlar el flujo y mostrar el menú |
| `Producto` | Representar un producto |
| `ExcelBD` | Administrar el archivo de Excel |
| `ProductoExcel` | Realizar las operaciones CRUD |

---

# Clase Producto

La clase `Producto` representa un producto dentro del programa.

Sus atributos son privados:

```csharp
private int id;
private string? nombre;
private double precio;
private int cantidad;
```

El uso de atributos privados permite aplicar el concepto de:

**Encapsulación**

---

# Encapsulación

La encapsulación permite controlar el acceso al estado interno de un objeto.

En lugar de modificar directamente:

```csharp
producto.precio = 1000;
```

la clase proporciona métodos como:

```csharp
Obtener_Precio()
Establecer_Precio()
```

Esto permite controlar cómo se utiliza la información del objeto.

---

# Constructores

La clase utiliza un constructor vacío:

```csharp
public Producto()
```

y un constructor con parámetros:

```csharp
public Producto(
    int id,
    string nombre,
    double precio,
    int cantidad)
```

El primero permite crear el objeto y asignar los valores posteriormente.

El segundo permite crear un objeto proporcionando directamente sus datos.

---

# Métodos de Producto

Entre los principales métodos se encuentran:

```text
Solicitar_Datos()
Obtener_Id()
Obtener_Nombre()
Obtener_Precio()
Obtener_Cantidad()
Establecer_Id()
Establecer_Nombre()
Establecer_Precio()
Establecer_Cantidad()
Imprimir_Informacion()
```

Cada método tiene una responsabilidad específica.

---

# Validaciones

El proyecto realiza validaciones antes de almacenar los datos.

## Nombre

No puede estar vacío.

```csharp
string.IsNullOrWhiteSpace()
```

## Precio

Debe ser mayor que cero.

```text
Precio > 0
```

## Cantidad

Debe ser un entero mayor que cero.

```text
Cantidad > 0
```

## ID

Debe ser un entero mayor que cero.

```text
Id > 0
```

---

# TryParse

Para validar valores numéricos se utilizan:

```csharp
int.TryParse()
double.TryParse()
```

Ejemplo:

```csharp
if (double.TryParse(
    entrada,
    out double valor))
{
    // El dato es numérico.
}
```

Esto permite validar entradas antes de utilizarlas.

---

# Clase ExcelBD

La clase `ExcelBD` administra el archivo:

```text
Productos.xlsx
```

El nombre `ExcelBD` mantiene una analogía con la clase de acceso utilizada en el proyecto SQLite. Técnicamente, esta clase administra un archivo de Excel y no un sistema gestor de bases de datos.

---

# Ruta del archivo

Se utiliza:

```csharp
private readonly string rutaArchivo =
    "Productos.xlsx";
```

Esto indica el nombre del archivo que utilizará la aplicación.

---

# Verificar existencia

La clase utiliza:

```csharp
File.Exists()
```

para comprobar si el archivo ya existe.

El método:

```text
Existe()
```

devuelve:

```text
true
```

si el archivo existe y:

```text
false
```

si no existe.

---

# Crear archivo

Cuando el archivo no existe, el programa crea un nuevo libro mediante:

```csharp
XLWorkbook
```

Posteriormente crea la hoja:

```text
Productos
```

y los encabezados:

```text
Id
Nombre
Precio
Cantidad
```

Finalmente guarda:

```text
Productos.xlsx
```

---

# XLWorkbook

`XLWorkbook` representa el libro de Excel.

Ejemplo:

```csharp
using XLWorkbook libro =
    new XLWorkbook();
```

Dentro del libro pueden agregarse hojas:

```csharp
libro.Worksheets.Add("Productos");
```

---

# IXLWorksheet

Una hoja de Excel puede representarse mediante:

```csharp
IXLWorksheet
```

En nuestro proyecto:

```csharp
IXLWorksheet hoja =
    libro.Worksheet("Productos");
```

Esto permite manipular específicamente la hoja `Productos`.

---

# Celdas

Las celdas pueden identificarse mediante fila y columna.

Por ejemplo:

```csharp
hoja.Cell(1, 1)
```

corresponde a:

```text
A1
```

Por lo tanto:

```csharp
hoja.Cell(1, 1).Value = "Id";
```

coloca `Id` en la celda `A1`.

---

# Formato

ClosedXML también permite aplicar formato.

Ejemplo:

```csharp
hoja.Range("A1:D1").Style.Font.Bold = true;
```

Esto establece los encabezados en negrita.

También podemos ajustar automáticamente las columnas:

```csharp
hoja.Columns().AdjustToContents();
```

---

# Clase ProductoExcel

La clase `ProductoExcel` se encarga de realizar las operaciones de persistencia.

Contiene:

```text
Insertar()
Consultar()
Actualizar()
Eliminar()
```

Estas operaciones forman nuestro CRUD.

---

# CREATE — Insertar

Para registrar un producto:

```text
1. Verificar que exista el archivo.
2. Abrir el libro.
3. Obtener la hoja.
4. Buscar la siguiente fila.
5. Generar un ID.
6. Escribir los datos.
7. Guardar el archivo.
```

Flujo:

```text
Producto
   ↓
ProductoExcel
   ↓
ClosedXML
   ↓
Productos.xlsx
   ↓
Nueva fila
```

---

# Generación del ID

En SQLite utilizamos:

```sql
AUTOINCREMENT
```

Excel no tiene un motor de base de datos que genere automáticamente el identificador.

Por ello, el programa busca el ID mayor y utiliza:

```text
Último ID + 1
```

Ejemplo:

```text
Último ID = 5

Nuevo ID = 6
```

---

# READ — Consultar

Para consultar:

```text
1. Abrir el archivo.
2. Obtener la hoja.
3. Recorrer las filas.
4. Ignorar la fila de encabezados.
5. Leer los valores.
6. Mostrar los productos.
```

El flujo es:

```text
Productos.xlsx
      ↓
Hoja Productos
      ↓
Filas
      ↓
Consola
```

---

# UPDATE — Actualizar

Para actualizar:

```text
1. Solicitar el ID.
2. Solicitar los nuevos datos.
3. Buscar el ID dentro de la hoja.
4. Modificar las celdas.
5. Guardar el archivo.
```

Ejemplo:

```text
Antes:

1 | Teclado | 850 | 10

Después:

1 | Teclado Mecánico | 1200 | 8
```

---

# DELETE — Eliminar

Para eliminar:

```text
1. Solicitar el ID.
2. Solicitar confirmación.
3. Buscar el registro.
4. Eliminar la fila.
5. Guardar el archivo.
```

Ejemplo:

```text
Antes:

1 | Teclado | 850 | 10
2 | Mouse   | 350 | 20

Después de eliminar ID 2:

1 | Teclado | 850 | 10
```

---

# Manejo de excepciones

Las operaciones sobre el archivo utilizan:

```csharp
try
{
    // Operación con Excel.
}
catch
{
    // Manejo del error.
}
```

Esto evita que un problema de lectura o escritura termine abruptamente el programa.

---

# IOException

Un archivo puede estar bloqueado por otro programa.

Por ejemplo:

```text
C# intenta guardar
       ↓
Productos.xlsx está abierto
       ↓
Archivo bloqueado
       ↓
IOException
```

Por ello se maneja:

```csharp
catch (IOException ex)
```

y se muestra un mensaje adecuado al usuario.

---

# Uso de using

Para administrar recursos utilizamos:

```csharp
using XLWorkbook libro =
    new XLWorkbook(...);
```

Esto permite liberar correctamente el objeto `XLWorkbook` cuando termina el bloque.

---

# Flujo completo del sistema

```text
                    INICIO
                       │
                       ▼
                Verificar archivo
                       │
               ┌───────┴───────┐
               │               │
            Existe          No existe
               │               │
               │               ▼
               │         Crear archivo
               │               │
               └───────┬───────┘
                       ▼
                    MENÚ
                       │
          ┌────────────┼────────────┐
          │            │            │
          ▼            ▼            ▼
       Registrar    Consultar    Actualizar
          │            │            │
          └────────────┼────────────┘
                       │
                       ▼
                    Eliminar
                       │
                       ▼
                      FIN
```
# Documentación del proyecto

**Nombre del proyecto:** **Ejemplo 14 - API REST de Países**

**Elaborado por:** **Anthony Silva**

**Fecha de elaboración:** **21 / 08 / 2026**

---

## Objetivo del proyecto

Crear una aplicación de consola en C# capaz de consultar información de diferentes países mediante una API REST.

El proyecto tiene como propósito introducir al estudiante en el consumo de servicios externos mediante solicitudes HTTP, procesamiento de información en formato JSON y aplicación de Programación Orientada a Objetos.

---

## Objetivos del proyecto

* Comprender qué es una API.
* Comprender qué es una API REST.
* Realizar una petición HTTP utilizando `HttpClient`.
* Utilizar el método HTTP `GET`.
* Trabajar con operaciones asíncronas mediante `async` y `await`.
* Recibir información en formato JSON.
* Analizar información JSON mediante `System.Text.Json`.
* Crear objetos a partir de información obtenida desde una API.
* Aplicar encapsulación mediante atributos privados.
* Utilizar métodos públicos y privados.
* Implementar validaciones.
* Manejar excepciones mediante `try-catch`.
* Separar responsabilidades mediante diferentes clases.

---

### Características del proyecto

* Tipo de proyecto: **Aplicación de consola**
* Versión de Visual Studio: **2026**
* Versión de C#: **.NET 10.0**
* Lenguaje de programación: **C#**
* Paradigma utilizado: **Programación Orientada a Objetos**
* API utilizada: REST Countries
* Tema principal: Consumo de APIs REST mediante HTTP

---

## Descripción del proyecto

El programa permite al usuario seleccionar un país desde un menú.

Después de seleccionar una opción, el programa realiza una petición HTTP hacia la API de países y obtiene información relacionada con el país seleccionado.

La información recibida es procesada y convertida en un objeto de la clase `Pais`.

Finalmente, el programa muestra la información obtenida en la consola.

---

## Arquitectura del proyecto

El proyecto está dividido en tres clases principales:

```text
Program.cs
Pais.cs
ApiPaises.cs
```

### Program

Es la clase encargada de controlar el flujo general del programa.

Sus responsabilidades principales son:

* Mostrar el menú.
* Solicitar la selección del usuario.
* Validar la opción.
* Crear el objeto de la API.
* Solicitar la consulta.
* Mostrar el resultado.

---

### Pais

Representa la información de un país.

Contiene atributos privados para:

```text
nombre
capital
poblacion
```

La clase incluye métodos para asignar y mostrar la información.

---

### ApiPaises

Es la clase encargada de comunicarse con la API REST.

Sus responsabilidades son:

* Crear el objeto `HttpClient`.
* Configurar la autenticación.
* Construir la URL.
* Realizar la petición HTTP.
* Recibir el JSON.
* Analizar la respuesta.
* Crear un objeto `Pais`.
* Manejar las excepciones relacionadas con la consulta.

---

## ¿Qué es una API?

API significa:

**Application Programming Interface**

Una API permite que diferentes aplicaciones puedan comunicarse entre sí.

En este proyecto, nuestro programa en C# solicita información a un servicio externo.

El flujo general es:

```text
Programa en C#
       ↓
     HTTP
       ↓
 API REST Countries
       ↓
     JSON
       ↓
 Programa en C#
```

---

## ¿Qué es REST?

REST es un estilo de arquitectura utilizado para construir servicios web.

Una API REST normalmente utiliza métodos HTTP como:

```text
GET - Leer o buscar datos
POST - Crear un dato nuevo
PUT - Actualizar un dato
DELETE - Eliminar un dato
```

En este proyecto solamente utilizamos:

```text
GET
```

porque únicamente estamos consultando información.

---

## ¿Qué es HTTP?

HTTP significa:

**HyperText Transfer Protocol**

Es el protocolo utilizado para la comunicación entre clientes y servidores web.

En este proyecto nuestro programa funciona como cliente y realiza una petición hacia un servidor.

---

## HttpClient

`HttpClient` es la clase de .NET utilizada para realizar solicitudes HTTP.

Ejemplo:

```csharp
HttpClient client = new HttpClient();
```

Posteriormente podemos realizar una petición:

```csharp
string jsonResponse =
    await client.GetStringAsync(url);
```

El método `GetStringAsync()` realiza una petición GET y devuelve el contenido de la respuesta como texto.

---

## ¿Por qué utilizamos async y await?

La comunicación con una API depende de una operación externa: la respuesta de un servidor.

Por este motivo utilizamos programación asíncrona.

```csharp
static async Task Main(string[] args)
```

y posteriormente:

```csharp
await client.GetStringAsync(url);
```

`await` permite esperar la finalización de la operación asíncrona antes de continuar con el procesamiento del resultado.

---

## ¿Qué es JSON?

JSON significa:

**JavaScript Object Notation**

Es un formato utilizado para representar y transportar información estructurada.

Ejemplo:

```json
{
    "name": {
        "common": "Mexico"
    },
    "population": 130000000
}
```

La API devuelve información en JSON y nuestro programa debe analizarla.

---

## System.Text.Json

C# proporciona la biblioteca:

```csharp
System.Text.Json
```

para trabajar con información JSON.

En este proyecto utilizamos:

```csharp
JsonDocument
```

para analizar la respuesta obtenida desde la API.

Ejemplo:

```csharp
using JsonDocument doc =
    JsonDocument.Parse(jsonResponse);
```

Después podemos obtener propiedades específicas:

```csharp
country
    .GetProperty("population")
    .GetInt64();
```

---

## Programación Orientada a Objetos

El proyecto utiliza POO mediante diferentes clases.

### Clase Pais

Representa un país.

### Clase ApiPaises

Representa el componente encargado de comunicarse con la API.

### Clase Program

Controla la ejecución de la aplicación.

Esta separación permite que cada clase tenga una responsabilidad específica.

---

## Encapsulación

La clase `Pais` utiliza atributos privados:

```csharp
private string? nombre;
private string? capital;
private long poblacion;
```

Esto significa que los datos internos del objeto no pueden modificarse directamente desde cualquier parte del programa.

La información se manipula mediante métodos definidos por la propia clase.

---

## Validaciones

El programa valida la información introducida por el usuario.

Por ejemplo:

```csharp
if (int.TryParse(entrada, out int opcion))
```

permite comprobar que el usuario realmente introdujo un número.

También se utiliza:

```csharp
string.IsNullOrWhiteSpace(entrada)
```

para verificar que el usuario no introduzca una opción vacía.

---

## Manejo de excepciones

El programa utiliza `try-catch`.

Ejemplo:

```csharp
try
{
    // Operación que puede generar un error.
}
catch (HttpRequestException ex)
{
    // Error relacionado con la comunicación HTTP.
}
catch (JsonException ex)
{
    // Error al interpretar el JSON.
}
catch (Exception ex)
{
    // Cualquier otro error inesperado.
}
```

### HttpRequestException

Se utiliza para manejar errores relacionados con la solicitud HTTP.

### JsonException

Se utiliza para manejar errores relacionados con el procesamiento del JSON.

### Exception

Permite manejar errores que no hayan sido contemplados específicamente.

---

## Flujo del programa

```text
Inicio
  ↓
Mostrar menú
  ↓
Usuario selecciona país
  ↓
Validar opción
  ↓
Crear objeto ApiPaises
  ↓
Construir URL
  ↓
Realizar GET
  ↓
Recibir JSON
  ↓
Analizar JSON
  ↓
Crear objeto Pais
  ↓
Mostrar información
  ↓
Fin
```

---

## Conceptos aprendidos

Durante este proyecto se aplican los siguientes conceptos:

```text
POO
│
├── Clases
├── Objetos
├── Encapsulación
├── Métodos
│
API
│
├── REST
├── HTTP
├── GET
│
C#
│
├── HttpClient
├── async
├── await
├── try-catch
├── JsonDocument
└── Validaciones
```

---

## Conclusión

En este proyecto se desarrolló una aplicación capaz de comunicarse con un servicio externo mediante una API REST.

El programa realiza una petición HTTP, recibe información en formato JSON, procesa los datos y los transforma en un objeto de C#.

Además, el proyecto demuestra cómo la Programación Orientada a Objetos permite separar responsabilidades mediante diferentes clases.

Esta actividad representa una introducción al desarrollo de aplicaciones capaces de comunicarse con servicios externos y constituye una base para proyectos posteriores que trabajen con APIs, bases de datos, aplicaciones web y sistemas distribuidos.

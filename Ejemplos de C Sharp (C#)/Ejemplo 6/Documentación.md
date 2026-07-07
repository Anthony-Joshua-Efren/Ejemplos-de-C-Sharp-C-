# Documentación del proyecto

**Nombre del proyecto:** **Ejemplo 6**

**Elaborado por:** **Anthony Silva**

**Fecha de elaboración:** **07 / 07 / 2026**

---

### Objetivo del proyecto

Crear un programa en C# que permita conocer y aplicar el uso de la estructura **TimeSpan**, comprendiendo cómo representar intervalos de tiempo, realizar operaciones matemáticas con duraciones, comparar periodos de tiempo y utilizar sus principales propiedades y métodos mediante ejemplos prácticos.

---

### Objetivos del proyecto

1. Comprender qué es un objeto **TimeSpan** y cuál es su finalidad dentro del lenguaje C#.
2. Aprender las diferentes formas de crear un objeto **TimeSpan**.
3. Conocer las propiedades que permiten obtener los componentes de una duración de tiempo.
4. Aprender la diferencia entre las propiedades normales y las propiedades **Total**.
5. Realizar operaciones matemáticas entre objetos **TimeSpan**.
6. Comparar diferentes intervalos de tiempo utilizando operadores relacionales.
7. Aprender a convertir cadenas de texto en objetos **TimeSpan** mediante **Parse()** y **TryParse()**.
8. Aplicar formatos personalizados para mostrar intervalos de tiempo.
9. Comprender cómo utilizar **TimeSpan** junto con **DateTime** para calcular tiempos transcurridos.
10. Aplicar los conocimientos mediante ejemplos reales como jornadas laborales y medición de tiempos de ejecución.

---

### Características del proyecto

* Tipo de proyecto: **Aplicación de consola**
* Versión de Visual Studio: **2026**
* Versión de C#: **.NET 10.0**

---

### Descripción del proyecto

Se ha desarrollado un proyecto en Visual Studio llamado **"Ejemplo 6"**, el cual muestra el funcionamiento completo de la estructura **TimeSpan** en C#.

Durante la ejecución del programa se presentan ejemplos sobre la creación de objetos **TimeSpan**, el uso de sus constructores, métodos estáticos, propiedades, operaciones aritméticas, comparaciones, formatos personalizados y casos prácticos.

Además, el proyecto muestra cómo combinar **TimeSpan** con **DateTime** para medir el tiempo transcurrido entre dos eventos, una técnica ampliamente utilizada en aplicaciones profesionales.

---

# ¿Qué es TimeSpan?

**TimeSpan** es una estructura del espacio de nombres **System** que representa un **intervalo o duración de tiempo**.

A diferencia de **DateTime**, **TimeSpan** no representa una fecha ni una hora específica, sino únicamente la cantidad de tiempo que existe entre dos momentos.

Por ejemplo:

* 15 minutos
* 2 horas
* 8 horas con 30 minutos
* 3 días
* 1 semana
* 250 milisegundos

Todos estos ejemplos representan duraciones de tiempo, por lo que pueden almacenarse mediante un objeto **TimeSpan**.

Una de las principales ventajas de **TimeSpan** es que permite realizar operaciones matemáticas con intervalos de tiempo de una forma muy sencilla.

---

# ¿Cuándo utilizar TimeSpan?

TimeSpan se utiliza cuando necesitamos trabajar con duraciones de tiempo, por ejemplo:

* Calcular cuánto tarda un programa en ejecutarse.
* Medir el tiempo de una descarga.
* Calcular la duración de una jornada laboral.
* Determinar cuánto tiempo ha permanecido conectado un usuario.
* Crear cronómetros.
* Crear cuentas regresivas.
* Calcular tiempos entre dos fechas.
* Acumular el tiempo empleado en varias actividades.

---

### Notas del proyecto

## Constructores de TimeSpan

TimeSpan puede crearse mediante diferentes constructores dependiendo de la información disponible.

Ejemplos:

```csharp
new TimeSpan(2,30,15);
```

Representa:

* 2 horas
* 30 minutos
* 15 segundos

---

```csharp
new TimeSpan(1,5,20,40);
```

Representa:

* 1 día
* 5 horas
* 20 minutos
* 40 segundos

---

```csharp
new TimeSpan(2,10,15,50,250);
```

Representa:

* 2 días
* 10 horas
* 15 minutos
* 50 segundos
* 250 milisegundos

---

## Métodos estáticos

Otra forma muy utilizada de crear un objeto TimeSpan es mediante los métodos estáticos **From**.

Estos métodos son más intuitivos porque indican directamente la unidad de tiempo que se desea crear.

Algunos de ellos son:

* TimeSpan.FromDays()
* TimeSpan.FromHours()
* TimeSpan.FromMinutes()
* TimeSpan.FromSeconds()
* TimeSpan.FromMilliseconds()
* TimeSpan.FromMicroseconds()

Ejemplos:

```csharp
TimeSpan.FromHours(2.5);
```

Resultado:

```
02:30:00
```

---

```csharp
TimeSpan.FromMinutes(90);
```

Resultado:

```
01:30:00
```

---

## Parse()

El método **Parse()** convierte una cadena de texto en un objeto **TimeSpan**.

Ejemplo:

```csharp
TimeSpan tiempo = TimeSpan.Parse("02:30:15");
```

Si el formato es incorrecto, el programa generará una excepción.

---

## TryParse()

Funciona igual que Parse(), pero evita que el programa termine por un error cuando el usuario escribe información incorrecta.

Ejemplo:

```csharp
if(TimeSpan.TryParse(cadena, out TimeSpan tiempo))
{
    Console.WriteLine("Tiempo válido");
}
```

Es el método recomendado cuando los datos provienen del usuario.

---

# Propiedades de TimeSpan

Las propiedades permiten conocer cada uno de los componentes que forman un intervalo de tiempo.

Las propiedades más utilizadas son:

* Days
* Hours
* Minutes
* Seconds
* Milliseconds

Ejemplo:

```csharp
TimeSpan tiempo = new TimeSpan(1,10,20,30);
```

Resultado:

* Days = 1
* Hours = 10
* Minutes = 20
* Seconds = 30

---

# Propiedades Totales

Además de las propiedades normales, TimeSpan posee propiedades llamadas **Total**, las cuales representan la duración completa convertida a una única unidad de medida.

Estas propiedades son:

* TotalDays
* TotalHours
* TotalMinutes
* TotalSeconds
* TotalMilliseconds

Ejemplo:

```csharp
TimeSpan tiempo = TimeSpan.FromHours(27.5);
```

Resultado:

```
Days = 1
Hours = 3
TotalHours = 27.5
```

**Esta diferencia es una de las más importantes de TimeSpan.**

Las propiedades normales muestran únicamente cada componente.

Las propiedades Total muestran la duración completa.

---

# Operadores

TimeSpan admite operaciones matemáticas.

Podemos sumar:

```csharp
a + b
```

Restar:

```csharp
a - b
```

Multiplicar:

```csharp
a * 2
```

Dividir:

```csharp
a / 2
```

Esto permite realizar cálculos con tiempos de una manera muy sencilla.

---

# Comparaciones

También es posible comparar dos objetos TimeSpan.

Operadores disponibles:

* (>)
* (<)
* (>=)
* (<=)
* (==)
* (!=)

Ejemplo:

```csharp
if(tiempo1 > tiempo2)
```

Esto indica que **tiempo1** representa una duración mayor que **tiempo2**.

---

# Métodos principales

Los métodos más utilizados de TimeSpan son:

* Add() → Suma dos intervalos de tiempo.
* Subtract() → Resta dos intervalos.
* Duration() → Devuelve el valor absoluto de un TimeSpan.
* Negate() → Cambia el signo del intervalo.
* Parse() → Convierte texto a TimeSpan.
* TryParse() → Convierte texto sin producir excepciones.

---

# Valores especiales

TimeSpan proporciona tres constantes muy útiles.

### TimeSpan.Zero

Representa una duración igual a cero.

```csharp
00:00:00
```

Se utiliza frecuentemente para inicializar acumuladores de tiempo.

---

### TimeSpan.MaxValue

Representa la mayor duración que puede almacenar un objeto TimeSpan.

---

### TimeSpan.MinValue

Representa la menor duración posible.

---

# Formatos de impresión

TimeSpan permite mostrar la duración utilizando diferentes formatos.

Ejemplos:

```csharp
hh:mm
```

Resultado:

```
08:30
```

---

```csharp
hh:mm:ss
```

Resultado:

```
08:30:45
```

---

```csharp
dd.hh:mm:ss
```

Resultado:

```
02.08:30:45
```

Estos formatos permiten adaptar la presentación de la información según las necesidades del programa.

---

# TimeSpan y DateTime

Uno de los usos más importantes consiste en calcular la diferencia entre dos fechas u horas.

Ejemplo:

```csharp
DateTime inicio = DateTime.Now;

// Código

DateTime fin = DateTime.Now;

TimeSpan tiempo = fin - inicio;
```

El resultado será un objeto **TimeSpan** que representa exactamente el tiempo transcurrido entre ambas fechas.

Esta técnica se utiliza para medir el rendimiento de programas, algoritmos, consultas a bases de datos y procesos en general.

---

# Casos de uso de TimeSpan

Algunas aplicaciones reales donde se utiliza TimeSpan son:

* Cronómetros.
* Temporizadores.
* Cuentas regresivas.
* Registro de asistencia.
* Control de jornadas laborales.
* Medición del tiempo de ejecución de un algoritmo.
* Tiempo de descarga de archivos.
* Tiempo de espera en procesos.
* Sistemas de producción.
* Videojuegos para controlar tiempos de recarga o habilidades.
* Aplicaciones deportivas para medir tiempos de entrenamiento.
* Sistemas médicos para registrar la duración de tratamientos o procedimientos.

---

# Conclusión

La estructura **TimeSpan** es una de las herramientas más importantes del lenguaje C# cuando se trabaja con duraciones de tiempo.

Gracias a sus constructores, propiedades, métodos y operadores, es posible representar, calcular, comparar y manipular intervalos de tiempo de forma sencilla y eficiente.

Su integración con **DateTime** permite resolver una gran cantidad de problemas relacionados con el cálculo de tiempos transcurridos, cronómetros, jornadas laborales y medición del rendimiento de aplicaciones, convirtiéndose en una herramienta fundamental para el desarrollo de software profesional.

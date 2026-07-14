# Documentación del proyecto

**Nombre del proyecto:** **Ejemplo 7**
    
**Elaborado por:** **Anthony Silva**

**Fecha de elaboración:** **12 / 07 / 2026**

---

### Objetivo del proyecto

Crear un programa en C# que permita comprender el funcionamiento de los arreglos (arrays), aprendiendo a declararlos, 
inicializarlos, recorrerlos y manipularlos mediante ejemplos prácticos con arreglos definidos y arreglos creados 
inicialmente sin valores asignados.

---

### Objetivos del proyecto

1. Comprender qué es un arreglo y para qué se utiliza en C#.
2. Aprender la sintaxis para declarar e inicializar arreglos.
3. Conocer la diferencia entre un arreglo definido y un arreglo creado inicialmente sin valores asignados.
4. Aprender a acceder a los elementos mediante su índice.
5. Recorrer un arreglo utilizando los ciclos for y foreach.
6. Capturar información desde el teclado para almacenar datos dentro de un arreglo.
7. Validar la entrada del usuario utilizando el método TryParse().
8. Mostrar la información almacenada en un arreglo de manera organizada.

---

### Características del proyecto

* Tipo de proyecto: **Aplicación de consola**
* Versión de Visual Studio: **2026**
* Versión de C#: **.NET 10.0**

---

### Descripción del proyecto

Se ha desarrollado un proyecto en Visual Studio llamado "Ejemplo 7", cuyo propósito es introducir el uso de los 
arreglos en el lenguaje C#.

Durante la ejecución del programa se muestran dos escenarios comunes de trabajo:

- Un arreglo definido, cuyos elementos son conocidos desde el momento de su creación.
- Un arreglo creado inicialmente sin valores asignados, que posteriormente es llenado mediante la información 
- proporcionada por el usuario.

Además, el proyecto permite recorrer los arreglos utilizando diferentes estructuras repetitivas, validar la 
información ingresada desde la consola y mostrar los datos almacenados de forma organizada.

---

## Notas del proyecto

### ¿Qué es un arreglo?

Un arreglo (también conocido como Array) es una estructura de datos que permite almacenar varios elementos del 
mismo tipo utilizando una sola variable.

Cada elemento se almacena en una posición específica denominada índice.

Por ejemplo, en lugar de declarar diez variables independientes:

```csharp
string alumno1 = "Ana";
string alumno2 = "Luis";
string alumno3 = "Carlos";
```

Podemos utilizar un solo arreglo:

```csharp
string[] alumnos = { "Ana", "Luis", "Carlos" };
```

Esto facilita la organización y el manejo de grandes cantidades de información.

### Características de los arreglos

Los arreglos en C# poseen las siguientes características:

- Almacenan únicamente datos del mismo tipo.
- Su tamaño se establece al momento de crearlos.
- Cada elemento ocupa una posición específica.
- La primera posición siempre comienza en el índice 0.
- Una vez creado el arreglo, su tamaño no puede modificarse.

### Propiedad Length

Todos los arreglos poseen la propiedad Length, la cual devuelve la cantidad de elementos que contiene el arreglo.

Ejemplo:

```csharp

Console.WriteLine(alumnos.Length);

```

Resultado:

4

Esta propiedad es ampliamente utilizada para recorrer arreglos mediante un ciclo for.

### Valores predeterminados de un arreglo

Cuando un arreglo se crea sin asignar valores, cada posición recibe automáticamente un valor predeterminado 
dependiendo del tipo de dato.

Algunos ejemplos son:

| Tipo de dato | Valor predeterminado |
|:--------------:|:---------------------:|
|int          | 0                   |
|double       | 0.0                 |
|decimal      | 0.0                 |
|bool         | false               |
|char        | '\0' (carácter nulo) |
|string       | null                |

Es importante conocer estos valores para comprender el comportamiento inicial de los arreglos.

### Ventajas de utilizar arreglos

Entre las principales ventajas de los arreglos se encuentran:

- Permiten almacenar múltiples datos utilizando una sola variable.
- Facilitan el procesamiento de grandes cantidades de información.
- Reducen la cantidad de variables necesarias dentro del programa.
- Son rápidos y eficientes para acceder a los elementos mediante su índice.
- Constituyen la base para comprender estructuras de datos más avanzadas como listas, pilas, colas y matrices.

### Limitaciones de los arreglos

Aunque los arreglos son muy útiles, también presentan algunas limitaciones:

- Su tamaño no puede modificarse después de su creación.
- Solo almacenan elementos del mismo tipo de dato.
- Insertar o eliminar elementos puede requerir mover información de una posición a otra.
- Cuando se necesita una colección dinámica, generalmente es preferible utilizar una ```List<T>```.

### Buenas prácticas

Al trabajar con arreglos se recomienda:

- Utilizar nombres descriptivos para los arreglos.
- Recorrer los arreglos utilizando la propiedad Length en lugar de escribir el tamaño manualmente.
- Validar siempre la información capturada por el usuario.
- Evitar acceder a posiciones que no existan, ya que se producirá una excepción **IndexOutOfRangeException**.
- Utilizar foreach cuando únicamente se necesite leer la información.
- Utilizar for cuando sea necesario modificar los elementos o conocer su índice.
# Documentación del proyecto

**Nombre del proyecto:** **Ejemplo 12 – Introducción a Programación Orientada a Objetos**

**Elaborado por:** **Anthony Silva**

**Fecha de elaboración:** **11 / 08 / 2026**

---

### Objetivo del proyecto

Crear un programa en C# que permita introducir los fundamentos de la Programación Orientada a Objetos (POO), comprendiendo el concepto de clase, objeto, propiedades, constructor y métodos mediante el desarrollo de una clase `Alumno`.

---

### Objetivos del proyecto

1. Comprender qué es la Programación Orientada a Objetos.
2. Identificar el concepto de clase como un molde para crear objetos.
3. Comprender qué es un objeto dentro de C#.
4. Aprender a declarar propiedades dentro de una clase.
5. Comprender el funcionamiento de un constructor.
6. Aprender a crear objetos utilizando la palabra clave `new`.
7. Identificar la diferencia entre datos y comportamientos de un objeto.
8. Aprender a crear métodos dentro de una clase.
9. Comprender cómo acceder y modificar las propiedades de un objeto.
10. Reforzar la organización del código mediante clases y objetos.

---

### Características del proyecto

* Tipo de proyecto: **Aplicación de consola**
* Versión de Visual Studio: **2026**
* Versión de C#: **.NET 10.0**
* Lenguaje de programación: **C#**
* Paradigma utilizado: **Programación Orientada a Objetos**

---

### Descripción del proyecto

Se ha desarrollado un proyecto en Visual Studio llamado **"Ejemplo 12"**, cuyo propósito es introducir al estudiante en los fundamentos de la Programación Orientada a Objetos en C#.

Para realizar este ejercicio se creó una clase llamada `Alumno`, la cual representa un molde que permite crear objetos que contienen información y comportamientos propios.

La clase `Alumno` contiene:

* Nombre
* Apellido
* Edad

Además, contiene métodos que permiten:

* mostrar la información del alumno,
* y simular una acción mediante el método `Estudiar()`.

Durante la ejecución del programa se crean diferentes objetos a partir de la clase `Alumno`, permitiendo observar que varios objetos pueden pertenecer a la misma clase y contener información diferente.

---

## Explicación general del código

El programa comienza dentro del método `Main`, desde donde se crea y controla la ejecución del programa.

Posteriormente se crean objetos de la clase `Alumno`.

Por ejemplo:

```csharp
Alumno alumno1 = new Alumno(
    "Anthony",
    "Silva",
    25
);
```

En esta instrucción se crea un nuevo objeto utilizando la palabra clave `new`.

El objeto recibe información inicial mediante el constructor de la clase.

Después, el programa utiliza los métodos definidos dentro de la clase para mostrar información y ejecutar comportamientos.

---

## ¿Qué es la Programación Orientada a Objetos?

La Programación Orientada a Objetos, conocida como **POO**, es un paradigma de programación que organiza el software utilizando **clases y objetos**.

En lugar de trabajar únicamente con variables y funciones independientes, POO permite agrupar:

* datos,
* características,
* y comportamientos

dentro de objetos.

Esto permite organizar mejor programas grandes y facilita la reutilización y mantenimiento del código.

---

## ¿Qué es una clase?

Una clase es un **molde o plantilla** que define las características y comportamientos que tendrán los objetos.

En este proyecto se utiliza:

```csharp
class Alumno
```

La clase `Alumno` establece qué información tendrá un alumno y qué acciones podrá realizar.

La clase por sí misma funciona como una definición.

No representa necesariamente a un alumno específico, sino el modelo que se utilizará para crear alumnos.

---

## ¿Qué es un objeto?

Un objeto es una **instancia de una clase**.

Por ejemplo:

```csharp
Alumno alumno1 = new Alumno(
    "Anthony",
    "Silva",
    25
);
```

En este caso:

* `Alumno` es la clase.
* `alumno1` es el objeto.
* `new` crea la instancia.
* `Alumno(...)` llama al constructor.

Podemos tener varios objetos creados a partir de la misma clase.

Por ejemplo:

```csharp
Alumno alumno1 = new Alumno ("Anthony", "Silva", 25);

Alumno alumno2 = new Alumno ("Carlos", "García", 20);
```

Ambos objetos pertenecen a la clase `Alumno`, pero contienen información diferente.

---

## Relación entre clase y objeto

La relación puede representarse de la siguiente manera:

```text
CLASE
Alumno
   │
   ├───────────────┐
   ↓               ↓
OBJETO          OBJETO
alumno_1         alumno_2

Anthony         Carlos
Silva           García
25              20
```

La clase funciona como el molde y los objetos son las instancias creadas a partir de dicho molde.

---

## ¿Qué son las propiedades?

Las propiedades representan las características o datos que pertenecen a un objeto.

En este proyecto se utilizan:

```csharp
public string Nombre { get; set; }

public string Apellido { get; set; }

public int Edad { get; set; }
```

Estas propiedades permiten almacenar información relacionada con cada objeto.

Por ejemplo:

```csharp
alumno_1.Nombre
alumno_1.Apellido
alumno_1.Edad
```

Cada objeto mantiene sus propios valores.

---

## ¿Qué significa `get` y `set`?

Las propiedades utilizan:

```csharp
get
set
```

`get` permite **obtener o leer** el valor de la propiedad.

`set` permite **asignar o modificar** el valor de la propiedad.

Por ejemplo:

```csharp
alumno_2.Nombre = "Carlos García";
```

Aquí se está utilizando `set` para modificar el valor de `Nombre`.

Cuando hacemos:

```csharp
Console.WriteLine(alumno_2.Nombre);
```

estamos utilizando `get` para obtener el valor.

---

## ¿Qué es un constructor?

Un constructor es un método especial que se ejecuta automáticamente cuando se crea un objeto.

En este proyecto se utiliza:

```csharp
public Alumno(
    string nombre,
    string apellido,
    int edad)
{
    Nombre = nombre;
    Apellido = apellido;
    Edad = edad;
}
```

El constructor recibe información y la utiliza para inicializar el objeto.

Cuando ejecutamos:

```csharp
new Alumno(
    "Anthony",
    "Silva",
    25
);
```

se llama automáticamente al constructor.

---

## ¿Por qué se utiliza `new`?

La palabra clave `new` se utiliza para crear una nueva instancia de una clase.

Por ejemplo:

```csharp
Alumno alumno_1 = new Alumno(
    "Anthony",
    "Silva",
    25
);
```

Sin `new`, no estaríamos creando una nueva instancia del objeto.

Podemos imaginarlo como:

```text
CLASE
  ↓
new
  ↓
OBJETO
```

---

## ¿Qué son los métodos?

Los métodos representan acciones o comportamientos que puede realizar un objeto.

En este proyecto se utilizan:

```csharp
Mostrar_Informacion()
```

y:

```csharp
Estudiar()
```

Por ejemplo:

```csharp
alumno_1.Estudiar();
```

Esto indica que el objeto `alumno_1` está ejecutando el comportamiento `Estudiar()`.

---

## Datos y comportamientos

Uno de los conceptos más importantes al comenzar POO es entender que un objeto puede contener:

### Datos

```text
Nombre
Apellido
Edad
```

### Comportamientos

```text
Mostrar_Informacion()
Estudiar()
```

Por lo tanto:

```text
                OBJETO ALUMNO
                      │
             ┌────────┴────────┐
             │                 │
           DATOS          COMPORTAMIENTOS
             │                 │
          Nombre             Estudiar()
          Apellido           Mostrar_Informacion()
          Edad
```

Esta combinación es una de las bases de la Programación Orientada a Objetos.

---

## Explicación de las funciones principales

### 1. `Main()`

Es el punto de entrada de la aplicación.

Desde este método se crean los objetos de la clase `Alumno` y se ejecutan sus métodos.

### 2. `Alumno()`

Es el constructor de la clase.

Su función es recibir los valores iniciales del objeto y asignarlos a sus propiedades.

### 3. `Mostrar_Informacion()`

Muestra en consola los datos almacenados en las propiedades del objeto.

### 4. `Estudiar()`

Representa un comportamiento del objeto.

En este ejemplo muestra un mensaje indicando que el alumno está estudiando programación.

---

## ¿Por qué utilizar clases?

Las clases permiten organizar mejor la información y el comportamiento de los objetos.

En lugar de tener variables separadas como:

```csharp
string nombre;
string apellido;
int edad;
```

podemos agruparlas dentro de una clase:

```csharp
class Alumno
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int Edad { get; set; }
}
```

Esto facilita la organización del programa.

---

## Ventajas de utilizar POO

* Permite organizar mejor el código.
* Facilita la reutilización de código.
* Permite representar objetos del mundo real dentro de un programa.
* Agrupa datos y comportamientos relacionados.
* Facilita el mantenimiento de aplicaciones grandes.
* Prepara al estudiante para conceptos como herencia, encapsulamiento y polimorfismo.

---

## Limitaciones del ejemplo

Este proyecto es una introducción básica a POO, por lo que todavía no incluye conceptos más avanzados.

No se implementan todavía:

* herencia,
* polimorfismo,
* interfaces,
* clases abstractas,
* encapsulamiento avanzado,
* patrones de diseño.

Estos conceptos pueden estudiarse posteriormente, una vez que el estudiante comprenda correctamente las bases de las clases y los objetos.

---

## Buenas prácticas aplicadas en el proyecto

* Utilizar nombres descriptivos para clases, propiedades y métodos.
* Mantener cada clase enfocada en una responsabilidad.
* Separar la creación de objetos de la definición de la clase.
* Utilizar constructores para inicializar objetos.
* Mantener una estructura de código clara y organizada.
* Utilizar métodos para representar comportamientos.
* Utilizar propiedades para representar las características de los objetos.

---

## Conclusión

Este proyecto representa la primera introducción del estudiante a la Programación Orientada a Objetos en C#.

A través de la clase `Alumno`, se puede comprender que una clase funciona como un molde y que los objetos son instancias creadas a partir de ese molde.

Además, se introducen conceptos fundamentales como:

* clases,
* objetos,
* propiedades,
* constructores,
* métodos,
* `get`,
* `set`,
* y `new`.

Comprender estos conceptos es fundamental antes de avanzar hacia temas más avanzados de POO.

La correcta comprensión de esta primera etapa permitirá que el estudiante posteriormente pueda estudiar conceptos como encapsulamiento, herencia, polimorfismo, abstracción e interfaces.

---

## Nota final

Este proyecto representa solamente el primer acercamiento a la Programación Orientada a Objetos.

La siguiente etapa natural será profundizar en el **encapsulamiento**, comprendiendo cómo proteger los datos de un objeto mediante modificadores de acceso y métodos o propiedades controladas.

Posteriormente se podrá avanzar hacia **herencia, polimorfismo y abstracción**, utilizando ejemplos cada vez más cercanos a sistemas reales.

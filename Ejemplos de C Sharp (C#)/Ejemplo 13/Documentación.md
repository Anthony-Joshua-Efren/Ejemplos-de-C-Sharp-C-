# Documentación del proyecto

**Nombre del proyecto:** **Ejemplo 13 – POO: Clase Persona y cálculo de IMC**

**Elaborado por:** **Anthony Silva**

**Fecha de elaboración:** **15 / 08 / 2026**

---

### Objetivo del proyecto

Crear un programa en C# utilizando Programación Orientada a Objetos que permita representar una persona mediante una clase, almacenar sus datos y calcular su Índice de Masa Corporal (IMC), aplicando además validaciones de entrada para garantizar que la información proporcionada por el usuario sea válida.

---

### Objetivos del proyecto

1. Reforzar los conceptos fundamentales de Programación Orientada a Objetos.
2. Comprender cómo representar una entidad mediante una clase.
3. Utilizar atributos privados para almacenar el estado interno de un objeto.
4. Implementar métodos para solicitar, procesar y mostrar información.
5. Comprender el funcionamiento de un objeto creado mediante `new`.
6. Aplicar validaciones sobre datos ingresados por el usuario.
7. Utilizar `TryParse()` para validar valores numéricos.
8. Utilizar `string.IsNullOrWhiteSpace()` para validar cadenas de texto.
9. Comprender la importancia de evitar valores inválidos como números negativos o cero.
10. Aplicar la fórmula del Índice de Masa Corporal dentro de una clase.

---

### Características del proyecto

* Tipo de proyecto: **Aplicación de consola**
* Versión de Visual Studio: **2026**
* Versión de C#: **.NET 10.0**
* Lenguaje de programación: **C#**
* Paradigma utilizado: **Programación Orientada a Objetos**
* Clase principal del modelo: **Persona**

---

### Descripción del proyecto

Se ha desarrollado un proyecto en Visual Studio llamado **"Ejemplo 13"**, cuyo propósito es continuar el aprendizaje de Programación Orientada a Objetos mediante la creación de una clase llamada `Persona`.

La clase representa a una persona y contiene información relacionada con:

* nombre,
* peso,
* estatura,
* IMC.

El programa solicita estos datos al usuario y posteriormente calcula el Índice de Masa Corporal.

Después del cálculo, el programa muestra una clasificación basada en el valor obtenido.

Además, se implementan diferentes validaciones para evitar que el usuario introduzca información incorrecta.

---

## Explicación general del código

El programa está dividido principalmente en dos partes:

```text
Program.cs
    │
    └── Main()
          │
          └── crea el objeto Persona

Persona.cs
    │
    ├── atributos
    ├── métodos
    ├── cálculo
    └── validaciones
```

El método `Main()` es el punto de entrada del programa y se encarga de crear el objeto.

La clase `Persona` contiene la información y los comportamientos relacionados con dicho objeto.

---

## ¿Qué es una clase?

Una clase es un molde que permite definir las características y comportamientos que tendrán los objetos.

En este proyecto se utiliza:

```csharp
class Persona
```

Esta clase representa el modelo utilizado para crear un objeto de tipo `Persona`.

---

## ¿Qué es un objeto?

Un objeto es una instancia de una clase.

En el programa se crea mediante:

```csharp
Persona persona = new Persona();
```

Aquí:

* `Persona` representa el tipo.
* `persona` es el nombre del objeto.
* `new` crea una nueva instancia.
* `Persona()` ejecuta el constructor de la clase.

Podemos representar la relación así:

```text
             CLASE
            Persona
               │
              new
               │
               ↓
             OBJETO
            persona
```

---

## Atributos privados

La clase contiene:

```csharp
private string? nombre;
private double peso = 0.0;
private double estatura = 0.0;
private double imc = 0.0;
```

Estos atributos representan el **estado interno del objeto**.

Se utilizan como `private` para evitar que otras clases puedan modificarlos directamente.

Esto introduce al estudiante al concepto de **encapsulamiento**.

---

## ¿Qué significa `private`?

El modificador `private` indica que el elemento solamente puede ser utilizado directamente desde la misma clase donde fue declarado.

Por ejemplo:

```csharp
private double peso;
```

El atributo `peso` pertenece internamente a la clase `Persona`.

Esto permite controlar cómo se modifican los datos y evitar cambios incorrectos.

---

## Método `Solicitar_Datos()`

El método:

```csharp
public void Solicitar_Datos()
```

se encarga de solicitar al usuario toda la información necesaria.

Dentro de este método se utilizan métodos de validación para garantizar que los datos sean correctos.

Los valores solicitados son:

* nombre,
* peso,
* estatura.

---

## Validación del nombre

Para validar el nombre se utiliza:

```csharp
string.IsNullOrWhiteSpace(entrada)
```

Esta función permite identificar si una cadena:

* es `null`,
* está vacía,
* o contiene únicamente espacios.

Por ejemplo:

```text
[Enter]
```

no es un nombre válido.

Tampoco:

```text
"        "
```

Por eso el programa vuelve a solicitar el dato hasta recibir un valor válido.

Además, se utiliza:

```csharp
entrada.Trim()
```

para eliminar espacios innecesarios al inicio y al final del texto.

---

## Validación de números con `TryParse()`

Para leer números se utiliza:

```csharp
double.TryParse(
    entrada,
    out double valor
)
```

Esto permite verificar si el texto introducido puede convertirse correctamente a un número decimal.

Por ejemplo:

```text
70.5   → válido
80     → válido
abc    → inválido
```

Esto evita que el programa falle al intentar convertir directamente una entrada incorrecta.

---

## Validación del peso

No basta con verificar que el peso sea un número.

También debemos comprobar que sea mayor que cero.

Por eso se utiliza:

```csharp
if (valor > 0)
{
    return valor;
}
```

De esta manera:

```text
-70 → inválido
0   → inválido
70  → válido
```

Esta validación permite que el programa rechace valores que no son válidos para el cálculo.

---

## Validación de la estatura

La estatura utiliza la misma lógica.

Debe cumplirse:

```csharp
valor > 0
```

Esto es especialmente importante porque la estatura se utiliza como divisor en la fórmula del IMC.

Una estatura de `0` provocaría una división entre cero.

---

## Método `Calcular_IMC()`

El método:

```csharp
public double Calcular_IMC()
```

realiza el cálculo:

```text
IMC = peso / estatura²
```

En C# se implementa como:

```csharp
imc = peso / (estatura * estatura);
```

El resultado se guarda en el atributo:

```csharp
private double imc;
```

y posteriormente se devuelve mediante:

```csharp
return imc;
```

---

## Método `Imprimir_Información()`

Este método se encarga de mostrar los datos almacenados en el objeto.

También llama al método:

```csharp
Calcular_IMC();
```

para obtener el resultado.

Después utiliza una estructura `if / else if / else` para mostrar una clasificación según el valor calculado.

---

## Uso de `if`, `else if` y `else`

El programa utiliza condiciones para determinar la clasificación:

```csharp
if (imcValor < 18.5)
{
    ...
}
else if (...)
{
    ...
}
else if (...)
{
    ...
}
else
{
    ...
}
```

Esto permite que el programa tome una decisión dependiendo del resultado obtenido.

De esta forma se combinan dos conceptos:

```text
POO
+
Estructuras condicionales
```

---

## Uso de colores en consola

El programa utiliza:

```csharp
Console.ForegroundColor
```

para cambiar temporalmente el color del texto.

Por ejemplo:

```csharp
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(" Clasificación: Peso normal");
Console.ResetColor();
```

Después de mostrar el mensaje se utiliza:

```csharp
Console.ResetColor();
```

para restaurar el color normal.

También se utiliza una secuencia ANSI para mostrar el texto de sobrepeso en naranja.

---

## Método `Leer_Double_Positivo()`

Este método es importante porque permite reutilizar una misma validación.

Recibe:

```csharp
string mensaje
string mensajePositivo
```

y verifica dos condiciones:

1. Que la entrada sea un número.
2. Que el número sea mayor que cero.

Esto permite utilizar el mismo método tanto para el peso como para la estatura.

---

## ¿Por qué crear métodos de validación?

Separar las validaciones en métodos permite evitar repetir código.

En lugar de escribir nuevamente toda la lógica para peso y estatura, se reutiliza:

```csharp
Leer_Double_Positivo()
```

Esto hace que el programa sea:

* más organizado,
* más fácil de leer,
* más fácil de mantener,
* y más fácil de modificar.

---

## Relación entre POO y el proyecto

El proyecto puede representarse de la siguiente manera:

```text
                    PERSONA
                       │
           ┌───────────┴───────────┐
           │                       │
         DATOS                COMPORTAMIENTOS
           │                       │
        nombre              Solicitar_Datos()
        peso                Calcular_IMC()
        estatura             Imprimir_Información()
        imc
```

La clase `Persona` concentra tanto los datos como las acciones relacionadas con esos datos.

Esto representa uno de los principios fundamentales de la Programación Orientada a Objetos.

---

## Ventajas de utilizar POO en este proyecto

* Permite agrupar los datos relacionados con una persona.
* Permite agrupar comportamientos relacionados con esos datos.
* Facilita la organización del programa.
* Permite reutilizar la clase para crear diferentes personas.
* Introduce el concepto de encapsulamiento mediante atributos privados.
* Facilita la ampliación del programa en futuras versiones.

---

## Buenas prácticas aplicadas en el proyecto

* Utilizar nombres descriptivos.
* Mantener los atributos como `private`.
* Separar cada responsabilidad en un método.
* Validar los datos antes de utilizarlos.
* Utilizar `TryParse()` para entradas numéricas.
* Evitar valores iguales o menores que cero para peso y estatura.
* Utilizar `Trim()` para limpiar entradas de texto.
* Utilizar comentarios para documentar conceptos importantes.
* Mantener el código organizado en clases.
* Utilizar métodos reutilizables para evitar duplicación.

---

## Conclusión

Este proyecto representa una continuación del estudio de la Programación Orientada a Objetos mediante la creación de una clase `Persona`.

A través de esta clase, el estudiante puede observar cómo se pueden agrupar datos y comportamientos relacionados dentro de un mismo objeto.

Además, el proyecto introduce conceptos importantes como:

* atributos privados,
* métodos,
* objetos,
* encapsulamiento,
* validación de datos,
* `TryParse()`,
* `string.IsNullOrWhiteSpace()`,
* y reutilización de métodos.

La incorporación de validaciones también permite comprender que un programa no solamente debe funcionar cuando recibe datos correctos, sino que debe ser capaz de detectar y rechazar información inválida.

Este ejercicio prepara el camino para continuar estudiando conceptos más avanzados de POO, especialmente **encapsulamiento, propiedades, constructores, herencia y polimorfismo**.

---

## Nota final

Este programa representa una aplicación sencilla de Programación Orientada a Objetos.

La clase `Persona` puede ampliarse posteriormente agregando nuevas propiedades y comportamientos.

Como siguiente paso dentro de POO, resulta natural trabajar con **encapsulamiento**, utilizando propiedades y modificadores de acceso para controlar de manera más precisa la lectura y modificación de los datos de un objeto.
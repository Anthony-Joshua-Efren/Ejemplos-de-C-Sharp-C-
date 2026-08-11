# Documentación del proyecto

**Nombre del proyecto:** **Ejemplo 11 – Introducción a matrices**

**Elaborado por:** **Anthony Silva**

**Fecha de elaboración:** **08 / 08 / 2026**

---

### Objetivo del proyecto

Crear un programa en C# que permita comprender el funcionamiento de las matrices como una extensión natural de los arreglos, analizando cómo se almacenan datos en filas y columnas y cómo se pueden recorrer, mostrar, buscar, actualizar y calcular estadísticas sobre ellos.

---

### Objetivos del proyecto

1. Comprender qué es una matriz en C# y cómo se diferencia de un arreglo de una dimensión.
2. Identificar el uso de filas y columnas dentro de una estructura bidimensional.
3. Aprender a declarar, crear y llenar una matriz en consola.
4. Explicar el uso de la sintaxis `[,]` para representar una matriz.
5. Comprender por qué se utilizan dos ciclos `for`, uno para filas y otro para columnas.
6. Diferenciar el uso de `Length` y `GetLength()` al trabajar con matrices.
7. Entender el uso de una variable global para compartir la matriz entre métodos.
8. Analizar el uso de `ref` cuando se desea modificar la variable original desde un método.
9. Practicar búsqueda, actualización y cálculo de estadísticas sobre una matriz.
10. Reforzar la lógica de índices, recorridos y organización del código.

---

### Características del proyecto

* Tipo de proyecto: **Aplicación de consola**
* Versión de Visual Studio: **2026**
* Versión de C#: **.NET 10.0**
* Lenguaje de programación: **C#**
* Estructura de datos principal: **Matriz de dos dimensiones**

---

### Descripción del proyecto

Se ha desarrollado un proyecto en Visual Studio llamado **"Ejemplo 11"**, cuyo propósito es introducir el estudio de las matrices en C# de una manera clara, ordenada y didáctica.

En este proyecto, el estudiante aprenderá a trabajar con una matriz de enteros que puede ser creada, llenada, mostrada, consultada y actualizada desde un menú en consola.

Además, el programa permite calcular la suma, el promedio, el valor mayor y el valor menor de todos los elementos almacenados en la matriz.

Este ejercicio es importante porque las matrices representan un paso más avanzado que los arreglos de una dimensión, ya que ahora la información se organiza en forma de tabla, con filas y columnas.

---

## Explicación general del código

El programa inicia declarando una matriz global:

```csharp
static int[,]? matriz = null;
```

Esta variable está declarada **fuera del método `Main`**, pero dentro de la clase `Program`.
Eso significa que es una **variable global de clase**, porque puede ser utilizada por todos los métodos del programa.

La matriz comienza como `null`, lo que significa que todavía no ha sido creada.

Después, el programa muestra un menú en consola con diferentes opciones para trabajar con la matriz.

La ejecución se mantiene dentro de un ciclo `while`, el cual permite que el menú siga apareciendo hasta que el usuario decida salir del programa.

Cada opción del menú llama a un método diferente, lo que ayuda a organizar mejor el código y a dividir cada tarea en funciones específicas.

---

## ¿Qué es una matriz?

Una matriz es una estructura de datos de **dos dimensiones** que permite almacenar valores organizados en:

* **filas**
* **columnas**

A diferencia de un arreglo de una sola dimensión, donde solo existe una secuencia lineal de posiciones, una matriz representa una tabla.

Por ejemplo:

```csharp
int[,] numeros = new int[3, 4];
```

Esto significa que la matriz tiene:

* 3 filas
* 4 columnas

En total, la matriz contiene 12 posiciones.

---

## ¿Qué significa `[,]`?

La sintaxis `[,]` indica que se trata de una **matriz de dos dimensiones**.

* Un solo `[]` representa un arreglo de una dimensión.
* Dos dimensiones se escriben con `[,]`.

Por eso:

```csharp
int[] arreglo;
```

es un arreglo simple, mientras que:

```csharp
int[,] matriz;
```

es una matriz de filas y columnas.

Esta diferencia es fundamental porque cambia la forma en que se accede a los datos.

En una matriz, cada dato se identifica con dos índices:

```csharp
matriz[fila, columna]
```

Por ejemplo:

```csharp
matriz[0, 0]
```

representa la primera fila y la primera columna.

---

## ¿Qué es una variable global en este programa?

En este proyecto, la matriz se declara como:

```csharp
static int[,]? matriz = null;
```

Esto permite que la variable esté disponible para todos los métodos de la clase.

Se le conoce como una variable global dentro de la clase porque no pertenece solo a un método específico como `Main`, sino que puede ser utilizada en funciones como:

* `Crear_Matriz()`
* `Llenar_Matriz()`
* `Mostrar_Matriz()`
* `Buscar_Valor()`
* `Actualizar_Valor()`
* `Mostrar_Estadisticas()`

Esto resulta útil porque evita estar pasando la matriz como parámetro en cada operación.

En este tipo de ejercicios, usar una variable global ayuda a que el estudiante entienda mejor cómo se comparte la información entre métodos.

---

## ¿Qué significa `ref`?

La palabra clave `ref` indica que un parámetro se pasa **por referencia**.

Esto significa que el método trabaja directamente con la variable original y no con una copia.

Por ejemplo:

```csharp
Llenar_Matriz(ref matriz);
```

En este caso, el método recibe la misma matriz que existe en `Main`, y no una copia independiente.

Esto es útil cuando se quiere modificar la variable original desde otro método.

### Importante

En este proyecto, `ref` no es estrictamente necesario para llenar cada posición de la matriz, porque los elementos de un arreglo o matriz ya pueden modificarse directamente. Sin embargo, se usa aquí como recurso didáctico para mostrar cómo un método puede trabajar directamente con la variable original.

Si en algún momento el método necesitara reemplazar toda la matriz por otra nueva, entonces `ref` sí sería especialmente útil.

---

## ¿Por qué se usan dos `for` con `i` y `j`?

Las matrices tienen dos dimensiones, por eso se necesitan dos ciclos anidados:

* uno para recorrer las **filas**
* otro para recorrer las **columnas**

Generalmente se usa:

* `i` para filas
* `j` para columnas

Por ejemplo:

```csharp
for (int i = 0; i < matriz.GetLength(0); i++)
{
    for (int j = 0; j < matriz.GetLength(1); j++)
    {
        Console.WriteLine(matriz[i, j]);
    }
}
```

### ¿Qué hace cada uno?

* El **primer `for`** avanza por cada fila.
* El **segundo `for`** recorre cada columna dentro de esa fila.

Esto es necesario porque una matriz no tiene una sola secuencia lineal de datos, sino una estructura organizada como tabla.

### Ejemplo visual

Si la matriz tiene este aspecto:

```text
[ 10, 20, 30 ]
[ 40, 50, 60 ]
```

Entonces:

* `i` recorre las dos filas
* `j` recorre las tres columnas de cada fila

Por eso, cuando se quiere llenar, mostrar o buscar dentro de una matriz, casi siempre se usan dos ciclos `for`.

---

## Diferencia entre `Length` y `GetLength()`

Este punto es muy importante para entender matrices.

### `Length`

`Length` devuelve el **total de elementos** que tiene la matriz.

Por ejemplo, si la matriz es de 3 filas por 4 columnas:

```csharp
int[,] matriz = new int[3, 4];
```

entonces:

```csharp
matriz.Length
```

devuelve `12`, porque hay 12 elementos en total.

---

### `GetLength(0)` y `GetLength(1)`

`GetLength()` devuelve el tamaño de una dimensión específica.

* `GetLength(0)` = cantidad de **filas**
* `GetLength(1)` = cantidad de **columnas**

Por ejemplo:

```csharp
matriz.GetLength(0)
```

devuelve `3`.

```csharp
matriz.GetLength(1)
```

devuelve `4`.

---

### ¿Por qué no usar solo `Length`?

Porque `Length` solo indica cuántos elementos existen en total, pero no dice cómo están distribuidos en filas y columnas.

En una matriz necesitamos saber:

* cuántas filas hay,
* cuántas columnas hay.

Por eso `GetLength()` es mejor cuando se trabaja con cada dimensión por separado.

---

## Explicación de las funciones principales

### 1. `Mostrar_Menu()`

Muestra en pantalla todas las opciones disponibles del programa.
Sirve para que el usuario pueda interactuar con el sistema de forma clara y ordenada.

### 2. `Crear_Matriz()`

Solicita al usuario cuántas filas y cuántas columnas tendrá la matriz.

Después crea una matriz nueva con esas dimensiones.

Esta función representa el inicio del manejo de datos bidimensionales.

### 3. `Llenar_Matriz()`

Permite asignar valores a cada posición de la matriz.

Primero recorre las filas y luego las columnas para pedir el dato correspondiente a cada celda.

Esta función es una de las más importantes porque muestra cómo se capturan datos en una estructura bidimensional.

### 4. `Mostrar_Matriz()`

Muestra el contenido de la matriz en consola de manera ordenada.

Aquí el alumno puede observar cómo los datos se presentan en forma de tabla.

### 5. `Buscar_Valor()`

Solicita un valor al usuario y verifica si ese dato existe dentro de la matriz.

Si se encuentra, se muestra la posición exacta donde apareció.

### 6. `Actualizar_Valor()`

Permite modificar el valor de una posición específica de la matriz.

El usuario indica la fila y la columna donde desea hacer el cambio.

### 7. `Mostrar_Estadisticas()`

Calcula y muestra:

* suma,
* promedio,
* mayor,
* menor.

Esta función recorre toda la matriz para analizar sus valores.

### 8. `Leer_Entero()` y `Leer_Entero_En_Rango()`

Estas funciones validan la entrada del usuario para evitar errores al capturar datos.

Son importantes para que el programa sea más seguro y más fácil de usar.

### 9. `Pausa()`

Detiene la ejecución momentáneamente para que el usuario pueda leer el resultado antes de continuar.

---

## Relación entre el programa y las matrices

El programa trabaja con matrices de la siguiente manera:

* **Create:** crear una matriz con filas y columnas.
* **Read:** mostrar y buscar valores.
* **Update:** modificar una posición específica.
* **Delete:** en este ejemplo no se incluye eliminación, porque en matrices de práctica básica normalmente se trabaja más con acceso y modificación que con eliminación directa.

Esto ayuda a que el estudiante comprenda la lógica interna de una matriz antes de avanzar a estructuras más complejas.

---

## Importancia de las matrices

Las matrices son muy útiles porque permiten organizar datos en forma tabular.

Se usan mucho en situaciones como:

* calificaciones de alumnos,
* coordenadas,
* tablas numéricas,
* mapas,
* registros organizados por filas y columnas.

Aprender matrices es importante porque ayuda a desarrollar el pensamiento lógico y a comprender mejor cómo se administran datos estructurados.

---

## Importancia de la estructura bidimensional

El paso de un arreglo simple a una matriz representa una evolución importante.

Un arreglo almacena datos en una sola línea.

Una matriz, en cambio, almacena datos en dos niveles:

* fila
* columna

Eso permite representar mejor la información cuando los datos tienen relación entre sí.

---

## Ventajas de utilizar matrices

* Permiten organizar datos en filas y columnas.
* Ayudan a practicar ciclos anidados.
* Refuerzan el manejo de índices.
* Son útiles para representar tablas.
* Permiten trabajar con información más estructurada.
* Preparan al estudiante para temas posteriores como matrices más grandes, tablas y estructuras más complejas.

---

## Limitaciones de las matrices

* Su tamaño se define al momento de crearlas.
* No pueden crecer automáticamente.
* El acceso requiere conocer correctamente la fila y la columna.
* Su manejo es más complejo que el de un arreglo simple.
* Requieren más cuidado al recorrerlas, porque hay dos dimensiones.

Estas limitaciones explican por qué, más adelante, se estudian estructuras más flexibles.

---

## Buenas prácticas aplicadas en el proyecto

* Utilizar nombres de variables y métodos descriptivos.
* Dividir el código en funciones pequeñas y específicas.
* Validar la información ingresada por el usuario.
* Verificar si la matriz existe antes de manipularla.
* Mostrar mensajes claros en pantalla.
* Evitar errores por índices fuera de rango.
* Mantener el código ordenado y fácil de leer.
* Explicar claramente la relación entre filas, columnas e índices.

---

## Conclusión

Este proyecto sirve como una introducción clara y práctica al uso de matrices en C#.

Gracias a él, el estudiante comprende que una matriz es una estructura de dos dimensiones que organiza información en filas y columnas.

Además, aprende conceptos importantes como:

* variable global,
* sintaxis `[,]`,
* uso de `ref`,
* diferencia entre `Length` y `GetLength()`,
* y por qué se necesitan dos ciclos `for`.

Todo esto ayuda a fortalecer la lógica de programación y prepara al estudiante para temas más avanzados como matrices mayores, tablas de datos y estructuras de información más complejas.

---

## Nota final

Este programa trabaja con una matriz en memoria, por lo que la información se pierde al cerrar la aplicación.

Sin embargo, el valor educativo del proyecto está en comprender la estructura bidimensional y dominar la lógica básica de recorrido, búsqueda y actualización.

La siguiente etapa natural sería ampliar el proyecto con matrices más grandes, operaciones adicionales o incluso persistencia de datos.

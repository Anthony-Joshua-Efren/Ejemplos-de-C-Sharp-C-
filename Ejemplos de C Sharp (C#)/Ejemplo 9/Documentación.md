# Documentación del proyecto

**Nombre del proyecto:** **Ejemplo 9 – Segunda parte: CRUD con arreglos**

**Elaborado por:** **Anthony Silva**

**Fecha de elaboración:** **04 / 08 / 2026**

---

### Objetivo del proyecto

Crear un programa en C# que permita comprender el funcionamiento de los arreglos (arrays) como base para introducir 
el concepto de CRUD, aplicando operaciones de creación, lectura, actualización y eliminación sobre colecciones de 
datos en memoria.

---

### Objetivos del proyecto

1. Reforzar el concepto de arreglo como estructura de datos.
2. Comprender que los arreglos permiten almacenar varios elementos del mismo tipo.
3. Introducir el concepto de CRUD de forma práctica y sencilla.
4. Aprender a crear, mostrar, buscar, actualizar y eliminar datos dentro de un arreglo.
5. Identificar la diferencia entre trabajar con datos temporales en memoria y datos persistentes.
6. Comprender por qué los arreglos son la base para estudiar otras estructuras de datos.
7. Relacionar el uso de arreglos con temas posteriores como matrices, listas, diccionarios y colecciones más avanzadas.
8. Reforzar el uso de métodos, validación de datos y organización del código.

---

### Características del proyecto

* Tipo de proyecto: **Aplicación de consola**
* Versión de Visual Studio: **2026**
* Versión de C#: **.NET 10.0**
* Lenguaje de programación: **C#**

---

### Descripción del proyecto

Se ha desarrollado un proyecto en Visual Studio llamado **"Ejemplo 9"**, cuyo propósito es continuar el estudio de los arreglos en C# e introducir su relación con el concepto de CRUD.

En esta segunda parte, el programa ya no solo permite crear y mostrar arreglos, sino también:

- buscar valores dentro de las posiciones del arreglo,
- calcular estadísticas como suma, promedio, mayor y menor,
- ordenar los elementos,
- actualizar valores existentes,
- y eliminar elementos del arreglo.

Esto permite que el estudiante observe cómo una colección de datos puede ser manipulada paso a paso, tal como ocurre en sistemas más completos donde se administran registros de usuarios, productos, alumnos o cualquier otro tipo de información.

---

## Explicación general del código

El programa inicia declarando dos arreglos:

- un **arreglo definido**,
- y un **arreglo indefinido**.

Ambos comienzan como `null`, lo que significa que todavía no han sido creados. Después, el programa muestra un menú en consola con diferentes opciones para trabajar con ellos.

La ejecución se mantiene dentro de un ciclo `while`, el cual permite que el menú siga apareciendo hasta que el usuario decida salir del programa.

Cada opción del menú llama a un método diferente, lo que ayuda a organizar mejor el código y a dividir cada tarea en funciones específicas.

---

## ¿Qué es un arreglo?

Un arreglo (o `array`) es una estructura de datos que permite almacenar varios valores del mismo tipo utilizando una sola variable.

Cada valor se guarda en una posición específica llamada **índice**.

Por ejemplo:

```csharp
int[] edades = { 18, 19, 20, 21 };
```

En este caso, el arreglo almacena cuatro valores enteros en una sola estructura.

Esto facilita la organización de la información y hace posible recorrer, buscar y modificar datos de forma ordenada.

---

## ¿Qué es CRUD?

CRUD es un acrónimo formado por las iniciales de cuatro operaciones básicas sobre datos:

- **C** = Create → Crear
- **R** = Read → Leer / Mostrar
- **U** = Update → Actualizar
- **D** = Delete → Eliminar

En este proyecto, el CRUD se aplica sobre arreglos para que el estudiante comprenda la lógica de administración de datos antes de pasar a estructuras más avanzadas o a bases de datos.

---

## Relación entre el programa y CRUD

El programa trabaja con CRUD de la siguiente manera:

- **Create:** crear arreglos definidos o indefinidos.
- **Read:** mostrar, recorrer y buscar valores.
- **Update:** modificar un valor ya existente en una posición.
- **Delete:** eliminar un valor del arreglo creando una nueva versión con menos elementos.

Es importante aclarar que en los arreglos la eliminación no ocurre de forma directa como en otras estructuras. Cuando se elimina un elemento, normalmente se crea un nuevo arreglo y se copian los elementos restantes.

---

## Explicación de las funciones principales

### 1. `MostrarMenu()`

Muestra en pantalla todas las opciones disponibles del programa.  
Sirve para que el usuario pueda interactuar con el sistema de forma clara y ordenada.

### 2. `CrearArregloDefinido()`

Solicita al usuario cuántos elementos tendrá el arreglo y después pide cada valor por separado.

Este arreglo se considera **definido** porque sus valores se capturan desde el momento de su creación.

### 3. `CrearArregloIndefinido()`

Crea un arreglo con un tamaño determinado, pero inicialmente sus posiciones contienen valores predeterminados.

Se utiliza para mostrar que un arreglo puede existir aunque todavía no se haya llenado con datos útiles.

### 4. `LlenarArreglo()`

Permite asignar valores a un arreglo ya creado.

Esta función ayuda a reforzar la idea de que los arreglos pueden llenarse de manera progresiva.

### 5. `MostrarArreglos()` y `MostrarArreglo()`

Muestran el contenido de uno o varios arreglos de manera ordenada en la consola.

Estas funciones apoyan la operación de lectura dentro del CRUD.

### 6. `RecorrerArreglos()`, `RecorrerConFor()` y `RecorrerConForeach()`

Permiten recorrer los arreglos usando diferentes estructuras repetitivas.

Esto ayuda al estudiante a comparar el uso de `for` y `foreach`.

### 7. `BuscarValorEnArreglos()` y `BuscarEnArreglo()`

Solicitan un valor al usuario y verifican si ese dato existe dentro del arreglo.

Esta operación es útil para comprender el análisis de datos dentro de una colección.

### 8. `MostrarEstadisticas()` y `EstadisticasArreglo()`

Calculan y muestran información como:

- suma,
- promedio,
- valor mayor,
- valor menor.

Estas operaciones refuerzan el tratamiento matemático de los datos almacenados en el arreglo.

### 9. `ActualizarValor()` y `ActualizarElemento()`

Permiten modificar el valor de una posición específica del arreglo.

Esta parte representa la operación **Update** del CRUD.

### 10. `EliminarValor()` y `EliminarElemento()`

Permiten quitar un elemento del arreglo.

Como los arreglos tienen tamaño fijo, la eliminación se realiza creando un nuevo arreglo más pequeño y copiando los datos restantes.

Esta parte representa la operación **Delete** del CRUD.

### 11. `OrdenarArreglos()` y `OrdenarYMostrar()`

Ordenan los datos de forma ascendente para observar cómo cambia el acomodo de la información.

La función crea una copia del arreglo para no alterar el original.

### 12. `LeerEntero()` y `LeerEnteroEnRango()`

Estas funciones validan la entrada del usuario para evitar errores al capturar datos.

Son importantes para que el programa sea más seguro y más fácil de usar.

### 13. `Pausa()`

Detiene la ejecución momentáneamente para que el usuario pueda leer el resultado antes de continuar.

---

## Importancia del CRUD en esta etapa

Aprender CRUD con arreglos es muy útil porque ayuda a comprender la lógica básica de la administración de información.

Antes de trabajar con bases de datos, el estudiante necesita entender preguntas como:

- ¿Dónde se guarda el dato?
- ¿Cómo se muestra?
- ¿Cómo se cambia?
- ¿Cómo se elimina?
- ¿Qué sucede cuando la información ya no cabe o debe reorganizarse?

Los arreglos permiten practicar estas ideas sin agregar todavía la complejidad de un sistema de base de datos.

---

## Importancia de las colecciones de datos

Los arreglos forman parte del estudio de las **colecciones de datos**, que son estructuras utilizadas para almacenar grupos de información.

Su importancia es fundamental porque después de los arreglos vienen otras estructuras como:

- **Matrices**
- **Listas**
- **Diccionarios**
- **Pilas**
- **Colas**
- **Conjuntos**
- **Colecciones genéricas**

Aprender arreglos primero ayuda a entender la lógica de todas estas estructuras posteriores.

Por ejemplo:

- una **matriz** amplía la idea del arreglo al trabajar con filas y columnas,
- una **lista** permite trabajar con datos de tamaño dinámico,
- un **diccionario** permite guardar información mediante clave y valor.

Por eso, este proyecto no solo enseña arreglos, sino que también prepara al estudiante para el estudio de estructuras de datos más avanzadas.

---

## Valores predeterminados de un arreglo

Cuando un arreglo se crea, sus posiciones reciben un valor inicial según el tipo de dato.

Algunos ejemplos son:

| Tipo de dato | Valor predeterminado |
|:--------------:|:---------------------:|
| int | 0 |
| double | 0.0 |
| decimal | 0.0 |
| bool | false |
| char | '\0' |
| string | null |

Esto explica por qué un arreglo recién creado puede mostrar valores vacíos o por defecto antes de ser llenado por el usuario.

---

## Ventajas de utilizar arreglos

- Permiten almacenar múltiples datos en una sola estructura.
- Facilitan la organización de la información.
- Ayudan a practicar la lógica de recorrido, búsqueda y modificación.
- Son la base para entender otras colecciones de datos.
- Permiten aprender la administración de índices y posiciones.
- Son una excelente introducción al pensamiento algorítmico.

---

## Limitaciones de los arreglos

- Su tamaño se define al momento de crearlos.
- No pueden crecer o disminuir fácilmente.
- Solo almacenan datos del mismo tipo.
- Insertar o eliminar elementos puede requerir crear un nuevo arreglo.
- No son tan flexibles como otras estructuras como `List<T>`.

Estas limitaciones explican por qué, después de estudiar arreglos, resulta natural avanzar hacia listas y otras colecciones.

---

## Buenas prácticas aplicadas en el proyecto

- Utilizar nombres de variables y métodos descriptivos.
- Dividir el código en funciones pequeñas y específicas.
- Validar la información ingresada por el usuario.
- Verificar si el arreglo existe antes de manipularlo.
- Mostrar mensajes claros en pantalla.
- Evitar errores por índices fuera de rango.
- Mantener el código ordenado y fácil de leer.

---

## Conclusión

Este proyecto sirve como una continuación natural del estudio de los arreglos, pero ahora enfocado en el inicio del concepto de CRUD.

Gracias a él, el estudiante comprende que una colección de datos no solo sirve para guardar valores, sino también para administrarlos mediante operaciones de creación, lectura, actualización y eliminación.

Además, este ejercicio prepara el camino para temas más avanzados como matrices, listas, diccionarios y estructuras de datos más complejas, que serán fundamentales en el desarrollo de software.

---

## Nota final

Este programa trabaja con datos en memoria, por lo que al cerrar la aplicación la información se pierde.  
Esto es normal, ya que todavía no se utiliza persistencia de datos como archivos o bases de datos.

La siguiente etapa natural sería guardar la información en un archivo o en una base de datos para conservarla entre ejecuciones.
# Documentación del proyecto

**Nombre del proyecto:** **Ejemplo 10 – CRUD de arreglo y archivo TXT**

**Elaborado por:** **Anthony Silva**

**Fecha de elaboración:** **08 / 08 / 2026**

---

### Objetivo del proyecto

Crear un programa en C# que permita comprender el funcionamiento de los arreglos como base para implementar un CRUD básico, agregando además el uso de archivos `.TXT` para guardar y cargar la información.

---

### Objetivos del proyecto

1. Reforzar el concepto de arreglo como estructura de datos.
2. Comprender que los arreglos permiten almacenar varios elementos del mismo tipo.
3. Introducir el concepto de CRUD de forma práctica y sencilla.
4. Aprender a crear, mostrar, buscar, actualizar y eliminar datos dentro de un arreglo.
5. Identificar la diferencia entre trabajar con datos en memoria y datos persistentes.
6. Comprender cómo se guarda y recupera información mediante archivos de texto.
7. Relacionar el uso de arreglos con temas posteriores como matrices, listas, diccionarios y colecciones más avanzadas.
8. Reforzar el uso de métodos, validación de datos y organización del código.

---

### Características del proyecto

* Tipo de proyecto: **Aplicación de consola**
* Versión de Visual Studio: **2026**
* Versión de C#: **.NET 10.0**
* Lenguaje de programación: **C#**
* Persistencia de datos: **Archivo de texto `.TXT`**

---

### Descripción del proyecto

Se ha desarrollado un proyecto en Visual Studio llamado **"Ejemplo 10"**, cuyo propósito es continuar el estudio de los arreglos en C# e introducir el uso de archivos de texto para almacenar información.

En esta etapa, el programa permite no solo crear y manipular un arreglo, sino también:

* agregar elementos,
* mostrar el contenido completo,
* buscar valores dentro del arreglo,
* actualizar posiciones específicas,
* eliminar elementos,
* guardar la información en un archivo `.TXT`,
* cargar los datos nuevamente desde el archivo,
* y mostrar el contenido almacenado en el archivo de texto.

Esto permite que el estudiante observe cómo una colección de datos puede ser administrada paso a paso y cómo la información puede conservarse aun después de cerrar el programa.

---

## Explicación general del código

El programa inicia declarando un arreglo de enteros:

* el **arreglo** comienza como `null`,
* y posteriormente puede crearse desde el menú principal.

Después, el programa muestra un menú en consola con diferentes opciones para trabajar con el arreglo y con el archivo de texto.

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

* **C** = Create → Crear
* **R** = Read → Leer / Mostrar
* **U** = Update → Actualizar
* **D** = Delete → Eliminar

En este proyecto, el CRUD se aplica sobre un arreglo para que el estudiante comprenda la lógica de administración de datos antes de pasar a estructuras más avanzadas o a bases de datos.

---

## Relación entre el programa y CRUD

El programa trabaja con CRUD de la siguiente manera:

* **Create:** crear el arreglo.
* **Read:** mostrar, recorrer y buscar valores.
* **Update:** modificar un valor ya existente en una posición.
* **Delete:** eliminar un valor del arreglo creando una nueva versión con menos elementos.

Además, se agrega una parte importante:

* **Guardar:** almacenar los datos del arreglo en un archivo `.TXT`.
* **Cargar:** recuperar los datos desde el archivo de texto.

Esto permite conectar el CRUD en memoria con la idea de persistencia de datos.

Es importante aclarar que en los arreglos la eliminación no ocurre de forma directa como en otras estructuras. Cuando se elimina un elemento, normalmente se crea un nuevo arreglo y se copian los elementos restantes.

---

## Explicación de las funciones principales

### 1. `Mostrar_Menu()`

Muestra en pantalla todas las opciones disponibles del programa.
Sirve para que el usuario pueda interactuar con el sistema de forma clara y ordenada.

### 2. `Crear_Arreglo()`

Solicita al usuario cuántos elementos tendrá el arreglo y después crea un arreglo de enteros con ese tamaño.

Esta función representa el inicio del manejo de datos dentro del programa.

### 3. `Agregar_Elemento()`

Permite colocar un valor en una posición específica del arreglo.

Aunque el arreglo tenga tamaño fijo, esta función ayuda a comprender cómo se asignan valores dentro de sus posiciones.

### 4. `Mostrar_Arreglo()` y `Mostrar_Arreglo_Simple()`

Muestran el contenido del arreglo de manera ordenada en la consola.

Estas funciones apoyan la operación de lectura dentro del CRUD.

### 5. `Buscar_Elemento()`

Solicita un valor al usuario y verifica si ese dato existe dentro del arreglo.

Esta operación es útil para comprender el análisis de datos dentro de una colección.

### 6. `Actualizar_Elemento()`

Permite modificar el valor de una posición específica del arreglo.

Esta parte representa la operación **Update** del CRUD.

### 7. `Eliminar_Elemento()`

Permite quitar un elemento del arreglo.

Como los arreglos tienen tamaño fijo, la eliminación se realiza creando un nuevo arreglo más pequeño y copiando los datos restantes.

Esta parte representa la operación **Delete** del CRUD.

### 8. `Guardar_En_TXT()`

Convierte los valores del arreglo en texto y los guarda en un archivo llamado `datos.txt`.

Esta función permite que la información no se pierda cuando el programa termina.

### 9. `Cargar_Desde_TXT()`

Lee el contenido del archivo `datos.txt` y reconstruye nuevamente el arreglo.

Esta función representa la recuperación de la información almacenada.

### 10. `Mostrar_Contenido_TXT()`

Muestra en pantalla el contenido completo del archivo de texto línea por línea.

Esto ayuda al alumno a visualizar cómo quedó guardada la información.

### 11. `Leer_Entero()` y `Leer_Entero_En_Rango()`

Estas funciones validan la entrada del usuario para evitar errores al capturar datos.

Son importantes para que el programa sea más seguro y más fácil de usar.

### 12. `Pausa()`

Detiene la ejecución momentáneamente para que el usuario pueda leer el resultado antes de continuar.

---

## ¿Qué hace la clase `File` en este proyecto?

La clase `File` permite trabajar con archivos de forma directa.

En este proyecto se utiliza principalmente para:

* verificar si el archivo existe con `File.Exists()`,
* guardar datos con `File.WriteAllLines()`,
* leer datos con `File.ReadAllLines()`.

Gracias a esto, el programa ya no depende únicamente de la memoria RAM, sino que puede conservar información en un archivo de texto.

---

## Importancia del CRUD en esta etapa

Aprender CRUD con arreglos es muy útil porque ayuda a comprender la lógica básica de la administración de información.

Antes de trabajar con bases de datos, el estudiante necesita entender preguntas como:

* ¿Dónde se guarda el dato?
* ¿Cómo se muestra?
* ¿Cómo se cambia?
* ¿Cómo se elimina?
* ¿Qué sucede cuando la información ya no cabe o debe reorganizarse?
* ¿Cómo se conserva la información después de cerrar el programa?

Los arreglos permiten practicar estas ideas sin agregar todavía la complejidad de un sistema de base de datos.

---

## Importancia del archivo TXT

El uso del archivo `.TXT` es importante porque introduce la idea de **persistencia de datos**.

Esto significa que la información puede guardarse en un archivo y recuperarse más adelante, incluso después de cerrar y volver a abrir el programa.

Esta parte del proyecto ayuda al estudiante a comprender la diferencia entre:

* **datos en memoria**, que desaparecen al cerrar el programa,
* y **datos persistentes**, que permanecen guardados en un archivo.

---

## Importancia de las colecciones de datos

Los arreglos forman parte del estudio de las **colecciones de datos**, que son estructuras utilizadas para almacenar grupos de información.

Su importancia es fundamental porque después de los arreglos vienen otras estructuras como:

* **Matrices**
* **Listas**
* **Diccionarios**
* **Pilas**
* **Colas**
* **Conjuntos**
* **Colecciones genéricas**

Aprender arreglos primero ayuda a entender la lógica de todas estas estructuras posteriores.

Por ejemplo:

* una **matriz** amplía la idea del arreglo al trabajar con filas y columnas,
* una **lista** permite trabajar con datos de tamaño dinámico,
* un **diccionario** permite guardar información mediante clave y valor.

Por eso, este proyecto no solo enseña arreglos, sino que también prepara al estudiante para el estudio de estructuras de datos más avanzadas.

---

## Valores predeterminados de un arreglo

Cuando un arreglo se crea, sus posiciones reciben un valor inicial según el tipo de dato.

Algunos ejemplos son:

| Tipo de dato | Valor predeterminado |
| :----------: | :------------------: |
|      int     |           0          |
|    double    |          0.0         |
|    decimal   |          0.0         |
|     bool     |         false        |
|     char     |         '\0'         |
|    string    |         null         |

Esto explica por qué un arreglo recién creado puede mostrar valores vacíos o por defecto antes de ser llenado por el usuario.

---

## Ventajas de utilizar arreglos

* Permiten almacenar múltiples datos en una sola estructura.
* Facilitan la organización de la información.
* Ayudan a practicar la lógica de recorrido, búsqueda y modificación.
* Son la base para entender otras colecciones de datos.
* Permiten aprender la administración de índices y posiciones.
* Son una excelente introducción al pensamiento algorítmico.

---

## Limitaciones de los arreglos

* Su tamaño se define al momento de crearlos.
* No pueden crecer o disminuir fácilmente.
* Solo almacenan datos del mismo tipo.
* Insertar o eliminar elementos puede requerir crear un nuevo arreglo.
* No son tan flexibles como otras estructuras como `List<T>`.

Estas limitaciones explican por qué, después de estudiar arreglos, resulta natural avanzar hacia listas y otras colecciones.

---

## Buenas prácticas aplicadas en el proyecto

* Utilizar nombres de variables y métodos descriptivos.
* Dividir el código en funciones pequeñas y específicas.
* Validar la información ingresada por el usuario.
* Verificar si el arreglo existe antes de manipularlo.
* Mostrar mensajes claros en pantalla.
* Evitar errores por índices fuera de rango.
* Mantener el código ordenado y fácil de leer.
* Guardar la información de forma sencilla en un archivo de texto.

---

## Conclusión

Este proyecto sirve como una continuación natural del estudio de los arreglos, pero ahora enfocado en el inicio del concepto de CRUD y en el uso básico de archivos de texto.

Gracias a él, el estudiante comprende que una colección de datos no solo sirve para guardar valores, sino también para administrarlos mediante operaciones de creación, lectura, actualización y eliminación.

Además, se introduce la idea de persistencia de datos, lo cual es un paso muy importante para después trabajar con archivos más completos o con bases de datos.

Este ejercicio también prepara el camino para temas más avanzados como matrices, listas, diccionarios y estructuras de datos más complejas, que serán fundamentales en el desarrollo de software.

---

## Nota final

Este programa trabaja con datos en memoria y con un archivo `.TXT` como apoyo para guardar la información.

La siguiente etapa natural sería trabajar con más funciones de la clase `File`, o incluso guardar la información en una base de datos para manejar registros de manera más profesional.

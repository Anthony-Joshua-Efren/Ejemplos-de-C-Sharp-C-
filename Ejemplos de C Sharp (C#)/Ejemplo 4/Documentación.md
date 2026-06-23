# Documentación del proyecto

Nombre del proyecto: **Ejemplo 4**

Elaborado por: **Anthony Silva**

Fecha de elaboración: **20 / 06 / 2026**

---

### Objetivo del proyecto

Crear un programa en C# que muestre el uso y ejemplos del objeto Random para generar números aleatorios, y aplique
algunos métodos comunes a esos números.

---

### Objetivos del proyecto

1. Conocer y aplicar el uso del objeto Random en C# para generar números aleatorios.
2. Utilizar métodos comunes de la clase Random para generar números enteros y números decimales.
3. Validar la generación de números aleatorios para asegurarse de que se encuentran dentro de un rango específico.
4. Mostrar los resultados de los números aleatorios generados por el programa.
5. Desarrollar habilidades para trabajar con números aleatorios en C#.

---

### Características del proyecto

- Tipo de proyecto: **Aplicación de consola**
- Versión de Visual Studio: **2026**
- Versión de C#: **.NET 10.0**

---

### Descripción del proyecto

Se ha creado un proyecto en Visual Studio llamado "Ejemplo 4". El proyecto contiene un programa que aplica el uso y
ejemplos del objeto Random para generar números aleatorios. El programa genera números enteros y decimales aleatorios,
y muestra los resultados en la consola. Además, el programa valida que los números generados se encuentren dentro de 
un rango específico.

---

### Notas del proyecto

Este programa es un ejemplo sencillo que muestra cómo usar el objeto Random en C# para generar números aleatorios.

- Random: El objeto Random se utiliza para generar números aleatorios en C#. Se pueden generar números enteros y decimales.
- Next(max) genera enteros hasta un máximo específico (excluyendo el máximo).
- Next(min, max) genera enteros en un rango específico (excluyendo el máximo).
- NextDouble() genera decimales entre 0 y 1 (excluyendo el 1).
- También sirve para elegir elementos al azar de arreglos o listas usando Next(0, array.Length) para obtener un índice aleatorio.

La creación de una instancia (constructor) significa que se puede usar el objeto Random para generar números aleatorios en el programa. 
Es importante crear una sola instancia de Random y reutilizarla para evitar problemas de generación de números aleatorios repetidos debido a la semilla basada en el tiempo.
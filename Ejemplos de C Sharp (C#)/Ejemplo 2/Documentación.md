# Documentación del proyecto

Nombre del proyecto: **Ejemplo 2**

Elaborado por: **Anthony Silva**

Fecha de elaboración: **10 / 06 / 2026**

---

### Objetivo del proyecto

Crear un programa en C# que muestre las cuatro operaciones básicas (suma, resta, multiplicación y división)
utilizando dos números ingresados por el usuario.

---

### Objetivos del proyecto

1. Conocer y aplicar las operaciones básicas de matemáticas en C#.
2. Aprender a recibir y manejar la entrada del usuario en una aplicación de consola.
3. Desarrollar habilidades para escribir código limpio y bien documentado.
4. Utilizar funciones para organizar el código y mejorar su legibilidad.
5. Conocer y usar las variables de tipo numérico en C#.

---

### Características del proyecto

- Tipo de proyecto: **Aplicación de consola**
- Versión de Visual Studio: **2026**
- Versión de C#: **.NET 10.0**

---

### Descripción del proyecto

Se ha creado un proyecto en Visual Studio llamado "Ejemplo 2". El proyecto contiene un programa que aplica
las cuatro operaciones básicas de matemáticas (suma, resta, multiplicación y división) utilizando dos números
ingresados por el usuario. El programa solicita al usuario que ingrese dos números y luego muestra los resultados
de las operaciones realizadas con esos números.

---

### Notas del proyecto

Static: La palabra clave "static" se utiliza para declarar miembros de una clase que pertenecen a 
la clase en sí, en lugar de a instancias específicas de la clase. En el código proporcionado,
los métodos "Suma", "Resta", "Multiplicación" y "División" están declarados como estáticos, lo que
significa que pueden ser llamados directamente desde el método "Main" sin necesidad de crear una
instancia de la clase "Program". Esto es útil para métodos que no dependen del estado de un objeto
específico y que pueden ser compartidos por todas las instancias de la clase.

En este caso, dado que los métodos realizan operaciones matemáticas simples, no requieren acceso a
datos específicos de una instancia, por lo que es apropiado declararlos como estáticos.

Void: La palabra clave "void" se utiliza para indicar que un método no devuelve ningún valor en el código.

Convert.ToDouble: El método "Convert.ToDouble" se utiliza para convertir una cadena de texto (string)
a un número de tipo double. En el código proporcionado, se utiliza para convertir la entrada del usuario,
que es una cadena, a un número de tipo double para realizar las operaciones matemáticas.
Si el usuario ingresa un valor que no se puede convertir a un número, se lanzará una excepción.
Es importante manejar esta situación adecuadamente en un programa real para evitar errores en tiempo de ejecución.

Otro caso podría ser el uso de "double.Parse" o "double.TryParse" para convertir la entrada del usuario a un número de tipo double.
Sin embargo, "Convert.ToDouble" es una opción común y conveniente para realizar esta conversión, ya que maneja automáticamente
los casos en los que la entrada no es un número válido, lanzando una excepción en lugar de devolver un valor predeterminado.

En cualquier caso, es importante asegurarse de que la entrada del usuario sea válida antes de intentar convertirla a un número
para evitar errores en tiempo de ejecución.

\n: El carácter "\n" se utiliza para representar un salto de línea en una cadena de texto en el código proporcionado.

using System (Puede ser omitido si se utiliza el nombre completo de la clase Console cada vez que se necesite, es decir, System.Console.)
# Documentación del proyecto

Nombre del proyecto: **Ejemplo 3**

Elaborado por: **Anthony Silva**

Fecha de elaboración: **13 / 06 / 2026**

---

### Objetivo del proyecto

Crear un programa en C# que muestre el uso de una variable de tipo cadena (string) y aplique algunos métodos 
comunes a esa cadena, como convertir a mayúsculas, minúsculas, obtener la longitud, extraer una subcadena, 
reemplazar espacios por guiones bajos y verificar si la cadena contiene una letra específica.

---

### Objetivos del proyecto

1. Conocer y aplicar la declaración de variables de tipo cadena (string) en C#.
2. Utilizar métodos comunes de la clase String para manipular y obtener información de las cadenas.
3. Validar la entrada del usuario para manejar casos en los que no se ingresa un nombre o solo se ingresan espacios en blanco.
4. Mostrar los resultados de las operaciones realizadas con la cadena ingresada por el usuario.
5. Desarrollar habilidades para trabajar con cadenas de texto en C#.
6. Comprender la importancia de manejar correctamente las entradas del usuario para evitar errores en tiempo de ejecución.

---

### Características del proyecto

- Tipo de proyecto: **Aplicación de consola**
- Versión de Visual Studio: **2026**
- Versión de C#: **.NET 10.0**

---

### Descripción del proyecto

Se ha creado un proyecto en Visual Studio llamado "Ejemplo 3". El proyecto contiene un programa que aplica el uso 
de una variable de tipo cadena (string) para almacenar el nombre completo del usuario. El programa solicita al 
usuario que ingrese su nombre completo, y luego muestra el nombre ingresado junto con algunos métodos comunes 
que se pueden aplicar a las cadenas, como convertir a mayúsculas, minúsculas, obtener la longitud, extraer una 
subcadena, reemplazar espacios por guiones bajos y verificar si la cadena contiene una letra específica.

---

### Notas del proyecto

Este programa es un ejemplo sencillo que muestra cómo usar una variable de tipo cadena (string) en C#.

El programa solicita al usuario que ingrese su nombre completo, y luego muestra el nombre ingresado junto
con algunos métodos comunes que se pueden aplicar a las cadenas, como convertir a mayúsculas, minúsculas,
obtener la longitud, extraer una subcadena, reemplazar espacios por guiones bajos y verificar si la cadena
contiene una letra específica. Además, el programa maneja el caso en que el usuario no ingresa ningún nombre 
o solo espacios en blanco.

- string?: El símbolo "?" después del tipo de dato "string" indica que la variable "Nombre_Completo" es nullable,
lo que significa que puede contener un valor nulo (null) además de una cadena de texto válida.

Esto es útil para manejar situaciones en las que el usuario no ingresa ningún nombre o solo espacios en blanco,
ya que en esos casos la variable puede quedar sin asignar o contener un valor nulo. Al usar "string?", el programa 
puede verificar si la variable es nula o contiene una cadena vacía antes de intentar realizar operaciones con ella, 
evitando así posibles errores en tiempo de ejecución.

- IsNullOrWhiteSpace: El método "string.IsNullOrWhiteSpace" se utiliza para verificar si una cadena es nula,
está vacía o contiene solo espacios en blanco. En el código proporcionado, se utiliza para validar la entrada
del usuario antes de mostrar el nombre completo y los métodos aplicados a la cadena.

Si el usuario no ingresa ningún nombre o solo espacios en blanco, el programa muestra un mensaje indicando
que no se ingresó ningún nombre. Esto ayuda a evitar errores al intentar realizar operaciones con una cadena
que no contiene información válida.

Se puede concatenar cadenas utilizando el operador "+" o mediante interpolación de cadenas con la sintaxis
$"Texto {Variable}".

- \n: Es un carácter de escape que representa una nueva línea. Se utiliza para separar el texto en diferentes
líneas al mostrar la salida en la consola.

- ToUpper(): Es un método de la clase String que convierte todos los caracteres de una cadena a mayúsculas.
- ToLower(): Es un método de la clase String que convierte todos los caracteres de una cadena a minúsculas.
- Length: Es una propiedad de la clase String que devuelve el número de caracteres en una cadena.
- Substring(int startIndex, int length): Es un método de la clase String que devuelve una subcadena a partir de un 
índice de inicio y una longitud especificada.
- Replace(string oldValue, string newValue): Es un método de la clase String que reemplaza todas las ocurrencias.
- Contains(string value): Es un método de la clase String que verifica si una cadena contiene una subcadena específica 
y devuelve un valor booleano (true o false).
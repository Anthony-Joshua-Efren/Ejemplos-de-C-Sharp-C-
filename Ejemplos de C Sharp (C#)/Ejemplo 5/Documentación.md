# Documentación del proyecto

Nombre del proyecto: **Ejemplo 5**

Elaborado por: **Anthony Silva**

Fecha de elaboración: **29 / 06 / 2026**

---

### Objetivo del proyecto

Crear un programa en C# que muestre el uso y ejemplos de los objetos Math y DateTime, permitiendo al usuario 
interactuar con la consola, cambiar colores, realizar cálculos matemáticos y trabajar con fechas y horas.

---

### Objetivos del proyecto

1. Conocer y aplicar el uso de la clase Console para cambiar el color de fondo y el color del texto en la consola.
2. Aprender a utilizar la clase Math para realizar operaciones matemáticas básicas y avanzadas.
3. Aprender a utilizar la clase DateTime para trabajar con fechas y horas en C#.

---

### Características del proyecto

- Tipo de proyecto: **Aplicación de consola**
- Versión de Visual Studio: **2026**
- Versión de C#: **.NET 10.0**

---

### Descripción del proyecto

Se ha creado un proyecto en Visual Studio llamado "Ejemplo 5". El proyecto contiene un programa que aplica el uso y
ejemplos de los objetos Console, Math y DateTime en C#. El programa permite al usuario interactuar con la consola, 
cambiar colores, realizar cálculos matemáticos y trabajar con fechas y horas.

---

### Notas del proyecto

Console nos permite cambiar el color de fondo y el color del texto en la consola, lo que mejora la experiencia del 
usuario al interactuar con la aplicación.

- Console.Title: Permite establecer el título de la ventana de la consola.
- Console.BackgroundColor: Permite establecer el color de fondo de la consola.
- Console.ForegroundColor: Permite establecer el color del texto en la consola.
- Console.ResetColor(): Permite restablecer los colores de la consola a sus valores predeterminados.
- Console.Clear(): Permite limpiar la consola y aplicar los cambios de color.

La clase Math sirve para realizar operaciones matemáticas básicas y avanzadas, como cálculos de raíces cuadradas, 
potencias, redondeos, entre otros. **(No se necesita instanciar la clase Math, ya que sus métodos son estáticos)**.

Algunos métodos de la clase Math son:

- Math.Abs(): Devuelve el valor absoluto de un número.
- Math.Ceiling(): Devuelve el entero más pequeño mayor o igual a un número.
- Math.Floor(): Devuelve el entero más grande menor o igual a un número.
- Math.Round(): Devuelve un número redondeado al entero más cercano.
- Math.Sqrt(): Devuelve la raíz cuadrada de un número.
- Math.Pow(): Devuelve un número elevado a una potencia específica.
- Math.Max(): Devuelve el valor máximo entre dos números.
- Math.Min(): Devuelve el valor mínimo entre dos números.
- Math.PI: Devuelve el valor de PI (3.141592653589793).
- Math.E: Devuelve el valor de E (2.718281828459045).
- Math.Log(): Devuelve el logaritmo natural de un número.
- Math.Log10(): Devuelve el logaritmo en base 10 de un número.
- Math.Exp(): Devuelve el valor de E elevado a la potencia de un número.

La clase DateTime permite trabajar con fechas y horas en C#. Se puede obtener la fecha y hora actual, así como
realizar operaciones con fechas, como sumar o restar días, meses o años.

Algunos métodos y propiedades de la clase DateTime son:

- DateTime.Now: Devuelve la fecha y hora actual.
- DateTime.Today: Devuelve la fecha actual sin la hora.
- DateTime.AddDays(): Permite sumar o restar días a una fecha.
- DateTime.AddMonths(): Permite sumar o restar meses a una fecha.
- DateTime.AddYears(): Permite sumar o restar años a una fecha.
- DateTime.ToString(): Permite convertir una fecha a una cadena de texto con un formato específico.
- DateTime.Parse(): Permite convertir una cadena de texto a un objeto DateTime.
- DateTime.Compare(): Permite comparar dos fechas y determinar cuál es mayor, menor o si son iguales.
- DateTime.Day: Devuelve el día del mes de una fecha.
- DateTime.Month: Devuelve el mes de una fecha.
- DateTime.Year: Devuelve el año de una fecha.
- DateTime.Hour: Devuelve la hora de una fecha.
- DateTime.Minute: Devuelve los minutos de una fecha.
- DateTime.Second: Devuelve los segundos de una fecha.
- DateTime.DayOfWeek: Devuelve el día de la semana de una fecha.
- DateTime.DayOfYear: Devuelve el día del año de una fecha.
- DateTime.IsLeapYear(): Permite determinar si un año es bisiesto o no.
- DateTime.DaysInMonth(): Permite obtener el número de días que tiene un mes específico de un año específico.
- DateTime.ToShortDateString(): Devuelve la fecha en formato corto (dd/MM/yyyy).
- DateTime.ToLongDateString(): Devuelve la fecha en formato largo (día de la semana, día del mes, mes y año).
- DateTime.ToShortTimeString(): Devuelve la hora en formato corto (HH:mm).
- DateTime.ToLongTimeString(): Devuelve la hora en formato largo (HH:mm:ss).
- DateTime.ToUniversalTime(): Convierte la fecha y hora a la hora universal coordinada (UTC).
- DateTime.ToLocalTime(): Convierte la fecha y hora a la hora local del sistema.
namespace Ejemplo_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Introducción a POO en C#";

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=======================================================");
            Console.WriteLine("    INTRODUCCIÓN A PROGRAMACIÓN ORIENTADA A OBJETOS");
            Console.WriteLine("=======================================================");
            Console.ResetColor();

            /*
             * En POO trabajamos con CLASES y OBJETOS.
             *
             * La clase Alumno funciona como un molde.
             * A partir de ese molde podemos crear diferentes objetos.
             */

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n Creando objetos de la clase Alumno...");
            Console.ResetColor();

            // Creamos el primer objeto:

            Alumno alumno_1 = new Alumno
            (
                "Anthony", "Silva", 25
            );

            // Creamos el segundo objeto:

            Alumno alumno_2 = new Alumno ("Carlos", "García", 20);

            // Creamos el tercer objeto:

            Alumno alumno_3 = new Alumno(
                "María",
                "López",
                22
            );

            Console.WriteLine("\n Información de los alumnos:");

            Console.WriteLine("\n=======================================================");

            Console.WriteLine("\n Alumno 1:");
            alumno_1.Mostrar_Informacion();

            Console.WriteLine("\n=======================================================");

            Console.WriteLine("\n Alumno 2:");
            alumno_2.Mostrar_Informacion();

            Console.WriteLine("\n=======================================================");

            Console.WriteLine("\n Alumno 3:");
            alumno_3.Mostrar_Informacion();

            Console.WriteLine("\n=======================================================");

            /*
             * También podemos utilizar métodos de la clase.
             */

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n Ejecutando método de la clase Alumno...");
            Console.ResetColor();

            alumno_1.Estudiar();

            Console.WriteLine("\n Programa finalizado.");

            Console.ReadKey();
        }
    }
}
namespace Ejemplo_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejemplo 7 - Arreglos";

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("====================================================");
            Console.WriteLine("                 USO DE ARREGLOS");
            Console.WriteLine("====================================================\n");

            Console.ResetColor();

            #region 1. Arreglo Definido

            // ---------------------------------------------------------
            // PARTE 1: ARREGLO DEFINIDO (Llenado desde el inicio)
            // Ideal para datos que ya conocemos de antemano.
            // ---------------------------------------------------------

            Console.WriteLine("--- 1. Arreglo Definido (Nombre de los Alumnos) ---");

            // Declaramos e inicializamos el arreglo en la misma línea.

            string[] alumnos = { "Bautista", "Benicio", "Benjamín", "Felipe", "Octavio", "Pedro", "Ramiro", "Santino", "Tizziano", "Yuliana" };

            // Declaramos e inicializamos el arreglo por posciones, pero en varias líneas para mayor claridad.

            string[] alumnos2 = new string[10];

            alumnos2[0] = "Bautista";
            alumnos2[1] = "Benicio";
            alumnos2[2] = "Benjamín";
            alumnos2[3] = "Felipe";
            alumnos2[4] = "Octavio";
            alumnos2[5] = "Pedro";
            alumnos2[6] = "Ramiro";
            alumnos2[7] = "Santino";
            alumnos2[8] = "Tizziano";
            alumnos2[9] = "Yuliana";

            Console.WriteLine("\n\nNombre de los Alumnos del Curso:");

            // Usamos un ciclo for para recorrer el tamaño exacto del arreglo

            for (int i = 0; i < alumnos.Length; i++)
            {
                Console.WriteLine($"\nPosición {i + 1}: {alumnos[i]}");
            }

            Console.WriteLine("\n\nAccediendo directamente a una posición del arreglo:");
            Console.WriteLine($"\nEl elemento almacenado en la posición 9 es: {alumnos2[9]}");

            #endregion

            #region 2. Arreglo Vacío

            // ---------------------------------------------------------
            // PARTE 2: ARREGLO INDEFINIDO (Vacío, se llena dinámicamente)
            // Ideal para datos que el usuario o el sistema va a generar.
            // ---------------------------------------------------------

            Console.WriteLine("\n\n--- 2. Arreglo Vacío (Registro de Puntajes) ---\n");

            // Declaramos un arreglo vacío pero con un tamaño fijo de 3 posiciones.

            int[] puntajes = new int[3];

            Console.BackgroundColor = ConsoleColor.Magenta;

            Console.Write("¡IMPORTANTE!:");

            Console.ResetColor();

            Console.WriteLine("\n\n-> El sistema tiene espacio para guardar 3 puntajes.\n");

            // Llenamos el arreglo de forma dinámica pidiendo datos al usuario

            for (int i = 0; i < puntajes.Length; i++)
            {
                bool datoVálido = false;

                while (!datoVálido)
                {
                    Console.Write($"\nIngresa el puntaje para la partida {i + 1}: ");

                    string? entrada = Console.ReadLine();

                    if (int.TryParse(entrada, out int puntajeIngresado))
                    {
                        puntajes[i] = puntajeIngresado;
                        datoVálido = true;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n-> Entrada no válida. Debes ingresar únicamente números enteros.");
                        Console.ResetColor();

                        Console.WriteLine("\nInténtalo nuevamente.\n");
                    }
                }
            }

            #endregion

            #region 3. Mostrar Datos

            // ---------------------------------------------------------
            // PARTE 3: MOSTRAR LOS DATOS DEL ARREGLO DINÁMICO
            // ---------------------------------------------------------

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("\n\n--- Resumen de Puntajes Guardados ---");

            Console.ResetColor();

            // Usamos un ciclo foreach como alternativa al for tradicional 
            // para mostrar otra forma de recorrer arreglos.

            int partida = 1;

            foreach (int score in puntajes)
            {
                Console.WriteLine($"\nPartida {partida}: {score} puntos");
                partida++;
            }

            #endregion

            Console.WriteLine("\n\nPresiona cualquier tecla para salir del sistema...");

            Console.ReadKey();
        }
    }
}
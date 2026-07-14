namespace Ejemplo_8
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // ==========================================
            // CONFIGURACIÓN INICIAL DE LA CLASE
            // ==========================================
            Console.Title = "Masterclass C# - Control Total de la Consola";
            Console.Clear();

            Console.WriteLine("==================================================");
            Console.WriteLine(" BIENVENIDOS AL DEMO DE COLORES EN .NET 10.0");
            Console.WriteLine("==================================================");
            Console.WriteLine("\nPresiona cualquier tecla para iniciar el Ejemplo 1...");
            Console.ReadKey(intercept: true);


            // ==========================================
            // EJEMPLO 1: CAMBIAR EL COLOR EN NUEVAS LÍNEAS
            // ==========================================
            Console.Clear();
            Console.Title = "Ejemplo 1: Líneas de Colores Diferentes";
            Console.WriteLine("--- EJEMPLO 1: Historial con múltiples colores ---\n");

            ConsoleColor[] coloresLineas = [ConsoleColor.Red, ConsoleColor.Green, ConsoleColor.Cyan, ConsoleColor.Yellow];

            for (int i = 0; i < coloresLineas.Length; i++)
            {
                Console.ForegroundColor = coloresLineas[i];
                Console.WriteLine($"[Línea {i + 1}] Imprimiendo texto en color {coloresLineas[i]}...");

                await Task.Delay(1500);
            }

            Console.ResetColor();
            Console.WriteLine("\nFin del Ejemplo 1. Presiona una tecla para el Ejemplo 2...");
            Console.ReadKey(intercept: true);


            // ==========================================
            // EJEMPLO 2: EFECTO PARPADEANTE EN EL MISMO LUGAR
            // ==========================================
            Console.Clear();
            Console.Title = "Ejemplo 2: Texto Parpadeante (Mismo lugar)";
            Console.WriteLine("--- EJEMPLO 2: Sobreescribir texto con coordenadas ---\n");

            ConsoleColor[] coloresParpadeo = [ConsoleColor.Magenta, ConsoleColor.Yellow, ConsoleColor.Green, ConsoleColor.Cyan];

            int x = Console.CursorLeft;
            int y = Console.CursorTop;

            // CORRECCIÓN 1: Se ocultó el cursor para evitar parpadeos visuales molestos
            Console.CursorVisible = false;

            for (int i = 0; i < 8; i++)
            {
                Console.SetCursorPosition(x, y);

                // Asignamos el color dinámicamente
                Console.ForegroundColor = coloresParpadeo[i % coloresParpadeo.Length];

                Console.Write($"»» CAMBIANDO DE COLOR EN TIEMPO REAL: {Console.ForegroundColor} ««       ");

                // CORRECCIÓN 1: Obligamos a la consola a vaciar su buffer e imprimir el color de inmediato
                Console.Out.Flush();

                await Task.Delay(1000);
            }

            // Devolvemos la visibilidad del cursor al terminar
            Console.CursorVisible = true;

            Console.ResetColor();
            Console.WriteLine("\n\nFin del Ejemplo 2. Presiona una tecla para el Ejemplo 3...");
            Console.ReadKey(intercept: true);


            // ==========================================
            // EJEMPLO 3: CAMBIO DE FONDO (BACKGROUND) COMPLETO
            // ==========================================
            Console.Clear();
            Console.Title = "Ejemplo 3: Pantalla Completa de Colores";

            ConsoleColor[] fondos = [ConsoleColor.DarkBlue, ConsoleColor.DarkRed, ConsoleColor.DarkGreen];

            foreach (var colorFondo in fondos)
            {
                Console.BackgroundColor = colorFondo;
                Console.ForegroundColor = ConsoleColor.White;

                Console.Clear();

                // CORRECCIÓN 2: Se añadió un segundo Flush aquí para asegurar que el sistema operativo renderice el fondo completo antes de la pausa
                Console.Out.Flush();

                Console.WriteLine("--- EJEMPLO 3: Pintando todo el fondo del lienzo ---");
                Console.WriteLine($"\nEl color de fondo de la terminal ahora es: {colorFondo}");
                Console.WriteLine("Cambiando al siguiente fondo en 2.5 segundos...");

                await Task.Delay(2500);
            }


            // ==========================================
            // RESTABLECIMIENTO FINAL
            // ==========================================
            Console.ResetColor();
            Console.Clear();
            Console.Title = "Consola Restablecida";

            Console.WriteLine("==================================================");
            Console.WriteLine(" ¡Demostración terminada con éxito!");
            Console.WriteLine(" Todos los efectos han sido ejecutados.");
            Console.WriteLine("==================================================");
        }
    }
}

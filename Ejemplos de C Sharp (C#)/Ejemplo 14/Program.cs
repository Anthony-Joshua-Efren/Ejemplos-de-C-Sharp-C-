namespace Ejemplo_14
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.Title = "API REST Countries - POO";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" ========================================================");
            Console.WriteLine("                CONSULTA DE PAÍSES");
            Console.WriteLine(" ========================================================");
            Console.ResetColor();

            Console.WriteLine("\n\n Bienvenido(a) al sistema de consulta de países.");

            // =================================================
            // CREAR OBJETO API
            // =================================================

            API_Países API = new API_Países();

            // =================================================
            // SOLICITAR PAÍS
            // =================================================

            string país_Búsqueda = Leer_Pais();

            // =================================================
            // CONSULTAR API
            // =================================================

            País? país = await API.Buscar_País(país_Búsqueda);

            // =================================================
            // MOSTRAR RESULTADO
            // =================================================

            if (país != null)
            {
                país.Imprimir_Informacion();
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n No fue posible obtener la información.");
                Console.ResetColor();
            }

            Console.WriteLine("\n\n Presione una tecla para salir...");
            Console.ReadKey();
        }

        // =====================================================
        // LEER PAÍS
        // =====================================================

        // Este método solicita el nombre del país y valida que el usuario realmente escriba algo.

        static string Leer_Pais()
        {
            while (true)
            {
                Console.Write("\n - Ingrese el país que desea consultar: ");
                string? entrada = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(entrada))
                {
                    return entrada.Trim();
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n ¡Entrada inválida! Debe ingresar un país.");
                Console.ResetColor();
            }
        }
    }
}
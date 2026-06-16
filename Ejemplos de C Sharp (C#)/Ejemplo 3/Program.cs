namespace Ejemplo_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? Nombre_Completo;
            string Apodo = "Thony";
            string Ciudad = "Ciudad de México";
            string Pais = "México";

            Console.WriteLine("Uso de una Cadena (string) en C#.");

            Console.Write("\n Escribe tu nombre completo: ");
            Nombre_Completo = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(Nombre_Completo))
            {
                Console.WriteLine("\n No se ingresó ningún nombre.");
            }
            else
            {
                Console.WriteLine($"\n Tu nombre completo es: {Nombre_Completo}");
                Console.WriteLine("\n Tu apodo es: " + Apodo);
                Console.WriteLine("\n Tu ciudad es: " + Ciudad);
                Console.WriteLine("\n Tu país es: {0}" , Pais);
                Console.WriteLine($"\n A continuación, te muestro algunos de los métodos que puedes usar con una variable de cadena (string):");
                Console.WriteLine($"\n 1. {Nombre_Completo.ToUpper()}");
                Console.WriteLine($"\n 2. {Nombre_Completo.ToLower()}");
                Console.WriteLine($"\n 3. {Nombre_Completo.Length}");
                Console.WriteLine($"\n 4. {Nombre_Completo.Substring(0, 5)}");
                Console.WriteLine($"\n 5. {Nombre_Completo.Replace(" ", "_")}");
                Console.WriteLine($"\n 6. {Nombre_Completo.Contains("a")}");
            }

            Console.ReadKey();
        }
    }
}

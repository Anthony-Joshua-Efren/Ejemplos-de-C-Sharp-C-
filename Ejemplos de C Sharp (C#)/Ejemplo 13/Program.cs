namespace Ejemplo_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "IMC - POO";

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" ========================================================");
            Console.WriteLine("              INDICE DE MASA CORPORAL - IMC");
            Console.WriteLine(" ========================================================");
            Console.ResetColor();

            Console.WriteLine("\n\n Bienvenido(a) al sistema de cálculo de IMC.");

            Console.WriteLine("\n Por favor, ingrese los datos solicitados a continuación:\n");

            // Creamos un objeto de la clase Persona.

            Persona persona = new Persona();

            // Solicitamos los datos.

            persona.Solicitar_Datos();

            // Mostramos la información y calculamos el IMC.

            persona.Imprimir_Información();

            Console.WriteLine("\n\n Presione una tecla para salir...");
            Console.ReadKey();
        }
    }
}

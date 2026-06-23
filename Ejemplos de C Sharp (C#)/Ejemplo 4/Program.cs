namespace Ejemplo_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Se crea el objeto Random para generar números aleatorios
            Random aleatorio = new Random();

            Console.WriteLine("Uso y ejemplos de Random en C#.");

            // 1. Número entero aleatorio entre 0 y 99
            int número_1 = aleatorio.Next(100);
            Console.WriteLine($"\n Número aleatorio entre 0 y 99: {número_1}");

            // 2. Número entero aleatorio entre 1 y 10
            int número_2 = aleatorio.Next(1, 11); // 11 no se incluye
            Console.WriteLine($"\n Número aleatorio entre 1 y 10: {número_2}");

            // 3. Número decimal aleatorio entre 0.0 y 1.0
            double decimal_Aleatorio = aleatorio.NextDouble();
            Console.WriteLine($"\n Número decimal entre 0 y 1: {decimal_Aleatorio}");

            // 4. Número decimal en un rango personalizado
            double decimal_Rango = aleatorio.NextDouble() * (50 - 10) + 10; //* (maximo - minimo) + minimo
            Console.WriteLine($"\n Número decimal entre 10 y 50: {decimal_Rango}");

            Console.WriteLine("\n Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}

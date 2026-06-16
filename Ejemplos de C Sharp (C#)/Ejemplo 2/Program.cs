namespace Ejemplo_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Número_1, Número_2;

            Console.WriteLine("Operaciones Básicas en C#.");

            Console.Write("\n Escribe el primer número: ");
            Número_1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n Escribe el segundo número: ");
            Número_2 = Convert.ToDouble(Console.ReadLine());

            Suma(Número_1, Número_2);
            Resta(Número_1, Número_2);
            Multiplicación(Número_1, Número_2);
            División(Número_1, Número_2);

            Console.ReadKey();
        }

        static void Suma(double Número_1, double Número_2)
        {
            double Resultado = Número_1 + Número_2;
            Console.WriteLine($"\n La suma de {Número_1} y {Número_2} es: {Resultado}");
        }

        static void Resta(double Número_1, double Número_2)
        {
            double Resultado = Número_1 - Número_2;
            Console.WriteLine($"\n La resta de {Número_1} y {Número_2} es: {Resultado}");
        }

        static void Multiplicación(double Número_1, double Número_2)
        {
            double Resultado = Número_1 * Número_2;
            Console.WriteLine($"\n La multiplicación de {Número_1} y {Número_2} es: {Resultado}");
        }

        static void División(double Número_1, double Número_2)
        {
            if (Número_2 != 0)
            {
                double Resultado = Número_1 / Número_2;
                Console.WriteLine($"\n La división de {Número_1} entre {Número_2} es: {Resultado}");
            }
            else
            {
                Console.WriteLine("\n No se puede dividir por cero.");
            }
        }
    }
}
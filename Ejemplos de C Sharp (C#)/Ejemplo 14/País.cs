using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo_14
{
    internal class País
    {
        // =====================================================
        // ATRIBUTOS PRIVADOS
        // =====================================================

        /*
         * Estos atributos representan la información que recibiremos desde la API.
         * Son privados para aplicar encapsulación.
         */

        private string? nombre;
        private string? capital;
        private long población;

        // =====================================================
        // CONSTRUCTOR
        // =====================================================

        public País()
        {
            nombre = "";
            capital = "";
            población = 0;
        }

        // =====================================================
        // ASIGNAR DATOS
        // =====================================================

        /*
         * Este método permite almacenar la información obtenida desde la API.
         */

        public void Asignar_Datos(string nombre, string capital, long población) // long es el tipo de dato para almacenar números enteros grandes
        {
            this.nombre = nombre;
            this.capital = capital;
            this.población = población;
        }

        // =====================================================
        // IMPRIMIR INFORMACIÓN
        // =====================================================

        /*
         * Este método muestra la información del país en la consola.
         */

        public void Imprimir_Informacion()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("\n\n ========================================================");
            Console.WriteLine("              INFORMACIÓN DEL PAÍS");
            Console.WriteLine(" ========================================================\n");
            Console.ResetColor();

            Console.WriteLine($"\n - Nombre del País: {nombre}");
            Console.WriteLine($"\n - Capital del País: {capital}");
            Console.WriteLine($"\n - Población de País: {población:N0} habitantes"); // N0 formatea el número con separadores de miles

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\n ========================================================");
            Console.ResetColor();

        }
    }
}
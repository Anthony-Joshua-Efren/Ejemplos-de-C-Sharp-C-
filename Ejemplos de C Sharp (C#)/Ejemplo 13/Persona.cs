using System;

namespace Ejemplo_13
{
    internal class Persona
    {
        // =====================================================
        // ATRIBUTOS PRIVADOS
        // =====================================================

        /*
         * Estos atributos representan el estado interno del objeto.
         * Son privados porque solamente la propia clase puede modificarlos directamente.
         */

        private string? nombre;
        private double peso = 0.0;
        private double estatura = 0.0;
        private double imc = 0.0;


        // =====================================================
        // MÉTODOS
        // =====================================================

        /*
         * Solicitar_Datos:
         * Este método solicita al usuario los datos necesarios para trabajar con el objeto.
         */

        public void Solicitar_Datos()
        {
            nombre = Leer_Nombre();

            peso = Leer_Double_Positivo("\n - Ingrese su peso actual (Kg): ", "(El peso debe ser mayor que cero.)");

            estatura = Leer_Double_Positivo("\n - Ingrese su estatura (Mts): ", "(La estatura debe ser mayor que cero.)");
        }

        /*
         * Calcular_IMC:
         * En este método calculamos el Índice de Masa Corporal (IMC).
         *
         * IMC = peso / estatura²
         */

        public double Calcular_IMC()
        {
            imc = peso / (estatura * estatura);

            return imc;
        }

        /*
         * Imprimir_Información:
         * Este método muestra el resultado del cálculo del IMC y la categoría correspondiente.
         */

        public void Imprimir_Información()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n\n ========================================================");
            Console.WriteLine("        REPORTE DEL ÍNDICE DE MASA CORPORAL - IMC");
            Console.WriteLine(" ========================================================\n");
            Console.ResetColor();

            Console.WriteLine($"\n - Nombre: {nombre}");
            Console.WriteLine($"\n - Peso: {peso:F2} Kg");
            Console.WriteLine($"\n - Estatura: {estatura:F2} Mts");

            double imcValor = Calcular_IMC();

            Console.WriteLine($"\n - IMC: {imcValor:F2} Kg/m²");


            // =================================================
            // CLASIFICACIÓN DEL IMC
            // =================================================

            if (imcValor < 18.5)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n Clasificación: BAJO PESO");
                Console.ResetColor();
            }

            else if (imcValor >= 18.5 && imcValor <= 24.9)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Clasificación: PESO NORMAL");
                Console.ResetColor();
            }

            else if (imcValor >= 25 && imcValor <= 29.9)
            {
                /*
                 * Código ANSI:
                 * \x1b[38;2;R;G;Bm
                 *
                 * 38 = color del texto
                 * 2  = modo RGB
                 * R  = rojo
                 * G  = verde
                 * B  = azul
                 */

                Console.WriteLine("\n \x1b[38;2;255;165;0mClasificación: SOBREPESO\x1b[0m");
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Clasificación: OBESIDAD");
                Console.ResetColor();
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n\n ========================================================");
            Console.ResetColor();
        }

        // =====================================================
        // LEER NOMBRE
        // =====================================================

        /*
         * Este método valida que el usuario realmente escriba un nombre.
         *
         * string.IsNullOrWhiteSpace() permite detectar:
         *
         * - Cadena vacía: ""
         * - Solo espacios: "     "
         * - Null
         */

        private string Leer_Nombre()
        {
            while (true)
            {
                Console.Write("\n - Ingrese su nombre completo: ");

                string? entrada = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(entrada))
                {
                    return entrada.Trim();
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n ¡Entrada inválida! (Debes escribir tu nombre.)");
                Console.ResetColor();
            }
        }

        // =====================================================
        // LEER DOUBLE POSITIVO
        // =====================================================

        /*
         * Este método realiza dos validaciones:
         *
         * 1. Que el usuario escriba un número.
         * 2. Que el número sea mayor que cero.
         *
         * Lo hacemos mediante un solo método reutilizable.
         */

        private double Leer_Double_Positivo(string mensaje, string mensajePositivo)
        {
            while (true)
            {
                Console.Write(mensaje);

                string? entrada = Console.ReadLine();

                if (double.TryParse(entrada, out double valor))
                {
                    if (valor > 0)
                    {
                        return valor;
                    }

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\n ¡Entrada inválida! {mensajePositivo}");
                    Console.ResetColor();

                    continue;
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n ¡Entrada inválida! (Debes escribir un número.)");
                Console.ResetColor();
            }
        }
    }
}
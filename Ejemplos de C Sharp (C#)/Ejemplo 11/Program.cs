namespace Ejemplo_11
{
    internal class Program
    {
        static int[,]? matriz = null;

        static void Main(string[] args)
        {
            Console.Title = "Matrices en C# - Ejemplo Básico";

            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Mostrar_Menu();

                string? opción = Console.ReadLine();
                Console.WriteLine();

                switch (opción)
                {
                    case "1":
                        matriz = Crear_Matriz();
                        Pausa();
                        break;

                    case "2":
                        Llenar_Matriz(ref matriz);
                        Pausa();
                        break;

                    case "3":
                        Mostrar_Matriz(matriz);
                        Pausa();
                        break;

                    case "4":
                        Buscar_Valor(matriz);
                        Pausa();
                        break;

                    case "5":
                        Actualizar_Valor(matriz);
                        Pausa();
                        break;

                    case "6":
                        Mostrar_Estadisticas(matriz);
                        Pausa();
                        break;

                    case "7":
                        salir = true;
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" Opción inválida.");
                        Console.ResetColor();
                        Pausa();
                        break;
                }
            }

            Console.WriteLine("\n Programa finalizado.");
            Console.ReadKey();
        }

        static void Mostrar_Menu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=======================================================");
            Console.WriteLine("                 MATRICES EN C#");
            Console.WriteLine("=======================================================");
            Console.ResetColor();

            Console.WriteLine("\n 1. Crear matriz");
            Console.WriteLine(" 2. Llenar matriz");
            Console.WriteLine(" 3. Mostrar matriz");
            Console.WriteLine(" 4. Buscar valor");
            Console.WriteLine(" 5. Actualizar valor");
            Console.WriteLine(" 6. Mostrar suma, promedio, mayor y menor");
            Console.WriteLine(" 7. Salir");

            Console.WriteLine("\n=======================================================");

            Console.Write("\n Selecciona una opción: ");
        }

        static int[,] Crear_Matriz()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=======================================================");
            Console.WriteLine(" CREAR MATRIZ");
            Console.WriteLine("=======================================================");
            Console.ResetColor();

            int filas = Leer_Entero_En_Rango("\n ¿Cuántas filas tendrá la matriz?: ", 1, 10);
            int columnas = Leer_Entero_En_Rango(" ¿Cuántas columnas tendrá la matriz?: ", 1, 10);

            int[,] nuevaMatriz = new int[filas, columnas];

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n Matriz creada correctamente de {filas} x {columnas}.");
            Console.ResetColor();

            return nuevaMatriz;
        }

        static void Llenar_Matriz(ref int[,]? matriz)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=======================================================");
            Console.WriteLine(" LLENAR MATRIZ");
            Console.WriteLine("=======================================================");
            Console.ResetColor();

            if (matriz is null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Primero debes crear la matriz.");
                Console.ResetColor();
                return;
            }

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = Leer_Entero($" Ingrese el valor para [{i + 1},{j + 1}]: ");
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n La matriz se llenó correctamente.");
            Console.ResetColor();
        }

        static void Mostrar_Matriz(int[,]? matriz)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=======================================================");
            Console.WriteLine(" MOSTRAR MATRIZ");
            Console.WriteLine("=======================================================");
            Console.ResetColor();

            if (matriz is null)
            {
                Console.WriteLine("\n La matriz no existe todavía.");
                return;
            }

            Console.WriteLine();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.Write(" [ ");

                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"{matriz[i, j],4}");

                    if (j < matriz.GetLength(1) - 1)
                    {
                        Console.Write(" , ");
                    }
                }

                Console.WriteLine(" ]");
            }
        }

        static void Buscar_Valor(int[,]? matriz)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=======================================================");
            Console.WriteLine(" BUSCAR VALOR EN LA MATRIZ");
            Console.WriteLine("=======================================================");
            Console.ResetColor();

            if (matriz is null)
            {
                Console.WriteLine("\n La matriz no existe todavía.");
                return;
            }

            int valorBuscado = Leer_Entero("\n Ingresa el valor que deseas buscar: ");
            bool encontrado = false;

            Console.WriteLine();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] == valorBuscado)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($" El valor {valorBuscado} fue encontrado en [{i + 1},{j + 1}].");
                        Console.ResetColor();
                        encontrado = true;
                    }
                }
            }

            if (!encontrado)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($" El valor {valorBuscado} no se encontró en la matriz.");
                Console.ResetColor();
            }
        }

        static void Actualizar_Valor(int[,]? matriz)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=======================================================");
            Console.WriteLine(" ACTUALIZAR VALOR");
            Console.WriteLine("=======================================================");
            Console.ResetColor();

            if (matriz is null)
            {
                Console.WriteLine("\n La matriz no existe todavía.");
                return;
            }

            Console.WriteLine("\n Matriz actual:");
            Mostrar_Matriz(matriz);

            int fila = Leer_Entero_En_Rango(
                $"\n Ingresa la fila a actualizar (1 - {matriz.GetLength(0)}): ",
                1,
                matriz.GetLength(0)
            );

            int columna = Leer_Entero_En_Rango(
                $" Ingresa la columna a actualizar (1 - {matriz.GetLength(1)}): ",
                1,
                matriz.GetLength(1)
            );

            int nuevoValor = Leer_Entero("\n Ingresa el nuevo valor: ");

            matriz[fila - 1, columna - 1] = nuevoValor;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n El valor en [{fila},{columna}] fue actualizado correctamente.");
            Console.ResetColor();
        }

        static void Mostrar_Estadisticas(int[,]? matriz)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=======================================================");
            Console.WriteLine(" SUMA, PROMEDIO, MAYOR Y MENOR");
            Console.WriteLine("=======================================================");
            Console.ResetColor();

            if (matriz is null)
            {
                Console.WriteLine("\n La matriz no existe todavía.");
                return;
            }

            int suma = 0;
            int mayor = matriz[0, 0];
            int menor = matriz[0, 0];
            int totalElementos = matriz.GetLength(0) * matriz.GetLength(1);

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    int valor = matriz[i, j];
                    suma += valor;

                    if (valor > mayor)
                    {
                        mayor = valor;
                    }

                    if (valor < menor)
                    {
                        menor = valor;
                    }
                }
            }

            double promedio = (double)suma / totalElementos;

            Console.WriteLine($"\n Suma: {suma}");
            Console.WriteLine($" Promedio: {promedio:F2}");
            Console.WriteLine($" Mayor: {mayor}");
            Console.WriteLine($" Menor: {menor}");
        }

        static int Leer_Entero(string mensaje)
        {
            while (true)
            {
                Console.Write(mensaje);
                string? entrada = Console.ReadLine();

                if (int.TryParse(entrada, out int numero))
                {
                    return numero;
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Entrada inválida. Debes escribir un número entero.");
                Console.ResetColor();
            }
        }

        static int Leer_Entero_En_Rango(string mensaje, int mínimo, int máximo)
        {
            while (true)
            {
                int valor = Leer_Entero(mensaje);

                if (valor >= mínimo && valor <= máximo)
                {
                    return valor;
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($" El número debe estar entre {mínimo} y {máximo}.\n");
                Console.ResetColor();
            }
        }

        static void Pausa()
        {
            Console.WriteLine("\n Presiona una tecla para continuar...");
            Console.ReadKey();
        }
    }
}
namespace Ejemplo_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "CRUD (Arreglo y Archivo TXT)";

            int[]? arreglo = null;

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
                        arreglo = Crear_Arreglo();
                        Pausa();
                        break;

                    case "2":
                        Agregar_Elemento(ref arreglo);
                        Pausa();
                        break;

                    case "3":
                        Mostrar_Arreglo(arreglo);
                        Pausa();
                        break;

                    case "4":
                        Buscar_Elemento(arreglo);
                        Pausa();
                        break;

                    case "5":
                        Actualizar_Elemento(arreglo);
                        Pausa();
                        break;

                    case "6":
                        Eliminar_Elemento(ref arreglo);
                        Pausa();
                        break;

                    case "7":
                        Guardar_En_TXT(arreglo);
                        Pausa();
                        break;

                    case "8":
                        Cargar_Desde_TXT(ref arreglo);
                        Pausa();
                        break;

                    case "9":
                        Mostrar_Contenido_TXT();
                        Pausa();
                        break;

                    case "10":
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

        // =========================================================
        // MENÚ PRINCIPAL
        // =========================================================

        static void Mostrar_Menu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("=======================================================");
            Console.WriteLine("       CRUD DE ARREGLO Y ARCHIVO TXT");
            Console.WriteLine("=======================================================");

            Console.ResetColor();

            Console.WriteLine("\n 1. Crear arreglo");
            Console.WriteLine(" 2. Agregar elemento");
            Console.WriteLine(" 3. Mostrar elementos");
            Console.WriteLine(" 4. Buscar elemento");
            Console.WriteLine(" 5. Actualizar elemento");
            Console.WriteLine(" 6. Eliminar elemento");
            Console.WriteLine(" 7. Guardar arreglo en TXT");
            Console.WriteLine(" 8. Cargar arreglo desde TXT");
            Console.WriteLine(" 9. Mostrar contenido del TXT");
            Console.WriteLine(" 10. Salir");

            Console.WriteLine("\n=======================================================");

            Console.Write("\n Selecciona una opción: ");
        }

        // =========================================================
        // CREAR ARREGLO
        // =========================================================

        static int[] Crear_Arreglo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("=======================================================");
            Console.WriteLine(" CREAR ARREGLO");
            Console.WriteLine("=======================================================");

            Console.ResetColor();

            int cantidad_Elementos = Leer_Entero_En_Rango("\n ¿Cuántos elementos tendrá el arreglo?: ", 1, 100);

            int[] arreglo = new int[cantidad_Elementos];

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n Arreglo creado correctamente.");
            Console.ResetColor();

            Console.WriteLine($" Capacidad: {arreglo.Length} elementos.");

            return arreglo;
        }

        // =========================================================
        // AGREGAR ELEMENTO
        // =========================================================

        static void Agregar_Elemento(ref int[]? arreglo)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("=======================================================");
            Console.WriteLine(" AGREGAR ELEMENTO");
            Console.WriteLine("=======================================================");

            Console.ResetColor();

            if (arreglo is null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Primero debes crear el arreglo.");
                Console.ResetColor();

                return;
            }

            if (arreglo.Length == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n El arreglo está vacío.");
                Console.ResetColor();

                return;
            }

            Console.WriteLine("\n Arreglo actual:");
            Mostrar_Arreglo_Simple(arreglo);

            int posición = Leer_Entero_En_Rango($"\n Ingresa la posición donde deseas agregar el valor (1 - {arreglo.Length}): ", 1, arreglo.Length);

            int valor = Leer_Entero("\n Ingresa el valor: ");

            arreglo[posición - 1] = valor;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n Elemento agregado correctamente.");
            Console.ResetColor();
        }

        // =========================================================
        // MOSTRAR ARREGLO
        // =========================================================

        static void Mostrar_Arreglo(int[]? arreglo)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("=======================================================");
            Console.WriteLine(" MOSTRAR ARREGLO");
            Console.WriteLine("=======================================================");

            Console.ResetColor();

            if (arreglo is null)
            {
                Console.WriteLine("\n El arreglo no existe todavía.");
                return;
            }

            if (arreglo.Length == 0)
            {
                Console.WriteLine("\n El arreglo está vacío.");
                return;
            }

            Console.WriteLine();

            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine($" Posición [{i + 1}] -> {arreglo[i]}");
            }

            Console.WriteLine("\n Arreglo completo:");

            Mostrar_Arreglo_Simple(arreglo);
        }

        static void Mostrar_Arreglo_Simple(int[] arreglo)
        {
            Console.Write(" [ ");

            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write(arreglo[i]);

                if (i < arreglo.Length - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine(" ]");
        }

        // =========================================================
        // BUSCAR ELEMENTO
        // =========================================================

        static void Buscar_Elemento(int[]? arreglo)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("=======================================================");
            Console.WriteLine(" BUSCAR ELEMENTO");
            Console.WriteLine("=======================================================");

            Console.ResetColor();

            if (arreglo is null)
            {
                Console.WriteLine("\n El arreglo no existe todavía.");
                return;
            }

            int valor_Buscado = Leer_Entero("\n Ingresa el valor que deseas buscar: ");

            bool encontrado = false;

            Console.WriteLine();

            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] == valor_Buscado)
                {
                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine($" El valor {valor_Buscado} fue encontrado en la posición {i + 1}.");

                    Console.ResetColor();

                    encontrado = true;
                }
            }

            if (!encontrado)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine($" El valor {valor_Buscado} no se encontró en el arreglo.");

                Console.ResetColor();
            }
        }

        // =========================================================
        // ACTUALIZAR ELEMENTO
        // =========================================================

        static void Actualizar_Elemento(int[]? arreglo)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("=======================================================");
            Console.WriteLine(" ACTUALIZAR ELEMENTO");
            Console.WriteLine("=======================================================");

            Console.ResetColor();

            if (arreglo is null)
            {
                Console.WriteLine("\n El arreglo no existe todavía.");
                return;
            }

            if (arreglo.Length == 0)
            {
                Console.WriteLine("\n El arreglo está vacío.");
                return;
            }

            Console.WriteLine("\n Arreglo actual:");

            Mostrar_Arreglo_Simple(arreglo);

            int posición = Leer_Entero_En_Rango($"\n Ingresa la posición que deseas actualizar (1 - {arreglo.Length}): ", 1, arreglo.Length);

            int nuevo_Valor = Leer_Entero("\n Ingresa el nuevo valor: ");

            arreglo[posición - 1] = nuevo_Valor;

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"\n El elemento de la posición {posición} fue actualizado correctamente.");

            Console.ResetColor();
        }

        // =========================================================
        // ELIMINAR ELEMENTO
        // =========================================================

        static void Eliminar_Elemento(ref int[]? arreglo)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("=======================================================");
            Console.WriteLine(" ELIMINAR ELEMENTO");
            Console.WriteLine("=======================================================");

            Console.ResetColor();

            if (arreglo is null)
            {
                Console.WriteLine("\n El arreglo no existe todavía.");
                return;
            }

            if (arreglo.Length == 0)
            {
                Console.WriteLine("\n El arreglo está vacío.");
                return;
            }

            Console.WriteLine("\n Arreglo actual:");

            Mostrar_Arreglo_Simple(arreglo);

            int posición = Leer_Entero_En_Rango($"\n Ingresa la posición que deseas eliminar (1 - {arreglo.Length}): ", 1, arreglo.Length);

            int[] nuevo_Arreglo = new int[arreglo.Length - 1];

            int índice_Nuevo = 0;

            for (int índice_Actual = 0; índice_Actual < arreglo.Length; índice_Actual++)
            {
                if (índice_Actual == posición - 1)
                {
                    continue;
                }

                nuevo_Arreglo[índice_Nuevo] = arreglo[índice_Actual];

                índice_Nuevo++;
            }

            arreglo = nuevo_Arreglo;

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"\n El elemento de la posición {posición} fue eliminado correctamente.");

            Console.ResetColor();
        }

        // =========================================================
        // GUARDAR EN TXT
        // =========================================================

        static void Guardar_En_TXT(int[]? arreglo)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("=======================================================");
            Console.WriteLine(" GUARDAR ARREGLO EN TXT");
            Console.WriteLine("=======================================================");

            Console.ResetColor();

            if (arreglo is null)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("\n El arreglo no existe todavía.");

                Console.ResetColor();

                return;
            }

            string ruta = "datos.txt";

            string[] datos = new string[arreglo.Length];

            for (int i = 0; i < arreglo.Length; i++)
            {
                datos[i] = arreglo[i].ToString();
            }

            File.WriteAllLines(ruta, datos);

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("\n El arreglo fue guardado correctamente.");
            Console.WriteLine($" Archivo: {ruta}");
            Console.WriteLine($" Elementos guardados: {arreglo.Length}");

            Console.ResetColor();
        }

        // =========================================================
        // CARGAR DESDE TXT
        // =========================================================

        static void Cargar_Desde_TXT(ref int[]? arreglo)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("=======================================================");
            Console.WriteLine(" CARGAR ARREGLO DESDE TXT");
            Console.WriteLine("=======================================================");

            Console.ResetColor();

            string ruta = "datos.txt";

            if (!File.Exists(ruta))
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("\n El archivo datos.txt no existe.");

                Console.ResetColor();

                return;
            }

            string[] datos = File.ReadAllLines(ruta);

            arreglo = new int[datos.Length];

            for (int i = 0; i < datos.Length; i++)
            {
                if (int.TryParse(datos[i], out int valor))
                {
                    arreglo[i] = valor;
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("\n Los datos fueron cargados correctamente.");
            Console.WriteLine($" Elementos cargados: {arreglo.Length}");

            Console.ResetColor();
        }


        // =========================================================
        // MOSTRAR CONTENIDO DEL TXT
        // =========================================================

        static void Mostrar_Contenido_TXT()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("=======================================================");
            Console.WriteLine(" MOSTRAR CONTENIDO DEL TXT");
            Console.WriteLine("=======================================================");

            Console.ResetColor();

            string ruta = "datos.txt";

            if (!File.Exists(ruta))
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("\n El archivo datos.txt no existe.");

                Console.ResetColor();

                return;
            }

            string[] datos = File.ReadAllLines(ruta);

            if (datos.Length == 0)
            {
                Console.WriteLine("\n El archivo está vacío.");
                return;
            }

            Console.WriteLine("\n Contenido del archivo:");

            Console.WriteLine("\n-------------------------------------------------------");

            for (int i = 0; i < datos.Length; i++)
            {
                Console.WriteLine($" Línea {i + 1}: {datos[i]}");
            }

            Console.WriteLine("-------------------------------------------------------");
        }

        // =========================================================
        // LEER ENTERO
        // =========================================================

        static int Leer_Entero(string mensaje)
        {
            while (true)
            {
                Console.Write(mensaje);

                string? entrada = Console.ReadLine();

                if (int.TryParse(entrada, out int número))
                {
                    return número;
                }

                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("\n Entrada inválida. Debes escribir un número entero.");

                Console.ResetColor();
            }
        }

        // =========================================================
        // LEER ENTERO EN RANGO
        // =========================================================

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

        // =========================================================
        // PAUSA
        // =========================================================

        static void Pausa()
        {
            Console.WriteLine("\n Presiona una tecla para continuar...");

            Console.ReadKey();
        }
    }
}
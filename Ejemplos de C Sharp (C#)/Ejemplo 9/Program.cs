namespace Ejemplo_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Arreglos definidos e indefinidos - CRUD básico";

            int[]? arreglo_Definido = null;
            int[]? arreglo_Indefinido = null;

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
                        arreglo_Definido = Crear_Arreglo_Definido();
                        Pausa();
                        break;

                    case "2":
                        arreglo_Indefinido = Crear_Arreglo_Indefinido();
                        Pausa();
                        break;

                    case "3":
                        Mostrar_Arreglos(arreglo_Definido, arreglo_Indefinido);
                        Pausa();
                        break;

                    case "4":
                        if (arreglo_Indefinido is null)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" Primero debes crear el arreglo indefinido.");
                            Console.ResetColor();
                        }
                        else
                        {
                            Llenar_Arreglo(arreglo_Indefinido, "indefinido");
                        }
                        Pausa();
                        break;

                    case "5":
                        Recorrer_Arreglos(arreglo_Definido, arreglo_Indefinido);
                        Pausa();
                        break;

                    case "6":
                        Buscar_Valor_En_Arreglos(arreglo_Definido, arreglo_Indefinido);
                        Pausa();
                        break;

                    case "7":
                        Mostrar_Estadisticas(arreglo_Definido, arreglo_Indefinido);
                        Pausa();
                        break;

                    case "8":
                        Actualizar_Valor(ref arreglo_Definido, ref arreglo_Indefinido);
                        Pausa();
                        break;

                    case "9":
                        Eliminar_Valor(ref arreglo_Definido, ref arreglo_Indefinido);
                        Pausa();
                        break;

                    case "10":
                        Ordenar_Arreglos(arreglo_Definido, arreglo_Indefinido);
                        Pausa();
                        break;

                    case "11":
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

            Console.WriteLine(" Programa finalizado.");
            Console.ReadKey();
        }

        static void Mostrar_Menu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=======================================================");
            Console.WriteLine("  ARREGLOS DEFINIDOS E INDEFINIDOS - CRUD BÁSICO");
            Console.WriteLine("=======================================================");
            Console.ResetColor();

            Console.WriteLine("\n 1. Crear arreglo definido");
            Console.WriteLine(" 2. Crear arreglo indefinido");
            Console.WriteLine(" 3. Mostrar arreglos");
            Console.WriteLine(" 4. Llenar arreglo indefinido");
            Console.WriteLine(" 5. Recorrer arreglos");
            Console.WriteLine(" 6. Buscar valor");
            Console.WriteLine(" 7. Mostrar suma, promedio, mayor y menor");
            Console.WriteLine(" 8. Actualizar valor");
            Console.WriteLine(" 9. Eliminar valor");
            Console.WriteLine(" 10. Ordenar arreglo");
            Console.WriteLine(" 11. Salir");
            Console.WriteLine("\n=======================================================");

            Console.Write("\n Selecciona una opción: ");
        }

        static int[] Crear_Arreglo_Definido()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=======================================================");
            Console.WriteLine(" CREAR ARREGLO DEFINIDO");
            Console.WriteLine("=======================================================");
            Console.ResetColor();

            int cantidad_Elementos = Leer_Entero("\n ¿Cuántos elementos tendrá el arreglo?: ");
            Console.WriteLine("");

            int[] arreglo = new int[cantidad_Elementos];

            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = Leer_Entero($" Elemento [{i + 1}]: ");
            }

            Console.WriteLine("\n Arreglo definido creado correctamente.");

            return arreglo;
        }

        static int[] Crear_Arreglo_Indefinido()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=======================================================");
            Console.WriteLine(" CREAR ARREGLO INDEFINIDO");
            Console.WriteLine("=======================================================");
            Console.ResetColor();

            int cantidad_Elementos = Leer_Entero("\n ¿Cuántos elementos tendrá el arreglo?: ");

            int[] arreglo = new int[cantidad_Elementos];

            Console.WriteLine("\n Arreglo indefinido creado correctamente.");
            Console.WriteLine("\n Actualmente sus posiciones tienen el valor predeterminado 0.");

            return arreglo;
        }

        static void Llenar_Arreglo(int[] arreglo, string nombre)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=======================================================");
            Console.WriteLine($" LLENAR ARREGLO {nombre.ToUpper()}");
            Console.WriteLine("=======================================================\n");
            Console.ResetColor();

            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = Leer_Entero($" Ingrese el valor para la posición [{i + 1}]: ");
            }

            Console.WriteLine($"\n El arreglo {nombre} se llenó correctamente.");
        }

        static void Mostrar_Arreglos(int[]? definido, int[]? indefinido)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=======================================================");
            Console.WriteLine(" MOSTRAR ARREGLOS");
            Console.WriteLine("=======================================================");
            Console.ResetColor();

            Console.WriteLine("\n Arreglo definido:");
            Mostrar_Arreglo(definido);

            Console.WriteLine("\n Arreglo indefinido:");
            Mostrar_Arreglo(indefinido);
        }

        static void Mostrar_Arreglo(int[]? arreglo)
        {
            if (arreglo is null)
            {
                Console.WriteLine(" No existe todavía.");
                return;
            }

            if (arreglo.Length == 0)
            {
                Console.WriteLine(" El arreglo está vacío.");
                return;
            }

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

        static void Recorrer_Arreglos(int[]? definido, int[]? indefinido)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=======================================================");
            Console.WriteLine(" RECORRER ARREGLOS");
            Console.WriteLine("=======================================================");
            Console.ResetColor();

            Console.WriteLine("\n Arreglo definido con for:");
            Recorrer_Con_For(definido);

            Console.WriteLine("\n Arreglo indefinido con foreach:");
            Recorrer_Con_Foreach(indefinido);
        }

        static void Recorrer_Con_For(int[]? arreglo)
        {
            if (arreglo is null)
            {
                Console.WriteLine(" No existe todavía.");
                return;
            }

            if (arreglo.Length == 0)
            {
                Console.WriteLine(" El arreglo está vacío.\n");
                return;
            }

            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine($" Posición {i} -> {arreglo[i]}");
            }
        }

        static void Recorrer_Con_Foreach(int[]? arreglo)
        {
            if (arreglo is null)
            {
                Console.WriteLine(" No existe todavía.");
                return;
            }

            if (arreglo.Length == 0)
            {
                Console.WriteLine(" El arreglo está vacío.\n");
                return;
            }

            int posición = 0;

            foreach (int valor in arreglo)
            {
                Console.WriteLine($" Posición {posición} -> {valor}");
                posición++;
            }
        }

        static void Buscar_Valor_En_Arreglos(int[]? definido, int[]? indefinido)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=======================================================");
            Console.WriteLine(" BUSCAR VALOR EN ARREGLOS");
            Console.WriteLine("=======================================================");
            Console.ResetColor();

            int valor_Buscado = Leer_Entero("\n Ingresa el valor que deseas buscar: ");

            Console.WriteLine();

            Buscar_En_Arreglo(definido, valor_Buscado, "definido");
            Buscar_En_Arreglo(indefinido, valor_Buscado, "indefinido");
        }

        static void Buscar_En_Arreglo(int[]? arreglo, int valor, string nombre)
        {
            if (arreglo is null)
            {
                Console.WriteLine($"\n El arreglo {nombre} no existe.");
                return;
            }

            bool encontrado = false;

            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] == valor)
                {
                    Console.WriteLine($" El valor {valor} fue encontrado en el arreglo {nombre} en la posición {i + 1}.");
                    encontrado = true;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine($" El valor {valor} no se encontró en el arreglo {nombre}.");
            }
        }

        static void Mostrar_Estadisticas(int[]? definido, int[]? indefinido)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=======================================================");
            Console.WriteLine(" SUMA, PROMEDIO, MAYOR Y MENOR");
            Console.WriteLine("=======================================================");
            Console.ResetColor();

            Console.WriteLine("\n Arreglo definido:");
            Estadisticas_Arreglo(definido);

            Console.WriteLine("\n Arreglo indefinido:");
            Estadisticas_Arreglo(indefinido);
        }

        static void Estadisticas_Arreglo(int[]? arreglo)
        {
            if (arreglo is null)
            {
                Console.WriteLine(" No existe todavía.");
                return;
            }

            if (arreglo.Length == 0)
            {
                Console.WriteLine(" El arreglo está vacío.");
                return;
            }

            int suma = 0;
            int mayor = arreglo[0];
            int menor = arreglo[0];

            for (int i = 0; i < arreglo.Length; i++)
            {
                suma += arreglo[i];

                if (arreglo[i] > mayor)
                {
                    mayor = arreglo[i];
                }

                if (arreglo[i] < menor)
                {
                    menor = arreglo[i];
                }
            }

            double promedio = (double)suma / arreglo.Length;

            Console.WriteLine($"\n Suma: {suma}");
            Console.WriteLine($" Promedio: {promedio:F2}");
            Console.WriteLine($" Mayor: {mayor}");
            Console.WriteLine($" Menor: {menor}");
        }

        static void Actualizar_Valor(ref int[]? definido, ref int[]? indefinido)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=======================================================");
            Console.WriteLine(" ACTUALIZAR VALOR");
            Console.WriteLine("=======================================================");
            Console.ResetColor();

            Console.WriteLine("\n ¿En qué arreglo deseas actualizar?");
            Console.WriteLine("\n 1. Arreglo definido");
            Console.WriteLine(" 2. Arreglo indefinido");
            Console.Write("\n Selecciona una opción: ");

            string? opción = Console.ReadLine();
            Console.WriteLine();

            switch (opción)
            {
                case "1":
                    if (definido is null)
                    {
                        Console.WriteLine(" Primero debes crear el arreglo definido.");
                        return;
                    }

                    Actualizar_Elemento(definido, "definido");
                    break;

                case "2":
                    if (indefinido is null)
                    {
                        Console.WriteLine(" Primero debes crear el arreglo indefinido.");
                        return;
                    }

                    Actualizar_Elemento(indefinido, "indefinido");
                    break;

                default:
                    Console.WriteLine(" Opción inválida.");
                    break;
            }
        }

        static void Actualizar_Elemento(int[] arreglo, string nombre)
        {
            if (arreglo.Length == 0)
            {
                Console.WriteLine($" El arreglo {nombre} está vacío.");
                return;
            }

            Console.WriteLine($" Arreglo {nombre}:");
            Mostrar_Arreglo(arreglo);

            int posición = Leer_Entero_En_Rango($"\n Ingresa la posición a actualizar (1 - {arreglo.Length}): ", 1, arreglo.Length);
            int nuevo_Valor = Leer_Entero("\n Ingresa el nuevo valor: ");

            arreglo[posición - 1] = nuevo_Valor;

            Console.WriteLine($"\n El valor del arreglo {nombre} fue actualizado correctamente.");
        }

        static void Eliminar_Valor(ref int[]? definido, ref int[]? indefinido)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=======================================================");
            Console.WriteLine(" ELIMINAR VALOR");
            Console.WriteLine("=======================================================");
            Console.ResetColor();

            Console.WriteLine("\n ¿En qué arreglo deseas eliminar?");
            Console.WriteLine("\n 1. Arreglo definido");
            Console.WriteLine(" 2. Arreglo indefinido");
            Console.Write("\n Selecciona una opción: ");

            string? opción = Console.ReadLine();
            Console.WriteLine();

            switch (opción)
            {
                case "1":
                    if (definido is null)
                    {
                        Console.WriteLine(" Primero debes crear el arreglo definido.");
                        return;
                    }

                    Eliminar_Elemento(ref definido, "definido");
                    break;

                case "2":
                    if (indefinido is null)
                    {
                        Console.WriteLine(" Primero debes crear el arreglo indefinido.");
                        return;
                    }

                    Eliminar_Elemento(ref indefinido, "indefinido");
                    break;

                default:
                    Console.WriteLine(" Opción inválida.");
                    break;
            }
        }

        static void Eliminar_Elemento(ref int[]? arreglo, string nombre)
        {
            if (arreglo is null)
            {
                Console.WriteLine($" El arreglo {nombre} no existe.");
                return;
            }

            if (arreglo.Length == 0)
            {
                Console.WriteLine($" El arreglo {nombre} está vacío.");
                return;
            }

            Console.WriteLine($" Arreglo {nombre}:");
            Mostrar_Arreglo(arreglo);

            int posición = Leer_Entero_En_Rango($"\n Ingresa la posición a eliminar (1 - {arreglo.Length}): ", 1, arreglo.Length);

            // En arreglos, eliminar significa crear un arreglo nuevo más pequeño
            // y copiar todos los elementos excepto el que se quiere quitar.
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

            Console.WriteLine($"\n El elemento de la posición {posición} fue eliminado correctamente del arreglo {nombre}.");
        }

        static void Ordenar_Arreglos(int[]? definido, int[]? indefinido)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=======================================================");
            Console.WriteLine(" ORDENAR ARREGLOS");
            Console.WriteLine("=======================================================");
            Console.ResetColor();

            Console.WriteLine("\n Arreglo definido ordenado:");
            Ordenar_Y_Mostrar(definido);

            Console.WriteLine("\n Arreglo indefinido ordenado:");
            Ordenar_Y_Mostrar(indefinido);
        }

        static void Ordenar_Y_Mostrar(int[]? arreglo)
        {
            if (arreglo is null)
            {
                Console.WriteLine(" No existe todavía.");
                return;
            }

            if (arreglo.Length == 0)
            {
                Console.WriteLine(" El arreglo está vacío.");
                return;
            }

            int[] copia = (int[])arreglo.Clone();
            Array.Sort(copia);

            Mostrar_Arreglo(copia);
        }

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

        static int Leer_Entero_En_Rango(string mensaje, int minímo, int máximo)
        {
            while (true)
            {
                int valor = Leer_Entero(mensaje);

                if (valor >= minímo && valor <= máximo)
                {
                    return valor;
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($" El número debe estar entre {minímo} y {máximo}.\n");
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
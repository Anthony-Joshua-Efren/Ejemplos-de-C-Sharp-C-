namespace Ejemplo_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "CRUD Excel - Productos";

            // =================================================
            // ENCABEZADO
            // =================================================

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" ========================================================");
            Console.WriteLine("           SISTEMA DE PRODUCTOS (C# + EXCEL)");
            Console.WriteLine(" ========================================================");
            Console.ResetColor();

            // =================================================
            // ARCHIVO EXCEL
            // =================================================

            Conexión_Excel excelBD = new Conexión_Excel();

            if (!excelBD.Existe())
            {
                excelBD.Crear_Archivo();
            }

            // =================================================
            // CRUD
            // =================================================

            Producto_Excel productoExcel = new Producto_Excel();

            int opción;

            do
            {
                Mostrar_Menu();

                opción = Leer_Opción();

                switch (opción)
                {
                    case 1:

                        Insertar_Producto(productoExcel);
                        break;

                    case 2:

                        productoExcel.Consultar();
                        break;

                    case 3:

                        Actualizar_Producto(productoExcel);
                        break;

                    case 4:

                        Eliminar_Producto(productoExcel);
                        break;

                    case 0:

                        Console.WriteLine("\n Programa finalizado.");
                        break;

                    default:

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n ¡Opción inválida!");
                        Console.ResetColor();
                        break;
                }

                if (opción != 0)
                {
                    Console.WriteLine("\n\n Presione una tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (opción != 0);
        }

        // =====================================================
        // MOSTRAR MENÚ
        // =====================================================

        static void Mostrar_Menu()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n ========================================================");
            Console.WriteLine("                    MENÚ PRINCIPAL");
            Console.WriteLine(" ========================================================\n");
            Console.ResetColor();

            Console.WriteLine(" 1. Registrar producto");
            Console.WriteLine(" 2. Consultar productos");
            Console.WriteLine(" 3. Actualizar producto");
            Console.WriteLine(" 4. Eliminar producto");
            Console.WriteLine(" 0. Salir");
        }

        // =====================================================
        // LEER OPCIÓN
        // =====================================================

        static int Leer_Opción()
        {
            while (true)
            {
                Console.Write(
                    "\n - Seleccione una opción: "
                );


                string? entrada =
                    Console.ReadLine();


                if (int.TryParse(
                    entrada,
                    out int opcion))
                {
                    return opcion;
                }


                Console.ForegroundColor =
                    ConsoleColor.Red;

                Console.WriteLine(
                    "\n ¡Entrada inválida! Debes ingresar un número."
                );

                Console.ResetColor();
            }
        }


        // =====================================================
        // INSERTAR
        // =====================================================

        static void Insertar_Producto(Producto_Excel productoExcel)
        {
            Console.WriteLine("\n\n REGISTRO DE PRODUCTO");

            Producto producto = new Producto();

            producto.Solicitar_Datos();

            productoExcel.Insertar(producto);
        }

        // =====================================================
        // ACTUALIZAR
        // =====================================================

        static void Actualizar_Producto(Producto_Excel productoExcel)
        {
            Console.WriteLine("\n\n ACTUALIZACIÓN DE PRODUCTO");

            int id = Leer_Id();

            Producto producto = new Producto();

            producto.Establecer_Id(id);

            producto.Solicitar_Datos();

            productoExcel.Actualizar(producto);
        }

        // =====================================================
        // ELIMINAR
        // =====================================================

        static void Eliminar_Producto(Producto_Excel productoExcel)
        {
            Console.WriteLine("\n\n ELIMINAR PRODUCTO");

            int id = Leer_Id();

            Console.Write("\n ¿Está seguro de eliminar el producto? (S/N): ");
            string? respuesta = Console.ReadLine();

            if (respuesta != null && respuesta.Trim().ToUpper() == "S")
            {
                productoExcel.Eliminar(id);
            }
            else
            {
                Console.WriteLine("\n Operación cancelada.");
            }
        }

        // =====================================================
        // LEER ID
        // =====================================================

        static int Leer_Id()
        {
            while (true)
            {
                Console.Write("\n - Ingrese el ID del producto: ");
                string? entrada = Console.ReadLine();

                if (int.TryParse(entrada, out int id) && id > 0)
                {
                    return id;
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n ¡Entrada inválida! El ID debe ser mayor que cero.");
                Console.ResetColor();
            }
        }
    }
}
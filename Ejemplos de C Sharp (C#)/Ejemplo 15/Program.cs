using Microsoft.Data.Sqlite;

namespace Ejemplo_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "CRUD SQLite - Productos";

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" ========================================================");
            Console.WriteLine("           SISTEMA DE PRODUCTOS (C# + SQLite)");
            Console.WriteLine(" ========================================================");
            Console.ResetColor();

            // =================================================
            // CREAR BASE DE DATOS
            // =================================================

            BD BaseDatos = new BD();

            BaseDatos.Crear_Tablas();

            // =================================================
            // CREAR CRUD
            // =================================================

            Producto_CRUD productoCRUD = new Producto_CRUD();

            // =================================================
            // MENÚ PRINCIPAL
            // =================================================

            int opcion;

            do
            {
                Mostrar_Menú();

                opcion = Leer_Opción();

                switch (opcion)
                {
                    case 1:
                        Insertar_Producto(productoCRUD);
                        break;

                    case 2:
                        productoCRUD.Consultar();
                        break;

                    case 3:
                        Actualizar_Producto(productoCRUD);
                        break;

                    case 4:
                        Eliminar_Producto(productoCRUD);
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

                if (opcion != 0)
                {
                    Console.WriteLine("\n\n Presione una tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (opcion != 0);
        }

        // =====================================================
        // MOSTRAR MENÚ
        // =====================================================

        static void Mostrar_Menú()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n ========================================================");
            Console.WriteLine("                    MENÚ PRINCIPAL");
            Console.WriteLine(" ========================================================\n");
            Console.ResetColor();

            Console.WriteLine(" 1. Registrar producto (Create - Crear)");
            Console.WriteLine(" 2. Consultar productos (Read - Leer)");
            Console.WriteLine(" 3. Actualizar producto (Update - Actualizar)");
            Console.WriteLine(" 4. Eliminar producto (Delete - Eliminar)");
            Console.WriteLine(" 0. Salir");
        }

        // =====================================================
        // LEER OPCIÓN
        // =====================================================

        static int Leer_Opción()
        {
            while (true)
            {
                Console.Write("\n - Seleccione una opción: ");
                string? entrada = Console.ReadLine();

                if (int.TryParse(entrada, out int opcion))
                {
                    return opcion;
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n ¡Entrada inválida! Debes ingresar un número.");
                Console.ResetColor();
            }
        }

        // =====================================================
        // INSERTAR PRODUCTO
        // =====================================================

        static void Insertar_Producto(Producto_CRUD productoCRUD)
        {
            Console.WriteLine("\n\n REGISTRO DE PRODUCTO");

            Producto producto = new Producto();

            producto.Solicitar_Datos();

            productoCRUD.Insertar(producto);
        }

        // =====================================================
        // ACTUALIZAR PRODUCTO
        // =====================================================

        static void Actualizar_Producto(Producto_CRUD productoCRUD)
        {
            Console.WriteLine("\n\n ACTUALIZACIÓN DE PRODUCTO");

            int id = Leer_Id();

            Producto producto = new Producto();

            producto.Establecer_Id(id);

            producto.Solicitar_Datos();

            productoCRUD.Actualizar(producto);
        }

        // =====================================================
        // ELIMINAR PRODUCTO
        // =====================================================

        static void Eliminar_Producto(Producto_CRUD productoCRUD)
        {
            Console.WriteLine("\n\n ELIMINAR PRODUCTO");

            int id = Leer_Id();

            Console.Write("\n ¿Está seguro de eliminar el producto? (S/N): ");
            string? respuesta = Console.ReadLine();

            if (respuesta != null && respuesta.Trim().ToUpper() == "S")
            {
                productoCRUD.Eliminar(id);
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

                if (int.TryParse(entrada, out int id))
                {
                    if (id > 0)
                    {
                        return id;
                    }
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n ¡Entrada inválida! El ID debe ser mayor que cero.");
                Console.ResetColor();
            }
        }
    }
}
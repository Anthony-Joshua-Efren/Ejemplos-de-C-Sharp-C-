using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo_16
{
    internal class Producto
    {
        // =====================================================
        // ATRIBUTOS PRIVADOS
        // =====================================================

        private int id;
        private string? nombre;
        private double precio;
        private int cantidad;

        // =====================================================
        // CONSTRUCTORES
        // =====================================================

        /*
         * Constructor vacío.
         * Se utiliza cuando necesitamos crear un objeto y posteriormente asignar sus valores.
         */

        public Producto()
        {
            id = 0;
            nombre = "";
            precio = 0.0;
            cantidad = 0;
        }


        /*
         * Constructor con parámetros.
         *
         * Permite crear un objeto Producto enviando todos sus datos.
         */

        public Producto(int id, string nombre, double precio, int cantidad)
        {
            this.id = id;
            this.nombre = nombre;
            this.precio = precio;
            this.cantidad = cantidad;
        }

        // =====================================================
        // MÉTODOS GET
        // =====================================================

        public int Obtener_Id()
        {
            return id;
        }

        public string Obtener_Nombre()
        {
            return nombre ?? "";
        }

        public double Obtener_Precio()
        {
            return precio;
        }

        public int Obtener_Cantidad()
        {
            return cantidad;
        }

        // =====================================================
        // MÉTODOS SET
        // =====================================================

        public void Establecer_Id(int id)
        {
            this.id = id;
        }

        public void Establecer_Nombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void Establecer_Precio(double precio)
        {
            this.precio = precio;
        }

        public void Establecer_Cantidad(int cantidad)
        {
            this.cantidad = cantidad;
        }

        // =====================================================
        // SOLICITAR DATOS
        // =====================================================

        public void Solicitar_Datos()
        {
            nombre = Leer_Nombre();
            precio = Leer_Double_Positivo("\n - Ingrese el precio: ", "(El precio debe ser mayor que cero.)");
            cantidad = Leer_Entero_Positivo("\n - Ingrese la cantidad: ", "(La cantidad debe ser mayor que cero.)");
        }

        // =====================================================
        // IMPRIMIR INFORMACIÓN
        // =====================================================

        public void Imprimir_Informacion()
        {
            Console.WriteLine($" - ID: {id}");
            Console.WriteLine($" - Nombre: {nombre}");
            Console.WriteLine($" - Precio: ${precio:F2}");
            Console.WriteLine($" - Cantidad: {cantidad}");
        }

        // =====================================================
        // LEER NOMBRE
        // =====================================================

        private string Leer_Nombre()
        {
            while (true)
            {
                Console.Write("\n - Ingrese el nombre del producto: ");
                string? entrada = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(entrada))
                {
                    return entrada.Trim();
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n ¡Entrada inválida! El nombre no puede estar vacío.");
                Console.ResetColor();
            }
        }

        // =====================================================
        // LEER DOUBLE POSITIVO
        // =====================================================

        private double Leer_Double_Positivo(string mensaje, string mensajeError)
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
                    Console.WriteLine($"\n ¡Entrada inválida! {mensajeError}");
                    Console.ResetColor();

                    continue;
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n ¡Entrada inválida! Debes ingresar un número.");
                Console.ResetColor();
            }
        }

        // =====================================================
        // LEER ENTERO POSITIVO
        // =====================================================

        private int Leer_Entero_Positivo(string mensaje, string mensajeError)
        {
            while (true)
            {
                Console.Write(mensaje);
                string? entrada = Console.ReadLine();

                if (int.TryParse(entrada, out int valor))
                {
                    if (valor > 0)
                    {
                        return valor;
                    }

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\n ¡Entrada inválida! {mensajeError}");
                    Console.ResetColor();

                    continue;
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n ¡Entrada inválida! Debes ingresar un número entero.");
                Console.ResetColor();
            }
        }
    }
}
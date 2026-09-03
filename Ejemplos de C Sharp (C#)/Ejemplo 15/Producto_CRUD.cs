using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo_15
{
    internal class Producto_CRUD
    {
        // =====================================================
        // ATRIBUTOS PRIVADOS
        // =====================================================

        private readonly Conexión_BD Conexión_BD;

        // =====================================================
        // CONSTRUCTOR
        // =====================================================

        public Producto_CRUD()
        {
            Conexión_BD = new Conexión_BD();
        }

        // =====================================================
        // CREATE
        // =====================================================

        // Inserta un producto en la base de datos.

        public void Insertar(Producto producto)
        {
            try
            {
                using SqliteConnection conexión = Conexión_BD.Obtener_Conexión();

                using SqliteCommand comando = conexión.CreateCommand();

                comando.CommandText = """

                    INSERT INTO Productos
                    (
                        Nombre,
                        Precio,
                        Cantidad
                    )
                    VALUES
                    (
                        $nombre,
                        $precio,
                        $cantidad
                    );

                    """;

                // Agregamos parámetros.
                // Esto evita construir la consulta concatenando directamente los datos del usuario.

                comando.Parameters.AddWithValue("$nombre", producto.Obtener_Nombre());
                comando.Parameters.AddWithValue("$precio", producto.Obtener_Precio());
                comando.Parameters.AddWithValue("$cantidad", producto.Obtener_Cantidad());

                comando.ExecuteNonQuery();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Producto registrado correctamente.");
                Console.ResetColor();
            }
            catch (SqliteException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Error al registrar el producto.");
                Console.WriteLine($" Detalle: {ex.Message}");
                Console.ResetColor();
            }
        }

        // =====================================================
        // READ
        // =====================================================

        // Obtiene todos los productos almacenados.

        public void Consultar()
        {
            try
            {
                using SqliteConnection conexion = Conexión_BD.Obtener_Conexión();

                using SqliteCommand comando = conexion.CreateCommand();

                comando.CommandText = """

                    SELECT
                        Id,
                        Nombre,
                        Precio,
                        Cantidad
                    FROM Productos
                    ORDER BY Id;

                    """;

                // ExecuteReader() permite recorrer las filas devueltas por un SELECT.

                using SqliteDataReader lector = comando.ExecuteReader();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n ========================================================");
                Console.WriteLine("                 LISTA DE PRODUCTOS");
                Console.WriteLine(" ========================================================\n");
                Console.ResetColor();

                bool existenProductos = false;

                while (lector.Read())
                {
                    existenProductos = true;

                    int id = lector.GetInt32(0);
                    string nombre = lector.GetString(1);
                    double precio = lector.GetDouble(2);
                    int cantidad = lector.GetInt32(3);

                    Console.WriteLine($" - ID: {id}");
                    Console.WriteLine($" - Nombre: {nombre}");
                    Console.WriteLine($" - Precio: ${precio:F2}");
                    Console.WriteLine($" - Cantidad: {cantidad}");
                    Console.WriteLine(" --------------------------------------------------------");
                }

                if (!existenProductos)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n No existen productos registrados.");
                    Console.ResetColor();
                }
            }
            catch (SqliteException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Error al consultar los productos.");
                Console.WriteLine($" Detalle: {ex.Message}");
                Console.ResetColor();
            }
        }

        // =====================================================
        // UPDATE
        // =====================================================

        // Actualiza los datos de un producto  su ID.

        public void Actualizar(Producto producto)
        {
            try
            {
                using SqliteConnection conexion = Conexión_BD.Obtener_Conexión();

                using SqliteCommand comando = conexion.CreateCommand();

                comando.CommandText = """

                    UPDATE Productos

                    SET
                        Nombre = $nombre,
                        Precio = $precio,
                        Cantidad = $cantidad

                    WHERE Id = $id;

                    """;

                comando.Parameters.AddWithValue("$id", producto.Obtener_Id());
                comando.Parameters.AddWithValue("$nombre", producto.Obtener_Nombre());
                comando.Parameters.AddWithValue("$precio", producto.Obtener_Precio());
                comando.Parameters.AddWithValue("$cantidad", producto.Obtener_Cantidad());

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n Producto actualizado correctamente.");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n No se encontró un producto con ese ID.");
                    Console.ResetColor();
                }
            }
            catch (SqliteException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Error al actualizar el producto.");
                Console.WriteLine($" Detalle: {ex.Message}");
                Console.ResetColor();
            }
        }

        // =====================================================
        // DELETE
        // =====================================================

        // Elimina un producto mediante su ID.

        public void Eliminar(int id)
        {
            try
            {
                using SqliteConnection conexion = Conexión_BD.Obtener_Conexión();

                using SqliteCommand comando = conexion.CreateCommand();

                comando.CommandText = """

                    DELETE FROM Productos
                    WHERE Id = $id;

                    """;

                comando.Parameters.AddWithValue("$id", id);

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n Producto eliminado correctamente.");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n No se encontró un producto con ese ID.");
                    Console.ResetColor();
                }
            }
            catch (SqliteException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Error al eliminar el producto.");
                Console.WriteLine($" Detalle: {ex.Message}");
                Console.ResetColor();
            }
        }
    }
}
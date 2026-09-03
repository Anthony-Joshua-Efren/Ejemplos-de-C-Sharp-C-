using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo_15
{
    internal class BD
    {
        // =====================================================
        // ATRIBUTOS PRIVADOS
        // =====================================================

        private readonly Conexión_BD Con_BD;

        // =====================================================
        // CONSTRUCTOR
        // =====================================================

        public BD()
        {
            Con_BD = new Conexión_BD();
        }

        // =====================================================
        // CREAR TABLAS
        // =====================================================

        // Este método crea las tablas necesarias para nuestra aplicación.

        public void Crear_Tablas()
        {
            try
            {
                // Obtener conexión.

                using SqliteConnection Conexión = Con_BD.Obtener_Conexión();

                // Crear comando.

                using SqliteCommand Comando = Conexión.CreateCommand();

                // SQL para crear la tabla.

                Comando.CommandText = """

                    CREATE TABLE IF NOT EXISTS Productos
                    (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Nombre TEXT NOT NULL,
                        Precio REAL NOT NULL,
                        Cantidad INTEGER NOT NULL
                    );

                    """;

                // Ejecutar SQL.

                Comando.ExecuteNonQuery();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Tabla Productos creada correctamente.");
                Console.ResetColor();
            }
            catch (SqliteException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Error al crear la tabla.");
                Console.WriteLine($"\n Detalle: {ex.Message}");
                Console.ResetColor();

                throw;
            }
        }
    }
}
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo_15
{
    internal class Conexión_BD
    {
        // =====================================================
        // ATRIBUTOS PRIVADOS
        // =====================================================

        // Esta cadena indica dónde estará ubicada nuestra base de datos SQLite.
        // readonly significa que la variable no puede ser modificada después de su inicialización.
        // Data Source = Tienda.db indica que la base de datos se llamará "Tienda.db" y estará en el mismo directorio que el ejecutable.

        private readonly string Cadena_Conexión = "Data Source = Tienda.db";

        // =====================================================
        // OBTENER CONEXIÓN
        // =====================================================

        // SqliteConnection es la clase que representa una conexión a una base de datos SQLite.

        public SqliteConnection Obtener_Conexión()
        {
            try
            {
                // Creamos la conexión.

                SqliteConnection Conexión = new SqliteConnection(Cadena_Conexión);

                // Abrimos la conexión.

                Conexión.Open();

                // Regresamos la conexión abierta.

                return Conexión;
            }
            catch (SqliteException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Error al conectar con la base de datos.");
                Console.WriteLine($"\n Detalle: {ex.Message}");
                Console.ResetColor();

                throw;
                /* throw sirve para relanzar la excepción y que pueda ser manejada
                 * por el código que llama a este método.
                 */
            }
        }
    }
}
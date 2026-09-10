using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo_16
{
    internal class Conexión_Excel
    {
        // =====================================================
        // ATRIBUTOS PRIVADOS
        // =====================================================

        // Ruta donde se almacenará el archivo de Excel.

        private readonly string Ruta_Archivo = "Productos.xlsx";

        // =====================================================
        // OBTENER RUTA
        // =====================================================

        public string Obtener_Ruta()
        {
            return Ruta_Archivo;
        }

        // =====================================================
        // VERIFICAR ARCHIVO
        // =====================================================

        // Este método comprueba si el archivo de Excel ya existe.

        public bool Existe()
        {
            return File.Exists(Ruta_Archivo);
        }

        // =====================================================
        // CREAR ARCHIVO
        // =====================================================

        // Este método crea el archivo Excel y prepara la hoja Productos.

        public void Crear_Archivo()
        {
            try
            {
                // Creamos un nuevo libro de Excel.

                using XLWorkbook libro = new XLWorkbook();

                // Creamos una hoja llamada Productos.

                IXLWorksheet hoja = libro.Worksheets.Add("Productos");

                // =================================================
                // ENCABEZADOS
                // =================================================

                hoja.Cell(1, 1).Value = "Id";
                hoja.Cell(1, 2).Value = "Nombre";
                hoja.Cell(1, 3).Value = "Precio";
                hoja.Cell(1, 4).Value = "Cantidad";

                // Damos formato a los encabezados.

                hoja.Range("A1:D1").Style.Font.Bold = true;

                // Ajustamos automáticamente el ancho de las columnas.

                hoja.Columns().AdjustToContents();

                // Guardamos el archivo.

                libro.SaveAs(Ruta_Archivo);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Archivo Productos.xlsx creado correctamente.");
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Error al crear el archivo de Excel.");
                Console.WriteLine($" Detalle: {ex.Message}");
                Console.ResetColor();

                throw;
            }
        }
    }
}
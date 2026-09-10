using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo_16
{
    internal class Producto_Excel
    {
        // =====================================================
        // ATRIBUTOS PRIVADOS
        // =====================================================

        private readonly Conexión_Excel conexión_Excel;

        // =====================================================
        // CONSTRUCTOR
        // =====================================================

        public Producto_Excel()
        {
            conexión_Excel = new Conexión_Excel();
        }

        // =====================================================
        // INSERTAR PRODUCTO
        // =====================================================

        // Agrega un nuevo producto al archivo Excel.

        public void Insertar(Producto producto)
        {
            try
            {
                // Verificamos que el archivo exista.

                if (!conexión_Excel.Existe())
                {
                    conexión_Excel.Crear_Archivo();
                }

                // Abrimos el libro existente.

                using XLWorkbook libro = new XLWorkbook(conexión_Excel.Obtener_Ruta());

                // Obtenemos la hoja Productos.

                IXLWorksheet hoja = libro.Worksheet("Productos");

                // Buscamos la siguiente fila disponible.
                // La fila 1 contiene los encabezados.

                int nuevaFila = hoja.LastRowUsed()?.RowNumber() + 1 ?? 2;

                // Obtenemos el siguiente ID.

                int nuevoId = Obtener_Siguiente_Id(hoja);

                // Escribimos la información.

                hoja.Cell(nuevaFila, 1).Value = nuevoId;
                hoja.Cell(nuevaFila, 2).Value = producto.Obtener_Nombre();
                hoja.Cell(nuevaFila, 3).Value = producto.Obtener_Precio();
                hoja.Cell(nuevaFila, 4).Value = producto.Obtener_Cantidad();

                // Formato para el precio.

                hoja.Cell(nuevaFila, 3).Style.NumberFormat.Format = "$#,##0.00";

                // Ajustamos columnas.

                hoja.Columns().AdjustToContents();

                // Guardamos los cambios.

                libro.Save();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Producto registrado correctamente.");
                Console.ResetColor();
            }
            catch (IOException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n No fue posible modificar el archivo.");
                Console.WriteLine("\n Verifique que Productos.xlsx no esté abierto.");
                Console.WriteLine($" Detalle: {ex.Message}");

                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Error al registrar el producto.");
                Console.WriteLine($" Detalle: {ex.Message}");
                Console.ResetColor();
            }
        }

        // =====================================================
        // OBTENER SIGUIENTE ID
        // =====================================================

        private int Obtener_Siguiente_Id(IXLWorksheet hoja)
        {
            int ultimoId = 0;

            if (hoja.LastRowUsed() == null)
            {
                return 1;
            }

            foreach (IXLRow fila in hoja.RowsUsed().Skip(1))
            {
                int id = fila.Cell(1).GetValue<int>();

                if (id > ultimoId)
                {
                    ultimoId = id;
                }
            }

            return ultimoId + 1;
        }

        // =====================================================
        // CONSULTAR PRODUCTOS
        // =====================================================

        public void Consultar()
        {
            try
            {
                if (!conexión_Excel.Existe())
                {
                    Console.WriteLine("\n No existe el archivo Productos.xlsx.");
                    return;
                }

                using XLWorkbook libro = new XLWorkbook(conexión_Excel.Obtener_Ruta());

                IXLWorksheet hoja = libro.Worksheet("Productos");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n ========================================================");
                Console.WriteLine("                 LISTA DE PRODUCTOS");
                Console.WriteLine(" ========================================================\n");
                Console.ResetColor();

                bool existenProductos = false;

                foreach (IXLRow fila in hoja.RowsUsed().Skip(1))
                {
                    existenProductos = true;

                    int id = fila.Cell(1).GetValue<int>();
                    string nombre = fila.Cell(2).GetValue<string>();
                    double precio = fila.Cell(3).GetValue<double>();
                    int cantidad = fila.Cell(4).GetValue<int>();

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
            catch (IOException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n No fue posible leer el archivo.");
                Console.WriteLine("\n Verifique que Productos.xlsx no esté bloqueado.");
                Console.WriteLine($" Detalle: {ex.Message}");
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Error al consultar los productos.");
                Console.WriteLine($" Detalle: {ex.Message}");
                Console.ResetColor();
            }

        }

        // =====================================================
        // ACTUALIZAR PRODUCTOS
        // =====================================================

        public void Actualizar(Producto producto)
        {
            try
            {
                if (!conexión_Excel.Existe())
                {
                    Console.WriteLine("\n No existe el archivo Productos.xlsx.");
                    return;
                }

                using XLWorkbook libro = new XLWorkbook(conexión_Excel.Obtener_Ruta());

                IXLWorksheet hoja = libro.Worksheet("Productos");

                bool encontrado = false;

                foreach (IXLRow fila in hoja.RowsUsed().Skip(1))
                {
                    int id = fila.Cell(1).GetValue<int>();

                    if (id == producto.Obtener_Id())
                    {
                        fila.Cell(2).Value = producto.Obtener_Nombre();
                        fila.Cell(3).Value = producto.Obtener_Precio();
                        fila.Cell(4).Value = producto.Obtener_Cantidad();
                        fila.Cell(3).Style.NumberFormat.Format = "$#,##0.00";

                        encontrado = true;

                        break;
                    }
                }

                if (encontrado)
                {
                    hoja.Columns().AdjustToContents();
                    libro.Save();

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
            catch (IOException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n No fue posible modificar el archivo.");
                Console.WriteLine("\n Verifique que Productos.xlsx no esté abierto.");
                Console.WriteLine($" Detalle: {ex.Message}");
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Error al actualizar el producto.");
                Console.WriteLine($" Detalle: {ex.Message}");
                Console.ResetColor();
            }
        }

        // =====================================================
        // ELIMINAR PRODUCTOS
        // =====================================================

        public void Eliminar(int id)
        {
            try
            {
                if (!conexión_Excel.Existe())
                {
                    Console.WriteLine("\n No existe el archivo Productos.xlsx.");
                    return;
                }

                using XLWorkbook libro = new XLWorkbook(conexión_Excel.Obtener_Ruta());

                IXLWorksheet hoja = libro.Worksheet("Productos");

                bool encontrado = false;

                foreach (IXLRow fila in hoja.RowsUsed().Skip(1))
                {
                    int idProducto = fila.Cell(1).GetValue<int>();

                    if (idProducto == id)
                    {
                        fila.Delete();

                        encontrado = true;

                        break;
                    }
                }

                if (encontrado)
                {
                    libro.Save();

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
            catch (IOException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n No fue posible modificar el archivo.");
                Console.WriteLine("\n Verifique que Productos.xlsx no esté abierto.");
                Console.WriteLine($" Detalle: {ex.Message}");
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Error al eliminar el producto.");
                Console.WriteLine($" Detalle: {ex.Message}");
                Console.ResetColor();
            }
        }
    }
}
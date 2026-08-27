using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Ejemplo_14
{
    internal class API_Países
    {
        // =====================================================
        // ATRIBUTOS PRIVADOS
        // =====================================================

        // HttpClient será el encargado de realizar las peticiones HTTP hacia la API.

        private readonly HttpClient cliente;

        // URL base de la API actual.

        private readonly string URL_API = "https://api.restcountries.com/countries/v5";

        // Token de demostración proporcionado por la documentación oficial.

        // IMPORTANTE: En una aplicación real NO debemos colocar credenciales directamente en el código.

        private readonly string token = "rc_live_demo"; // (Canada)
        //private readonly string token = "rc_live_d676f485f4ba42b5b016b1a9790ccd78"; // ´Token personal)

        // =====================================================
        // CONSTRUCTOR
        // =====================================================

        public API_Países()
        {
            cliente = new HttpClient();
            cliente.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            
            // Bearer token para autentitcación es un tipo de token de acceso que se utiliza en la autenticación de API.
            // Se envía en el encabezado de la solicitud HTTP para verificar la identidad del cliente y permitir el acceso a los recursos protegidos.
        }

        // =====================================================
        // BUSCAR PAÍS
        // =====================================================

        // Este método realiza una petición GET hacia la API utilizando el nombre del país.

        // try-catch se utiliza para manejar posibles errores durante la ejecución del código.

        public async Task<País?> Buscar_País(string país_Búsqueda)
        {
            try
            {
                // Convertimos el nombre para poder utilizarlo correctamente dentro de la URL.

                país_Búsqueda = Uri.EscapeDataString(país_Búsqueda);

                // Endpoint para buscar por nombre.
                // Endpoint es la parte de la URL que indica el recurso específico al que queremos acceder en la API.

                string URL = $"{URL_API}/names.common/{país_Búsqueda}";

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n Consultando información en la API...");
                Console.ResetColor();

                // Realizamos la petición GET.
                // await permite esperar la respuesta sin bloquear el hilo.

                string json_Response = await cliente.GetStringAsync(URL);

                // Convertimos el JSON recibido en un documento que podremos recorrer.

                using JsonDocument documento = JsonDocument.Parse(json_Response);

                JsonElement root = documento.RootElement;

                // La API actual devuelve la información dentro del objeto "data".

                JsonElement data = root.GetProperty("data");

                JsonElement objects = data.GetProperty("objects");

                // Tomamos el primer resultado.

                JsonElement country = objects[0];

                // =================================================
                // EXTRAER INFORMACIÓN
                // =================================================

                string nombre_Común = country.GetProperty("names").GetProperty("common").GetString()?? "Desconocido";
                string capital = country.GetProperty("capitals")[0].GetProperty("name").GetString()?? "Sin capital";
                long población = country.GetProperty("population").GetInt64();

                // Creamos el objeto Pais.

                País país = new País();
                país.Asignar_Datos(nombre_Común, capital, población);

                return país;
            }

            catch (HttpRequestException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Error de conexión con la API.");
                Console.WriteLine($" Detalle: {ex.Message}");
                Console.ResetColor();

                return null;
            }

            catch (JsonException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Error al interpretar la respuesta JSON.");
                Console.WriteLine($" Detalle: {ex.Message}");
                Console.ResetColor();

                return null;
            }

            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Ocurrió un error inesperado.");
                Console.WriteLine($" Detalle: {ex.Message}");
                Console.ResetColor();

                return null;
            }
        }
    }
}

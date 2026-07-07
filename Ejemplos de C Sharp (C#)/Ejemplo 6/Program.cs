namespace Ejemplo_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejemplo 6 (TimeSpan)";

            Console.WriteLine("====================================================");
            Console.WriteLine("               EJEMPLO DE TIMESPAN");
            Console.WriteLine("====================================================\n");

            #region 1. Constructores

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("1. CONSTRUCTORES \n");
            Console.ResetColor();

            /*
                TimeSpan posee varios constructores.
            */

            // Horas, minutos y segundos
            TimeSpan tiempo_1 = new TimeSpan(2, 30, 15);

            // Días, horas, minutos, segundos
            TimeSpan tiempo_2 = new TimeSpan(1, 5, 20, 40);

            // Días, horas, minutos, segundos y milisegundos
            TimeSpan tiempo_3 = new TimeSpan(2, 10, 15, 50, 250);

            Console.WriteLine($"\tTiempo 1: {tiempo_1}");
            Console.WriteLine($"\tTiempo 2: {tiempo_2}");
            Console.WriteLine($"\tTiempo 3: {tiempo_3}");

            Console.WriteLine();

            #endregion

            #region 2. Métodos

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("2. MÉTODOS ESTÁTICOS\n");
            Console.ResetColor();

            /*
                Son la forma más utilizada para crear TimeSpan.
            */

            TimeSpan dias = TimeSpan.FromDays(5);

            TimeSpan horas = TimeSpan.FromHours(4.5);

            TimeSpan minutos = TimeSpan.FromMinutes(150);

            TimeSpan segundos = TimeSpan.FromSeconds(90);

            TimeSpan milisegundos = TimeSpan.FromMilliseconds(500);

            TimeSpan microsegundos = TimeSpan.FromMicroseconds(800);

            Console.WriteLine($"\t5 días = {dias}");
            Console.WriteLine($"\t4.5 horas = {horas}");
            Console.WriteLine($"\t150 minutos = {minutos}");
            Console.WriteLine($"\t90 segundos = {segundos}");
            Console.WriteLine($"\t500 milisegundos = {milisegundos}");
            Console.WriteLine($"\t800 microsegundos = {microsegundos}");

            Console.WriteLine();

            #endregion

            #region 3. Parse

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("3. PARSE\n");
            Console.ResetColor();

            /*
                Convierte un texto en TimeSpan.
            */

            TimeSpan parse_1 = TimeSpan.Parse("10:15:30");

            TimeSpan parse_2 = TimeSpan.Parse("2.08:30:15"); // 2 días

            Console.WriteLine("\t" + parse_1);
            Console.WriteLine("\t" + parse_2);

            Console.WriteLine();

            #endregion

            #region 4. TryParse

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("4. TRYPARSE\n");
            Console.ResetColor();

            /*
                Evita errores cuando el usuario escribe datos inválidos.
            */

            Console.Write("\tIngrese una duración (hh:mm:ss): ");

            string? entrada = Console.ReadLine();

            if (TimeSpan.TryParse(entrada, out TimeSpan resultado))
            {
                Console.WriteLine("\n\tDuración válida.");
                Console.WriteLine("\t" + resultado);
            }
            else
            {
                Console.WriteLine("\n\tFormato incorrecto.");
            }

            Console.WriteLine();

            #endregion

            #region 5. Propiedades

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("5. PROPIEDADES\n");
            Console.ResetColor();

            TimeSpan tiempo = new TimeSpan(1, 10, 20, 30, 500);

            Console.WriteLine($"\tDays = {tiempo.Days}");
            Console.WriteLine($"\tHours = {tiempo.Hours}");
            Console.WriteLine($"\tMinutes = {tiempo.Minutes}");
            Console.WriteLine($"\tSeconds = {tiempo.Seconds}");
            Console.WriteLine($"\tMilliseconds = {tiempo.Milliseconds}");

            Console.WriteLine("\n\t===== PROPIEDADES TOTALES =====\n");

            Console.WriteLine($"\tTotalDays = {tiempo.TotalDays}");
            Console.WriteLine($"\tTotalHours = {tiempo.TotalHours}");
            Console.WriteLine($"\tTotalMinutes = {tiempo.TotalMinutes}");
            Console.WriteLine($"\tTotalSeconds = {tiempo.TotalSeconds}");
            Console.WriteLine($"\tTotalMilliseconds = {tiempo.TotalMilliseconds}");

            Console.WriteLine();

            #endregion

            #region 6. Operadores

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("6. OPERADORES\n");
            Console.ResetColor();

            TimeSpan a = TimeSpan.FromHours(5);

            TimeSpan b = TimeSpan.FromMinutes(30);

            Console.WriteLine($"\ta = {a}");
            Console.WriteLine($"\tb = {b}\n");

            Console.WriteLine($"\tSuma = {a + b}");

            Console.WriteLine($"\tResta = {a - b}");

            Console.WriteLine($"\tMultiplicación = {a * 2}");

            Console.WriteLine($"\tDivisión = {a / 2}");

            Console.WriteLine();

            #endregion

            #region 7. Comparaciones

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("7. COMPARACIONES\n");
            Console.ResetColor();

            Console.WriteLine("\t{0}", a > b);

            Console.WriteLine("\t{0}", a < b);

            Console.WriteLine("\t{0}", a == b);

            Console.WriteLine("\t{0}", a != b);

            Console.WriteLine("\t{0}", a >= b);

            Console.WriteLine("\t{0}", a <= b);

            Console.WriteLine();

            #endregion

            #region 8. Métodos

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("8. MÉTODOS\n");
            Console.ResetColor();

            Console.WriteLine($"\tAdd = {a.Add(b)}");

            Console.WriteLine($"\tSubtract = {a.Subtract(b)}");

            Console.WriteLine($"\tDuration = {TimeSpan.FromHours(-5).Duration()}");

            Console.WriteLine($"\tNegate = {a.Negate()}");

            Console.WriteLine();

            #endregion

            #region 9. Valores especiales

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("9. VALORES ESPECIALES\n");
            Console.ResetColor();

            Console.WriteLine("\t{0}", TimeSpan.Zero);

            Console.WriteLine("\t{0}", TimeSpan.MaxValue);

            Console.WriteLine("\t{0}", TimeSpan.MinValue);

            Console.WriteLine();

            #endregion

            #region 10. Formatos

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("10. FORMATOS\n");
            Console.ResetColor();

            TimeSpan formato = new TimeSpan(2, 8, 15, 20);

            Console.WriteLine("\t{0}", formato);

            Console.WriteLine("\t{0}", formato.ToString("c"));

            Console.WriteLine("\t{0}", formato.ToString("g"));

            Console.WriteLine(  formato.ToString("G"));

            Console.WriteLine("\t{0}", formato.ToString(@"dd\.hh\:mm\:ss"));

            Console.WriteLine("\t{0}", formato.ToString(@"hh\:mm"));

            Console.WriteLine("\t{0}", formato.ToString(@"hh\:mm\:ss"));

            Console.WriteLine();

            #endregion

            #region 11. Caso práctico

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("11. CASO PRÁCTICO\n");
            Console.ResetColor();

            /*
                Una persona entra a trabajar a las 08:30
                Sale a las 17:45
            */

            TimeSpan entrada_Trabajo = new TimeSpan(8, 30, 0);

            TimeSpan salida_Trabajo = new TimeSpan(17, 45, 0);

            TimeSpan jornada = salida_Trabajo - entrada_Trabajo;

            Console.WriteLine($"\tEntrada: {entrada_Trabajo}");

            Console.WriteLine($"\tSalida: {salida_Trabajo}");

            Console.WriteLine($"\tTrabajó: {jornada}");

            Console.WriteLine($"\tHoras trabajadas: {jornada.TotalHours}");

            Console.WriteLine();

            #endregion

            #region 12. Ejemplo con DateTime

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("12. TIMESPAN + DATETIME\n");
            Console.ResetColor();

            /*
                Aquí sí usamos DateTime.
            */

            DateTime inicio = DateTime.Now;

            System.Threading.Thread.Sleep(3000);

            DateTime fin = DateTime.Now;

            TimeSpan diferencia = fin - inicio;

            Console.WriteLine($"\tInicio: {inicio}");

            Console.WriteLine($"\tFin: {fin}");

            Console.WriteLine($"\tTiempo transcurrido: {diferencia}");

            Console.WriteLine();

            #endregion

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("FIN DEL EJEMPLO");
            Console.ResetColor();

            Console.ReadKey();
        }
    }
}

namespace Ejemplo_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejemplo 5"; //Título de la ventana de la consola
            //Console.BackgroundColor = ConsoleColor.DarkBlue; // Color de fondo de la consola
            //Console.ForegroundColor = ConsoleColor.Green; // Color del texto de la consola

            Console.WriteLine("Uso y ejemplos de Math y DateTime en C#.");

            int absoluto = Math.Abs(10 - 25); // Valor absoluto de la resta
            double área = Math.PI * Math.Pow(5, 2); // Área de un círculo con radio 5
            double raíz_cuadrada = Math.Sqrt(81); // Raíz cuadrada de 81
            double redondeado = Math.Round(12.678, 2); // Número 12.678 redondeado a 2 decimales

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n MATH");
            Console.ResetColor();

            Console.WriteLine($"\n Valor absoluto de 10 - 25: {absoluto}");
            Console.WriteLine($"\n Área de un círculo con radio 5: {área}");
            Console.WriteLine($"\n Raíz cuadrada de 81: {raíz_cuadrada}");
            Console.WriteLine($"\n Número 12.678 redondeado a 2 decimales: {redondeado}");

            Console.WriteLine("\n ---------------------------------------------------------------------------");

            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n DateTime");
            Console.ResetColor();

            // Creación de un objeto DateTime para obtener la fecha y hora actual
            DateTime ahora = DateTime.Now;

            Console.WriteLine($"\n La fecha actual es: {ahora.ToLongDateString()}" + " (formato largo)."); // Muestra la fecha actual en formato largo
            Console.WriteLine($"\n La fecha actual es: {ahora.ToShortDateString()}" + " (formato corto dd/mm/aaaa)."); // Muestra la fecha actual en formato corto
            Console.WriteLine($"\n El año es: {ahora.Year}"); // Muestra el año actual
            Console.WriteLine($"\n El mes es: {ahora.Month}"); // Muestra el mes actual
            Console.WriteLine($"\n El día es: {ahora.Day}"); // Muestra el día actual
            Console.WriteLine($"\n La hora actual es: {ahora.ToLongTimeString()}" + " (formato largo)."); // Muestra la hora actual en formato largo
            Console.WriteLine($"\n La hora actual es: {ahora.ToShortTimeString()}" + " (formato corto)."); // Muestra la hora actual en formato corto
            Console.WriteLine($"\n La hora actual es: {ahora.Hour} horas, {ahora.Minute} minutos y {ahora.Second} segundos."); // Muestra la hora actual en horas, minutos y segundos
            Console.WriteLine($"\n La fecha y hora actual es: {ahora.ToString("dd/MM/yyyy HH:mm:ss")}" + " (formato personalizado)."); // Muestra la fecha y hora actual en formato personalizado
            Console.WriteLine($"\n La fecha de tu país es: {ahora.ToLocalTime()}"); // Muestra la fecha y hora actual en formato local
            Console.WriteLine($"\n El día es: {ahora.DayOfWeek}"); // Muestra el día de la semana actual

            Console.ReadKey();
        }
    }
}

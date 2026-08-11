using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejemplo_12
{
    public class Alumno
    {
        // ATRIBUTOS (PROPIEDADES / CARACTERÍSTICAS):

        // Estas propiedades representan las características que tiene un objeto de tipo Alumno.

        // Getters y Setters permiten acceder y modificar las propiedades de un objeto.

        // Get: Permite obtener el valor de la propiedad.
        // Set: Permite modificar el valor de la propiedad.

        public string? Nombre { get; set; }

        public string? Apellido { get; set; }

        public int Edad { get; set; }

        // CONSTRUCTOR:

        // El constructor es un método especial que se llama automáticamente cuando se crea un objeto de la clase.
        // Su función es inicializar las propiedades del objeto.

        public Alumno(string nombre, string apellido, int edad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
        }

        // MÉTODOS (FUNCIONES):

        // Los métodos representan acciones o comportamientos que puede realizar un objeto.

        public void Mostrar_Informacion()
        {
            Console.WriteLine($"\n\t Nombre: {Nombre}");
            Console.WriteLine($"\n\t Apellido: {Apellido}");
            Console.WriteLine($"\n\t Edad: {Edad}");
        }

        public void Estudiar()
        {
            Console.WriteLine($"\n\t {Nombre} está estudiando programación.");
        }
    }
}
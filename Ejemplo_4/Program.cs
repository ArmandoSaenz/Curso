using System;

namespace Ejemplo_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string title = "Cuarto script";
            string mensaje = "¡HoLa MuNdO!";
            string mayusculas = mensaje.ToUpper();
            Console.Title = title;
            Console.WriteLine($"Mensaje original: {mensaje}");
            Console.WriteLine($"Mensaje en mayúsculas: {mayusculas}");
            Console.ReadLine();
        }
    }
}

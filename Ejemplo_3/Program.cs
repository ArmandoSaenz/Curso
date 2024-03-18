using System;

namespace Ejemplo_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string title = "Tercer script";
            string mensaje = "¡HoLa MuNdO!";
            string minusculas = mensaje.ToLower();
            Console.Title = title;
            Console.WriteLine($"Mensaje original: {mensaje}");
            Console.WriteLine($"Mensaje en minúsculas: {minusculas}");
        }
    }
}
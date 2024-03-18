using System;
using System.Linq;

namespace Ejemplo_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string title = "Quinto script";
            string mensaje = "¡Hola Mundo!";
            string mensaje2 = mensaje.Remove(5);
            string mensaje3 = mensaje.Remove(5, 2);
            Console.Title = title;
            Console.WriteLine($"Mensaje original: {mensaje}");
            mensaje.Reverse();
            Console.WriteLine($"Eliminando desde el caracter 5: {mensaje2}");
            Console.WriteLine($"Eliminando 2 caracteres comenzando desde el 5: {mensaje3}");
            Console.ReadLine();
        }
    }
}

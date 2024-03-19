using System;

namespace Ejemplo_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string title = "Cuarto script";
            Console.Title = title;
            //---------------------------------------------------------------
            Console.Write("Ingresa una palabra o frase:");
            string mensaje = Console.ReadLine();
            string mensaje2 = mensaje.Remove(5);
            string mensaje3 = mensaje.Remove(5, 2);
            Console.WriteLine($"Mensaje original: {mensaje}");
            Console.WriteLine($"Eliminando desde el caracter 5: {mensaje2}");
            Console.WriteLine($"Eliminando 2 caracteres comenzando desde el 5: {mensaje3}");
            Console.ReadLine();
        }
    }
}
using System;

namespace Ejemplo_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string title = "Quinto script";
            Console.Title = title;
            //---------------------------------------------------------------
            Console.Write("Ingresa una palabra o frase:");
            string mensaje = Console.ReadLine();
            string mensaje2 = mensaje.Substring(5);
            string mensaje3 = mensaje.Substring(5,2);
            Console.WriteLine($"Mensaje original: {mensaje}");
            Console.WriteLine($"Extrayendo desde el caracter 5: {mensaje2}");
            Console.WriteLine($"Extrayendo 2 caracteres comenzando desde el 5: {mensaje3}");
            Console.ReadLine();
        }
    }
}
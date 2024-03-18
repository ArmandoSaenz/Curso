using System;

namespace Ejemplo_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string title = "Segundo script";
            string mensaje = "¡Hola mundo!";
            Console.Title = title;
            Console.WriteLine(mensaje);
            Console.ReadLine();
        }
    }
}
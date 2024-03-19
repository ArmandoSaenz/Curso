using System;

namespace Ejemplo_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string title = "Tercer script";
            Console.Title = title;
            //---------------------------------------------------------------
            Console.Write("Ingresa una palabra o frase:");
            string mensaje = Console.ReadLine();
            string minusculas = mensaje.ToLower();
            string mayusculas = mensaje.ToUpper();
            Console.WriteLine($"Original: {mensaje}");
            Console.WriteLine($"En Minúsculas: {minusculas}");
            Console.WriteLine($"En Mayúsculas: {mayusculas}");
            Console.ReadLine();
        }
    }
}

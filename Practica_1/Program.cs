using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string titulo = "Practica 1";
            Console.Title = titulo;
            //----------------------------------------------------
            Console.Write("Escribe el nombre de pila: ");
            string nombre = Console.ReadLine();
            Console.Write("Escribe el apellido: ");
            string apellido = Console.ReadLine();
            string correo = nombre.ToLower().Remove(2);
            correo += apellido.ToLower().Remove(3);
            correo += "@ujed.mx";
            Console.WriteLine($"El correo es: {correo}");
            Console.ReadLine();
        }
    }
}

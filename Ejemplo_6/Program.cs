using System;

namespace Ejemplo_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string title = "Sexto script";
            Console.Title = title;
            //---------------------------------------------------------------
            Console.WriteLine("Este programa extrae información del proceso");
            string pcname = Environment.MachineName;
            string username = Environment.UserName;
            string CarpetaDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string CarpetaImagenes = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            string CarpetaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string currentfolder = Environment.CurrentDirectory;
            int processor = Environment.ProcessorCount;
            Console.WriteLine($"Nombre de la pc: {pcname}");
            Console.WriteLine($"El número de procesadores de la PC es {processor}");
            Console.WriteLine($"El usuario actual es {username}");
            Console.WriteLine($"La direccion de Documentos es {CarpetaDocumentos}");
            Console.WriteLine($"La direccion de Imagenes es {CarpetaImagenes}");
            Console.WriteLine($"La direccion de Escritorio es {CarpetaEscritorio}");
            Console.WriteLine($"La carpeta donde se esta ejecutando es: {currentfolder}");
            Console.ReadLine();
        }
    }
}
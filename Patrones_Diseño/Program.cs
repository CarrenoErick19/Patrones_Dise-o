using System;

namespace Patrones_Diseño
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Singleton.Instance.mensaje);
            Singleton.Instance.mensaje = "hola marte";
            Console.WriteLine(Singleton.Instance.mensaje);
        }
    }
}

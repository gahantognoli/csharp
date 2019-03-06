using System;
using static System.Console;

namespace ExemploOverload
{
    class Program
    {

        static void Mostrar(string obj)
        {
            WriteLine(obj);
        }

        static void Mostrar(int obj)
        {
            WriteLine($"Mostrar(int) {obj}");
        }

        static void Mostrar(bool obj)
        {
            WriteLine($"Mostrar(bool) {obj}");
        }

        static void Mostrar(object obj)
        {
            WriteLine($"");
        }

        static void Main(string[] args)
        {
            Mostrar("Olá Mundo!");
            Mostrar(10);
            Mostrar(true);

            ReadKey();
        }
    }
}

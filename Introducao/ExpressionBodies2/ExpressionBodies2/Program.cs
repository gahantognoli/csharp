using static System.Console;
using System;

namespace ExpressionBodies2
{
    public class Calc
    {
        public static string Nome => "Super Calc";

        public static int Somar(int x, int y) => x + y; //Expression bodies

        public static int Multiplicar(int x, int y) => x * y;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var resultado = Calc.Somar(10, 20);
            var mult = Calc.Multiplicar(10, 30);
            WriteLine($"Usando a calculadora: {Calc.Nome} \nResultado: {resultado}");
            WriteLine($"Usando {Calc.Nome}, a multiplicacao de {mult}");
            ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //operadores aritméticos
            //operadores primários
            //operadores de comparação
            //operadores lógicos


            //Exemplo prático
            Console.Write("Valor 1: ");
            decimal valor1 = decimal.Parse(Console.ReadLine());

            Console.Write("Valor 2: ");
            decimal valor2 = decimal.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Soma: " + (valor1 + valor2));
            Console.WriteLine("Subtração: " + (valor1 - valor2));
            Console.WriteLine("Multiplicação: " + (valor1 * valor2));
            Console.WriteLine("Divisão: " + (valor1 / valor2));

            if(valor1 > 0 && valor2 < 0)
                Console.WriteLine("Valores maiores do que 0.");

            Console.ReadKey();

        }
    }
}

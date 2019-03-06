using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repeticao1
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            for (int i = 1; i <= 1000; i++)
            {
                soma += i;
            }
            Console.Write("Soma dos numeros de 1 a 1000: " + soma);
            Console.ReadKey();
        }
    }
}

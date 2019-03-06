using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeticao4
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (!(i % 3 == 0))
                {
                    soma += i;        
                }
            }

            Console.WriteLine("Soma é: " + soma);
            Console.ReadKey();
        }
    }
}

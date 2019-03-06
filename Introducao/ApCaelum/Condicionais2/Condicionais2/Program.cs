using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorNotaFiscal = 999;

            if (valorNotaFiscal <= 999)
            {
                Console.WriteLine("Imposto de 2% sobre o valor da nota!");
            }
            else if(valorNotaFiscal >= 999 && valorNotaFiscal <= 2999)
            {
                Console.WriteLine("Imposto de 2,5% sobre o valor da nota!");
            }
            else if(valorNotaFiscal >= 3000 && valorNotaFiscal <= 6999)
            {
                Console.WriteLine("Imposto de 2,8% sobre o valor da nota!");
            }
            else if(valorNotaFiscal >= 7000)
            {
                Console.WriteLine("Imposto de 3% sobre o valor da nota!");
            }

            Console.ReadKey();

        }
    }
}

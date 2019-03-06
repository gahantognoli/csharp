using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionais3
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = 15;
            string mensagem = valor > 10 ? "Maior que dez!" : "Menor que dez!";

            Console.WriteLine(mensagem);
            Console.ReadKey();
        }
    }
}

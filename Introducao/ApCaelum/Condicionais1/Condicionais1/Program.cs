using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionais1
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 20;
            bool brasileira = true;

            if(idade >= 16 && brasileira)
            {
                Console.WriteLine("Você está apto a votar!");
            }
            else
            {
                Console.WriteLine("Você não está apto a votar!");
            }

            Console.ReadKey();
        }
    }
}

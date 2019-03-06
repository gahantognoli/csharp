using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            do
            {
                a++;
                Console.WriteLine(a);
            } while (a < 10);

            Console.ReadKey();

            int b = 10;
            while(b > 0)
            {
                Console.WriteLine(b);
                b--;
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}

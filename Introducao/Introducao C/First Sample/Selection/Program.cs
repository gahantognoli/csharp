using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection
{
    class Program
    {
        static void Main(string[] args)
        {
            #region If

            int a = 10;

            if (a == 5)
                Console.WriteLine("a = 5");
            else
                Console.WriteLine("a <> 5");

            //ternario
            int b = (a <= 10) ? 5 : 2;

            bool ok = true;
            if (ok)
                Console.WriteLine("OK");

            Console.ReadKey();

            #endregion

            #region switch

            int c = int.Parse(Console.ReadLine());

            switch (c)
            {
                case 0:
                    Console.WriteLine("c == 0");
                    break;

                case 5:
                    Console.WriteLine("c == 5");
                    break;

                case 10:
                    Console.WriteLine("c == 10");
                    break;

                default:
                    Console.WriteLine("c == " + c);
                    break;
            }

            Console.ReadKey();

            #endregion
        }
    }
}

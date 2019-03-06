using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Util.Calc;

namespace UsingStaticExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = Somar(3, 5);

            Console.WriteLine(r);
            Console.ReadKey();
        }
    }
}

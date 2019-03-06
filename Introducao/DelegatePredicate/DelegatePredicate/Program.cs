using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePredicate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>() { "Gabriel", "Jonathan", "William" };

            foreach (var s in nomes)
            {
                if (Contains(s))
                    Console.WriteLine(s);
            }

            Console.ReadLine();
        }

        public static string st = "i";

        public static bool Contains(string arg)
        {
            return arg.Contains(st);
        }

    }
}

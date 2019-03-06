using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            object o = (object)a;

            int b = (int)o;

            Console.WriteLine(o.GetType().ToString());
            Console.ReadKey();
        }
    }
}

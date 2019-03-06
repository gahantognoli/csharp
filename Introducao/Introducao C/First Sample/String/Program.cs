using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "one, two, three";

            string s2 = "one";
            s2 += " ,two";
            s2 += " ,three";

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("one");
            stringBuilder.Append(" ,two");
            stringBuilder.Append(" ,three");

            //recursos principais das strings
            s2.EndsWith("ree");
            s2.Equals("a");
            s2.IndexOf("two");
            s2.Insert(4, "OK");
            //s2.Length;
            s2.Remove(4, 3);
            s2.Replace("two", "one");

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(stringBuilder);
            Console.ReadKey();

        }
    }
}

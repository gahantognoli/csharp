using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueRef2
{

    public class Cliente
    {
        public int Codigo;
        public string Nome;
        public string Telefone;

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Codigo: " + Codigo);
            stringBuilder.AppendLine("Nome: " + Nome);
            stringBuilder.AppendLine("Telefone: " + Telefone);
            return stringBuilder.ToString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            int x = 10;
            string s = "Guinter";
            bool b = false;

            Cliente c = new Cliente { Codigo = 1, Nome = "Gabriel", Telefone = "17 3392-1256" };

            Console.WriteLine("Codigo: " + c.Codigo);
            Console.WriteLine("Nome: " + c.Nome);
            Console.WriteLine("Telefone: " + c.Telefone);

            Cliente c2;
            c2 = c;

            Console.WriteLine(c);
            Console.WriteLine(c2);

            if (c.Equals(c2))
            {
                Console.WriteLine("São iguais!");
            }

            Console.WriteLine("x: " + x);
            Console.WriteLine("s: " + s);
            Console.WriteLine("b: " + b);

            Console.ReadKey();
        }
    }
}

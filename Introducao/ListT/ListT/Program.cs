using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListT
{

    public class Cliente
    {
        public int Codigo;
        public string Nome;
        public string CPF;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente() { Codigo = 1, Nome = "Gabriel", CPF = "416.367.418-78" };
            Cliente cliente2 = new Cliente() { Codigo = 2, Nome = "João", CPF = "412.367.418-78" };
            Cliente cliente3 = new Cliente() { Codigo = 3, Nome = "Valter", CPF = "415.367.418-78" };

            List<Cliente> lista = new List<Cliente>(); //{cliente1, cliente2, cliente3};
            lista.Add(cliente1);
            lista.Add(cliente2);
            lista.Add(cliente3);

            foreach (Cliente item in lista)
            {
                Console.WriteLine(item.Nome);
            }

            Console.WriteLine(lista.FirstOrDefault(c => c.CPF == "416.367.418-78").Nome);

            Console.ReadKey();
        }
    }
}

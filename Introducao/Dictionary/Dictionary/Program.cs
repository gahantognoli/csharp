using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryA
{

    class Pedido
    {
        public int Codigo;
        public string Nome;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Pedido> pedidos = new Dictionary<int, Pedido>();
            Pedido p1 = new Pedido() { Codigo = 1, Nome = "AAA" };
            Pedido p2 = new Pedido() { Codigo = 2, Nome = "BBB" };
            Pedido p3 = new Pedido() { Codigo = 3, Nome = "CCC" };

            pedidos.Add(1, p1);
            pedidos.Add(2, p2);
            pedidos.Add(3, p3);

            foreach (Pedido item in pedidos.Values)
            {
                Console.WriteLine("Pedido numero: " + item.Codigo);
            }

            //Único foreach
            Console.WriteLine("PEDIDOS: ");
            foreach (KeyValuePair<int, Pedido> item in pedidos)
            {
                Console.WriteLine(item.Key + " - " + item.Value.Nome);
            }

            Console.WriteLine("Soma dos pedidos: ");
            var soma = pedidos.Sum(p => p.Value.Codigo);

            Console.ReadKey();
        }

    }
}

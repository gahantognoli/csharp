using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropriedadesIndexadas
{

    public class Produtos
    {
        private List<string> Itens;

        public Produtos()
        {
            Itens = new List<string>();
        }

        public void AddItem(string item)
        {
            Itens.Add(item);
        }

        public string Get(int index)
        {
            return Itens[index];
        }

        //propriedade indexada
        public string this[int index] {
            get
            {
                return Itens[index];
            }
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Produtos produtos = new Produtos();
            produtos.AddItem("Iphone 6s");
            produtos.AddItem("Galaxy s9");

            Console.WriteLine(produtos[0]);
            Console.WriteLine(produtos[1]);

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesIENumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            ColecaoClientes colecaoClientes = new ColecaoClientes();

            foreach (var s in colecaoClientes.GetClientes())
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}

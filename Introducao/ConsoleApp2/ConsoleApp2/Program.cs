using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe valor a Depositar: ");
            var v1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe valor a Sacar: ");
            var v2 = Convert.ToDouble(Console.ReadLine());
            Conta conta = new Conta();

            conta.Depositar(v1);
            conta.Sacar(v2);
            Console.WriteLine($"Saldo de: {conta.Saldo}");
            Console.ReadKey();

        }
    }
}

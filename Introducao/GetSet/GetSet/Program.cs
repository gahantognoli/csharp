using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();
            conta.SetCliente("Gabriel");
            conta.Depositar(1000);
            conta.Sacar(500);

            Console.WriteLine(conta.GetCliente() + " seu saldo na data de " + DateTime.Today.ToShortDateString() + 
                " = " + conta.GetValor());
            Console.ReadKey();
        }
    }
}

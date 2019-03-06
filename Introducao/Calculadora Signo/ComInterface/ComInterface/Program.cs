using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Assinatura assinatura = new Assinatura {
                Codigo = 123,
                Nome = "Assinatura MVP",
                Preco = 69.99M,
                DataExpiracao = DateTime.Today.AddMonths(12)
            };

            Console.WriteLine($"Dias restantes de assinatura:  { assinatura.GetTempoRestante().Days}");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaCalculadoraSignos
{
    class Program
    {
        static void Main(string[] args)
        {
            InterpretadorSigno interpretador = new InterpretadorSigno();

            Console.WriteLine("Em que dia você nasceu?");
            string dia = Console.ReadLine();

            Console.WriteLine("Em que mês você nasceu?");
            string mes = Console.ReadLine();

            int diaInt = 0;
            int mesInt = 0;

            try
            {
                diaInt = Convert.ToInt32(dia);
                mesInt = Convert.ToInt32(mes);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
                Environment.Exit(1);
            }

            Signo signo = interpretador.Interpretar(diaInt, mesInt);

            if(signo != null)
            {
                Console.WriteLine("Seu signo é " + signo.nome + " " + signo.caracteristicas);
            }
            else
            {
                Console.WriteLine("Não foi possível interpretar seu signo, tente novamente!");
            }

            Console.ReadLine();

        }
    }
}

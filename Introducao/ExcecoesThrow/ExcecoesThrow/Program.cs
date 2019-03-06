using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcecoesThrow
{
    class Program
    {

        private static void Estagiario(string tarefa)
        {
            Console.WriteLine("Executando a tarefa..." + tarefa);
        }

        private static void Programador(string tarefa)
        {
            try
            {
                Estagiario(tarefa);
            }
            catch (Exception ex)
            {
                Console.WriteLine("PROGRAMADOR");
                throw new Exception("Estagiário cometeu erro!");
            }
        }

        private static void Arquiteto(string tarefa)
        {
            Programador(tarefa);
        }

        private static void Coodernador(string tarefa)
        {
            Arquiteto(tarefa);
        }

        private static void Gerente(string tarefa)
        {
            try
            {
                Coodernador(tarefa);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Gerente capturou a exceção");
            }
        }

        static void Main(string[] args)
        {
            string tarefa = "99/99/9999";
            Gerente(tarefa);
            Console.ReadKey();
        }
    }
}

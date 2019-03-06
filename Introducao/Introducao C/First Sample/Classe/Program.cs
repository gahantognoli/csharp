using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            aluno.Nome = "Gabriel";
            aluno.Idade = 20;

            Aluno aluno2 = new Aluno("Pedro", 28);

            Console.WriteLine("Nome Aluno: " + aluno.Nome);
            Console.WriteLine("Nome Aluno2: " + aluno2.Nome);

            aluno.Limpar();
            aluno2.Limpar();

            Console.ReadKey();
        }
    }
}

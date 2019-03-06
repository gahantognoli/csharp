using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AutoPropertyInitializer
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno1 aluno = new Aluno1(1, "Gabriel");
            WriteLine($"{aluno.Matricula} - {aluno.Nome}");

            Aluno aluno1 = new Aluno();
            WriteLine($"{Aluno.Matricula} - {aluno1.Nome} - {aluno1.Status}");

            ReadKey();
        }
    }
}

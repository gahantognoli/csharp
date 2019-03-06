using System;
using static System.Console;

namespace StringInterpolation
{

    class Pessoa
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa()
            {
                Matricula = 1,
                Nome = "Gabriel",
                Sobrenome = "Antognoli"
            };

            WriteLine(string.Format("Bem vindo {0} {1} ({2}), este é o C# 6", 
                pessoa.Nome, pessoa.Sobrenome, pessoa.Matricula));
            WriteLine($"Bem vindo {pessoa.Nome} {pessoa.Sobrenome} ({pessoa.Matricula}), este é o C# 6");
            WriteLine($"Olá, agora são: {DateTime.Now.ToLongTimeString()}");
            ReadLine();
        }
    }
}

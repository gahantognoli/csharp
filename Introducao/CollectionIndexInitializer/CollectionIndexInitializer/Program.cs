using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CollectionIndexInitializer
{

    public class Aluno
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        //public Aluno(string nome)
        //{
        //    Nome = nome;
        //}
    }

    class Program
    {
        static void Main(string[] args)
        {
            var alunos = new List<Aluno>()
            {
                new Aluno() { Nome = "Gabriel", Sobrenome = "Antognoli" },
                new Aluno() { Nome = "Guilherme", Sobrenome = "Souza" }
            };

            //var alunos2 = new Dictionary<int, Aluno>();
            //alunos2.Add(1, new Aluno() { Nome = "Gazim", Sobrenome = "Xavier" });
            //alunos2.Add(2, new Aluno() { Nome = "Jean", Sobrenome = "Dias" });

            var alunos2 = new Dictionary<int, Aluno>()
            {
                [1] = new Aluno() { Nome = "Oscar", Sobrenome = "Valente" },
                [2] = new Aluno() { Nome = "Valetina", Sobrenome = "Joniville" },
                [3] = new Aluno() { Nome = "Michael", Sobrenome = "Lotus" },
            }; 

            var a1 = new Aluno() { Nome = "Gabriel", Sobrenome = "Antognoli" };

            WriteLine($"{alunos2[1].Nome} {alunos2[1].Sobrenome}");
            ReadKey();

        }
    }
}

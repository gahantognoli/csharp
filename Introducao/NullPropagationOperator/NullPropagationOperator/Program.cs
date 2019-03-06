using System;

namespace NullPropagationOperator
{ 
    public class Aluno
    {
        public int Matricula { get; set; } = 0;
        public string Nome { get; set; } = "sem nome";
        public Curso Curso { get; set; }
    }

    public class Curso
    {
        public int Codigo { get; set; } = 0;
        public string Nome { get; set; } = "sem nome";
        public Area Area { get; set; }
    }

    public class Area
    {
        public string Nome { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno()
            {
                Matricula = 1,
                Nome = "Gabriel"
            };


            Console.WriteLine($"Matricula: {aluno.Matricula}\nNome: {aluno.Nome}");
            Console.WriteLine($"Curso: {aluno?.Curso?.Nome ?? "Sem Curso"}");
            Console.WriteLine($"Area: {aluno?.Curso?.Area?.Nome ?? "Sem Area"}");
            Console.ReadKey();
        }
    }
}

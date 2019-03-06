using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameOfOperator
{
    public class Professor
    {
        public string Matricula { get; set; } = "0";
        public string Nome { get; set; } = "sem nome";
        public DateTime Data { get; set; } = DateTime.Now;

        public override string ToString()
        {
            return $"Matricula: {Matricula}, Nome: {Nome}, Data: {Data}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Professor professor = null;
            Console.WriteLine(professor?.ToString() ?? $"Objeto {nameof(professor)} não instanciado!");
            professor = new Professor() { Nome = "Gabriel", Matricula = "1" };
            Console.ReadKey();
        }
    }
}

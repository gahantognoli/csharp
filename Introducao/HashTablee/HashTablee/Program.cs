using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTablee
{

    public class Aluno
    {
        public int Matricula;
        public string Nome;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("1", "Gabriel");
            hashtable.Add("2", "Otávio");
            hashtable.Add("3", "José");

            if (hashtable.ContainsKey("2")) //verifica se a chave existe
            {
                Console.WriteLine(hashtable["2"]);
            }

            foreach (var item in hashtable.Values)
            {
                Console.WriteLine(item);
            }

            Hashtable alunos = new Hashtable();
            Aluno aluno = new Aluno() { Matricula = 1, Nome = "Euclides" };
            Aluno aluno2 = new Aluno() { Matricula = 2, Nome = "Naomi" };
            alunos.Add(aluno.Matricula, aluno.Nome);
            alunos.Add(aluno2.Matricula, aluno2.Nome);

            foreach (var item in alunos.Values)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}

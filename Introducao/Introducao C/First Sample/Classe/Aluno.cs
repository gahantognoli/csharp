using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe
{
    class Aluno
    {

        public Aluno()
        {
            Console.WriteLine("Aluno Constructor");
        }


        public Aluno(string _nome, int _idade)
        {
            this.nome = _nome;
            this.idade = _idade;
        }

        //Fields
        private string nome;
        private int idade;

        //Properties
        public string Nome {
            get { return nome; }
            set { nome = value; }
        }

        public int Idade
        {
            set
            {
                if (value >= 18)
                    idade = value;
            }
        }

        public void Limpar()
        {
            this.idade = 0;
            this.nome = string.Empty;
        }

        private void GoAge()
        {
            this.idade = 21;
        }

        public bool VerificaMaiorIdade(int idade)
        {
            return idade > 18;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPropertyInitializer
{
    class Aluno1
    {
        private int _matricula;
        private string _nome;

        public int Matricula
        {
            get { return _matricula; }
            set { _matricula = value; }
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public Aluno1()
        {
        }

        public Aluno1(int matricula, string nome)
        {
            Matricula = matricula;
            Nome = nome;
        }
    }
}

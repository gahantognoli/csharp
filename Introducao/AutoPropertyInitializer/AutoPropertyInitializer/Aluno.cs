using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPropertyInitializer
{
    class Aluno
    {
        public static int Matricula { get; set; } = 0;
        public string Nome { get; set; } = "Sem Nome";
        public string Status { get; set; } = Matricula == 0 ? "Não matriculado" : "Matriculado";
    }
}

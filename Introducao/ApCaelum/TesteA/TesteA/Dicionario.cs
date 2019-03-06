using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteA
{
    public class Dicionario : IDicionario
    {
        public int dicionario1 { get; set; }
        public int propriedadeAMais { get; set; }

        public int Dicionario1Teste()
        {
            return 1;
        }

        public string Teste()
        {
            return "Dicionario1";
        }
    }
}

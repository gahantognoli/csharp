using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteA
{
    public class Dicionario2 : IDicionario
    {
        public int dicionario2 { get; set; }

        public int Dicionario2Teste()
        {
            return 2;
        }

        public string Teste()
        {
            return "Dicionario2";
        }
    }
}

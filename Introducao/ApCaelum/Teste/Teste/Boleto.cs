using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    class Boleto : FormaDePagamento
    {
        public int seila { get; set; }

        public override void Pagar(FormaDePagamento formaDePagamento)
        {
            
        }
    }
}

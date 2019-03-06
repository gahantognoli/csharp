using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    public abstract class FormaDePagamento
    {
        public virtual void Pagar(FormaDePagamento formaDePagamento) { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComInterface
{
    public class Assinatura : Produto, IExpiravel
    {
        public DateTime DataExpiracao { get; set; }

        public TimeSpan GetTempoRestante()
        {
            return DataExpiracao - DateTime.Today;
        }
    }
}

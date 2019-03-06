using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades
{
    public class MensalidadeNagativaException : Exception
    {
        public MensalidadeNagativaException(string message)
            :base(message)
        {
            
        }
    }
}

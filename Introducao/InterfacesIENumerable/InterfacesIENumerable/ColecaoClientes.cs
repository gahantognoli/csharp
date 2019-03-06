using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesIENumerable
{
    public class ColecaoClientes
    {
       private List<string> Clientes;

        public ColecaoClientes()
        {
            Clientes.Add("Gabriel");
            Clientes.Add("João");
            Clientes.Add("Mauro");
        }

        public IEnumerable<string> GetClientes()
        {
            return this.Clientes;
        }

    }
}

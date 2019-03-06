using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MicroExemploE.F
{
    //DBContext é a classe central do EF, representa o banco de dados dentro da aplicãção.
    class ClientesContext : DbContext
    {
        public ClientesContext() : base("BancoClientes")
        {

        }

        //DBset são as tabelas.
        public DbSet<Cliente> Clientes { get; set; }
    }
}

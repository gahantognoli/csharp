using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ExemploVendas.EF.Models
{
    public class BancoVendas : DbContext
    {
        public BancoVendas() : base("VendasEF")
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
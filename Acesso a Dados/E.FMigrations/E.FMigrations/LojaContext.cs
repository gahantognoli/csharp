using E.FMigrations.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.FMigrations
{
    public class LojaContext : DbContext
    {
        public LojaContext() : base("Loja")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<LojaContext, Configuration>());
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }
}

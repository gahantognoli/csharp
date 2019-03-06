using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.F.Mapeamento1ParaN
{
    public class LojaContext : DbContext
    {
        public LojaContext() : base("Loja")
        {
            Database.Log = p => System.Diagnostics.Debug.WriteLine(p);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //remove a deleção em cascata
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Marca> Marcas { get; set; }
    }
}

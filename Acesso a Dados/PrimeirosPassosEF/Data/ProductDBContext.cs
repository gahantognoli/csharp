using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Domain;

namespace Data
{
    public class ProductDBContext : DbContext
    {
        public ProductDBContext() : base("ProductDB")
        {
            Database.SetInitializer<ProductDBContext>(new CreateDatabaseIfNotExists<ProductDBContext>());
            Database.Initialize(false);
            Database.Log = d => System.Diagnostics.Debug.WriteLine(d);
        }

        //Criação da tabelas.
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Loja> Lojas { get; set; }
    }
}

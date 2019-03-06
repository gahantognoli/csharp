using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PaginacaoAspNetMvc.Models
{
    public class LojaContext : DbContext
    {
        public LojaContext() : base("PaginacaoBD") { }

        public DbSet<Produto> Produtos { get; set; }
    }
}
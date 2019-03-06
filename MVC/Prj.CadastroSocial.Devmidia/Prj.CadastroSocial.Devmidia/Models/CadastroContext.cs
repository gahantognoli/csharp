using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Prj.CadastroSocial.Devmidia.Models
{
    public class CadastroContext : DbContext
    {
        public CadastroContext() : base("DbCadastroSocial") {}

        public DbSet<Pessoa> Pessoas { get; set; }
    }
}
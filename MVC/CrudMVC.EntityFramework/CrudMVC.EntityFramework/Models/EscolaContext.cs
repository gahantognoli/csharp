using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CrudMVC.EntityFramework.Models
{
    public class EscolaContext : DbContext
    {
        public EscolaContext() : base("Escola")
        {
            Database.CreateIfNotExists();
        }

        public DbSet<Aluno> Alunos { get; set; }
    }
}
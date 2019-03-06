using System;
using System.Collections.Generic;
using System.Data.Entity;

using System.Linq;
using System.Web;

namespace AutenticacaoAspNet.Models
{
    public class UsuarioContext : DbContext
    {
        public UsuarioContext() : base("AutenticacaoUsuarios") { }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
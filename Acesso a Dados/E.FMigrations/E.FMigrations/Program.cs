using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.FMigrations
{
    class Program
    {
        static void Main(string[] args)
        {
            LojaContext db = new LojaContext();

            db.Produtos.Add(
                new Produto()
                {
                    Nome = "Smartphone",
                    Preco = 3400,
                    DataCadastro = DateTime.Now
                });

            db.SaveChanges();
        }
    }
}

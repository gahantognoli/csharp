using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.F.Mapeamento1ParaN
{
    class Program
    {
        static void Main(string[] args)
        {
            LojaContext db = new LojaContext();

            #region Insercao de produtos e marcas com E.F
            //Marca marca = db.Marcas.Find(1);

            ////Inserindo produto e marca.
            ////Produto produto = new Produto()
            ////{
            ////    Nome = "Geladeira",
            ////    Preco = 2000,
            ////    Marca = new Marca()
            ////    {
            ////        Nome = "Eletrolux"
            ////    }
            ////};

            ////Inserindo Produto a partir de uma marca existente no contexto.
            //Produto produto = new Produto()
            //{
            //    Nome = "Ferro de passar",
            //    Preco = 1100,
            //    Marca = marca
            //};

            ////Tentando inserir produto sem Marca, lembrando que a FOREIGN KEY marca é NOT NULL,
            ////gerando assim um ERRO.
            ////Produto produto = new Produto()
            ////{
            ////    Nome = "Ferro de passar",
            ////    Preco = 1100,
            ////};

            //db.Produtos.Add(produto);

            //db.SaveChanges();

            #endregion

            #region Alteração Marca do Produto
            //Marca marca = db.Marcas.Find(2);

            //Produto produto = db.Produtos.Find(2);

            //produto.Marca = marca;

            //db.SaveChanges();

            //Console.ReadKey();

            #endregion

            #region Inserindo uma Marca com vários Produtos
            //Marca marca = new Marca()
            //{
            //    Nome = "Apple",
            //    Produtos = new List<Produto>()
            //    {
            //        new Produto() { Nome = "Iphone X", Preco = 4000 },
            //        new Produto() { Nome = "Iphone 8", Preco = 3000 }
            //    }
            //};

            //db.Marcas.Add(marca);

            //db.SaveChanges();
            #endregion

            #region Localizando Marca do Produto
            //Produto produto = db.Produtos.Find(5);

            //Console.WriteLine(produto.Marca.Nome);

            //Console.ReadKey();
            #endregion

            #region Localizando Produtos da marca
            //Marca marca = db.Marcas.Find(3);

            //marca.Produtos.ToList().ForEach(p => Console.WriteLine(p.Nome));

            //Console.ReadKey();
            #endregion

            #region Excluir Marca
            //Isso faz o DELETE em cascata, por padrão no E.F
            //Marca marca = db.Marcas.Find(1);

            //db.Marcas.Remove(marca);

            //db.SaveChanges();
            #endregion
        }
    }
}

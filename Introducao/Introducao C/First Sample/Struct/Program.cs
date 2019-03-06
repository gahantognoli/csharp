using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Struct
{
    class Program
    {
        public struct Livro
        {
            public string titulo;
            public string autor;
            public int codigo;
            public int anoPublicacao;
        }

        static void Main(string[] args)
        {
            Livro livro;
            livro.codigo = 1;
            livro.autor = "Machado de Assis";
            livro.titulo = "Dom Casmurro";
            livro.anoPublicacao = 1940;

            Livro livro2;
            livro2.codigo = 2;
            livro2.autor = "Jorge Amado";
            livro2.titulo = "Gabriela";
            livro2.anoPublicacao = 1965;

            List<Livro> livros = new List<Livro>();
            livros.Add(livro);
            livros.Add(livro2);

            Console.WriteLine("Total livros: " + livros.Count);
            Console.WriteLine("--------------------------------");

            foreach(Livro item in livros)
            {
                Console.WriteLine("Código: " + item.codigo);
                Console.WriteLine("Titulo: " + item.titulo);
                Console.WriteLine("Autor: " + item.autor);
                Console.WriteLine("Ano de Publicação: " + item.anoPublicacao);
                Console.WriteLine("-----------------------------------");
            }

            Console.ReadKey();

        }
    }
}

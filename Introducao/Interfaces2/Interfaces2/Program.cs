using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
    class Program
    {
        static void Main(string[] args)
        {
            Documento documento = new Documento() { Nome = "texto.docx" };
            Console.WriteLine(documento.Nome);
            documento.Ler();
            documento.Escrever();

            Imagem imagem = new Imagem() { Nome = " img1.jpg" };
            Console.WriteLine(imagem.Nome);
            imagem.Ler();
            imagem.Escrever();
            Console.ReadKey();
        }
    }
}

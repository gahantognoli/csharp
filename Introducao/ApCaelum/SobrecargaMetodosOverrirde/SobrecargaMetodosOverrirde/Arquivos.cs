using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaMetodosOverrirde
{
    public class Musica
    {
        public string Nome;
        public int Tamanho;

        public void Abrir()
        {
            Console.WriteLine("Tocando música: " + Nome);
        }
    }

    public class DocumentoWord
    {
        public string Nome;
        public int Tamanho;

        public void Abrir()
        {
            Console.WriteLine("Mostrando documento do Word: " + Nome);
        }
    }

    public class Imagem
    {
        public string Nome;
        public int Tamanho;

        public void Abrir()
        {
            Console.WriteLine("Exibindo imagem:  " + Nome);
        }
    }

    public class Windows
    {
        private ArrayList Arquivos;

        public Windows()
        {
            Arquivos = new ArrayList();
        }

        public void Add(Object arquivo)
        {
            Arquivos.Add(arquivo);
        }

        public void Abrir(Object arquivo)
        {
            //arquivo.Abir();
        }

    }

}

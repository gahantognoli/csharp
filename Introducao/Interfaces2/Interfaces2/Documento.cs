using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{

    public interface IArmazenavel //padrão: I...able
    {
        void Ler();
        void Escrever();
    }   

    public interface IComprimivel
    {
        void Compactar();
        void Descompactar();
    }

    public class Arquivo
    {
        public string Nome;
    }

    public class Compactador : IComprimivel
    {
        public void Compactar()
        {
            Console.WriteLine("Compactando arquivo");
        }

        public void Descompactar()
        {
            Console.WriteLine("Descompactando arquivo");
        }
    }

    public class Armazenador : IArmazenavel
    {
        public void Ler()
        {
            Console.WriteLine("Lendo documento ...");
        }

        public void Escrever()
        {
            Console.WriteLine("Escrevendo arquivo...");
        }
    }


    public class Documento : Arquivo
    {
        //herança de "caixa preta"
        //simulando herança multipla
        private Armazenador armazenador = new Armazenador();
        private Compactador compactador = new Compactador();

        public void Ler()
        {
            armazenador.Ler();
        }

        public void Escrever()
        {
            armazenador.Escrever();
        }

        public void Compactar()
        {
            compactador.Compactar();
        }

        public void Descompactar()
        {
            compactador.Descompactar();
        }
    }

    public class Imagem : Arquivo
    {
        //herança de "caixa preta"
        //simulando herança multipla
        private Armazenador armazenador = new Armazenador();
        private Compactador compactador = new Compactador();

        public void Ler()
        {
            armazenador.Ler();
        }

        public void Escrever()
        {
            armazenador.Escrever();
        }

        public void Compactar()
        {
            compactador.Compactar();
        }

        public void Descompactar()
        {
            compactador.Descompactar();
        }
    }

}

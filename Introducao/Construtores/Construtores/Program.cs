using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores
{

    public class Contato
    {
        public string Tipo;
        public string Descricao;
    }

    public class Cliente
    {
        public int Id;
        public string Nome;
        public Contato Contato;

        //Padrão
        public Cliente()
        {
            this.Id = 0;
            this.Nome = "Sem nome";
            this.Contato = new Contato();
        }

        public Cliente(int id, string nome)
        {
            this.Id = id;
            this.Nome = nome;
            this.Contato = new Contato();
        }

        public override string ToString()
        {
            return String.Format("Código: {0} Nome: {1} ", Id, Nome);
        }

    }

    public class ClienteVIP : Cliente
    {
        //escondendo acesso externo.
        private int Tempo;

        //repassa para o construtor da classe base, os parâmetros.
        //NO c# os construtores não são herdados!!!
        public ClienteVIP(int codigo, string nome, int tempo)
            :base(codigo, nome)
        {
            this.Tempo = tempo;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            cliente.Id = 123;
            cliente.Nome = "Gabriel";
            cliente.Contato.Tipo = "Telefone";
            cliente.Contato.Descricao = "3392-1256";

            Cliente cliente2 = new Cliente(111, "Rodolfo");

            ClienteVIP clienteVIP = new ClienteVIP(10, "João da Silva", 10);

            Console.WriteLine(cliente);
            Console.WriteLine(cliente2);
            Console.WriteLine(clienteVIP);

            Console.ReadKey();
        }
    }
}

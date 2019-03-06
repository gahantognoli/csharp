using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroExemploE.F
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente()
            {
                Id = 1,
                Nome = "Gabriel",
                Idade = 20,
                Credito = 2400.20M
            };

            ClientesContext db = new ClientesContext();

            db.Clientes.Add(cliente);

            //Persiste as informações do contexto para o banco de dados.
            db.SaveChanges();

            Console.WriteLine("Cliente Salvo com sucesso!");

            Console.ReadKey();
        }
    }
}

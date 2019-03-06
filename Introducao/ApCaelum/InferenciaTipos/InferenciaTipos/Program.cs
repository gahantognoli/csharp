using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InferenciaTipos
{

    public class Connection
    {
        public string ConnectionString;

        public void Conectar()
        {
            Console.WriteLine("Conectando ...");
        }

        public void Fechar()
        {
            Console.WriteLine("Fechando ...");
        }
    }

    public static class Fabrica
    {
        public static Connection CriarConnection()
        {
            return new Connection();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var connection = new Connection() { ConnectionString = "BANCO" };
            connection.Conectar();
            connection.Fechar();

            dynamic connection2 = new Connection() { ConnectionString = "BANCO" };
            connection2.Conectar();
            connection2.Fechar();
            //connection2.Bar(); //resolvido em tempo de execução e não de compilação.

            Console.ReadKey();
        }
    }
}

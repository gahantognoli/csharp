using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            DBConnection connection = new OracleConnection() { StringConexao = "Oracle Server" };
            connection.Open();
            connection.Close();

            Console.ReadKey();
        }
    }
}

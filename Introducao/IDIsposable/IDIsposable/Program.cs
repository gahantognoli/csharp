using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace IDIsposable
{
    class Program
    {
        static void Main(string[] args)
        {
            //implementa o IDisposable
            //using (var sql = new SqlConnection())
            //{
            //    /// comandos ...
            //}

            using (var con = new Conexao())
            {
                con.Conectar();
                con.Fechar();
            }

            Console.ReadKey();

        }
    }
}

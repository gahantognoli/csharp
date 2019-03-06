using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao3
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SqlConnection sqlConnection =
                new SqlConnection(ConfigurationManager.ConnectionStrings["Cadastro"].ConnectionString)) 
            {
                sqlConnection.Open();
                var transaction = sqlConnection.BeginTransaction();
                try
                {
                    string query1 = "INSERT INTO Cliente(NomeCliente, Email) VALUES (@Nome, @Email)";
                    string query2 = "DELETE FROM Cliente WHERE idCliente = 3";
                    SqlCommand command = sqlConnection.CreateCommand();
                    command.Transaction = transaction;
                    command.CommandText = query1;
                    command.Parameters.AddWithValue("@Nome", "Thor");
                    //command.Parameters.AddWithValue("@Email", "thor@gmail.com");

                    SqlCommand command2 = sqlConnection.CreateCommand();
                    command2.Transaction = transaction;
                    command2.CommandText = query2;

                    //executamos em uma transação
                    command.ExecuteNonQuery();
                    command2.ExecuteNonQuery();

                    transaction.Commit();
                    Console.WriteLine("Comandos executados com sucesso!");

                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Console.WriteLine("Falha ao executar transação!\nDetalhes: Tipo:" + 
                        ex.GetType() + "\nMessagem: " + ex.Message);
                }
            }
            Console.ReadKey();
        }
    }
}

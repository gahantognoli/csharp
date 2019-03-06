using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Aplicacao2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada de dados

            //string sql
            //string query = "INSERT INTO Cliente(NomeCliente, Email) VALUES (@Nome, @Email)";

            //stored procedure
            string procedure = "GravarCliente";
            Console.WriteLine("Informe o nome do Cliente: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe o Email do Cliente: ");
            string email = Console.ReadLine();

            SqlConnection connection =
            new SqlConnection(ConfigurationManager.ConnectionStrings["Cadastro"].ConnectionString);
            SqlCommand command = new SqlCommand(procedure, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Nome", nome);
            command.Parameters.AddWithValue("@Email", email);
            connection.Open();
            try
            {

                if(command.ExecuteNonQuery() > 0)
                {
                    Console.WriteLine("Registro inserido com sucesso!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Falha ao executar o comando! \nDetalhes: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            Console.ReadKey();
        }
    }
}

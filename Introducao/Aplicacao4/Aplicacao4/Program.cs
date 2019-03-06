using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Aplicacao4
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SqlConnection sqlConnection = 
                new SqlConnection(ConfigurationManager.ConnectionStrings["Cadastro"].ConnectionString))
            {
                string query = "SELECT * FROM Cliente";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                //apenas leitura, e sequencial.
                SqlDataReader dataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);

                //varredura do dataReader
                //Read() = Le o datareader e passa para o próximo registro, retornando um 
                //boleano se chegar ao fim ou não
                while (dataReader.Read())
                {
                    Console.WriteLine("Id: " + dataReader[0]);
                    Console.WriteLine("Nome: " + dataReader[1]);
                    Console.WriteLine("Email: " + dataReader[2]);
                    Console.WriteLine("------------------------------------------------");
                }
                dataReader.Close();
            }
            Console.ReadKey();
        }
    }
}

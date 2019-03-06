using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Aplicacao
{
    class Program
    {
        static void Main(string[] args)
        {
            //Para abrir uma conexão com o banco de dados você precisa de algumas informações.
            //Sendo elas: O local do banco, o nome do banco de dados e algumas outras especificações como usuário e senha.
            //string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Cadastro;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            using (SqlConnection connection = new SqlConnection(getConnetionStringFromConfig()))
            {
                connection.Open(); //abrir a conexão com o banco de dados.
                Console.WriteLine("Conexão com o banco de dados efetuada com sucesso!");
                Console.WriteLine("Estado da conexão: " + connection.State); //mostra o estado da conexão.
                connection.Close();
                Console.WriteLine("Estado da conexão: " + connection.State); //mostra o estado da conexão.
            }
            Console.ReadKey();
        }

        private static string getConnetionStringFromConfig()
        {
            return ConfigurationManager.ConnectionStrings["Cadastro"].ConnectionString;
        }

        private static string getConnectionStringFromBuilder()
        {
            SqlConnectionStringBuilder sqlConnectionString = new SqlConnectionStringBuilder();

            sqlConnectionString.DataSource = @"(localdb)\MSSQLLocalDB";
            sqlConnectionString.InitialCatalog = "Cadastro";
            sqlConnectionString.IntegratedSecurity = true;

            return sqlConnectionString.ConnectionString;
        }

    }
}

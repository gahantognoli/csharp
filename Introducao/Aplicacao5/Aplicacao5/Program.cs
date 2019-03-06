using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Aplicacao5
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Cadastro"].ConnectionString);
            string sql = "SELECT * FROM Cliente";
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            DataSet dataSet = new DataSet();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataSet);
            DataTable dataTable = dataSet.Tables[0];
            foreach (DataRow item in dataTable.Rows)
            {
                Console.WriteLine("Id: " + item[0]);
                Console.WriteLine("Nome: " + item[1]);
                Console.WriteLine("Email: " + item[2]);
                Console.WriteLine("----------------------------------");
            }
            Console.ReadKey();
        }
    }
}

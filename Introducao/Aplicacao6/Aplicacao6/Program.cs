using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Aplicacao6
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection sqlConnection = 
                new SqlConnection(ConfigurationManager.ConnectionStrings["Cadastro"].ConnectionString);
            string sql1 = "SELECT * FROM Cliente";
            string sql2 = "SELECT * FROM Contato";

            SqlCommand sqlCommand = new SqlCommand(sql1, sqlConnection);
            SqlCommand sqlCommand2 = new SqlCommand(sql2, sqlConnection);

            DataSet dataSet = new DataSet("Clientes");

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter(sqlCommand2);

            sqlDataAdapter.Fill(dataSet, "Clientes");
            sqlDataAdapter2.Fill(dataSet, "Contatos"); //popular o mesmo dataset com dois selects (result set).

            DataTable dtClientes = dataSet.Tables[0];
            DataTable dtContatos = dataSet.Tables[1];

            //Relacionar os dois datables
            DataRelation relation = dataSet.Relations.Add(
                "ClientesContas",
                dtClientes.Columns["IdCliente"],
                dtContatos.Columns["IdCliente"]
            );

            foreach (DataRow Row in dtClientes.Rows)
            {
                Console.WriteLine("Nome Cliente: " + Row[1]);
                foreach (DataRow item in Row.GetChildRows(relation))
                {
                    Console.Write(item[0] + " - " + item[1]);
                }
                Console.WriteLine("--------------------------");
            }
            Console.ReadKey();
        }
    }
}

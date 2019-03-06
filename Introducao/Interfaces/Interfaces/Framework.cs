using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{

    interface IBDConnection
    {
        void Open();
        void Close();
    }

    interface ITransaction
    {
        void StartTransaction();
    }


    public abstract class DBConnection : IBDConnection
    {
        public string StringConexao { get; set; }

        public virtual void Open()
        {
            Console.WriteLine("Abrindo conexão...");
            Console.WriteLine("Connection string: " + StringConexao);
        }

        public virtual void Close()
        {
            Console.WriteLine("Fechando Conexão...");
        }
    }

    public class SqlConnection : DBConnection, ITransaction
    {
        public override void Open()
        {
            base.Open();
            //codigo específico
        }

        public override void Close()
        {
            base.Close();
            //Código específico
        }

        public void StartTransaction()
        {

        }
    }

    public class OracleConnection : DBConnection, ITransaction
    {
        public override void Open()
        {
            base.Open();
            //codigo específico
        }

        public override void Close()
        {
            base.Close();
            //Código específico
        }

        public void StartTransaction()
        {

        }
    }

}

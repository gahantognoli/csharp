using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ClassesExtensao
{

    public static class JsonDataSet
    {
        public static void WriteJSON(this DataSet dataSet, string fileName)
        {
            
        }

        public static string ToUrl(this String str)
        {
            return str = "http://" + str;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //DataSet dataSet = new DataSet();
            //dataSet.WriteJSON("dados.js");
            //dataSet.WriteXml("dados.xml");

            string url = "www.google.com.br";
            Console.WriteLine(url.ToUrl());
        }
    }
}

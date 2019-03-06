using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Systen.Text_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            #region StringBuilder
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("New ");
            stringBuilder.Append("York");

            stringBuilder.Insert(6, "aaa"); // inserir textos a partir de um ponto
            stringBuilder.Remove(6, 7);
            stringBuilder.Replace("k", "que");

            Console.WriteLine(stringBuilder);
            stringBuilder.Clear();
            Console.ReadKey();
            #endregion



        }
    }
}

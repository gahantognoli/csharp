using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            //muito custoso para o processador concatenar string, por isso é recomendado usar a classe StringBuilder.
            //string str = "";

            //for (int i = 0; i < 100000; i++)
            //{
            //    str = str + i + " ";
            //}

            //Console.WriteLine(str);

            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < 100000; i++)
            {
                stringBuilder.Append(i).Append(" ");
            }

            StringBuilder stringBuilder2 = new StringBuilder();
            stringBuilder.AppendLine("Primeira linha");
            stringBuilder.AppendLine("Segunda linha");

            StringBuilder stringBuilder3 = new StringBuilder();
            stringBuilder3.Append("Qualquer um pode escrever codigo que o computador pode entender. Bons programdores escrevem codigo para humanos entenderem.");
            stringBuilder3.Replace("codigo", "código");

            Console.WriteLine(stringBuilder);
            Console.WriteLine(stringBuilder2);
            Console.WriteLine(stringBuilder3);

            StringBuilder stringBuilder4 = new StringBuilder();
            stringBuilder4.Append("abcdefghijklmnopqrstuvwxyz");
            Console.WriteLine(stringBuilder4[2]);

            StringBuilder stringBuilder5 = new StringBuilder();
            stringBuilder5.Append("abcdefghijklmnopqrstuvwxyz");
            stringBuilder5.Remove(4, 10);
            Console.WriteLine(stringBuilder5);

            StringBuilder stringBuilder6 = new StringBuilder("aaa ", 10);
            stringBuilder6.Append("Teste");
            Console.WriteLine(stringBuilder6);

            Console.Read();
        }
    }
}

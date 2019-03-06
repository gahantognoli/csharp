using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace System.IO_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Gabriel Antognoli - Persistencia arquivo txt (System.IO)\n");
            File.AppendAllText(@"c:\temp\teste_file2.txt", stringBuilder.ToString());

            //outro método
            string[] values = { "Line 1", "Line 2", "Line 3" };
            File.AppendAllLines(@"c:\temp\teste_file3.txt", values);
            File.Copy(@"c:\temp\teste_file3.txt", @"c:\temp\teste_file3_copy.txt");

            File.Encrypt(@"c:\temp\teste_file3_copy.txt"); //encriptar arquivo

            File.Decrypt(@"c:\temp\teste_file3_copy.txt"); //descriptografar arquivo

            File.Delete(@"c:\temp\teste_file3_copy.txt");
        }
    }
}

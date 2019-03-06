using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypes
{
    class  Program
    {
        enum acessorio { Sapato, Bolsa, Cinto, Carteira, Colar }

        static void Main(string[] args)
        {
            int i = 10;
            string a = "OK";
            char ch = 'X';

            long l = 9999999;

            float f = 32.9090F; //8 digitos  de precisão
            double d = 32.90909090; // 15 digitos de precisão

            decimal dec = 10.10101010M; //29 digitos de precisão 

            bool bl = true;

            int item = (int)acessorio.Bolsa;

            //Conversões
            int i1 = 10;
            long i2 = i1;

            double d2 = 10.9;
            int i3 = (int)d2;

            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}

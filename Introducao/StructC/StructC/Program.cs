using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructC
{

    public class PosicaoClass
    {
        public int X;
        public int Y;

        public override string ToString()
        {
            return "X = " + X + " Y = " + Y;
        }
    }

    public struct PosicaoStruct
    {
        public int X;
        public int Y;

        public override string ToString()
        {
            return "X = " + X + " Y = " + Y;
        }
    }

    public enum Role
    {
        Arquiteto, Desenvolvedor, Tester
    }

    public enum Color
    {
        Red = 1, Orange = 2, Blue = 3
    }

    public enum FormaPagamento
    {
        Boleto, Cartao, Cheque
    }

    class Program
    {
        static void Main(string[] args)
        {
            PosicaoClass pos1 = new PosicaoClass();
            pos1.X = 10;
            pos1.Y = 20;

            PosicaoStruct pos2 = new PosicaoStruct();
            pos2.X = 30;
            pos2.Y = 40;

            PosicaoStruct pos3 = pos2;
            pos3.Y = 50;

            PosicaoClass pos4 = pos1;
            pos4.X = 100;

            //Enumeradores
            FormaPagamento formaPagamento = FormaPagamento.Cartao;

            Console.WriteLine(pos1);
            Console.WriteLine(pos2);
            Console.WriteLine(pos3);
            Console.WriteLine(formaPagamento);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueRef
{

    public class PosicaoClass
    {
        public int x { get; set; }
        public int y { get; set; }
    }

    class Program
    {

        public static void Dobrar(ref int valor)
        {
            valor = valor * 2;
        }

        public static void Dobrar(PosicaoClass posicao)
        {
            posicao.x = posicao.x * 2;
            posicao.y = posicao.y * 2;
        }

        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            y = x;
            Console.WriteLine(x);
            Console.WriteLine(y);

            PosicaoClass posicaoClass = new PosicaoClass();
            posicaoClass.x = 10;
            posicaoClass.y = 20;

            PosicaoClass posicaoClass2 = new PosicaoClass();
            posicaoClass2.x = 30;
            posicaoClass2.y = 40;

            posicaoClass2 = posicaoClass;
            posicaoClass2.x = 50;

            Console.WriteLine(posicaoClass.x);
            Console.WriteLine(posicaoClass.y);

            Console.WriteLine(posicaoClass2.x);
            Console.WriteLine(posicaoClass2.y);

            int valor = 10;
            Dobrar(ref valor);
            Console.WriteLine(valor);

            PosicaoClass posicaoClass3 = new PosicaoClass();
            posicaoClass3.x = 20;
            posicaoClass3.y = 30;

            PosicaoClass posicaoClass4 = new PosicaoClass();
            posicaoClass4.x = 40;
            posicaoClass4.y = 50;

            Dobrar(posicaoClass3);
            Dobrar(posicaoClass4);

            Console.WriteLine(posicaoClass3.x);
            Console.WriteLine(posicaoClass3.y);

            Console.WriteLine(posicaoClass4.x);
            Console.WriteLine(posicaoClass4.y);

            Console.ReadKey();
        }
    }
}

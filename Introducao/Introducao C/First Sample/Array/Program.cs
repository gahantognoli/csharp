using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uma dimensão
            int[] a1 = new int[3];
            a1[0] = 10;
            a1[1] = 20;
            a1[2] = 30;

            //formas de declaração do Array
            bool[] b1 = new bool[] { true, false, false, true, false };

            string[] s1 = { "one", "two", "three" };

            int[,] ma1 = new int[3, 5];
            ma1[0, 0] = 10;

            ArrayList arrayList = new ArrayList();
            arrayList.Add(10);
            arrayList.Add("OK");
            arrayList.Add(true);

            //Generics
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);


        }
    }
}

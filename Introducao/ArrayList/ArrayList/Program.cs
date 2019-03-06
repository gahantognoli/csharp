using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListA
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList();
            array.Add("Gabriel");
            array.Add("Lucas");
            array.Add("Daniel");
            array.Add(10);

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Quantidade: " + array.Count);
            Console.WriteLine("Capacidade: " + array.Capacity);

            Console.ReadKey();
        }
    }
}

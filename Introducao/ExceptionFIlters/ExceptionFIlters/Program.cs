using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionFIlters
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 10;
            var y = 0;
            try
            {
                var r = x / y;
                Console.WriteLine($"{x} dividido por {y} é: {r}");
            }
            //catch (DivideByZeroException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            catch(Exception e) when (e.Message.ToUpper().Contains("ZERO"))
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e) when (e.Message.ToUpper().Contains("DIVISAO"))
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}

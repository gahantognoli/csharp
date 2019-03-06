using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesEstaticas
{
    
    public static class ConversorStatic
    {
        public static double CelsiusToFah(double temperatura)
        {
            return (temperatura * 9 / 5) + 32;
        }

        public static double FahToCelsius(double temperatura)
        {
            return (temperatura - 32) * 5 / 9;
        }
    }

    public class ConversorInstancia
    {
        public static double temperatura;

        public double CelsiusToFah()
        {
            return (temperatura * 9 / 5) + 32;
        }

        public double FahToCelsius()
        {
            return (temperatura - 32) * 5 / 9;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var temperatura = 35.0;
            temperatura = ConversorStatic.CelsiusToFah(temperatura);


            //Instancia
            ConversorInstancia conversorInstancia = new ConversorInstancia();
            var celsius = conversorInstancia.CelsiusToFah();
            var fah = conversorInstancia.FahToCelsius();

            Console.WriteLine(temperatura);
            Console.WriteLine(celsius);
            Console.WriteLine(fah);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflexao2
{

    public class Cliente
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public Cliente(string nome)
        {
            Nome = nome;
        }

        public void Imprimir(string titulo)
        {
            Console.WriteLine(titulo + " - " + Nome);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(Cliente);
            ConstructorInfo constructor = type.GetConstructor(new Type[] { typeof(string) });
            var obj = constructor.Invoke(new object[] { "Gabriel" });
            MethodInfo mi = type.GetMethod("Imprimir");
            mi.Invoke(obj, new object[] { "Olá, " } );
            Console.ReadKey();
        }
    }
}

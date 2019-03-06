using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflexao
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            Type type = carro.GetType();

            Console.WriteLine(type.FullName);

            Type t = typeof(Carro);
            Console.WriteLine(type.FullName);

            Type t2 = typeof(Carro);
            GetMetodo(t2);
            GetMetodos(t2);

            Type t3 = typeof(Carro);
            GetCampos(t3);
            getPropriedades(t3);

            Type t4 = typeof(Carro);
            GetInterfaces(t4);

            Type t5 = typeof(Carro);
            GetParametors(t5);

            Console.ReadKey();
        }

        private static void GetParametors(Type t5)
        {
            Console.WriteLine("Parametros: ");
            MethodInfo[] mi = t5.GetMethods();
            foreach (var item in mi)
            {
                string resultado = item.ReturnType.FullName + "\n";
                StringBuilder stringBuilder = new StringBuilder();
                foreach (var pa in item.GetParameters())
                {
                    stringBuilder.AppendLine(string.Format("{0} - {1}", pa.ParameterType, pa.Name));
                }
                Console.WriteLine("{0} {1} {2}", resultado, item.Name, stringBuilder);
            }
        }

        private static void GetInterfaces(Type t4)
        {
            Console.WriteLine("Interfaces: ");
            Type[] interfaces = t4.GetInterfaces();
            foreach (var item in interfaces)
            {
                Console.WriteLine(item.Name);
            }
        }

        private static void GetCampos(Type t3)
        {
            Console.WriteLine("Campos: ");
            FieldInfo[] field = t3.GetFields();
            foreach (var item in field)
            {
                Console.WriteLine(item.Name);
            }
        }

        private static void GetMetodos(Type t2)
        {
            Console.WriteLine("Métodos:");
            MethodInfo[] mi = t2.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public);
            foreach (var item in mi)
            {
                Console.WriteLine("Método: " + item.Name);
            }
        }

        private static void GetMetodo(Type t2)
        {
            MemberInfo mi = t2.GetMethod("EstaMovendo");
            Console.WriteLine(mi.Name);
        }

        public static void getPropriedades(Type type)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Informações do tipo: " + type.Name);
            stringBuilder.AppendLine("Nome Completo: " + type.FullName);
            Type tipoBase = type.BaseType;
            if (tipoBase != null)
            {
                stringBuilder.AppendLine("Tipo Base: " + type.BaseType.Name);
            }
            MemberInfo[] membros = type.GetMembers();

            foreach (var m in membros)
            {
                stringBuilder.AppendLine(m.MemberType + " - " + m.Name);
            }

            Console.WriteLine(stringBuilder.ToString());
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesGenericas
{

    class Cliente
    {
        public int Codigo;
        public string Nome;
    }

    public class Pilha<T>
    {
        int pos = 0;
        T[] itens = new T[100];

        public void Push(T item)
        {
            itens[pos] = item;
            pos++;
        }

        public T Pop()
        {
            pos--;
            return itens[pos];
        }
    }

    public class PilhaBad
    {
        int pos = 0;
        Object[] itens = new Object[100];

        public void Push(Object item)
        {
            itens[pos] = item;
            pos++;
        }

        public Object Pop()
        {
            pos--;
            return itens[pos];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Pilha p1 = new Pilha();
            //p1.Push(10);
            //p1.Push("Teste");
            //p1.Push(new Pilha());

            Pilha<Cliente> p2 = new Pilha<Cliente>();
            p2.Push(new Cliente() { Codigo = 1, Nome = "Gabriel" });
            p2.Push(new Cliente() { Codigo = 2, Nome = "José" });
            Cliente cliente = p2.Pop();

            PilhaBad p3 = new PilhaBad();
            p3.Push(new Cliente() { Codigo = 1, Nome = "Gabriel" });
            p3.Push(new Cliente() { Codigo = 2, Nome = "José" });
            Cliente cliente = p3.Pop();
        }
    }
    
}

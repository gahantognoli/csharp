using System;

namespace Sobrecarga
{

    public class CaixaDialogo
    {
        public void Show(string mensagem)
        {
            Console.WriteLine(mensagem);
        }

        public void Show(string mensagem, int delay)
        {
            Console.WriteLine(mensagem);
        }

        public void Show(string mensagem, double delay)
        {
            Console.WriteLine(mensagem);
        }

        public void Show(string mensagem, double delay, bool ok, bool no, bool cancel)
        {
            Console.WriteLine(mensagem);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            CaixaDialogo caixaDialogo = new CaixaDialogo();
            caixaDialogo.Show("Confirmar?");

            Console.ReadKey();
        }
    }
}

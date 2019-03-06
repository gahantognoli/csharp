using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametrosOpcionais
{

    public class CaixaDialogo
    {
        //Parametros opcionais devem sempre vir ao fim de todos os demais parâmetros
        public void Show(string mensagem, bool Ok, bool No, bool cancel, int delay = 10)
        {
            Console.WriteLine(mensagem);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CaixaDialogo caixaDialogo = new CaixaDialogo();
            caixaDialogo.Show("Confirmar", true, true, true);
            Console.ReadKey();
        }
    }
}

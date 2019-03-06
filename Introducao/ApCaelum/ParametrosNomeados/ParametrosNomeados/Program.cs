using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametrosNomeados
{

    public class CaixaDialogoBad
    {
        public void Show(string Mensagem, bool MostrarBotaoOk, bool MostralBotaoNo, bool MostrarBotaoCancel, int Delay)
        {
            Console.WriteLine(Mensagem);
        }
    }

    public class CaixaDialogo
    {
        public void Show(DialogoParams dialogoParams)
        {
            Console.WriteLine(dialogoParams.Mensagem);
        }
    }

    public class DialogoParams
    {
        public string Mensagem;
        public bool MostrarBotaoOk;
        public bool MostralBotaoNo;
        public bool MostrarBotaoCancel;
        public int Delay;
    }

    class Program
    {
        static void Main(string[] args)
        {
            CaixaDialogoBad caixaDialogo = new CaixaDialogoBad();
            //Parametros nomeados (dizer exatamente o que o parametro é, deixar claro!)
            //Para fins de documentação isso é muito utilizado!
            caixaDialogo.Show(Mensagem: "Confirmar operação?", MostrarBotaoOk: true, MostralBotaoNo: false, 
                MostrarBotaoCancel: false, Delay: 10);

            CaixaDialogo caixaDialogo2 = new CaixaDialogo();
            //Parametros nomeados (dizer exatamente o que o parametro é, deixar claro!)
            //Para fins de documentação isso é muito utilizado!
            caixaDialogo2.Show(new DialogoParams() {
                Mensagem = "Confirmar operação?",
                MostrarBotaoOk = true,
                MostralBotaoNo = false,
                MostrarBotaoCancel = false,
                Delay = 10
            });

            Console.ReadKey();
        }
    }
}

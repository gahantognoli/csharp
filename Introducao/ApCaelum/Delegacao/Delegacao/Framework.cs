using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegacao
{

    public class Boleto
    {
        public void Pagar(double valor)
        {
            Console.WriteLine("Boleto pago no valor de " + valor);
        }
    }

    public class Pedido
    {
        private Boleto boleto = new Boleto();

        public void Fechar(double valor)
        {
            //delegação
            boleto.Pagar(valor);
        }
    }
}

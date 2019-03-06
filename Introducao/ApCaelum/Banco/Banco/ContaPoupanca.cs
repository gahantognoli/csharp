using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class ContaPoupanca : Conta
    {
        //modifica o comportamento do método sacar da classe base, aproveitando sua implementação atravéz da 
        //palavra reservada "base".

        public ContaPoupanca(int numero) : base(numero)
        {

        }

        public override void Sacar(double valor)
        {
            base.Sacar(valor + 0.10);
        }

        public override void Depositar(double valor)
        {
            base.Depositar(valor + 0.05);
        }

    }
}

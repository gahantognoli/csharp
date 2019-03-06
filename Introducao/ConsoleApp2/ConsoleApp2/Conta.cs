using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Conta
    {
        private const double _limite = -500;
        private double _saldo;

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (valor > Saldo + _limite)
            {
                throw new SaldoInsuficienteException("Saldo Insuficente");
            }
            else
            {
                  
            }
        }

        public double Saldo { get { return _saldo; } }

    }
}

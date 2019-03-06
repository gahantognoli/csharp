using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoBanco
{
    class Conta
    {
        private int numero;
        private Cliente cliente;
        private double saldo;
        
        public int Numero
        {
            get
            {
                return numero;
            }

            set
            {
                numero = value;
            }
        }

        public Cliente Cliente
        {
            get
            {
                return cliente;
            }

            set
            {
                cliente = value;
            }
        }

        public double Saldo
        {
            get
            {
                return saldo;
            }

            private set
            {
                saldo = value;
            }
        }

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if(saldo >= valor)
            {
                saldo -= valor;
                return true;
            }
            return false;
        }

        public bool Transferir(Conta destino, double valor)
        {
            if(this.saldo >= valor)
            {
                this.Sacar(valor);
                destino.Depositar(valor);
                return true;
            }
            return false;
        }

    }
}

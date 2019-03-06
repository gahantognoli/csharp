using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSet
{
    public class Conta
    {
        private string Cliente;
        private double Valor;

        //Como estau criando um construtor o default é perdido.
        //Caso queira amnter deve fazer a implementação dele no braço.
        public Conta()
        {

        }

        public Conta(string cliente)
        {
            Cliente = cliente;
        }
        

        public void Sacar(double valor)
        {
            this.Valor = this.Valor = valor;
        }

        public void Depositar(double valor)
        {
            this.Valor = this.Valor - valor;
        }

        public double GetValor()
        {
            return Valor;
        }

        public string GetCliente()
        {
            return Cliente;
        }

        public void SetCliente(string cliente)
        {
            Cliente = cliente;
        }
    }
}

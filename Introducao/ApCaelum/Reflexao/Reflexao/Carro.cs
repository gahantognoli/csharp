using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflexao
{
    internal class Carro : ICarro, IPintado
    {
        public string Cor;
        private int velocidade;
        public int Velocidade
        {
            get { return velocidade; }
        }

        public Carro()
        {
            Cor = "Vermelho";
            velocidade = 0;
        }

        public Carro(string cor, int velocidade)
        {
            Cor = cor;
            this.velocidade = velocidade;
        }

        public void Acelerar(int quantidade)
        {
            velocidade += quantidade;
        }

        public bool EstaMovendo()
        {
            if (Velocidade == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public double CalcularKilometrosPorLitro(int kmInicial, int kmFinal, double litros)
        {
            return (kmFinal - kmInicial) / litros;
        }

        public bool ehPintado()
        {
            return (Cor != null);
        }
    }

    internal class CarroEsporte : Carro
    {
        public CarroEsporte()
        {
            Cor = "Azul";
        }
    }

}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class ContaCorrente : Conta
    {

        public ContaCorrente(int numero) : base(numero)
        {

        }

        public override void Sacar(double valor)
        {
            base.Sacar(valor + 0.10);
        }
    }
}

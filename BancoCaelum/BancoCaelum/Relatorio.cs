﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCaelum
{
    class Relatorio
    {
        public double totalBanco { get; private set; }
        public void TotalizadorDeContas(Conta conta)
        {
            totalBanco += conta.Saldo;
        }     


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.Classes
{
    class Conta
    {
        public double Saldo { get; set; }

        public void Deposita(double valor)
        {
            Saldo += valor;

        }
        public void Saca (double valor)
        {
            Saldo -= valor;

        }
    }


}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulamentoBanco
{
    class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; private set; }

        public void Saca(double valorSaque)
        {
            if (Saldo>=valorSaque)
            {
                Saldo -= valorSaque;
            }

        }

        public void Deposita(double valorDeposito)
        {
            if (valorDeposito>0)
            {
                Saldo += valorDeposito;
            }
        }

    }

}

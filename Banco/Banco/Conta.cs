using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Conta
    {
        public int numero;
        public double saldo;
        public string titular;
        public string CPF;

        public void Deposita(double valor)
        {
            saldo = saldo + valor;
        }
      
        public bool Saca(double valorSaque)
        {
            if (this.saldo >= valorSaque)
            {
                this.saldo = this.saldo - valorSaque;
                return true;
            }
            else return false;
        }

    }
}

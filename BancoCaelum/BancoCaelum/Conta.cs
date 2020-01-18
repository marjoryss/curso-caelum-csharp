using System.ComponentModel;

namespace BancoCaelum
{
    public class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; private set; }
        public Cliente Titular { get; set; }

        public void Saca(double valorSaque)
        {
            if (Saldo >= valorSaque)
            {
                Saldo -= valorSaque;
            }

        }

        public void Deposita(double valorDeposito)
        {
            if (valorDeposito > 0)
            {
                Saldo += valorDeposito;
            }
        }

    }
}
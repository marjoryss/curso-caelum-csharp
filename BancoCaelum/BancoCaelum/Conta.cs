using System.ComponentModel;

namespace BancoCaelum
{
    public class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; private set; }
        public Cliente Titular { get; set; }
        public string Tipo { get; set; }

        public bool Saca(double valorSaque)
        {
            if (this.Tipo == "cp" && this.Saldo >= valorSaque + 0.10)
            {
                this.Saldo = this.Saldo - (valorSaque + 0.10);
                return true;     
            }
            if (this.Saldo >= valorSaque && this.Tipo == "cc")
            {
                this.Saldo = this.Saldo - valorSaque;
                return true;
            }
            return false;
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
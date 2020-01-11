using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banco_2
{
    class Cliente
    {
        public string nome;
        public string CPF;
        public string RG;
        public string endereço;
        public int idade;

        public bool EhMaiorDeIdade()
        {
            if (idade >= 18)
            {
                return true;
            }
            else
                return false;
        }
    
                 


    }
}

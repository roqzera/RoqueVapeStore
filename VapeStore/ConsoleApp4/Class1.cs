using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoqueVapeStore
{

    public class CalculosCaixa
    {
        public decimal Valor;
        public int Qtd;
        public decimal Dinheiro;

        public decimal Total()
        {
            return Qtd * Valor;
        }
        public decimal Troco()
        {
            return Dinheiro - Total();
        }

    }
}
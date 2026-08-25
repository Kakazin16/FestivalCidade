using System;
using System.Collections.Generic;
using System.Text;

namespace FestivalCidade
{
    public class Ingresso
    {
        public string NomeFa { get; set; }
        public int DiasShow { get; set; }
        public string Cupom { get; set; }
        public int PontosFidelidade { get; set; }

        public double CalcularCustoBruto()
        {
            return 15.00 + (120.00 * DiasShow);
        }

        public double CalcularDesconto()
        {
            if (!string.IsNullOrEmpty(Cupom) && Cupom.Equals("ROCK10", StringComparison.OrdinalIgnoreCase))
            {
                return CalcularCustoBruto() * 0.10;
            }
            return 0.00;
        }

        public double CalcularValorFinal()
        {
            return CalcularCustoBruto() - CalcularDesconto();
        }

    }
}

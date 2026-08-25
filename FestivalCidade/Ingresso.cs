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



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    internal class consumo
    {

        public double KmInicial;
        public double KmFinal;
        public double KmTotal;
        public double GasolinaGasta;
        public double Consumo;

       public double CalculaGasosa()
        {
            KmTotal = KmFinal - KmInicial;

            Consumo = KmTotal / GasolinaGasta;
            return Consumo;
        }
    }
}

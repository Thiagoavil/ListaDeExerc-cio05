using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    internal class Cilindro
    {
        public double raioDaBase;
        public double altura;
        public double Volume;


        public double CalculaVolume()
        {
            Volume =  3.14 * (raioDaBase * raioDaBase) *altura;
            return Volume;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    internal class Esfera
    {

        public double raio;
        public double VolumeEsfera;



        public double CalculaVolume()
        {
            VolumeEsfera = 4 * 3.14 * Math.Pow(raio, 3) / 3;
            return VolumeEsfera;
        }
    }
}

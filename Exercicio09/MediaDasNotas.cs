using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio09
{
    internal class MediaDasNotas
    {
        public double[] nota;
        public double  totalDasNotas;
        public int numeroDeNotas;
        public double MediaHarmonica;

        public double calculaMedia()
        {
            for(int i = 0; i < nota.Length; i++)
            {
                totalDasNotas = 1/nota[i] + totalDasNotas;
            }

            MediaHarmonica = numeroDeNotas / totalDasNotas;
            return MediaHarmonica;
        }
    }
}

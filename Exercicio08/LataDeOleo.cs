using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio08
{
    internal class LataDeOleo
    {
        public double raio;
        public double altura;
        public double VolumeCilindro;


        public double CalculaVolumeLataDeOleo()
        {
            VolumeCilindro = 3.14 * Math.Pow(raio, 2) * altura;
            return VolumeCilindro;
        }
    }
}

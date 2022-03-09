using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    internal class caixa
    {
        public double comprimento;
        public double largura;
        public double altura;


        public double calculaVolumeDaCaixa()
        {
            double volumeCaixa = largura * altura * comprimento;
            return volumeCaixa;
        }
    }
}

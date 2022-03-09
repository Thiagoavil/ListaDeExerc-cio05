using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06
{
    internal class ConversorCparaF
    {
        public double TemperaturaF;
        public double TemperaturaC;

        public double converterParaF()
        {
            TemperaturaF = (TemperaturaC * 1.8) + 32;
            return TemperaturaF;    
        }
    }
}

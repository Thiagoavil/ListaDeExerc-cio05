using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    internal class converterFparaC
    {
        public double TemperaturaF;
        public double TemperaturaC;




        public double ConverterParaC()
        {

            TemperaturaC = (TemperaturaF - 32) / 1.8;
            return TemperaturaC;
        }


    }
}

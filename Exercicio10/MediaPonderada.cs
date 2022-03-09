using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    internal class MediaPonderada
    {
        public double nota1;
        public double nota2;
        public double peso1 =1;
        public double peso2 =2;


        public double CalculaMedia()
        {
            double media1 = nota1 * peso1;
            double media2 = nota2 * peso2;

            double totalmediaponderada= (media1 + media2) / (peso1+peso2);
            
            return totalmediaponderada;
        }
    }
}

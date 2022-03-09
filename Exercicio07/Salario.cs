using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07
{
    internal class Salario
    {
        public double vendas;
        public double salarioBase;
        public double PorcentagemdaComissao;
        public double salarioTotal;
        

        public double CalculaSalarioTotal()
        {
            salarioTotal = salarioBase + (vendas * PorcentagemdaComissao);
            return salarioTotal;
        }
    }
}

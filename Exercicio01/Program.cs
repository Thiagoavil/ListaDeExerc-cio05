using System;

namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            caixa caixa = new caixa();

            Console.WriteLine("Digite a altura da caixa");
            caixa.altura=Convert.ToDouble(caixa.altura);

            Console.WriteLine("Digite a largura da caixa");
            caixa.largura = Convert.ToDouble(caixa.altura);

            Console.WriteLine("Digite o comprimento da caixa");
            caixa.comprimento = Convert.ToDouble(caixa.altura);

            double resultado = caixa.calculaVolumeDaCaixa();

            Console.WriteLine("O volume da caixa é: " + Math.Round(resultado, 2) + "Cm³");

        }
    }
}

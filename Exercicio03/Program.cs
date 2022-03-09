using System;

namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cilindro cilindro = new Cilindro();

            Console.WriteLine("Digite a altura: ");
            cilindro.altura=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o raio da base:");
            cilindro.raioDaBase = Convert.ToDouble(Console.ReadLine());

            double volumeFinal = cilindro.CalculaVolume();

            Console.Write("O volume do Cilindro é: " + Math.Round(volumeFinal,2));

        }
    }
}

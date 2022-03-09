using System;

namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Esfera esfera = new Esfera();

            Console.WriteLine("Digite o raio da esfera em cm:");
            esfera.raio = Convert.ToDouble(Console.ReadLine());

            double resultado = esfera.CalculaVolume();

            Console.WriteLine("O volume da esfera é de: "+ Math.Round(resultado,1) + "cm");
        }
    }
}

using System;

namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            consumo consumo=new consumo();

            Console.WriteLine("Digite o KM inicial: ");
            consumo.KmInicial=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o KM final: ");
            consumo.KmFinal=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor quantos litros gastos de gasolina: ");
            consumo.GasolinaGasta=Convert.ToDouble(Console.ReadLine());

            double resultado = consumo.CalculaGasosa();

            Console.WriteLine("A quantidade de Km feitos por litro é de: " + Math.Round(resultado,2) + "KM/l");

        }
    }
}

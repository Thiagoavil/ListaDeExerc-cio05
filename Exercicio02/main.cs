using System;

namespace Exercicio02
{
    internal class main
    {
        static void Main(string[] args)
        {
           converterFparaC conversor = new converterFparaC();

            Console.WriteLine("Digite a temperatura em Fahrenheit");
            conversor.TemperaturaF = Convert.ToDouble(Console.ReadLine());

            double resultado = conversor.ConverterParaC();

            Console.WriteLine("A temperatura em Celsius é: " + Math.Round(resultado,1) + "°C");
        }
    }
}

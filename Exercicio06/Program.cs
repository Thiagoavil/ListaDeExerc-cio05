using System;

namespace Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConversorCparaF conversor = new ConversorCparaF();

            Console.WriteLine("Digite a temperatura em °C: ");
            conversor.TemperaturaC =Convert.ToDouble(Console.ReadLine());

            double resultado = conversor.converterParaF();

            Console.WriteLine("A temperatura em Fahrenheit é: " + Math.Round(resultado,1) + "°F");

        }
    }
}

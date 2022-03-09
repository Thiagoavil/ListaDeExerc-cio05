using System;

namespace Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LataDeOleo lataDeOleo = new LataDeOleo();   
            
            Console.WriteLine("Digite o Raio da lata de oleo");
            lataDeOleo.raio= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a altura da Lata de Oleo");
            lataDeOleo.altura = Convert.ToDouble(Console.ReadLine());

            double VolumeLata = lataDeOleo.CalculaVolumeLataDeOleo();
            
            Console.WriteLine("O volume da lata de oleo é: "+ VolumeLata + "m²");
        }
    }
}

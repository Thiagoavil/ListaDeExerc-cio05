using System;

namespace Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Salario salario = new Salario();

            Console.WriteLine("Digite o salário base: ");
            salario.salarioBase = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a quantidade em reais vendidas:");
            salario.vendas=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite quantos por cento de Comissão: ");
            salario.PorcentagemdaComissao=Convert.ToDouble(Console.ReadLine())/100;

            double resultado = salario.CalculaSalarioTotal(); 

            Console.WriteLine("O salário total é de : R$"+ Math.Round(resultado,2));
        }
    }
}

using System;

namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MediaPonderada aluno = new MediaPonderada();

            Console.WriteLine("Digite a primeira nota");
            aluno.nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota");
            aluno.nota2 = Convert.ToDouble(Console.ReadLine());


            double resultado = aluno.CalculaMedia();


            Console.WriteLine("A media ponderada é: " + Math.Round(resultado,2));

        }
    }
}

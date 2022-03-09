using System;

namespace Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MediaDasNotas aluno = new MediaDasNotas();
            Console.WriteLine("Quantas notas deja informar:");
            aluno.numeroDeNotas = Convert.ToInt32(Console.ReadLine());


            aluno.nota = new double[aluno.numeroDeNotas];

            for (int i = 0; i < aluno.numeroDeNotas; i++)
            {

                Console.WriteLine("Informe sua nota:");
                aluno.nota[i] = double.Parse(Console.ReadLine());

            }

            double resultado = aluno.calculaMedia();
            Console.WriteLine("A media harmonica é: " + Math.Round(resultado,2));
        }
    }
}

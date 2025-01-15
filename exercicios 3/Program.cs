using exercicios_3;
using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno();

            Console.WriteLine("Digite o nome do aluno: ");
            a1.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas que o aluno tirou: ");
            a1.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a1.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a1.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL: " + a1.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (a1.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("Faltaram: " + a1.NotaRestante().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}

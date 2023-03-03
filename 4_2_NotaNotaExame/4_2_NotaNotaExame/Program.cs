using System;
using System.Globalization;

namespace bee1040
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, media, notaexame, mediafinal;

            string[] vet = Console.ReadLine().Split(' ');
            n1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            n2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
            n3 = double.Parse(vet[2], CultureInfo.InvariantCulture);
            n4 = double.Parse(vet[3], CultureInfo.InvariantCulture);

            media = (n1 * 2 + n2 * 3 + n3 * 4 + n4 * 1) / 10.0;

            if (media < 5.0)
            {
                Console.WriteLine($"Aluno reprovado!");
            }
            else if (media >= 7.0)
            {
                Console.WriteLine($"Aluno aprovado!");
            }
            else
            {
                Console.WriteLine($"Aluno em exame, adicinar nota do exame:");
                notaexame = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);// Adicao de nova var apos condicional.
                mediafinal = (media + notaexame) / 2.0;
                Console.WriteLine($"Media: {media.ToString("F1", CultureInfo.InvariantCulture)}\nNota do exame: {notaexame.ToString("F1", CultureInfo.InvariantCulture)}\nSituação do aluno: Aprovado!\nMedia final: {mediafinal.ToString("F1", CultureInfo.InvariantCulture)}");
            }
            Console.ReadLine();
        }
    }
}

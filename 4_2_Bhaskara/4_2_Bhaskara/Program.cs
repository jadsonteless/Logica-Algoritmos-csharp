using System;
using System.Globalization;

namespace uri1036
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, r1, r2;


            string[] vet = Console.ReadLine().Split(' ');
            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            delta = Math.Pow(b, 2.0) - 4 * a * c; // 1(passo) da formula para encontra o delta.

            if (a == 0.0 || delta < 0.0) // Tradução: se a for menor que 0 ou delta for menor que 0.
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                r1 = (-b + Math.Sqrt(delta)) / (2.0 * a); // 2(passo) da formula para acha o valor de X.
                r2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
                Console.WriteLine($"R1 = {r1.ToString("F5", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"R2 = {r2.ToString("F5", CultureInfo.InvariantCulture)}");
            }
        }
    }
}

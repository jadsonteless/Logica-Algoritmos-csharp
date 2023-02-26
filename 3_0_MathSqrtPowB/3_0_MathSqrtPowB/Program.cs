using System;
using System.Globalization;

namespace uri1015
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2, resultado;

            string[] vet = Console.ReadLine().Split(' ');
            x1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            y1 = double.Parse(vet[1], CultureInfo.InvariantCulture);

            vet = Console.ReadLine().Split(' ');
            x2 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(vet[1], CultureInfo.InvariantCulture);

            // Distancia entre dois pontos Formula: Raiz de (x2 - x1)^2 + (y2 - y1)^2
            resultado = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0));


            Console.WriteLine($"{resultado.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.ReadLine();
        }
    }
}

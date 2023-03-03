using System;
using System.Globalization;

namespace soma
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, soma;

            x = int.Parse(Console.ReadLine());

            soma = 0;

            while (x != 0)
            {
                soma = soma + x;
                Console.WriteLine($"Soma dos itens = {soma}");
                x = int.Parse(Console.ReadLine());
            }
            Console.ReadLine();
        }
    }
}

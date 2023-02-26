using System;

namespace uri1019
{
    class Program
    {
        static void Main(string[] args)
        {
            int seg, hora, resto, minutos, segundos;

            seg = int.Parse(Console.ReadLine());

            hora = seg / 3600; // realiza divisao dos segundos por 1h em segundos que é igual a 3600seg.
            resto = seg % 3600; // utiliza o resto que sobra da divisao do segundos por hora em segundos.

            minutos = resto / 60; // divide o resto do segundos por hora em minutos.
            segundos = resto % 60; // recebe o resto que sobra da divisao acima.

            Console.WriteLine($"{hora}:{minutos}:{seg}");
            Console.ReadLine();
        }
    }
}
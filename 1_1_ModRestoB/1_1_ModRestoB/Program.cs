using System;

namespace uri1018
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, quociente, resto, nota;

            N = int.Parse(Console.ReadLine());
            Console.WriteLine(N);

            resto = N; // N entra na var resto.

            nota = 100;
            quociente = resto / nota; 
            Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
            resto = resto % nota; // N sai da var resrto e entra o mod da divisao do N pela nota. 

            nota = 50;
            quociente = resto / nota;
            Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
            resto = resto % nota;

            nota = 20;
            quociente = resto / nota;
            Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
            resto = resto % nota;

            nota = 10;
            quociente = resto / nota;
            Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
            resto = resto % nota;

            nota = 5;
            quociente = resto / nota;
            Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
            resto = resto % nota;

            nota = 2;
            quociente = resto / nota;
            Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
            resto = resto % nota;

            nota = 1;
            quociente = resto / nota;
            Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
            resto = resto % nota;

            Console.ReadLine();
        }
    }
}

using System;

namespace EstruturaComposta
{
    class Program
    {
        static void Main(string[] args)
        {
            int horas;

            Console.WriteLine("Que horas são?");
            horas = int.Parse(Console.ReadLine());


            // Quando o if vem acompanhado do else é chamado de estrutura composta.
            if (horas <= 12)
            {
                Console.WriteLine("Bom Dias!");
            }
            else
            {
                if (horas <= 18)
                {
                    Console.WriteLine("Boa Tarde!");
                }
                else
                {
                    Console.WriteLine("Boa Noite!");
                }
                
            }
            // esse estrutura de condicional é chamanda de encadeamento.

            Console.ReadLine();
        }
    }
}
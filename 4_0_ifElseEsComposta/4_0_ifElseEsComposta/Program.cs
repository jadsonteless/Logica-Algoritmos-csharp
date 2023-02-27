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
                Console.WriteLine("Boa tarde!");
            }
            // if == se e else == se nao
            // se o if for falso vai executar o bloco de comandos do else.

            Console.ReadLine();
        }
    }
}

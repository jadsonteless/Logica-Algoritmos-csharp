using System; // atribui System aos consoles
using System.Globalization; // instala CultureInfo.InvariantCulture

namespace sqrtpow
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2; // var do tipo string.
            int idade1, idade2; // var do tipo number int.
            double media; // var do tipo number double.

            string[] vet; // vertor para fazer corte de stings.

            vet = Console.ReadLine().Split(' '); // faz a corte de strings do primeiro input.
            nome1 = vet[0]; // add primera string.
            idade1 = int.Parse(vet[1]); // add segunda string.

            vet = Console.ReadLine().Split(' '); // faz a corte de strings do segundo input.
            nome2 = vet[0]; // add primeira string.
            idade2 = int.Parse(vet[1]); // add segunda string.

            media = (idade1 + idade2) / 2.0; // 2.0 informa que o resultado é do tipo double.
            // media = (double) (idade1 + idade2) / 2; informa que os numero sao do tipo double.

            // imprime resultado nno console.
            Console.WriteLine($"A IDADE MÉDIA DE {nome1} E {nome2} É DE {media.ToString("F1", CultureInfo.InvariantCulture)} ANOS");


            Console.ReadLine();
        }
    }
}
/*
    # APLICAMOS:
    - String
    - Leitura de mais de um dado na mesma linha
    - Casting
    
 */

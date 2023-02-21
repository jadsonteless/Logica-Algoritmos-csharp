using System; // add System aos Console.
using System.Globalization; // inslata CultureInfo.InvariantCulture.

namespace split
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod1, cod2, qtd1, qtd2; // var numeros int.
            double preco1, preco2, total; // var numeros double.

            string[] valores = Console.ReadLine().Split(' '); // recebe e divida as string em partes.
            cod1 = int.Parse(valores[0]); // add primeira parte.
            qtd1 = int.Parse(valores[1]); // add segunda parte.
            preco1 = double.Parse(valores[2], CultureInfo.InvariantCulture); // add terceira parte.

            valores = Console.ReadLine().Split(' '); // recebe segundo valores.
            cod2 = int.Parse(valores[0]);
            qtd2 = int.Parse(valores[1]);
            preco2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            total = preco1 * qtd1 + preco2 * qtd2; // realiza o calculo.

            // imprimi o resultado:
            Console.WriteLine($"VALOR A PAGAR: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}

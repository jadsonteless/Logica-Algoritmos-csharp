using System; // atribui System aos consoles
using System.Globalization; // instala CultureInfo.InvariantCulture

namespace sqrtpow
{
    class Program
    {
        static void Main(string[] args)
        {
            string vendendor; // tipo palavras.
            double salario, tvendido, meta, total; // numeros decimal.

            vendendor = Console.ReadLine(); // entrada de nome.
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // entrada do salario com a conversao do "ponto" com CultureInfo.InvariantCulture.
            tvendido = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //// entrada total vendido com a conversao do "ponto" com CultureInfo.InvariantCulture.

            meta = tvendido / 100.0 * 15.0; // calculo de porcentagem.
            total = salario + meta; // soma dos valores.


            Console.WriteLine($"TOTAL = R$ {total.ToString("F2", CultureInfo.InvariantCulture)}"); // print do resultado.

            Console.ReadLine();
        }
    }
}
/*      # ATIVIDADE: SALÁRIO COM BÔNUS 
            - Uri online 1009

Faça um programa que leia o nome de um vendedor, o seu salário fixo e o total de vendas efetuadas 
por ele no mês (em dinheiro). Sabendo que este vendedor ganha 15% de comissão sobre suas vendas efetuadas, 
informar o total a receber no final do mês, com duas casas decimais.

Entrada
O arquivo de entrada contém um texto (primeiro nome do vendedor) e 2 valores de dupla precisão (double) 
com duas casas decimais, representando o salário fixo do vendedor e montante total das vendas efetuadas 
por este vendedor, respectivamente.

Saída
Imprima o total que o funcionário deverá receber, conforme exemplo fornecido.

Exemplos:
1   Entrada     Saida
    Joao        TOTAL = 684.54
    500.00
    1230.30

2   Entrada     Saida
    Joao        TOTAL = 700.00
    700.00
    0.00

3   Entrada     Saida
    Joao        TOTAL = 1884.58
    1700.00
    1230.50
 */

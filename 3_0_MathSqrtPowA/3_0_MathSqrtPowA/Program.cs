using System; // atribui System aos consoles
using System.Globalization; // instala CultureInfo.InvariantCulture

namespace sqrtpow
{
    class Program
    {
        static void Main(string[] args)
        {
            // b = base a = altura
            double b, a, area, perimetro, diagonal;

            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // area é base x altura
            area = b * a;
            // periemto é a soma de base + altura x 2
            perimetro = 2 * (b + a); // perimetro = 2 * b + 2 * a; tambem poderia ser motando dessa forma

            //          Sqrt = Raiz quadrada        Pow = Pontenciação
            diagonal = Math.Sqrt(Math.Pow(b, 2.0) + Math.Pow(a, 2.0));

            // impresão dos resultados
            Console.WriteLine($"AREA = {area.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"PERIMETRO = {perimetro.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"DIAGONAL = {diagonal.ToString("F4", CultureInfo.InvariantCulture)}");

            Console.ReadLine();
        }
    }
}

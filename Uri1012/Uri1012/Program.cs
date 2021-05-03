using System;
using System.Globalization;

namespace Uri1012
{
    class Program
    {
        static void Main(string[] args)
        {
            String entrada = Console.ReadLine();

            double a = double.Parse(entrada.Split(' ')[0], CultureInfo.InvariantCulture);
            double b = double.Parse(entrada.Split(' ')[1], CultureInfo.InvariantCulture);
            double c = double.Parse(entrada.Split(' ')[2], CultureInfo.InvariantCulture);

            double triangulo = (a * c) / 2;
            double circulo = 3.14159 * (Math.Pow(c, 2));
            double trapezio = ((a + b) * c) / 2;
            double quadrado = b * b;
            double retangulo = b * a;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}

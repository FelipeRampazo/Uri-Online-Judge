using System;
using System.Globalization;

namespace Uri1006
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = ((a * 2) + (b * 3) + (c * 5)) / 10;

            Console.WriteLine("MEDIA = " + media.ToString("f1", CultureInfo.InvariantCulture));

        }
    }
}

using System;
using System.Globalization;

namespace Uri1002
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = 3.14159;

            double raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double a = Math.Pow(raio, 2) * n;

            Console.WriteLine("A =" + a.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}

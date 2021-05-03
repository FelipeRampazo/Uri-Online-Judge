using System;
using System.Collections.Generic;
using System.Globalization;

namespace Uri1043
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');

            double a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            if (a + b > c && b + c > a && a + c> b)
            {
                double perimetro = a + b + c;
                Console.WriteLine("Perimetro = "+ perimetro.ToString("F1",CultureInfo.InvariantCulture));

            }
            else
            {
                double area = ((a + b) * c) / 2;
                Console.WriteLine("Area = " + area.ToString("F1", CultureInfo.InvariantCulture));
            }





        }
    }
}

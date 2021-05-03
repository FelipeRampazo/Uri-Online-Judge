using System;
using System.Globalization;

namespace Uri1021
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            int d100 = (int)(n / 100);
            double resto = n % 100;
            int d50 = (int)(resto / 50);
            resto = resto % 50;
            int d20 = (int)(resto / 20);
            resto = resto % 20;
            int d10 = (int)(resto / 10);
            resto = resto % 10;
            int d05 = (int)(resto / 5);
            resto = resto % 5;
            int d02 = (int)(resto / 2);
            resto = resto % 2;

            resto = resto * 100;
            
            int m100 = (int)(resto / 100);
            resto = resto % 100;
            int m50 = (int)(resto / 50);
            resto = resto % 50;
            int m25 = (int)(resto / 25);
            resto = resto % 25;
            int m10 = (int)(resto / 10);
            resto = resto % 10;
            int m05 = (int)(resto /5);
            resto = resto % 5;
            int m01 = (int)(resto / 1);

            Console.WriteLine("NOTAS:");
            Console.WriteLine(d100 + " nota(s) de R$ 100.00");
            Console.WriteLine(d50 + " nota(s) de R$ 50.00");
            Console.WriteLine(d20 + " nota(s) de R$ 20.00");
            Console.WriteLine(d10 + " nota(s) de R$ 10.00");
            Console.WriteLine(d05 + " nota(s) de R$ 5.00");
            Console.WriteLine(d02 + " nota(s) de R$ 2.00");

            Console.WriteLine("MOEDAS:");
            Console.WriteLine(m100 + " moeda(s) de R$ 1.00");
            Console.WriteLine(m50 + " moeda(s) de R$ 0.50");
            Console.WriteLine(m25 + " moeda(s) de R$ 0.25");
            Console.WriteLine(m10 + " moeda(s) de R$ 0.10");
            Console.WriteLine(m05 + " moeda(s) de R$ 0.05");
            Console.WriteLine(m01 + " moeda(s) de R$ 0.01");



        }
    }
}

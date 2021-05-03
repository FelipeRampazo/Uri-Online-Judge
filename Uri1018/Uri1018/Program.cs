using System;

namespace Uri1018
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = int.Parse(Console.ReadLine());
            int resto = 0;
            int d100 = 0, d50 = 0, d20 = 0, d10 = 0, d5 = 0, d2 = 0, d1 = 0;

            d100 = valor / 100;
            resto = valor % 100;
            d50 = resto/50;
            resto = resto % 50;
            d20 = resto / 20;
            resto = resto % 20;
            d10 = resto / 10;
            resto = resto % 10;
            d5 = resto / 5;
            resto = resto % 5;
            d2 = resto / 2;
            resto = resto % 2;
            d1 = resto / 1;
            resto = resto % 1;

            Console.WriteLine(valor);
            Console.WriteLine(d100 + " nota(s) de R$ 100,00");
            Console.WriteLine(d50 + " nota(s) de R$ 50,00");
            Console.WriteLine(d20 + " nota(s) de R$ 20,00");
            Console.WriteLine(d10 + " nota(s) de R$ 10,00");
            Console.WriteLine(d5 + " nota(s) de R$ 5,00");
            Console.WriteLine(d2 + " nota(s) de R$ 2,00");
            Console.WriteLine(d1 + " nota(s) de R$ 1,00");


        }
    }
}

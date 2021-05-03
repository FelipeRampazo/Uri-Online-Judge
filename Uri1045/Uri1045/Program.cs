using System;
using System.Globalization;

namespace Uri1045
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numeros = Console.ReadLine().Split(' ');

            double a = double.Parse(numeros[0], CultureInfo.InvariantCulture);
            double b = double.Parse(numeros[1], CultureInfo.InvariantCulture);
            double c = double.Parse(numeros[2], CultureInfo.InvariantCulture);

            double aux = 0;


            if (c >= b && b >= a)
            {
                aux = c;
                c = a;
                a = aux;
            }
            else if (c >= a && a >= b) {
                aux = c;
                c = b;
                b = a;
                a = aux;
            }
            else if (b >= c && c >= a)
            {
                aux = b;
                b = c;
                c = a;
                a = aux;
            }
            else if (b >= a && a >= c)
            {
                aux = a;
                a = b;
                b = aux;
            }
            else if (a <= c && c >= b) {
                aux = c;
                c = b;
                b = aux;
            }

            if (a >= b + c)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else
            {

                if (Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2))
                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                if (Math.Pow(a, 2) > Math.Pow(b, 2) + Math.Pow(c, 2))
                {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                if (Math.Pow(a, 2) < Math.Pow(b, 2) + Math.Pow(c, 2))
                {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }
                if (a == b && a == c)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if (a == b && a != c || b == c && b != a || c == a && c != b)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }
        }
    }
}

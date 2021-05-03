using System;
using System.Globalization;

namespace Uri1037
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            if (numero < 0 || numero > 100)
            {
                Console.WriteLine("Fora de intervalo");
            }

            else if ( numero <= 25) {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if ( numero <= 50)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (numero <= 75)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if (numero <= 100)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
        }
    }
}

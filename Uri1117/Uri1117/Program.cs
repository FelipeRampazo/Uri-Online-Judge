using System;
using System.Collections.Generic;
using System.Globalization;

namespace Uri1117
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = -1;
            double y = -1;

            List<int> verifica = new List<int>();

            while (x == -1 || y == -1)
            {
                double aux = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (x == -1 && aux >= 0 && aux <= 10)
                {
                    x = aux;
                }
                else if (x != -1 && y == -1 && aux >= 0 && aux <= 10)
                {
                    y = aux;
                }
                else
                {
                    verifica.Add(1);
                }
            }
            foreach (int nuemro in verifica)
            {
                Console.WriteLine("nota invalida");
            }

            double media = (x + y) / 2;
            Console.WriteLine("media = " + media.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}

using System;
using System.Globalization;

namespace Uri1116
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] x = new int[n];
            int[] y = new int[n];

            for (int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                x[i] = int.Parse(vet[0]);
                y[i] = int.Parse(vet[1]);

            }

            for (int i = 0; i < n; i++)
            {
                if (y[i] == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    double divi = (double)x[i] / y[i];

                    Console.WriteLine(divi.ToString("f1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}

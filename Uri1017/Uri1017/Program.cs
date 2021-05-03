using System;
using System.Globalization;

namespace Uri1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempo = int.Parse(Console.ReadLine());
            int velM = int.Parse(Console.ReadLine());


            int dist = tempo * velM;
            double gasto = dist / 12.0;

            Console.WriteLine(gasto.ToString("F3", CultureInfo.InvariantCulture));


        }
    }
}

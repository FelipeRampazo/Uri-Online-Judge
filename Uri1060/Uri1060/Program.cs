using System;
using System.Globalization;

namespace Uri1060
{
    class Program
    {
        static void Main(string[] args)
        {
            int posi = 0;
            for (int i = 1; i <= 6; i++)
            {
                 double numero = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if (numero > 0)
                {
                    posi++ ;
                }


            }

            Console.WriteLine(posi + " valores positivos");
        }
    }
}

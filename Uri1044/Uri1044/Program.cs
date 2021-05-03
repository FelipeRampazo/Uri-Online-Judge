using System;

namespace Uri1044
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] num = Console.ReadLine().Split(' ');

            int a = int.Parse(num[0]);
            int b = int.Parse(num[1]);
            int resto = 0;
            if (a > b)
            {
                resto = a % b;
            }
            else
            {
                resto = b % a;
            }

            if (resto == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            };
        }
    }
}

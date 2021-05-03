using System;

namespace Uri1035
{
    class Program
    {
        static void Main(string[] args)
        {
            string vet = Console.ReadLine();

            int a = int.Parse(vet.Split(' ')[0]);
            int b = int.Parse(vet.Split(' ')[1]);
            int c = int.Parse(vet.Split(' ')[2]);
            int d = int.Parse(vet.Split(' ')[3]);


            if (b > c && d > a && (c + d) > (b + a) && c > 0 && d > 0 && a % 2 == 0)
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }

        }
    }
}

using System;

namespace Uri1013
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');

            int a = int.Parse(vet[0]);
            int b = int.Parse(vet[1]);
            int c = int.Parse(vet[2]);

            int maior1 = (a + b + Math.Abs(a - b)) / 2;
            int maior2 = (maior1 + c + Math.Abs(maior1 - c)) / 2;

            Console.WriteLine(maior2 + " eh o maior");
        }
    }
}

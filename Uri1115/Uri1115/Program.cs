using System;
using System.Collections.Generic;

namespace Uri1115
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            List<int> x = new List<int>();
            List<int> y = new List<int>();

            while (int.Parse(vet[0]) != 0 && int.Parse(vet[1]) != 0)
            {
                x.Add(int.Parse(vet[0]));
                y.Add(int.Parse(vet[1]));



                vet = Console.ReadLine().Split(' ');


            }


            for (int i = 0; i <  x.Count; i++)
            {
                if (x[i] > 0 && y[i] > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (x[i] < 0 && y[i] > 0)
                {
                    Console.WriteLine("segundo");
                }
                else if (x[i] < 0 && y[i] < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else
                {
                    Console.WriteLine("quarto");
                }

            }
        }
    }
}

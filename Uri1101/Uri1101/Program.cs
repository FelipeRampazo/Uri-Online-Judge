using System;
using System.Collections.Generic;

namespace Uri1101
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            List<int> m = new List<int>();
            List<int> n = new List<int>();


            while (int.Parse(vet[0]) > 0 && int.Parse(vet[1]) > 0)
            {
                m.Add(int.Parse(vet[0]));
                n.Add(int.Parse(vet[1]));

                vet = Console.ReadLine().Split(' ');
            }

            for (int i = 0; i < m.Count; i++)
            {
                if (m[i] > n[i])
                {
                    int aux = m[i];
                    m[i] = n[i];
                    n[i] = aux;
                }

                int soma = 0;
                for (int j = m[i]; j <= n[i]; j++)
                {

                    Console.Write(j + " ");
                    soma += j;

                }
                Console.Write("Sum=" + soma);
                Console.WriteLine();

              
                }
            }



        }
    }


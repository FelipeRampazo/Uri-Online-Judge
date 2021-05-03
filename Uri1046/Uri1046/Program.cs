using System;

namespace Uri1046
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numeros = Console.ReadLine().Split(' ');

            int inicio = int.Parse(numeros[0]);
            int fim = int.Parse(numeros[1]);

            int duracao = 0;

            if (fim > inicio)
            {
                duracao = fim - inicio;
            }
            else
            {
                duracao = (24 + fim) - inicio;  
            }

            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");


        }
    }
}

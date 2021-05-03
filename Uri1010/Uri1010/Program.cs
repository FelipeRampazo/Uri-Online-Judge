using System;
using System.Globalization;

namespace Uri1010
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int numeroA = int.Parse(vet[0]);
            int quantidadeA = int.Parse(vet[1]);
            double valorA = double.Parse(vet[2],CultureInfo.InvariantCulture);

            string[] vet2 = Console.ReadLine().Split(' ');
            int numeroB = int.Parse(vet2[0]);
            int quantidadeB = int.Parse(vet2[1]);
            double valorB = double.Parse(vet2[2],CultureInfo.InvariantCulture);

            double total = (valorA * quantidadeA) + (valorB * quantidadeB);
            
            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2",CultureInfo.InvariantCulture));


        }
    }
}

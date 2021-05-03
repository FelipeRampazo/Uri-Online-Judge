using System;
using System.Globalization;

namespace Uri1038
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int codigo = int.Parse(vet[0]);
            int quantidade = int.Parse(vet[1]);
            double preco = 0;

           switch (codigo)
            {
                case 1:
                    preco = 4.00;
                    break;
                case 2:
                    preco = 4.50;
                    break;
                case 3:
                    preco = 5.00;
                    break;
                case 4:
                    preco = 2.00;
                    break;
                case 5:
                    preco = 1.50;
                    break;
            }

            double total = preco * quantidade;
            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture) );
        }
    }
}

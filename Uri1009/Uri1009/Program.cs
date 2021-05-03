using System;
using System.Globalization;

namespace Uri1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salario, vendas;

            nome = Console.ReadLine();
            salario = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            vendas = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double total = salario + (vendas * 0.15f);

            Console.WriteLine("TOTAL = R$ " + total.ToString("f2", CultureInfo.InvariantCulture));

            
        }
    }
}

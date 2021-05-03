using System;
using System.Globalization;

namespace Uri1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, horas;
            double recebePorHoras, salario;

            numero = int.Parse(Console.ReadLine());
            horas = int.Parse(Console.ReadLine());
            recebePorHoras = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            salario = horas * recebePorHoras;

            Console.WriteLine("NUMBER = " + numero);
            Console.WriteLine("SALARY = U$ " + salario.ToString("f2", CultureInfo.InvariantCulture));

            

        }
    }
}

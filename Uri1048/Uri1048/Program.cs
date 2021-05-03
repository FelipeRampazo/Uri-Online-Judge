using System;
using System.Globalization;

namespace Uri1048
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double porcentagem = 0;
            double novoSalario = 0;
            double reajuste = 0;

            if (salario >= 0 && salario <= 400)
            {
                porcentagem = 15;
                reajuste = (salario / 100) * porcentagem;
                novoSalario = salario + reajuste;

                Console.WriteLine("Novo salario: "+ novoSalario.ToString("F2",CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: "+ reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + porcentagem + " %");

            }
            else if (salario > 400 && salario <= 800)
            {
                porcentagem = 12;
                reajuste = (salario / 100) * porcentagem;
                novoSalario = salario + reajuste;

                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + porcentagem + " %");

            }
            else if (salario > 800 && salario <= 1200)
            {
                porcentagem = 10;
                reajuste = (salario / 100) * porcentagem;
                novoSalario = salario + reajuste;

                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + porcentagem + " %");

            }
            else if (salario > 1200 && salario <= 2000)
            {
                porcentagem = 7;
                reajuste = (salario / 100) * porcentagem;
                novoSalario = salario + reajuste;

                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + porcentagem + " %");

            }
            else if (salario > 2000)
            {
                porcentagem = 4;
                reajuste = (salario / 100) * porcentagem;
                novoSalario = salario + reajuste;

                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2",CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + porcentagem + " %");

            }
        }
    }
}

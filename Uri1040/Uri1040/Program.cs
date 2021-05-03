using System;
using System.Globalization;

namespace Uri1040
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] notas = Console.ReadLine().Split(' ');
            double n1 = double.Parse(notas[0],CultureInfo.InvariantCulture);
            double n2 = double.Parse(notas[1], CultureInfo.InvariantCulture);
            double n3 = double.Parse(notas[2], CultureInfo.InvariantCulture);
            double n4 = double.Parse(notas[3], CultureInfo.InvariantCulture);

            double media = Math.Truncate(((n1 * 2) + (n2 * 3) + (n3 * 4) + (n4 * 1)) )/10;
            
            Console.WriteLine("Media: " + media.ToString("F1",CultureInfo.InvariantCulture));


            if (media >= 7)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media < 5)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else
            {
                Console.WriteLine("Aluno em exame.");
           
            
            double nE = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Nota do exame: " + nE.ToString("F1", CultureInfo.InvariantCulture));

            double nMedia = (media + nE) / 2;

            if (nMedia >= 5)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else
            {
                Console.WriteLine("Aluno reprovado.");
            }

            Console.WriteLine("Media final: " + nMedia.ToString("F1", CultureInfo.InvariantCulture));

            
            }


        }
    }
}

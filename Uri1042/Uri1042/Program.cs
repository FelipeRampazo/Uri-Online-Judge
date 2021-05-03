using System;

namespace Uri1042
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');

            int a = int.Parse(valores[0]);
            int b = int.Parse(valores[1]);
            int c = int.Parse(valores[2]);

            if (a < b && b < c)
            {
                Console.WriteLine(a.ToString());
                Console.WriteLine(b.ToString());
                Console.WriteLine(c.ToString());
            }
            else if (a < c  && c  < b)
            {
                Console.WriteLine(a.ToString());
                Console.WriteLine(c.ToString());
                Console.WriteLine(b.ToString());
            }
            else if (b < a && a < c)
            {
                Console.WriteLine(b.ToString());
                Console.WriteLine(a.ToString());
                Console.WriteLine(c.ToString());
            }
            else if (b < c && c < a)
            {
                Console.WriteLine(b.ToString());
                Console.WriteLine(c.ToString());
                Console.WriteLine(a.ToString());
            }
            else if (c < a && a < b)
            {
                Console.WriteLine(c.ToString());
                Console.WriteLine(a.ToString());
                Console.WriteLine(b.ToString());
            }
            else{
                Console.WriteLine(c.ToString());
                Console.WriteLine(b.ToString());
                Console.WriteLine(a.ToString());
            }

            Console.WriteLine();
            Console.WriteLine(a.ToString());
            Console.WriteLine(b.ToString());
            Console.WriteLine(c.ToString());
        }
    }
}

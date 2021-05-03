using System;
using System.Collections.Generic;

namespace Uri1114
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha = int.Parse(Console.ReadLine());
            List<int> lista = new List<int>();

            while (senha != 2002)
            {
                lista.Add(1);

                senha = int.Parse(Console.ReadLine());
            }
            for(int i = 0; i < lista.Count; i++)
            {
                if (lista[i] == 1)
                {
                    Console.WriteLine("Senha Invalida");
                }

            }

            Console.WriteLine("Acesso Permitido");

        }
    }
}

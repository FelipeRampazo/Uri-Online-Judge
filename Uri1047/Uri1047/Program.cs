using System;

namespace Uri1047
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] entrada = Console.ReadLine().Split(' ');

            int horaInicio = int.Parse(entrada[0]);
            int minutoInicio = int.Parse(entrada[1]);
            int horaFim = int.Parse(entrada[2]);
            int minutoFim = int.Parse(entrada[3]);
            int duracaoReal = 0;
            int minutosIniciais = (horaInicio * 60) + minutoInicio;
            int minutosFinais = (horaFim * 60) + minutoFim;
            
            if (minutosFinais > minutosIniciais)
            {
                duracaoReal = minutosFinais - minutosIniciais;
            }
            else
            {
                duracaoReal = (minutosFinais + 1440) - minutosIniciais;
            }

            Console.WriteLine("O JOGO DUROU "+ (duracaoReal / 60) + " HORA(S) E "+ (duracaoReal % 60) + " MINUTO(S)");


        }
    }
}

using System;

namespace Uri1049
{
    class Program
    {
        static void Main(string[] args)
        {
            string palavra1 = Console.ReadLine();
            string palavra2 = Console.ReadLine();
            string palavra3 = Console.ReadLine();
            string resultado = "resultado";

            if (palavra1 == "vertebrado" && palavra2 == "ave" && palavra3 == "carnivoro")
            {
                resultado = "aguia";
            }
            else if(palavra1 == "vertebrado" && palavra2 == "ave" && palavra3 == "onivoro")
            {
                resultado = "pomba";
            }
            else if (palavra1 == "vertebrado" && palavra2 == "mamifero" && palavra3 == "onivoro")
            {
                resultado = "homem";
            }
            else if (palavra1 == "vertebrado" && palavra2 == "mamifero" && palavra3 == "herbivoro")
            {
                resultado = "vaca";
            }
            else if (palavra1 == "invertebrado" && palavra2 == "inseto" && palavra3 == "hematofago")
            {
                resultado = "pulga";
            }
            else if (palavra1 == "invertebrado" && palavra2 == "inseto" && palavra3 == "herbivoro")
            {
                resultado = "lagarta";
            }
            else if (palavra1 == "invertebrado" && palavra2 == "anelideo" && palavra3 == "hematofago")
            {
                resultado = "sanguessuga";
            }
            else if (palavra1 == "invertebrado" && palavra2 == "anelideo" && palavra3 == "onivoro")
            {
                resultado = "minhoca";
            }

            Console.WriteLine(resultado); ;

        }
    }
    }


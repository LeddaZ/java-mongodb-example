using System;
using System.Collections.Generic;

namespace Funzioni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double CalcoloSomma(Double num1, Double num2)
            {
                return num1 + num2;
            }

            Double CalcoloMax(Double num1, Double num2)
            {
                if (num1 > num2)
                    return num1;
                else
                    return num2;
            }

            Double CalcoloMedia(List<Double> lista)
            {
                Double somma = 0;
                foreach (Double n in lista)
                {
                    somma += n;
                }
                return somma / lista.Count;
            }

            Console.Title = "Funzioni";
            Double n1, n2;
            Console.Write("Inserisci il primo addendo: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Inserisci il secondo addendo: ");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("La somma è: " + CalcoloSomma(n1, n2));
            Console.WriteLine("Il massimo è: " + CalcoloMax(n1, n2));

            List<Double> bonk = new List<Double>
            {
                23.2,
                24.1,
                98.123,
                -23.12
            };
            Console.WriteLine("\nContenuto della lista");
            foreach (Double n in bonk)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
            Console.WriteLine("La media è: " + CalcoloMedia(bonk));
            Console.ReadKey();
        }
    }
}

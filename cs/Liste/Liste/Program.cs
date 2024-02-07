using System;
using System.Collections.Generic;

namespace Liste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Liste";
            List<Int32> lista = new List<Int32>
            {
                77,
                12,
                34
            };
            for (Int32 i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }
            Console.WriteLine();
            foreach(Int32 i in lista)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();

            Console.WriteLine();
            List<Int32> temp = new List<Int32>();
            Console.WriteLine("Inserisci 5 temperature");
            for (Int32 i = 0; i < 5; i++)
            {
                Int32 t;
                do
                {
                    Console.Write((i + 1) + ": ");
                    t = Convert.ToInt32(Console.ReadLine());
                }
                while (t < -273);
                temp.Add(t);
            }
            foreach(Int32 i in temp)
            {
                if (i < 15)
                    Console.WriteLine("Freddo (" + i + ")");
                else if (i >= 15 && i <= 25)
                    Console.WriteLine("Temperato (" + i + ")");
                else
                    Console.WriteLine("Caldo (" + i + ")");
            }
            Console.ReadKey();

            Console.WriteLine();
            List<Double> numeri = new List<Double>();
            Console.WriteLine("Inserisci 5 numeri");
            Double somma = 0;
            Double max = Double.MinValue;
            Double min = Double.MaxValue;
            for(Int32 i = 0; i < 5; i++)
            {
                Console.Write((i + 1) + ": ");
                Double n = Convert.ToDouble(Console.ReadLine());
                numeri.Add(n);
                somma += n;
                if (n > max)
                    max = n;
                if (n < min)
                    min = n;
            }
            Console.WriteLine("Media: " + (somma/numeri.Count));
            Console.WriteLine("Massimo: " + max);
            Console.WriteLine("Minimo: " + min);
            Console.ReadKey();
        }
    }
}

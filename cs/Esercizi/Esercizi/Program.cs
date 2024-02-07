using System;

namespace Esercizi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Esercizi";
            Console.WriteLine("Diagrammi");
            Int32 c = 1, n, n1, n2, n3;
            Console.WriteLine("Inserisci 3 numeri interi compresi tra 0 e 10");
            do
            {
                Console.Write("n" + c + ": ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            while (n < 0 || n > 10);
            c++;
            n1 = n;
            do
            {
                Console.Write("n" + c + ": ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            while (n < 0 || n > 10);
            c++;
            n2 = n;
            do
            {
                Console.Write("n" + c + ": ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            while (n < 0 || n > 10);
            n3 = n;

            Console.Write("[");
            for (int i = 0; i < n1; i++)
            {
                Console.Write("X");
            }
            Console.WriteLine("]");

            Console.Write("[");
            for (int i = 0; i < n2; i++)
            {
                Console.Write("X");
            }
            Console.WriteLine("]");

            Console.Write("[");
            for (int i = 0; i < n3; i++)
            {
                Console.Write("X");
            }
            Console.WriteLine("]");

            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("Tavola pitagorica");
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    Console.Write("|" + (j + 1) * (i + 1) + "\t");
                }
                Console.WriteLine("|");
            }

            Console.ReadKey();
        }
    }
}

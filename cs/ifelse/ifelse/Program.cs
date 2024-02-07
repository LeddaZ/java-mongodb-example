using System;

namespace ifelse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "if/else";
            Console.Write("Inserisci il voto: ");
            int voto = Convert.ToInt32(Console.ReadLine());
            if (voto >= 6)
            {
                Console.WriteLine("Promosso");
            }
            else
            {
                Console.WriteLine("Bocciato");
            }
            Console.WriteLine();

            Console.Write("Inserisci la temperatura dell'acqua: ");
            int temp = Convert.ToInt32(Console.ReadLine());
            if (temp >= 100)
            {
                Console.WriteLine("Stato gassoso");
            }
            else if (temp >= 0)
            {
                Console.WriteLine("Stato liquido");
            }
            {
                Console.WriteLine("Stato solido");
            }
            Console.ReadKey();
        }
    }
}

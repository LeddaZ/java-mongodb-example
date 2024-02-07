using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double PrezzoUnitario;
            int Quantita;
            double Imponibile, IVA, Totale;
            PrezzoUnitario = 45.9;
            Quantita = 2;
            Imponibile = PrezzoUnitario * Quantita;
            IVA = Imponibile * 0.22;
            Totale = Imponibile + IVA;

            Console.WriteLine("Imponibile: " + Imponibile + "\nIVA: " + IVA + "\nTotale: " + Totale);
            Console.ReadKey();
        }
    }
}

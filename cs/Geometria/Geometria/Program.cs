using System;

namespace Geometria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Area rettangolo";
            double Base, Altezza;
            Console.Write("Inserisci la base: ");
            Base = Convert.ToDouble(Console.ReadLine());
            Console.Write("Inserisci l'altezza: ");
            Altezza = Convert.ToDouble(Console.ReadLine());
            double Area = Base * Altezza;
            double Perimetro = (Base + Altezza) * 2;
            Console.WriteLine("Area: " + Area + "\nPerimetro: " + Perimetro);
            Console.ReadLine();
        }
    }
}

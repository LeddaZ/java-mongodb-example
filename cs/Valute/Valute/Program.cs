using System;

namespace Valute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Valute";
            Console.Write("Inserisci l'importo in euro: ");
            double euro = 0;
            try
            {
                euro = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Devi inserire un numero idiota\n" + ex);
            }
            finally
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.Title = "b";
                Console.WriteLine("aaaaaaaabababababb");
            }
            double dollari = euro * 1.07;
            double yen = euro * 160.95;
            double sterline = euro * 0.87;
            Console.WriteLine("Dollari: " + dollari + "\nYen: " + yen + "\nSterline: " + sterline);
            Console.ReadKey();
        }
    }
}

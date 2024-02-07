using System;
using System.Linq;

namespace CodiceFiscale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String Consonanti(String cognome)
            {
                String codice = "";
                Char[] vocali = { 'A', 'E', 'I', 'O', 'U' };
                String temp = "";
                // Consonanti
                foreach (Char c in cognome.ToUpper())
                {
                    if (!vocali.Contains(c))
                        temp += c;
                }
                if (temp.Length >= 3)
                {
                    for (Int32 i = 0; i < 3; i++)
                        codice += temp.Substring(i, 1);
                }
                else // Se le consonanti non bastano si prendono le vocali
                {
                    codice += temp;
                    temp = "";
                    foreach (Char c in cognome.ToUpper())
                    {
                        if (vocali.Contains(c) && codice.Length < 3)
                            codice += c;
                    }
                    if (temp.Length >= 3)
                    {
                        for (Int32 i = 0; i < 3; i++)
                            codice += temp.Substring(i, 1);
                    }
                    else
                        codice += temp;
                }
                if (codice.Length < 3)
                    codice += "X";
                return codice;
            }
            Console.Write("Inserisci il cognome: ");
            String cog = Console.ReadLine();
            Console.WriteLine(Consonanti(cog));
            Console.ReadKey();
        }
    }
}

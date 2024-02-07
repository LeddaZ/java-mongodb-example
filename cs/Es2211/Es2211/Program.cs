using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es2211
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void Titolo(String titolo)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(titolo);
                Console.ForegroundColor = ConsoleColor.White;
            }


            string ConvListString(List<string> lista)
            {
                string s = "";
                for(int i = 0; i < (lista.Count() - 1); i++)
                {
                    s += lista[i] + ", ";
                }
                s += lista[lista.Count() - 1];
                return s;
            }

            string ConvListInt(List<int> lista)
            {
                string s = "";
                for (int i = 0; i < (lista.Count() - 1); i++)
                {
                    s += lista[i] + ", ";
                }
                s += lista[lista.Count() - 1];
                return s;
            }

            string ConvListDouble(List<double> lista)
            {
                string s = "";
                for (int i = 0; i < (lista.Count() - 1); i++)
                {
                    s += lista[i] + ", ";
                }
                s += lista[lista.Count() - 1];
                return s;
            }

            List<string> InvertiLista(List<string> stringhe)
            {
                List<string> nuovaLista = new List<string>();
                for(int i = (stringhe.Count - 1); i >= 0; i--)
                {
                    nuovaLista.Add(stringhe[i]);
                }
                return nuovaLista;
            }

            int UltimoNumero(List<int> numeri)
            {
                return numeri[numeri.Count() - 1];
            }

            string ElementoLista(List<string> stringhe, int i)
            {
                return stringhe[i - 1];
            }

            int PosizioneNellaLista(List<string> lista, string elemento)
            {
                int pos;
                for (int i = 0; i < lista.Count(); i++)
                {
                    if (lista[i] == elemento)
                    {
                        pos = i + 1;
                        return pos;
                    }
                }
                pos = 0;
                return pos;
            }

            double SommaElementi(List<double> lista)
            {
                double somma = 0;
                foreach (double n in lista) { 
                    somma += n;
                }
                return somma;
            }

            Console.Title = "Esercizi 22/11";

            Titolo("Inversione lista di stringhe");
            List<string> listaStringhe = new List<string>
            {
                "Pinnacoli Pendenti",
                "Formichiere Rosso Assassino 9000 Deluxe",
                "uwu"
            };
            Console.WriteLine("Pre-inversione: " + ConvListString(listaStringhe));
            Console.WriteLine("Elemento 2: " + ElementoLista(listaStringhe, 2));
            Console.WriteLine("Posizione di 'Pinnacoli Pendenti': " + PosizioneNellaLista(listaStringhe, "Pinnacoli Pendenti"));
            Console.WriteLine("Post-inversione: " + ConvListString(InvertiLista(listaStringhe)) + "\n");

            Titolo("Ultimo numero della lista");
            List<int> listaNumeri = new List<int>
            {
                12,
                223,
                15,
                54
            };
            Console.WriteLine("Lista: " + ConvListInt(listaNumeri));
            Console.WriteLine("Ultimo numero: " + UltimoNumero(listaNumeri) + "\n");

            Titolo("Somma degli elementi");
            List<double> listaDouble = new List<double>
            {
                32.11,
                1.07,
                57.28,
                123.456,
                789.012
            };
            Console.WriteLine("Lista: " + ConvListDouble(listaDouble));
            Console.WriteLine("Somma: " + SommaElementi(listaDouble));
            Console.ReadKey();
        }
    }
}

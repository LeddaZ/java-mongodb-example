using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Dipendenti
{
    public partial class FormDipendenti : Form
    {
        public FormDipendenti()
        {
            InitializeComponent();
        }

        private void ButtonDipendenti_Click(object sender, EventArgs e)
        {
            Dipendente d1 = new Dipendente
            {
                Nome = "Mario",
                Cognome = "Rossi",
                Giorno = 12,
                Mese = 7,
                Anno = "1994",
                Sesso = 'M'
            };
            d1.CodF = CalcolaCodF(d1);
            Dipendente d2 = new Dipendente
            {
                Nome = "Anna",
                Cognome = "Boh",
                Giorno = 9,
                Mese = 11,
                Anno = "2001",
                Sesso = 'F'
            };
            d2.CodF = CalcolaCodF(d2);
            Dipendente d3 = new Dipendente
            {
                Nome = "Zxcvbnm",
                Cognome = "Asdfghjkl",
                Giorno = 21,
                Mese = 2,
                Anno = "1999",
                Sesso = 'M'
            };
            d3.CodF = CalcolaCodF(d3);
            Dipendente d4 = new Dipendente
            {
                Nome = "Leonardo",
                Cognome = "Ledda",
                Giorno = 2,
                Mese = 12,
                Anno = "2002",
                Sesso = 'M'
            };
            d4.CodF = CalcolaCodF(d4);
            List<Dipendente> lista = new List<Dipendente>()
            {
                d1, d2, d3, d4
            };
            Tabella.DataSource = lista;
        }

        private string Cognome(string cognome)
        {
            string codice = "";
            char[] vocali = { 'A', 'E', 'I', 'O', 'U' };
            string temp = "";
            // Consonanti
            foreach (char c in cognome.ToUpper())
            {
                if (!vocali.Contains(c))
                    temp += c;
            }
            if (temp.Length >= 3)
            {
                for (int i = 0; i < 3; i++)
                    codice += temp.Substring(i, 1);
            }
            else // Se le consonanti non bastano si prendono le vocali
            {
                codice += temp;
                temp = "";
                foreach (char c in cognome.ToUpper())
                {
                    if (vocali.Contains(c) && codice.Length < 3)
                        codice += c;
                }
                if (temp.Length >= 3)
                {
                    for (int i = 0; i < 3; i++)
                        codice += temp.Substring(i, 1);
                }
                else
                    codice += temp;
            }
            if (codice.Length < 3)
                codice += "X";
            return codice;
        }

        private string Nome(string nome)
        {
            string codice = "";
            char[] vocali = { 'A', 'E', 'I', 'O', 'U' };
            string temp = "";
            // Consonanti
            foreach (char c in nome.ToUpper())
            {
                if (!vocali.Contains(c))
                    temp += c;
            }
            if (temp.Length >= 4)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (i != 1)
                        codice += temp.Substring(i, 1);
                }
            }
            else if (temp.Length == 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    codice += temp.Substring(i, 1);
                }
            }
            else // Se le consonanti non bastano si prendono le vocali
            {
                codice += temp;
                temp = "";
                foreach (char c in nome.ToUpper())
                {
                    if (vocali.Contains(c) && codice.Length < 3)
                        codice += c;
                }
                if (temp.Length >= 3)
                {
                    for (int i = 0; i < 3; i++)
                        codice += temp.Substring(i, 1);
                }
                else
                    codice += temp;
            }
            if (codice.Length < 3)
                codice += "X";
            return codice;
        }

        private string CalcolaCodF(Dipendente d)
        {
            string codF = "";
            string gString;
            int g = d.Giorno;
            if (d.Sesso == 'F')
                g += 40;
            if (g < 10)
                gString = "0" + g;
            else
                gString = g.ToString();
            codF += Cognome(d.Cognome);
            codF += Nome(d.Nome);
            codF += d.Anno.Substring(d.Anno.Length - 2, 2);
            switch (d.Mese)
            {
                case 1:
                    codF += "A";
                    break;
                case 2:
                    codF += "B";
                    break;
                case 3:
                    codF += "C";
                    break;
                case 4:
                    codF += "D";
                    break;
                case 5:
                    codF += "E";
                    break;
                case 6:
                    codF += "H";
                    break;
                case 7:
                    codF += "L";
                    break;
                case 8:
                    codF += "M";
                    break;
                case 9:
                    codF += "P";
                    break;
                case 10:
                    codF += "R";
                    break;
                case 11:
                    codF += "S";
                    break;
                case 12:
                    codF += "T";
                    break;
            }
            codF += gString;
            codF += "G224C";
            return codF;
        }
    }
}

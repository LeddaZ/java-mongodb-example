namespace VerificaCSharp
{
    public class CodFiscale
    {
        private readonly string Nome;
        private readonly string Cognome;
        private readonly DateTime DataNascita;
        private readonly char Sesso;
        private readonly string Comune;

        public CodFiscale(string Nome, string Cognome, DateTime DataNascita, char Sesso, string Comune) {
            this.Nome = Nome;
            this.Cognome = Cognome;
            this.DataNascita = DataNascita;
            this.Sesso = Sesso;
            this.Comune = Comune;
        }

        private string GetCognome()
        {
            string Codice = "";
            char[] Vocali = ['A', 'E', 'I', 'O', 'U'];
            string Temp = "";
            // Consonanti
            foreach (char c in Cognome.ToUpper())
            {
                if (!Vocali.Contains(c))
                    Temp += c;
            }
            if (Temp.Length >= 3)
            {
                for (int i = 0; i < 3; i++)
                    Codice += Temp.Substring(i, 1);
            }
            else // Se le consonanti non bastano si prendono le vocali
            {
                Codice += Temp;
                Temp = "";
                foreach (char c in Cognome.ToUpper())
                {
                    if (Vocali.Contains(c) && Codice.Length < 3)
                        Codice += c;
                }
                if (Temp.Length >= 3)
                {
                    for (int i = 0; i < 3; i++)
                        Codice += Temp.Substring(i, 1);
                }
                else
                    Codice += Temp;
            }
            if (Codice.Length < 3)
                Codice += "X";
            return Codice;
        }

        private string GetNome()
        {
            string Codice = "";
            char[] Vocali = ['A', 'E', 'I', 'O', 'U'];
            string Temp = "";
            // Consonanti
            foreach (char c in Nome.ToUpper())
            {
                if (!Vocali.Contains(c))
                    Temp += c;
            }
            if (Temp.Length >= 4)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (i != 1)
                        Codice += Temp.Substring(i, 1);
                }
            }
            else if (Temp.Length == 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    Codice += Temp.Substring(i, 1);
                }
            }
            else // Se le consonanti non bastano si prendono le vocali
            {
                Codice += Temp;
                Temp = "";
                foreach (char c in Nome.ToUpper())
                {
                    if (Vocali.Contains(c) && Codice.Length < 3)
                        Codice += c;
                }
                if (Temp.Length >= 3)
                {
                    for (int i = 0; i < 3; i++)
                        Codice += Temp.Substring(i, 1);
                }
                else
                    Codice += Temp;
            }
            if (Codice.Length < 3)
                Codice += "X";
            return Codice;
        }

        private string GetDataSesso()
        {
            string Codice = "";
            string gString;
            int g = DataNascita.Day;
            if (Sesso == 'F')
                g += 40;
            if (g < 10)
                gString = "0" + g;
            else
                gString = g.ToString();
            int m = DataNascita.Month;
            string a = DataNascita.Year.ToString();
            Codice += a.Substring(a.Length - 2, 2);
            switch (m)
            {
                case 1:
                    Codice += "A";
                    break;
                case 2:
                    Codice += "B";
                    break;
                case 3:
                    Codice += "C";
                    break;
                case 4:
                    Codice += "D";
                    break;
                case 5:
                    Codice += "E";
                    break;
                case 6:
                    Codice += "H";
                    break;
                case 7:
                    Codice += "L";
                    break;
                case 8:
                    Codice += "M";
                    break;
                case 9:
                    Codice += "P";
                    break;
                case 10:
                    Codice += "R";
                    break;
                case 11:
                    Codice += "S";
                    break;
                case 12:
                    Codice += "T";
                    break;
            }
            Codice += gString;
            return Codice;
        }

        public override string ToString()
        {
            return $"{GetNome()}{GetCognome()}{GetDataSesso()}";
        }
    }
}

using System;
using System.Linq;
using System.Windows.Forms;

namespace CodFiscaleForm
{
    public partial class CodiceFiscale : Form
    {
        private char sesso = 'M';

        public CodiceFiscale()
        {
            InitializeComponent();
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

        private void ButtonCalcola_Click(object sender, EventArgs e)
        {
            string codF = "";
            string cognome = TextBoxCognome.Text;
            string nome = TextBoxNome.Text;
            string gString;
            int g = DataNascita.Value.Day;
            if (sesso == 'F')
                g += 40;
            if (g < 10)
                gString = "0" + g;
            else
                gString = g.ToString();
            int m = DataNascita.Value.Month;
            String a = DataNascita.Value.Year.ToString();
            codF += Cognome(cognome);
            codF += Nome(nome);
            codF += a.Substring(a.Length - 2, 2);
            switch (m)
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
            LabelCodice.Text = codF;
        }

        private void RadioM_CheckedChanged(object sender, EventArgs e)
        {
            sesso = 'M';
        }

        private void RadioF_CheckedChanged(object sender, EventArgs e)
        {
            sesso = 'F';
        }
    }
}

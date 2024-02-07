using System;
using System.Windows.Forms;

namespace Stringhe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Stringhe";
            Console.Write("E-mail: ");
            String email = Console.ReadLine();
            if (email.Contains("@") && email.Contains(".") && email.Length >= 6)
                MessageBox.Show("Indirizzo valido", "E-mail", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Indirizzo non valido", "E-mail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Console.WriteLine("Lunghezza della stringa " + email + ": " + email.Length);
            Console.WriteLine("Indice del carattere @: " + email.IndexOf('@'));
            Console.Write("Password: ");
            String password = Console.ReadLine();
            if (password.Length < 8)
                MessageBox.Show("Password troppo corta", "Lunghezza password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Password valida", "Lunghezza password", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Console.WriteLine();
            String messaggio = "sternocleidomastoideo";
            Console.WriteLine(messaggio + " " + messaggio.Substring(4, 2));

            Console.WriteLine();
            Console.Write("Inserisci una stringa: ");
            String caramba = Console.ReadLine();
            foreach (Char c in caramba)
            {
                Console.WriteLine(c);
            }
            Console.ReadKey();
        }
    }
}

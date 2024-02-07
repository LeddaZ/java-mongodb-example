namespace VerificaCSharp
{
    public class Dipendente
    {
        public int Id { get; set; }
        public string? Cognome { get; set; }
        public string? Nome { get; set; }
        public string? DataNascita { get; set; }
        public char Sesso { get; set; }
        public string? ComuneNascita { get; set; }
        public string? ProvinciaNascita { get; set; }
        public string? Email { get; set; }

        public Dipendente()
        {

        }
    }
}

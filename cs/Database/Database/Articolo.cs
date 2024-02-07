namespace Database
{
    public class Articolo
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string descrizione { get; set; }
        public float prezzo { get; set; }
        public int giacenza { get; set; }
        public int iva { get; set; }

        public Articolo()
        {

        }
    }
}

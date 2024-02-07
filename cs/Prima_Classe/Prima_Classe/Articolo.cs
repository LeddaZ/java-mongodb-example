using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prima_Classe
{
    public class Articolo
    {
        public Articolo()
        {

        }

        public Articolo(int id_articolo, string nome, string descrizione, double prezzo, int giacenza, int aliquotaIva)
        {
            this.id_articolo = id_articolo;
            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.giacenza = giacenza;
            this.aliquotaIva = aliquotaIva;
        }

        public int id_articolo {  get; set; }
        public string nome { get; set; }
        public string descrizione { get; set; }
        public double prezzo { get; set; }
        public int giacenza { get; set; }
        public int aliquotaIva {  get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Articoli
{
    public partial class FormListaArticoli : Form
    {
        public FormListaArticoli()
        {
            InitializeComponent();
        }

        private void ButtonGenera_Click(object sender, EventArgs e)
        {
            Articolo a1 = new Articolo
            {
                ID = 1,
                Nome = "Logitech K740",
                Descrizione = "Tastiera Logitech K740",
                Prezzo = 90,
                Giacenza = 3,
                IVA = 22
            };
            Articolo a2 = new Articolo {
                ID = 2,
                Nome = "Scrivania",
                Descrizione = "Scrivania 140x60 cm",
                Prezzo = 120,
                Giacenza = 9,
                IVA = 22
            };
            Articolo a3 = new Articolo
            {
                ID = 3,
                Nome = "Latte",
                Descrizione = "Latte intero",
                Prezzo = 3.99,
                Giacenza = 25,
                IVA = 4
            };
            List<Articolo> lista = new List<Articolo>
            {
                a1,
                a2,
                a3
            };
            Tabella.DataSource = lista;
        }
    }
}

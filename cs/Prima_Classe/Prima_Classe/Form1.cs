using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prima_Classe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.btn_crea_articolo.Click += Btn_crea_articolo_Click;
        }

        private void Btn_crea_articolo_Click(object sender, EventArgs e)
        {
            Articolo art1 = new Articolo();
            art1.id_articolo = 1;
            art1.nome = "pane";
            art1.descrizione = "pane al latte";
            art1.prezzo = 4.5;
            art1.giacenza = 20;
            art1.aliquotaIva = 4;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

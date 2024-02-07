using System;
using System.Windows.Forms;

namespace Forms
{
    public partial class Calcolatrice : Form
    {
        private readonly string errore = "Uno o entrambi i valori inseriti non sono validi o mancano";

        public Calcolatrice()
        {
            InitializeComponent();
        }

        private void ButtonAddizione_Click(object sender, EventArgs e)
        {
            try
            {
                LabelRisultato.Text = "Risultato: " +
                    (Convert.ToDouble(TextBoxNum1.Text) + Convert.ToDouble(TextBoxNum2.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show(errore, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonSottrazione_Click(object sender, EventArgs e)
        {
            try
            {
                LabelRisultato.Text = "Risultato: " +
                    (Convert.ToDouble(TextBoxNum1.Text) - Convert.ToDouble(TextBoxNum2.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show(errore, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonMoltiplicazione_Click(object sender, EventArgs e)
        {
            try
            {
                LabelRisultato.Text = "Risultato: " +
                (Convert.ToDouble(TextBoxNum1.Text) * Convert.ToDouble(TextBoxNum2.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show(errore, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonDivisione_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(TextBoxNum1.Text) == 0 || Convert.ToDouble(TextBoxNum2.Text) == 0)
                {
                    MessageBox.Show("Ma che fai?!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    LabelRisultato.Text = "Risultato: " +
                        (Convert.ToDouble(TextBoxNum1.Text) / Convert.ToDouble(TextBoxNum2.Text));
                }
            }
            catch (FormatException)
            {
                MessageBox.Show(errore, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

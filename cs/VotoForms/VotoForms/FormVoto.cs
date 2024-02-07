namespace VotoForms
{
    public partial class FormVoto : Form
    {
        public FormVoto()
        {
            InitializeComponent();
        }

        private void FormVoto_Load(object sender, EventArgs e)
        {

        }

        private void ButtonCalcola_Click(object sender, EventArgs e)
        {
            int voto = Convert.ToInt32(TextBoxVoto.Text);
            if (voto <= 59)
                MessageBox.Show("F", "Voto");
            else if (voto >= 60 && voto <= 69)
                MessageBox.Show("E", "Voto");
            else if (voto >= 70 && voto <= 79)
                MessageBox.Show("D", "Voto");
            else if (voto >= 80 && voto <= 84)
                MessageBox.Show("C", "Voto");
            else if (voto >= 85 && voto <= 89)
                MessageBox.Show("B", "Voto");
            else if (voto >= 90 && voto <= 100)
                MessageBox.Show("A", "Voto");
            else
                MessageBox.Show("eh no", "Voto", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
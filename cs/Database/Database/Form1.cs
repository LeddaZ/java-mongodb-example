using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Database
{
    public partial class Form1 : Form
    {
        readonly List<Articolo> articoli = new List<Articolo>();
        static readonly string StringaConnessione = "Server=localhost\\SQLEXPRESS; Database=caramba; Trusted_Connection=True";
        SqlConnection conn = new SqlConnection(StringaConnessione);
        public Form1()
        {
            InitializeComponent();
            BtnArticoli.Click += BtnArticoli_Click;
        }

        private void BtnArticoli_Click(object sender, System.EventArgs e)
        {
            List<User> users = new List<User>();
            try {
                conn.Open();
                SqlCommand comm = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "SELECT * FROM TabArticoli"
                };
                SqlDataReader reader = comm.ExecuteReader();
                articoli.Clear();
                while (reader.Read())
                {
                    Articolo articolo = new Articolo
                    {
                        id = Convert.ToInt32(reader["ID"]),
                        nome = Convert.ToString(reader["Nome"]),
                        descrizione = Convert.ToString(reader["Descrizione"]),
                        prezzo = Convert.ToSingle(reader["Prezzo"]),
                        giacenza = Convert.ToInt32(reader["Giacenza"]),
                        iva = Convert.ToInt32(reader["IVA"])
                    };
                    articoli.Add(articolo);
                }
                dataGridView1.DataSource = articoli;
                reader.Close();

                SqlCommand comm2 = new SqlCommand
                {
                    CommandText = "SELECT * FROM Users",
                    Connection = conn
                };
                SqlDataReader reader2 = comm2.ExecuteReader();
                while (reader2.Read())
                {
                    User u = new User
                    {
                        id = Convert.ToInt32(reader2["UserID"]),
                        email = Convert.ToString(reader2["Email"]),
                        password = Convert.ToString(reader2["Password"])
                    };
                    users.Add(u);
                }
                dataGridView2.DataSource = users;
            }
            catch (Exception ex) {
                MessageBox.Show("Accidenti\n" + ex.Message);
            }
            conn.Close();
        }

        private void BtnInserisci_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn
                };
                cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@Descrizione", txtDescrizione.Text);
                cmd.Parameters.AddWithValue("@Prezzo", (double)numPrezzo.Value);
                cmd.Parameters.AddWithValue("@Giacenza", (int)numGiacenza.Value);
                cmd.Parameters.AddWithValue("@IVA", (int)numIVA.Value);
                cmd.CommandText = "INSERT INTO TabArticoli (Nome,Descrizione,Prezzo,Giacenza,IVA)" +
                    "VALUES (@Nome,@Descrizione,@Prezzo,@Giacenza,@IVA)";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Articolo inserito correttamente", "Aggiunta articolo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eccezione: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        private void BtnElimina_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn
                };
                cmd.Parameters.AddWithValue("@ID", (int)numID.Value);
                cmd.CommandText = "DELETE FROM TabArticoli WHERE ID=@ID";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Articolo rimosso correttamente", "Rimozione articolo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eccezione: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        private void BtnCerca_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand
                {
                    Connection = conn,
                };
                comm.Parameters.AddWithValue("@Nome", txtCerca.Text);
                comm.CommandText = "SELECT * FROM TabArticoli WHERE Nome LIKE '%@Nome%'";
                SqlDataReader reader = comm.ExecuteReader();
                articoli.Clear();
                while (reader.Read())
                {
                    Articolo articolo = new Articolo
                    {
                        id = Convert.ToInt32(reader["ID"]),
                        nome = Convert.ToString(reader["Nome"]),
                        descrizione = Convert.ToString(reader["Descrizione"]),
                        prezzo = Convert.ToSingle(reader["Prezzo"]),
                        giacenza = Convert.ToInt32(reader["Giacenza"]),
                        iva = Convert.ToInt32(reader["IVA"])
                    };
                    articoli.Add(articolo);
                }
                dataGridView3.DataSource = articoli;
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Accidenti\n" + ex.Message);
            }
            conn.Close();
        }
    }
}

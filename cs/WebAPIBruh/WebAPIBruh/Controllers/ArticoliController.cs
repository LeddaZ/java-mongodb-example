using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace WebAPIBruh.Controllers
{
    public class ArticoliController : Controller
    {
        readonly List<Articolo> articoli = new List<Articolo>();
        static readonly string StringaConnessione = "Server=localhost\\SQLEXPRESS; Database=caramba; Trusted_Connection=True";
        SqlConnection conn = new SqlConnection(StringaConnessione);

        [Route("articoli/lista/tutti")]
        [HttpGet]
        public List<Articolo> GetListArticoli()
        {
            try
            {
                conn.Open();
                SqlCommand comm = new()
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
                        ID = Convert.ToInt32(reader["ID"]),
                        Nome = Convert.ToString(reader["Nome"]),
                        Descrizione = Convert.ToString(reader["Descrizione"]),
                        Prezzo = Convert.ToSingle(reader["Prezzo"]),
                        Giacenza = Convert.ToInt32(reader["Giacenza"]),
                        IVA = Convert.ToInt32(reader["IVA"])
                    };
                    articoli.Add(articolo);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Accidenti\n" + ex.Message);
            }
            conn.Close();
            return articoli;
        }

        [Route("articoli/lista/fuoristock")]
        [HttpGet]
        public List<Articolo> GetListArticoliFuoriStock()
        {
            try
            {
                conn.Open();
                SqlCommand comm = new()
                {
                    Connection = conn,
                    CommandText = "SELECT * FROM TabArticoli WHERE Giacenza=0"
                };
                SqlDataReader reader = comm.ExecuteReader();
                articoli.Clear();
                while (reader.Read())
                {
                    Articolo articolo = new Articolo
                    {
                        ID = Convert.ToInt32(reader["ID"]),
                        Nome = Convert.ToString(reader["Nome"]),
                        Descrizione = Convert.ToString(reader["Descrizione"]),
                        Prezzo = Convert.ToSingle(reader["Prezzo"]),
                        Giacenza = Convert.ToInt32(reader["Giacenza"]),
                        IVA = Convert.ToInt32(reader["IVA"])
                    };
                    articoli.Add(articolo);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Accidenti\n" + ex.Message);
            }
            conn.Close();
            return articoli;
        }

        [Route("articoli/gestisci/articolo")]
        [HttpGet]
        public Articolo GetArticolo(int id)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new()
                {
                    Connection = conn
                };
                SqlDataReader reader = cmd.ExecuteReader();
                Articolo art = new();
                while (reader.Read())
                {
                    if (Convert.ToInt32(reader["ID"]) == id)
                    {
                        art.ID = Convert.ToInt32(reader["ID"]);
                        art.Nome = Convert.ToString(reader["Nome"]);
                        art.Descrizione = Convert.ToString(reader["Descrizione"]);
                        art.Prezzo = Convert.ToSingle(reader["Prezzo"]);
                        art.Giacenza = Convert.ToInt32(reader["Giacenza"]);
                        art.IVA = Convert.ToInt32(reader["IVA"]);
                    }
                }
                reader.Close();
                conn.Close();
                return art;
            }
            catch (Exception)
            {
                conn.Close();
                return null;
            }
        }

        [Route("articoli/gestisci/inserisci")]
        [HttpPost]
        public string InserisciArticolo(Articolo art)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new()
                {
                    Connection = conn
                };
                cmd.Parameters.AddWithValue("@Nome", art.Nome);
                cmd.Parameters.AddWithValue("@Descrizione", art.Descrizione);
                cmd.Parameters.AddWithValue("@Prezzo", Math.Round(art.Prezzo, 2));
                cmd.Parameters.AddWithValue("@Giacenza", art.Giacenza);
                cmd.Parameters.AddWithValue("@IVA", art.IVA);
                cmd.CommandText = "INSERT INTO TabArticoli (Nome,Descrizione,Prezzo,Giacenza,IVA)" +
                    "VALUES (@Nome,@Descrizione,@Prezzo,@Giacenza,@IVA)";
                cmd.ExecuteNonQuery();
                conn.Close();
                return "gg";
            }
            catch (Exception ex)
            {
                conn.Close();
                return ex.Message;
            }
        }

        [Route("articoli/gestisci/elimina")]
        [HttpDelete]
        public string EliminaArticolo(int id)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new()
                {
                    Connection = conn
                };
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.CommandText = "DELETE FROM TabArticoli WHERE ID=@ID";
                cmd.ExecuteNonQuery();
                conn.Close();
                return "gg";
            }
            catch (Exception ex)
            {
                conn.Close();
                return ex.Message;
            }
        }

        [Route("articoli/gestisci/aggiorna_giacenza")]
        [HttpPut]
        public string AggiornaGiacenza(int id, bool acquisto)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new()
                {
                    Connection = conn
                };
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.CommandText = "SELECT Giacenza FROM TabArticoli WHERE ID=@ID";
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                int giacenza = Convert.ToInt32(reader["Giacenza"]);
                reader.Close();
                SqlCommand cmd2 = new()
                {
                    Connection = conn
                };
                cmd2.Parameters.AddWithValue("@ID", id);
                if (acquisto)
                    cmd2.CommandText = "UPDATE TabArticoli SET Giacenza=" + (giacenza + 1) + "WHERE ID=@ID";
                else
                    cmd2.CommandText = "UPDATE TabArticoli SET Giacenza=" + (giacenza - 1) + "WHERE ID=@ID";
                cmd2.ExecuteNonQuery();
                conn.Close();
                return "gg";
                
            }
            catch (Exception ex)
            {
                conn.Close();
                return ex.Message;
            }
        }
    }
}

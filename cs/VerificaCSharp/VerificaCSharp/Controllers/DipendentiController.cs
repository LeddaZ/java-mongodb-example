using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Globalization;

namespace VerificaCSharp.Controllers
{
    public class DipendentiController : Controller
    {
        private readonly CultureInfo CultureInfo = new ("it-IT");
        readonly List<Dipendente> Dipendenti = [];
        static readonly string StringaConnessione = "Server=localhost\\SQLEXPRESS; Database=caramba; Trusted_Connection=True";
        readonly SqlConnection Conn = new (StringaConnessione);

        [Route("dipendenti/get/tutti")]
        [HttpGet]
        public List<Dipendente> GetListaDipendenti()
        {
            try
            {
                Conn.Open();
                SqlCommand Comm = new()
                {
                    Connection = Conn,
                    CommandText = "SELECT * FROM TDipendenti"
                };
                SqlDataReader Reader = Comm.ExecuteReader();
                Dipendenti.Clear();
                while (Reader.Read())
                {
                    Dipendente Dip = new()
                    {
                        Id = Convert.ToInt32(Reader["DipendenteID"]),
                        Nome = Convert.ToString(Reader["Nome"]),
                        Cognome = Convert.ToString(Reader["Cognome"]),
                        DataNascita = DateTime.Parse(Reader["DataNascita"].ToString() ?? "", CultureInfo).ToShortDateString(),
                        Sesso = Convert.ToChar(Reader["Sesso"]),
                        ComuneNascita = Convert.ToString(Reader["ComuneNascita"]),
                        ProvinciaNascita = Convert.ToString(Reader["ProvinciaNascita"]),
                        Email = Convert.ToString(Reader["Email"])
                    };
                    Dipendenti.Add(Dip);
                }
                Reader.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Errore\n" + ex.Message);
            }
            Conn.Close();
            return Dipendenti;
        }

        [Route("dipendenti/get/singolo")]
        [HttpGet]
        public Dipendente GetDipendente(int Id)
        {
            Dipendente Dip = new();
            if (EsisteDipendente(Id)) {
                try
                {
                    Conn.Open();
                    SqlCommand Comm = new()
                    {
                        Connection = Conn
                    };
                    Comm.Parameters.AddWithValue("@Id", Id);
                    Comm.CommandText = "SELECT * FROM TDipendenti WHERE DipendenteID = @Id";
                    SqlDataReader Reader = Comm.ExecuteReader();
                    Reader.Read();
                    Dip.Id = Convert.ToInt32(Reader["DipendenteID"]);
                    Dip.Nome = Convert.ToString(Reader["Nome"]);
                    Dip.Cognome = Convert.ToString(Reader["Cognome"]);
                    Dip.DataNascita = DateTime.Parse(Reader["DataNascita"].ToString() ?? "", CultureInfo).ToShortDateString();
                    Dip.Sesso = Convert.ToChar(Reader["Sesso"]);
                    Dip.ComuneNascita = Convert.ToString(Reader["ComuneNascita"]);
                    Dip.ProvinciaNascita = Convert.ToString(Reader["ProvinciaNascita"]);
                    Dip.Email = Convert.ToString(Reader["Email"]);
                    Reader.Close();
                    Conn.Close();
                    return Dip;
                }
                catch (Exception ex)
                {
                    Conn.Close();
                    Debug.WriteLine("Errore\n" + ex.Message);
                    return Dip;
                }
            }
            else
            {
                Debug.WriteLine($"Errore: DipendenteID {Id} non trovato");
                return Dip;
            }
        }

        [Route("dipendenti/post/inserisci")]
        [HttpPost]
        public string InserisciDipendente(Dipendente Dip)
        {
            try
            {
                Conn.Open();
                SqlCommand Comm = new()
                {
                    Connection = Conn
                };
                Comm.Parameters.AddWithValue("@Nome", Dip.Nome);
                Comm.Parameters.AddWithValue("@Cognome", Dip.Cognome);
                Comm.Parameters.AddWithValue("@DataNascita", Dip.DataNascita);
                Comm.Parameters.AddWithValue("@Sesso", Dip.Sesso);
                Comm.Parameters.AddWithValue("@ComuneNascita", Dip.ComuneNascita);
                Comm.Parameters.AddWithValue("@ProvinciaNascita", Dip.ProvinciaNascita);
                Comm.Parameters.AddWithValue("@Email", Dip.Email);
                Comm.CommandText = "INSERT INTO TDipendenti (Nome, Cognome, DataNascita, Sesso, ComuneNascita, ProvinciaNascita, Email)" +
                    "VALUES (@Nome, @Cognome, @DataNascita, @Sesso, @ComuneNascita, @ProvinciaNascita, @Email)";
                Comm.ExecuteNonQuery();
                Conn.Close();
                return "Inserimento riuscito";
            }
            catch (Exception ex)
            {
                Conn.Close();
                return $"Errore: {ex.Message}";
            }
        }
        
        [Route("dipendenti/delete/elimina")]
        [HttpDelete]
        public string EliminaDipendente(int Id)
        {
            if (EsisteDipendente(Id))
            {
                try
                {
                    Conn.Open();
                    SqlCommand Comm = new()
                    {
                        Connection = Conn
                    };
                    Comm.Parameters.AddWithValue("@Id", Id);
                    Comm.CommandText = "DELETE FROM TDipendenti WHERE DipendenteID = @Id";
                    Comm.ExecuteNonQuery();
                    Conn.Close();
                    return "Eliminazione riuscita";
                }
                catch (Exception ex)
                {
                    Conn.Close();
                    return $"Errore: {ex.Message}";
                }
            }
            else
            {
                return $"Errore: DipendenteID {Id} non trovato";
            }
        }

        [Route("dipendenti/put/aggiorna_email")]
        [HttpPut]
        public string AggiornaEmail(int Id, string Email)
        {
            if (EsisteDipendente(Id))
            {
                try
                {
                    Conn.Open();
                    SqlCommand Comm = new()
                    {
                        Connection = Conn
                    };
                    Comm.Parameters.AddWithValue("@Id", Id);
                    Comm.Parameters.AddWithValue("@Email", Email);
                    Comm.CommandText = "UPDATE TDipendenti SET Email = @Email WHERE DipendenteID = @Id";
                    Comm.ExecuteNonQuery();
                    Conn.Close();
                    return "Aggiornamento Email riuscito";

                }
                catch (Exception ex)
                {
                    Conn.Close();
                    return $"Errore: {ex.Message}";
                }
            }
            else
            {
                return $"Errore: DipendenteID {Id} non trovato";
            }
        }

        [Route("dipendenti/get/codfiscale")]
        [HttpGet]
        public string GetCodFiscale(int Id)
        {
            if (EsisteDipendente(Id))
            {
                CodFiscale cf = new(GetDipendente(Id).Nome ?? "", GetDipendente(Id).Cognome ?? "", DateTime.Parse(GetDipendente(Id).DataNascita ?? ""), GetDipendente(Id).Sesso, GetDipendente(Id).ComuneNascita ?? "");
                return $"{cf}{GetCodCatastale(Id)}";
            }
            else
            {
                return $"Errore: DipendenteID {Id} non trovato";
            }
        }

        private string GetCodCatastale(int Id)
        {
            try
            {
                string? Result = "";
                Conn.Open();
                SqlCommand Comm = new()
                {
                    Connection = Conn
                };
                Comm.Parameters.AddWithValue("@Id", Id);
                Comm.CommandText = "SELECT CodiceCatastale FROM TComuni AS C JOIN TDipendenti AS D ON C.Comune = D.ComuneNascita WHERE D.DipendenteID = @Id";
                SqlDataReader Reader = Comm.ExecuteReader();
                Reader.Read();
                Result = Convert.ToString(Reader["CodiceCatastale"]);
                Reader.Close();
                Conn.Close();
                return Result ?? "";

            }
            catch (Exception ex)
            {
                Conn.Close();
                return $"Errore: {ex.Message}";
            }
        }

            private bool EsisteDipendente(int Id)
        {
            try
            {
                Conn.Open();
                SqlCommand Comm = new()
                {
                    Connection = Conn
                };
                Comm.Parameters.AddWithValue("@DipendenteID", Id);
                Comm.CommandText = "SELECT * FROM TDipendenti WHERE DipendenteID = @DipendenteID";
                SqlDataReader Reader = Comm.ExecuteReader();
                Dipendente Dip = new();
                if (Reader.Read())
                {
                    Reader.Close();
                    Conn.Close();
                    return true;
                }
                else
                {
                    Reader.Close();
                    Conn.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                Conn.Close();
                Debug.WriteLine("Errore\n" + ex.Message);
                return false;
            }
        }
    }
}

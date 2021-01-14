using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class KorisnikRepository
    {
        public int InsertKorisnik(Korisnik k)
        {
            using (SqlConnection sqlCon = new SqlConnection(Konekcija.konekcija))
            {

                String query = "INSERT INTO Korisnik (Ime, Prezime, JMBG, Adresa, Telefon, Racun, Username, Password, Email) VALUES ('"+ k.Ime + "', '" + k.Prezime + "', '" + k.JMBG + "', '" + k.Adresa + "', '" + k.Telefon + "', " + k.Racun + ", '" + k.Username + "', '" + k.Password + "', '" + k.Email + "')";

                using (SqlCommand command = new SqlCommand(query, sqlCon))
                {
                    sqlCon.Open();
                    return command.ExecuteNonQuery();
                }
            }
        }
        public Korisnik CheckKorisnik(string username, string password)
        {
            Korisnik k = new Korisnik();
            using (SqlConnection sqlCon = new SqlConnection(Konekcija.konekcija))
            {

                String query = "SELECT * FROM Korisnik WHERE Username = '"+ username +"' AND Password = '"+ password +"'";

                using (SqlCommand command = new SqlCommand(query, sqlCon))
                {
                    sqlCon.Open();
                    SqlDataReader result = command.ExecuteReader();
                    while (result.Read())
                    {
                        k.Id = result.GetInt32(0);
                        k.Ime = result.GetString(1);
                        k.Prezime = result.GetString(2);
                        k.JMBG = result.GetString(3);
                        k.Adresa = result.GetString(4);
                        k.Telefon = result.GetString(5);
                        k.Racun = result.GetInt32(6);
                        k.Username = result.GetString(7);
                        k.Password = result.GetString(8);
                        k.Email = result.GetString(9);
                    }
                    return k;
                }
            }
        }
        public void UpdateKorisnik(Korisnik k)
        {
            using (SqlConnection sqlCon = new SqlConnection(Konekcija.konekcija))
            {

                String query = "UPDATE Korisnik SET Racun = " + k.Racun + " WHERE Id = " + k.Id + "";

                using (SqlCommand command = new SqlCommand(query, sqlCon))
                {
                    sqlCon.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}

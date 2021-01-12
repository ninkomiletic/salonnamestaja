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
        public object DBConnection { get; private set; }

        public List<Korisnik> GetAllKorisnik()
        {
            List<Korisnik> results = new List<Korisnik>();

            SqlDataReader sqlDataReader = DBconnection.GetData("SELECT * FROM Korisnik");

            while (sqlDataReader.Read())
            {
                Korisnik k = new Korisnik();
                k.Id = sqlDataReader.GetInt32(0);
                k.Ime = sqlDataReader.GetString(1);
                k.Prezime = sqlDataReader.GetString(2);
                k.JMBG = sqlDataReader.GetString(3);
                k.Adresa = sqlDataReader.GetString(4);
                k.Telefon = sqlDataReader.GetString(5);
                k.Username = sqlDataReader.GetString(6);
                k.Password = sqlDataReader.GetString(7);

                results.Add(k);
            }

            DBconnection.CloseConnection();

            return results;
        }
        public int InsertKorisnik(Korisnik k)
        {
            var result = DBconnection.EditData(string.Format("INSERT INTO Korinsik VALUES ('{0}', '{1}', {2}, '{3}', '{4}', {5}), '{6}')"));
            DBconnection.CloseConnection();

            return result;
        }
    }
}

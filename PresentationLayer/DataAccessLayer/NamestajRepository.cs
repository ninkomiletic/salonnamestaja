using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class NamestajRepository
    {
        public object DBConnection { get; private set; }

        public List<Namestaj> GetAllNamestaj()
        {
            List<Namestaj> results = new List<Namestaj>();

            SqlDataReader sqlDataReader = DBconnection.GetData("SELECT * FROM Korisnik");

            while (sqlDataReader.Read())
            {
                Namestaj n = new Namestaj();
                n.Id = sqlDataReader.GetInt32(0);
                n.Naziv = sqlDataReader.GetString(1);
                n.Velicina = sqlDataReader.GetDecimal(2);
                n.Cena = sqlDataReader.GetDecimal(3);
                n.Stanje = sqlDataReader.GetInt32(4);
                
                results.Add(n);
            }

            DBconnection.CloseConnection();

            return results;
        }

    }
}

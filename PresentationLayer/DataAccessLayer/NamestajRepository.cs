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
        public string konekcija = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public Namestaj GetNamestaj(int id)
        {
            Namestaj n = new Namestaj();
            using (SqlConnection sqlCon = new SqlConnection(konekcija))
            {

                String query = "SELECT * FROM Namestaj WHERE Id = "+ id +"";

                using (SqlCommand command = new SqlCommand(query, sqlCon))
                {
                    sqlCon.Open();
                    SqlDataReader result = command.ExecuteReader();
                    while (result.Read())
                    {
                        n.Id = result.GetInt32(0);
                        n.Naziv = result.GetString(1);
                        n.Velicina = result.GetDecimal(2);
                        n.Cena = result.GetDecimal(3);
                        n.Stanje = result.GetInt32(4);
                    }
                    return n;
                }
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class KorisnikBuisness
    {
 

        public KorisnikBuisness()
        {
            this.korisnikBuisness = new KorisnikBuisness();
        }

        public List<Korisnik> GetAllKorisniks()
        {
            return this.KorisnikRepository.GetAllKorisniks;
        }
        public bool InsertKorisnik(Korisnik k)
        {
            if (this.KorisnikRepository.InsertKorisnik(k) > 0)
             {
            return true;
        }
           return false;
        }
    }
}

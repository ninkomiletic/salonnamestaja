using DataAccessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class KorisnikBusiness
    {
        private readonly KorisnikRepository korisnikRepository;

        public KorisnikBusiness()
        {
            this.korisnikRepository = new KorisnikRepository();
        }

       
        public bool InsertKorisnik(Korisnik k)
        {
            if(this.korisnikRepository.InsertKorisnik(k) > 0)
            {
                return true;
            }
            return false;
        }
        public Korisnik CheckKorisnik(string username, string password)
        {
            return this.korisnikRepository.CheckKorisnik(username, password);
        }
        public void UpdateKorisnik(Korisnik k)
        {
            this.korisnikRepository.UpdateKorisnik(k);
        }
    }
}

using DataAccessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class NamestajBusiness
    {
        private readonly NamestajRepository namestajRepository;
        public NamestajBusiness()
        {
            this.namestajRepository = new NamestajRepository();
        }

        public Namestaj GetNamestaj(int id)
        {
            return this.namestajRepository.GetNamestaj(id);
        }

    }
}

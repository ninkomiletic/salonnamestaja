using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Namestaj
    {
        public int id { get; set; }
        public int Id { get; internal set; }
        public string Naziv { get; set; }
        public decimal Velicina { get; set; }
        public decimal Cena { get; set; }
        public int Stanje { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POP_SF_08_15.Model
{
    public class Salon
    {
        public int id { get; set; }
        public string naziv { get; set; }
        public string adresa { get; set; }
        public string telefon { get; set; }
        public string email { get; set; }
        public string webAdresa { get; set; }
        public string PIB { get; set; }
        public string maticniBroj { get; set; }
        public string brojZiroRacuna { get; set; }
        public bool obrisan { get; set; }
    }
}

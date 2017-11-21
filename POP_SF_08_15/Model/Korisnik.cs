using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POP_SF_08_15.Model
{
    public class Korisnik
    {
        public enum TipKorisnika
        {
            administrator,
            prodavac
        }
        public int id { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string korisnickoIme { get; set; }
        public string lozinka { get; set; }
        public TipKorisnika tipKorisnika { get; set; }
        public bool obrisan { get; set; }
    }
}
